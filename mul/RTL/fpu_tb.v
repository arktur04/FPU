`timescale 1ns/1ns

module fpu_tb();

`define DATA_WIDTH 64
`define EXP_WIDTH 11
`define FRAC_WIDTH (`DATA_WIDTH - `EXP_WIDTH - 1)
`define MAX_LINE_LENGTH 1000 
`define NaN 64'h7ff8000000000000

reg clk, rst_n, start;
integer test_file, status, i;
reg [`DATA_WIDTH - 1: 0] op1, op2;
reg [`DATA_WIDTH - 1: 0] out_expected;
reg nan_expected, overflow_expected, underflow_expected, zero_expected;
wire [`DATA_WIDTH - 1: 0] out_actual;
wire nan_actual, overflow_actual, underflow_actual, zero_actual, done;
reg [`MAX_LINE_LENGTH * 8: 1] comment;
reg error;

always #2 clk = ~clk;

initial
begin
  error = 0;
  clk = 1'b0;
  rst_n = 1'b0;
  start = 0;
  #10 rst_n = 1'b1;
  //------------
  test_file = $fopen("test_file.txt", "r");  // открываем файл
  i = 0;
  while ( ! $feof(test_file)) //цикл до конца файла
  begin  
    @(negedge clk); 
    status = $fscanf(test_file,"%h %h %h", op1, op2, out_expected); // парсим очередную строку
    status = $fgets(comment, test_file); // пропускаем комментарий
	 // вычисляем значения флагов
	 nan_expected = is_nan(out_expected);
	 overflow_expected = is_inf(out_expected) && !is_inf(op1) && !is_inf(op2);
	 underflow_expected = is_zero(out_expected) && !is_zero(op1) && !is_zero(op2);
	 zero_expected = is_zero(out_expected);
	 //--------
    i = i + 1;
	 start = 1;
    @(negedge clk);
	 start = 0;
	 //ждем, когда DUT завершит вычисление
	 @(posedge done);
	 // сравнение ответа с ожиданием
	 if(!is_equal(out_expected, out_actual))
      error = 1;
	 if((nan_expected != nan_actual) || (overflow_expected != overflow_actual) || (underflow_expected != underflow_actual) || (zero_expected != zero_actual))
      error = 1;
  end
  //закрываем файл и прекращаем работу
  $fclose(test_file);
  #100 $stop; 
end

mul_float dut(
  //inputs
  .rst_n(rst_n), 
  .clk(clk), 
  .start(start),
  .op1(op1), 
  .op2(op2),
  //outputs
  .out_reg(out_actual),
  .nan_reg(nan_actual),
  .overflow_reg(overflow_actual),
  .underflow_reg(underflow_actual),
  .zero_reg(zero_actual),
  .done_reg(done));

//функция сравнения чисел
function is_equal;
input [`DATA_WIDTH - 1: 0] expected, actual;
reg expectedIsNaN, actualIsNaN;
begin
  expectedIsNaN = &(expected | ~`NaN);
  actualIsNaN = &(actual | ~`NaN);
  is_equal = (expected == actual) || (expectedIsNaN && actualIsNaN);
end
endfunction

function is_zero;
input [`DATA_WIDTH - 1: 0] value;
begin
  is_zero = value[`DATA_WIDTH - 2: `DATA_WIDTH - `EXP_WIDTH - 1] == {`EXP_WIDTH{1'b0}};
end
endfunction

function is_inf;
input [`DATA_WIDTH - 1: 0] value;
begin
  is_inf = (value[`DATA_WIDTH - 2: `DATA_WIDTH - `EXP_WIDTH - 1] == {`EXP_WIDTH{1'b1}}) && (value[`DATA_WIDTH - `EXP_WIDTH - 2: 0] == {`FRAC_WIDTH{1'b0}});
end
endfunction

function is_nan;
input [`DATA_WIDTH - 1: 0] value;
begin
  is_nan = (value[`DATA_WIDTH - 2: `DATA_WIDTH - `EXP_WIDTH - 1] == {`EXP_WIDTH{1'b1}}) && (value[`DATA_WIDTH - `EXP_WIDTH - 2: 0] != {`FRAC_WIDTH{1'b0}});
end
endfunction

endmodule
