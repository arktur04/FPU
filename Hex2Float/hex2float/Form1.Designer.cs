namespace hex2float
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.hexTextBox = new System.Windows.Forms.TextBox();
            this.floatTextBox = new System.Windows.Forms.TextBox();
            this.hex2FloatButton = new System.Windows.Forms.Button();
            this.float2HexButton = new System.Windows.Forms.Button();
            this.singlePrecisionButton = new System.Windows.Forms.RadioButton();
            this.doublePrecisionButton = new System.Windows.Forms.RadioButton();
            this.epsilonButton = new System.Windows.Forms.Button();
            this.nanButton = new System.Windows.Forms.Button();
            this.poitiveInfinityButton = new System.Windows.Forms.Button();
            this.negativeInfinityButton = new System.Windows.Forms.Button();
            this.minValueButton = new System.Windows.Forms.Button();
            this.maxValueButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hexATextBox = new System.Windows.Forms.TextBox();
            this.hexBTextBox = new System.Windows.Forms.TextBox();
            this.eqTextBox = new System.Windows.Forms.TextBox();
            this.notEqTextBox = new System.Windows.Forms.TextBox();
            this.greatTextBox = new System.Windows.Forms.TextBox();
            this.lessTextBox = new System.Windows.Forms.TextBox();
            this.hexPlusTextBox = new System.Windows.Forms.TextBox();
            this.hexMinusTextBox = new System.Windows.Forms.TextBox();
            this.hexMulTextBox = new System.Windows.Forms.TextBox();
            this.hexDivTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.floatATextBox = new System.Windows.Forms.TextBox();
            this.floatBTextBox = new System.Windows.Forms.TextBox();
            this.floatPlusTextBox = new System.Windows.Forms.TextBox();
            this.floatMinusTextBox = new System.Windows.Forms.TextBox();
            this.floatMulTextBox = new System.Windows.Forms.TextBox();
            this.floatDivTextBox = new System.Windows.Forms.TextBox();
            this.hexToAButton = new System.Windows.Forms.Button();
            this.hexToBButton = new System.Windows.Forms.Button();
            this.floatToBButton = new System.Windows.Forms.Button();
            this.floatToAButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hexTextBox
            // 
            this.hexTextBox.Location = new System.Drawing.Point(12, 13);
            this.hexTextBox.Name = "hexTextBox";
            this.hexTextBox.Size = new System.Drawing.Size(160, 20);
            this.hexTextBox.TabIndex = 0;
            this.hexTextBox.Text = "0";
            // 
            // floatTextBox
            // 
            this.floatTextBox.Location = new System.Drawing.Point(12, 39);
            this.floatTextBox.Name = "floatTextBox";
            this.floatTextBox.Size = new System.Drawing.Size(160, 20);
            this.floatTextBox.TabIndex = 1;
            this.floatTextBox.Text = "0,0";
            // 
            // hex2FloatButton
            // 
            this.hex2FloatButton.Location = new System.Drawing.Point(178, 14);
            this.hex2FloatButton.Name = "hex2FloatButton";
            this.hex2FloatButton.Size = new System.Drawing.Size(75, 20);
            this.hex2FloatButton.TabIndex = 2;
            this.hex2FloatButton.Text = "hex2float";
            this.hex2FloatButton.UseVisualStyleBackColor = true;
            this.hex2FloatButton.Click += new System.EventHandler(this.hex2FloatButton_Click);
            // 
            // float2HexButton
            // 
            this.float2HexButton.Location = new System.Drawing.Point(178, 40);
            this.float2HexButton.Name = "float2HexButton";
            this.float2HexButton.Size = new System.Drawing.Size(75, 20);
            this.float2HexButton.TabIndex = 3;
            this.float2HexButton.Text = "float2hex";
            this.float2HexButton.UseVisualStyleBackColor = true;
            this.float2HexButton.Click += new System.EventHandler(this.float2HexButton_Click);
            // 
            // singlePrecisionButton
            // 
            this.singlePrecisionButton.AutoSize = true;
            this.singlePrecisionButton.Checked = true;
            this.singlePrecisionButton.Location = new System.Drawing.Point(164, 108);
            this.singlePrecisionButton.Name = "singlePrecisionButton";
            this.singlePrecisionButton.Size = new System.Drawing.Size(52, 17);
            this.singlePrecisionButton.TabIndex = 4;
            this.singlePrecisionButton.TabStop = true;
            this.singlePrecisionButton.Text = "single";
            this.singlePrecisionButton.UseVisualStyleBackColor = true;
            this.singlePrecisionButton.CheckedChanged += new System.EventHandler(this.singlePrecisionButton_CheckedChanged);
            // 
            // doublePrecisionButton
            // 
            this.doublePrecisionButton.AutoSize = true;
            this.doublePrecisionButton.Location = new System.Drawing.Point(222, 108);
            this.doublePrecisionButton.Name = "doublePrecisionButton";
            this.doublePrecisionButton.Size = new System.Drawing.Size(57, 17);
            this.doublePrecisionButton.TabIndex = 5;
            this.doublePrecisionButton.Text = "double";
            this.doublePrecisionButton.UseVisualStyleBackColor = true;
            this.doublePrecisionButton.CheckedChanged += new System.EventHandler(this.doublePrecisionButton_CheckedChanged);
            // 
            // epsilonButton
            // 
            this.epsilonButton.Location = new System.Drawing.Point(12, 65);
            this.epsilonButton.Name = "epsilonButton";
            this.epsilonButton.Size = new System.Drawing.Size(39, 23);
            this.epsilonButton.TabIndex = 6;
            this.epsilonButton.Text = "eps";
            this.epsilonButton.UseVisualStyleBackColor = true;
            this.epsilonButton.Click += new System.EventHandler(this.epsilonButton_Click);
            // 
            // nanButton
            // 
            this.nanButton.Location = new System.Drawing.Point(50, 65);
            this.nanButton.Name = "nanButton";
            this.nanButton.Size = new System.Drawing.Size(39, 23);
            this.nanButton.TabIndex = 7;
            this.nanButton.Text = "nan";
            this.nanButton.UseVisualStyleBackColor = true;
            this.nanButton.Click += new System.EventHandler(this.nanButton_Click);
            // 
            // poitiveInfinityButton
            // 
            this.poitiveInfinityButton.Location = new System.Drawing.Point(88, 65);
            this.poitiveInfinityButton.Name = "poitiveInfinityButton";
            this.poitiveInfinityButton.Size = new System.Drawing.Size(39, 23);
            this.poitiveInfinityButton.TabIndex = 8;
            this.poitiveInfinityButton.Text = "+inf";
            this.poitiveInfinityButton.UseVisualStyleBackColor = true;
            this.poitiveInfinityButton.Click += new System.EventHandler(this.poitiveInfinityButton_Click);
            // 
            // negativeInfinityButton
            // 
            this.negativeInfinityButton.Location = new System.Drawing.Point(126, 65);
            this.negativeInfinityButton.Name = "negativeInfinityButton";
            this.negativeInfinityButton.Size = new System.Drawing.Size(39, 23);
            this.negativeInfinityButton.TabIndex = 9;
            this.negativeInfinityButton.Text = "-inf";
            this.negativeInfinityButton.UseVisualStyleBackColor = true;
            this.negativeInfinityButton.Click += new System.EventHandler(this.negativeInfinityButton_Click);
            // 
            // minValueButton
            // 
            this.minValueButton.Location = new System.Drawing.Point(164, 65);
            this.minValueButton.Name = "minValueButton";
            this.minValueButton.Size = new System.Drawing.Size(39, 23);
            this.minValueButton.TabIndex = 10;
            this.minValueButton.Text = "min";
            this.minValueButton.UseVisualStyleBackColor = true;
            this.minValueButton.Click += new System.EventHandler(this.minValueButton_Click);
            // 
            // maxValueButton
            // 
            this.maxValueButton.Location = new System.Drawing.Point(202, 65);
            this.maxValueButton.Name = "maxValueButton";
            this.maxValueButton.Size = new System.Drawing.Size(39, 23);
            this.maxValueButton.TabIndex = 11;
            this.maxValueButton.Text = "max";
            this.maxValueButton.UseVisualStyleBackColor = true;
            this.maxValueButton.Click += new System.EventHandler(this.maxValueButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.hexATextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.hexBTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.eqTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.notEqTextBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.greatTextBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lessTextBox, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.hexPlusTextBox, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.hexMinusTextBox, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.hexMulTextBox, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.hexDivTextBox, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.floatATextBox, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.floatBTextBox, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.floatPlusTextBox, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.floatMinusTextBox, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.floatMulTextBox, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.floatDivTextBox, 2, 9);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 134);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(493, 252);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 225);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "a/b";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "a*b";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "a-b";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "a+b";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "a<b";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "a>b";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "a!=b";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "a==b";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "b";
            // 
            // hexATextBox
            // 
            this.hexATextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hexATextBox.Enabled = false;
            this.hexATextBox.Location = new System.Drawing.Point(43, 3);
            this.hexATextBox.Name = "hexATextBox";
            this.hexATextBox.Size = new System.Drawing.Size(220, 20);
            this.hexATextBox.TabIndex = 1;
            this.hexATextBox.Text = "0";
            // 
            // hexBTextBox
            // 
            this.hexBTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hexBTextBox.Enabled = false;
            this.hexBTextBox.Location = new System.Drawing.Point(43, 28);
            this.hexBTextBox.Name = "hexBTextBox";
            this.hexBTextBox.Size = new System.Drawing.Size(220, 20);
            this.hexBTextBox.TabIndex = 2;
            this.hexBTextBox.Text = "0";
            // 
            // eqTextBox
            // 
            this.eqTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eqTextBox.Enabled = false;
            this.eqTextBox.Location = new System.Drawing.Point(43, 53);
            this.eqTextBox.Name = "eqTextBox";
            this.eqTextBox.Size = new System.Drawing.Size(220, 20);
            this.eqTextBox.TabIndex = 3;
            this.eqTextBox.Text = "0";
            // 
            // notEqTextBox
            // 
            this.notEqTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notEqTextBox.Enabled = false;
            this.notEqTextBox.Location = new System.Drawing.Point(43, 78);
            this.notEqTextBox.Name = "notEqTextBox";
            this.notEqTextBox.Size = new System.Drawing.Size(220, 20);
            this.notEqTextBox.TabIndex = 4;
            this.notEqTextBox.Text = "0";
            // 
            // greatTextBox
            // 
            this.greatTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.greatTextBox.Enabled = false;
            this.greatTextBox.Location = new System.Drawing.Point(43, 103);
            this.greatTextBox.Name = "greatTextBox";
            this.greatTextBox.Size = new System.Drawing.Size(220, 20);
            this.greatTextBox.TabIndex = 5;
            this.greatTextBox.Text = "0";
            // 
            // lessTextBox
            // 
            this.lessTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lessTextBox.Enabled = false;
            this.lessTextBox.Location = new System.Drawing.Point(43, 128);
            this.lessTextBox.Name = "lessTextBox";
            this.lessTextBox.Size = new System.Drawing.Size(220, 20);
            this.lessTextBox.TabIndex = 6;
            this.lessTextBox.Text = "0";
            // 
            // hexPlusTextBox
            // 
            this.hexPlusTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hexPlusTextBox.Enabled = false;
            this.hexPlusTextBox.Location = new System.Drawing.Point(43, 153);
            this.hexPlusTextBox.Name = "hexPlusTextBox";
            this.hexPlusTextBox.Size = new System.Drawing.Size(220, 20);
            this.hexPlusTextBox.TabIndex = 7;
            this.hexPlusTextBox.Text = "0";
            // 
            // hexMinusTextBox
            // 
            this.hexMinusTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hexMinusTextBox.Enabled = false;
            this.hexMinusTextBox.Location = new System.Drawing.Point(43, 178);
            this.hexMinusTextBox.Name = "hexMinusTextBox";
            this.hexMinusTextBox.Size = new System.Drawing.Size(220, 20);
            this.hexMinusTextBox.TabIndex = 8;
            this.hexMinusTextBox.Text = "0";
            // 
            // hexMulTextBox
            // 
            this.hexMulTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hexMulTextBox.Enabled = false;
            this.hexMulTextBox.Location = new System.Drawing.Point(43, 203);
            this.hexMulTextBox.Name = "hexMulTextBox";
            this.hexMulTextBox.Size = new System.Drawing.Size(220, 20);
            this.hexMulTextBox.TabIndex = 9;
            this.hexMulTextBox.Text = "0";
            // 
            // hexDivTextBox
            // 
            this.hexDivTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hexDivTextBox.Enabled = false;
            this.hexDivTextBox.Location = new System.Drawing.Point(43, 228);
            this.hexDivTextBox.Name = "hexDivTextBox";
            this.hexDivTextBox.Size = new System.Drawing.Size(220, 20);
            this.hexDivTextBox.TabIndex = 10;
            this.hexDivTextBox.Text = "0";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "a";
            // 
            // floatATextBox
            // 
            this.floatATextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.floatATextBox.Enabled = false;
            this.floatATextBox.Location = new System.Drawing.Point(269, 3);
            this.floatATextBox.Name = "floatATextBox";
            this.floatATextBox.Size = new System.Drawing.Size(221, 20);
            this.floatATextBox.TabIndex = 21;
            this.floatATextBox.Text = "0";
            // 
            // floatBTextBox
            // 
            this.floatBTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.floatBTextBox.Enabled = false;
            this.floatBTextBox.Location = new System.Drawing.Point(269, 28);
            this.floatBTextBox.Name = "floatBTextBox";
            this.floatBTextBox.Size = new System.Drawing.Size(221, 20);
            this.floatBTextBox.TabIndex = 22;
            this.floatBTextBox.Text = "0";
            // 
            // floatPlusTextBox
            // 
            this.floatPlusTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.floatPlusTextBox.Enabled = false;
            this.floatPlusTextBox.Location = new System.Drawing.Point(269, 153);
            this.floatPlusTextBox.Name = "floatPlusTextBox";
            this.floatPlusTextBox.Size = new System.Drawing.Size(221, 20);
            this.floatPlusTextBox.TabIndex = 27;
            this.floatPlusTextBox.Text = "0";
            // 
            // floatMinusTextBox
            // 
            this.floatMinusTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.floatMinusTextBox.Enabled = false;
            this.floatMinusTextBox.Location = new System.Drawing.Point(269, 178);
            this.floatMinusTextBox.Name = "floatMinusTextBox";
            this.floatMinusTextBox.Size = new System.Drawing.Size(221, 20);
            this.floatMinusTextBox.TabIndex = 28;
            this.floatMinusTextBox.Text = "0";
            // 
            // floatMulTextBox
            // 
            this.floatMulTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.floatMulTextBox.Enabled = false;
            this.floatMulTextBox.Location = new System.Drawing.Point(269, 203);
            this.floatMulTextBox.Name = "floatMulTextBox";
            this.floatMulTextBox.Size = new System.Drawing.Size(221, 20);
            this.floatMulTextBox.TabIndex = 29;
            this.floatMulTextBox.Text = "0";
            // 
            // floatDivTextBox
            // 
            this.floatDivTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.floatDivTextBox.Enabled = false;
            this.floatDivTextBox.Location = new System.Drawing.Point(269, 228);
            this.floatDivTextBox.Name = "floatDivTextBox";
            this.floatDivTextBox.Size = new System.Drawing.Size(221, 20);
            this.floatDivTextBox.TabIndex = 30;
            this.floatDivTextBox.Text = "0";
            // 
            // hexToAButton
            // 
            this.hexToAButton.Location = new System.Drawing.Point(259, 13);
            this.hexToAButton.Name = "hexToAButton";
            this.hexToAButton.Size = new System.Drawing.Size(39, 19);
            this.hexToAButton.TabIndex = 15;
            this.hexToAButton.Text = "-> A";
            this.hexToAButton.UseVisualStyleBackColor = true;
            this.hexToAButton.Click += new System.EventHandler(this.hexToAButton_Click);
            // 
            // hexToBButton
            // 
            this.hexToBButton.Location = new System.Drawing.Point(304, 13);
            this.hexToBButton.Name = "hexToBButton";
            this.hexToBButton.Size = new System.Drawing.Size(39, 19);
            this.hexToBButton.TabIndex = 16;
            this.hexToBButton.Text = "-> B";
            this.hexToBButton.UseVisualStyleBackColor = true;
            this.hexToBButton.Click += new System.EventHandler(this.hexToBButtonClick);
            // 
            // floatToBButton
            // 
            this.floatToBButton.Location = new System.Drawing.Point(304, 40);
            this.floatToBButton.Name = "floatToBButton";
            this.floatToBButton.Size = new System.Drawing.Size(39, 19);
            this.floatToBButton.TabIndex = 18;
            this.floatToBButton.Text = "-> B";
            this.floatToBButton.UseVisualStyleBackColor = true;
            this.floatToBButton.Click += new System.EventHandler(this.floatToBButton_Click);
            // 
            // floatToAButton
            // 
            this.floatToAButton.Location = new System.Drawing.Point(259, 40);
            this.floatToAButton.Name = "floatToAButton";
            this.floatToAButton.Size = new System.Drawing.Size(39, 19);
            this.floatToAButton.TabIndex = 17;
            this.floatToAButton.Text = "-> A";
            this.floatToAButton.UseVisualStyleBackColor = true;
            this.floatToAButton.Click += new System.EventHandler(this.floatToAButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 398);
            this.Controls.Add(this.floatToBButton);
            this.Controls.Add(this.floatToAButton);
            this.Controls.Add(this.hexToBButton);
            this.Controls.Add(this.hexToAButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.maxValueButton);
            this.Controls.Add(this.minValueButton);
            this.Controls.Add(this.negativeInfinityButton);
            this.Controls.Add(this.poitiveInfinityButton);
            this.Controls.Add(this.nanButton);
            this.Controls.Add(this.epsilonButton);
            this.Controls.Add(this.doublePrecisionButton);
            this.Controls.Add(this.singlePrecisionButton);
            this.Controls.Add(this.float2HexButton);
            this.Controls.Add(this.hex2FloatButton);
            this.Controls.Add(this.floatTextBox);
            this.Controls.Add(this.hexTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "float2hex";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox hexTextBox;
        private System.Windows.Forms.TextBox floatTextBox;
        private System.Windows.Forms.Button hex2FloatButton;
        private System.Windows.Forms.Button float2HexButton;
        private System.Windows.Forms.RadioButton singlePrecisionButton;
        private System.Windows.Forms.RadioButton doublePrecisionButton;
        private System.Windows.Forms.Button epsilonButton;
        private System.Windows.Forms.Button nanButton;
        private System.Windows.Forms.Button poitiveInfinityButton;
        private System.Windows.Forms.Button negativeInfinityButton;
        private System.Windows.Forms.Button minValueButton;
        private System.Windows.Forms.Button maxValueButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox hexATextBox;
        private System.Windows.Forms.TextBox hexBTextBox;
        private System.Windows.Forms.TextBox eqTextBox;
        private System.Windows.Forms.TextBox notEqTextBox;
        private System.Windows.Forms.TextBox greatTextBox;
        private System.Windows.Forms.TextBox lessTextBox;
        private System.Windows.Forms.TextBox hexPlusTextBox;
        private System.Windows.Forms.TextBox hexMinusTextBox;
        private System.Windows.Forms.TextBox hexMulTextBox;
        private System.Windows.Forms.TextBox hexDivTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox floatATextBox;
        private System.Windows.Forms.TextBox floatBTextBox;
        private System.Windows.Forms.TextBox floatPlusTextBox;
        private System.Windows.Forms.TextBox floatMinusTextBox;
        private System.Windows.Forms.TextBox floatMulTextBox;
        private System.Windows.Forms.TextBox floatDivTextBox;
        private System.Windows.Forms.Button hexToAButton;
        private System.Windows.Forms.Button hexToBButton;
        private System.Windows.Forms.Button floatToBButton;
        private System.Windows.Forms.Button floatToAButton;
    }
}

