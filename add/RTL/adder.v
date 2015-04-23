module div_float
  #(parameter
   FLOAT_WIDTH = 64
  )
  (
  input wire rst_n, clk, start,
  input wire op_sub, //high for subtraction, low for addition
  input wire [FLOAT_WIDTH - 1: 0] op1, op2,
  output reg [FLOAT_WIDTH - 1: 0] out_reg,
  output reg nan_reg,
  output reg overflow_reg,
  output reg underflow_reg,
  output reg zero_reg,
  output reg done_reg
  );
  localparam EXP_WIDTH = (FLOAT_WIDTH == 64) ? 11: 8; 
  localparam FRACTION_WIDTH = (FLOAT_WIDTH == 64) ? 52: 23;
  localparam FULL_FRACTION_WIDTH = FRACTION_WIDTH + 3;
  localparam SIGN_BIT =  FLOAT_WIDTH - 1;
  localparam EXP_MSB = SIGN_BIT - 1;
  localparam EXP_LSB = EXP_MSB - EXP_WIDTH + 1;
  //localparam EXP_SHIFT = (2 ** (EXP_WIDTH - 1)) - 1;
  localparam EXP_MAX = (2 ** (EXP_WIDTH)) - 1;
  localparam FRACTION_MSB = EXP_LSB - 1;
  //localparam DIV_COUNTER_WIDTH = (FLOAT_WIDTH == 64) ? 7: 6;
  localparam NAN_VALUE = (FLOAT_WIDTH == 64) ? 64'hFFF8_0000_0000_0000: 32'hFFC0_0000;
  localparam INF_VALUE = (FLOAT_WIDTH == 64) ? 64'h7FF0_0000_0000_0000: 32'h7F80_0000;
  localparam STAGES = 3; // пока неизвестно кол-во стадий

  //-----------

  reg stage;
  wire next_stage = (stage < STAGES - 1'b1)? stage + 1'b1: 0;
  always@(posedge clk or negedge rst_n)
  begin
    //stage increment
	if(start)
	begin
	  stage <= 0;  
	end
	else
	begin
	  stage <= next_stage;
	end
  end
  
  
  wire [EXP_WIDTH - 1: 0] exp1 = op1[EXP_MSB: EXP_LSB],
    exp2 = op2[EXP_MSB: EXP_LSB];
	
  wire [FRAC_WIDTH - 1: 0] frac1 = op1[FRAC_MSB: 0],
  frac2 = op2[FRAC_MSB: 0];
  
  wire exp1_bigger = exp1 > exp2, 
  exp2_bigger = exp1 < exp2;
  
  wire sign1 = op1[SIGN_BIT],
    sign2 = op2[SIGN_BIT];
	
  wire real_operation = sign1 ^ sign2 ^ op_sub;  //subtraction if high
  wire sub_direction = sign1 & !(sign2 ^ op_sub);  //(op2 - op1) operation if high
  wire op1_correction = (sub_direction & (frac1 > frac2) | !sub_direction & (frac2 > frac1)) & (exp1 == exp2);
  
  reg [FLOAT_WIDTH - 1: 0] big_reg, little_reg;

  always@(posedge clk or negedge rst_n)
  begin
    if(stage == 0)
	begin
	  if(exp1_bigger)
	  begin
	    big_reg <= op1;
	    little_reg <= op2;
	  end
	  else
	  begin
	    if(exp2_bigger)
		begin
	      big_reg <= op2;
	      little_reg <= op1;
		end
		else  //exp1 == exp2
		begin
		  if(sub_direction)
		  begin
	        big_reg <= op2;
	        little_reg <= op1;
	      end
		  else
		  begin
		    big_reg <= op1;
	        little_reg <= op2;
		  end
		end
	  end
	end
  end

  reg [FULL_FRACTION_WIDTH: 0] op1_wide_reg, op2_wide_reg;
  
  always@(posedge clk or negedge rst_n)
  begin
    if(stage == 1)
	begin
      op1_wide_reg <= {2'b01, big_reg[FRACTION_MSB: 0], 1'b0} << op1_correction;
	  op2_wide_reg <= {2'b01, little_reg[FRACTION_MSB: 0], 1'b0} >> (exp1 - exp2);
	end
  end

  reg [FULL_FRACTION_WIDTH: 0] result_frac_before_correction_reg;
	  
  always@(posedge clk or negedge rst_n)
  begin
    if(stage == 2)
	begin
	  if(op_sub == 0)
	  begin
	    result_frac_before_correction_reg = op1_wide_reg + op2_wide_reg;
      end
	  else
	  begin
	    result_frac_before_correction_reg = op1_wide_reg - op2_wide_reg;
	  end;
	end
  end

  reg [FULL_FRACTION_WIDTH: 0] result_frac_reg;
  
  always@(posedge clk or negedge rst_n)
  begin
    if(stage == 3)
	begin
	  result_frac_reg <= result_frac_before_correction_reg << (FULL_FRACTION_WIDTH - find_one(result_frac_before_correction_reg) + 1);
	end
  end
  
  reg sign_reg;
  
  always@(posedge clk or negedge rst_n)
  begin
    if(stage == 4)
	begin
	  sign_reg <= !real_operation & (sign1 ^ sign2) | real_operation & sub_direction();  //todo
	end
  end

  function [7: 0] find_one
    input [FULL_FRACTION_WIDTH: 0] op;
	find_one = FULL_FRACTION_WIDTH; // default value for (op == 0)
	integer i;
	for(i = FULL_FRACTION_WIDTH; i >= 0; i = i - 1)
	  if(op[i])
	  begin
	    find_one = i;
		break;
	  end
  endfunction
endmodule