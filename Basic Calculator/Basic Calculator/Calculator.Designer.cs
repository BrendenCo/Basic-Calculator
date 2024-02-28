namespace Basic_Calculator
{
    partial class Calculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            num1 = new Button();
            groupBox1 = new GroupBox();
            numBracketR = new Button();
            numBracketL = new Button();
            numClear = new Button();
            numEnter = new Button();
            numDelete = new Button();
            numDivide = new Button();
            numDecimal = new Button();
            numNegative = new Button();
            numMultiply = new Button();
            num9 = new Button();
            numSubtract = new Button();
            num6 = new Button();
            num0 = new Button();
            num8 = new Button();
            num5 = new Button();
            num7 = new Button();
            num4 = new Button();
            numAdd = new Button();
            num3 = new Button();
            num2 = new Button();
            calcDisplay = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // num1
            // 
            num1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            num1.Font = new Font("Segoe UI", 16F);
            num1.Location = new Point(20, 81);
            num1.Margin = new Padding(0);
            num1.Name = "num1";
            num1.Padding = new Padding(3);
            num1.Size = new Size(76, 42);
            num1.TabIndex = 0;
            num1.Text = "1";
            num1.UseVisualStyleBackColor = true;
            num1.Click += calculate;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(numBracketR);
            groupBox1.Controls.Add(numBracketL);
            groupBox1.Controls.Add(numClear);
            groupBox1.Controls.Add(numEnter);
            groupBox1.Controls.Add(numDelete);
            groupBox1.Controls.Add(numDivide);
            groupBox1.Controls.Add(numDecimal);
            groupBox1.Controls.Add(numNegative);
            groupBox1.Controls.Add(numMultiply);
            groupBox1.Controls.Add(num9);
            groupBox1.Controls.Add(numSubtract);
            groupBox1.Controls.Add(num6);
            groupBox1.Controls.Add(num0);
            groupBox1.Controls.Add(num8);
            groupBox1.Controls.Add(num5);
            groupBox1.Controls.Add(num7);
            groupBox1.Controls.Add(num4);
            groupBox1.Controls.Add(numAdd);
            groupBox1.Controls.Add(num3);
            groupBox1.Controls.Add(num2);
            groupBox1.Controls.Add(num1);
            groupBox1.Location = new Point(12, 127);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(347, 310);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // numBracketR
            // 
            numBracketR.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            numBracketR.Font = new Font("Segoe UI", 16F);
            numBracketR.Location = new Point(96, 39);
            numBracketR.Margin = new Padding(0);
            numBracketR.Name = "numBracketR";
            numBracketR.Padding = new Padding(3);
            numBracketR.Size = new Size(76, 42);
            numBracketR.TabIndex = 11;
            numBracketR.Text = ")";
            numBracketR.UseVisualStyleBackColor = true;
            numBracketR.Click += calculate;
            // 
            // numBracketL
            // 
            numBracketL.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            numBracketL.Font = new Font("Segoe UI", 16F);
            numBracketL.Location = new Point(20, 39);
            numBracketL.Margin = new Padding(0);
            numBracketL.Name = "numBracketL";
            numBracketL.Padding = new Padding(3);
            numBracketL.Size = new Size(76, 42);
            numBracketL.TabIndex = 10;
            numBracketL.Text = "(";
            numBracketL.UseVisualStyleBackColor = true;
            numBracketL.Click += calculate;
            // 
            // numClear
            // 
            numClear.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            numClear.Font = new Font("Segoe UI", 16F);
            numClear.Location = new Point(172, 39);
            numClear.Margin = new Padding(0);
            numClear.Name = "numClear";
            numClear.Padding = new Padding(3);
            numClear.Size = new Size(76, 42);
            numClear.TabIndex = 9;
            numClear.Text = "C";
            numClear.UseVisualStyleBackColor = true;
            numClear.Click += calculate;
            // 
            // numEnter
            // 
            numEnter.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            numEnter.Font = new Font("Segoe UI", 16F);
            numEnter.Location = new Point(172, 249);
            numEnter.Margin = new Padding(0);
            numEnter.Name = "numEnter";
            numEnter.Padding = new Padding(3);
            numEnter.Size = new Size(152, 42);
            numEnter.TabIndex = 8;
            numEnter.Text = "=";
            numEnter.UseVisualStyleBackColor = true;
            numEnter.Click += calculate;
            // 
            // numDelete
            // 
            numDelete.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            numDelete.Font = new Font("Segoe UI", 16F);
            numDelete.Location = new Point(248, 39);
            numDelete.Margin = new Padding(0);
            numDelete.Name = "numDelete";
            numDelete.Padding = new Padding(3);
            numDelete.Size = new Size(76, 42);
            numDelete.TabIndex = 7;
            numDelete.Text = "<-";
            numDelete.UseVisualStyleBackColor = true;
            numDelete.Click += calculate;
            // 
            // numDivide
            // 
            numDivide.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            numDivide.Font = new Font("Segoe UI", 16F);
            numDivide.Location = new Point(248, 207);
            numDivide.Margin = new Padding(0);
            numDivide.Name = "numDivide";
            numDivide.Padding = new Padding(3);
            numDivide.Size = new Size(76, 42);
            numDivide.TabIndex = 6;
            numDivide.Text = "/";
            numDivide.UseVisualStyleBackColor = true;
            numDivide.Click += calculate;
            // 
            // numDecimal
            // 
            numDecimal.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            numDecimal.Font = new Font("Segoe UI", 16F);
            numDecimal.Location = new Point(172, 207);
            numDecimal.Margin = new Padding(0);
            numDecimal.Name = "numDecimal";
            numDecimal.Padding = new Padding(3);
            numDecimal.Size = new Size(76, 42);
            numDecimal.TabIndex = 6;
            numDecimal.Text = ".";
            numDecimal.UseVisualStyleBackColor = true;
            numDecimal.Click += calculate;
            // 
            // numNegative
            // 
            numNegative.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            numNegative.Font = new Font("Segoe UI", 16F);
            numNegative.Location = new Point(20, 207);
            numNegative.Margin = new Padding(0);
            numNegative.Name = "numNegative";
            numNegative.Padding = new Padding(3);
            numNegative.Size = new Size(76, 42);
            numNegative.TabIndex = 5;
            numNegative.Text = "( - )";
            numNegative.UseVisualStyleBackColor = true;
            numNegative.Click += calculate;
            // 
            // numMultiply
            // 
            numMultiply.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            numMultiply.Font = new Font("Segoe UI", 16F);
            numMultiply.Location = new Point(248, 165);
            numMultiply.Margin = new Padding(0);
            numMultiply.Name = "numMultiply";
            numMultiply.Padding = new Padding(3);
            numMultiply.Size = new Size(76, 42);
            numMultiply.TabIndex = 4;
            numMultiply.Text = "x";
            numMultiply.UseVisualStyleBackColor = true;
            numMultiply.Click += calculate;
            // 
            // num9
            // 
            num9.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            num9.Font = new Font("Segoe UI", 16F);
            num9.Location = new Point(172, 165);
            num9.Margin = new Padding(0);
            num9.Name = "num9";
            num9.Padding = new Padding(3);
            num9.Size = new Size(76, 42);
            num9.TabIndex = 4;
            num9.Text = "9";
            num9.UseVisualStyleBackColor = true;
            num9.Click += calculate;
            // 
            // numSubtract
            // 
            numSubtract.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            numSubtract.Font = new Font("Segoe UI", 16F);
            numSubtract.Location = new Point(248, 123);
            numSubtract.Margin = new Padding(0);
            numSubtract.Name = "numSubtract";
            numSubtract.Padding = new Padding(3);
            numSubtract.Size = new Size(76, 42);
            numSubtract.TabIndex = 4;
            numSubtract.Text = "-";
            numSubtract.UseVisualStyleBackColor = true;
            numSubtract.Click += calculate;
            // 
            // num6
            // 
            num6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            num6.Font = new Font("Segoe UI", 16F);
            num6.Location = new Point(172, 123);
            num6.Margin = new Padding(0);
            num6.Name = "num6";
            num6.Padding = new Padding(3);
            num6.Size = new Size(76, 42);
            num6.TabIndex = 4;
            num6.Text = "6";
            num6.UseVisualStyleBackColor = true;
            num6.Click += calculate;
            // 
            // num0
            // 
            num0.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            num0.Font = new Font("Segoe UI", 16F);
            num0.Location = new Point(96, 207);
            num0.Margin = new Padding(0);
            num0.Name = "num0";
            num0.Padding = new Padding(3);
            num0.Size = new Size(76, 42);
            num0.TabIndex = 3;
            num0.Text = "0";
            num0.UseVisualStyleBackColor = true;
            num0.Click += calculate;
            // 
            // num8
            // 
            num8.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            num8.Font = new Font("Segoe UI", 16F);
            num8.Location = new Point(96, 165);
            num8.Margin = new Padding(0);
            num8.Name = "num8";
            num8.Padding = new Padding(3);
            num8.Size = new Size(76, 42);
            num8.TabIndex = 3;
            num8.Text = "8";
            num8.UseVisualStyleBackColor = true;
            num8.Click += calculate;
            // 
            // num5
            // 
            num5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            num5.Font = new Font("Segoe UI", 16F);
            num5.Location = new Point(96, 123);
            num5.Margin = new Padding(0);
            num5.Name = "num5";
            num5.Padding = new Padding(3);
            num5.Size = new Size(76, 42);
            num5.TabIndex = 3;
            num5.Text = "5";
            num5.UseVisualStyleBackColor = true;
            num5.Click += calculate;
            // 
            // num7
            // 
            num7.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            num7.Font = new Font("Segoe UI", 16F);
            num7.Location = new Point(20, 165);
            num7.Margin = new Padding(0);
            num7.Name = "num7";
            num7.Padding = new Padding(3);
            num7.Size = new Size(76, 42);
            num7.TabIndex = 2;
            num7.Text = "7";
            num7.UseVisualStyleBackColor = true;
            num7.Click += calculate;
            // 
            // num4
            // 
            num4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            num4.Font = new Font("Segoe UI", 16F);
            num4.Location = new Point(20, 123);
            num4.Margin = new Padding(0);
            num4.Name = "num4";
            num4.Padding = new Padding(3);
            num4.Size = new Size(76, 42);
            num4.TabIndex = 2;
            num4.Text = "4";
            num4.UseVisualStyleBackColor = true;
            num4.Click += calculate;
            // 
            // numAdd
            // 
            numAdd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            numAdd.Font = new Font("Segoe UI", 16F);
            numAdd.Location = new Point(248, 81);
            numAdd.Margin = new Padding(0);
            numAdd.Name = "numAdd";
            numAdd.Padding = new Padding(3);
            numAdd.Size = new Size(76, 42);
            numAdd.TabIndex = 1;
            numAdd.Text = "+";
            numAdd.UseVisualStyleBackColor = true;
            numAdd.Click += calculate;
            // 
            // num3
            // 
            num3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            num3.Font = new Font("Segoe UI", 16F);
            num3.Location = new Point(172, 81);
            num3.Margin = new Padding(0);
            num3.Name = "num3";
            num3.Padding = new Padding(3);
            num3.Size = new Size(76, 42);
            num3.TabIndex = 1;
            num3.Text = "3";
            num3.UseVisualStyleBackColor = true;
            num3.Click += calculate;
            // 
            // num2
            // 
            num2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            num2.Font = new Font("Segoe UI", 16F);
            num2.Location = new Point(96, 81);
            num2.Margin = new Padding(0);
            num2.Name = "num2";
            num2.Padding = new Padding(3);
            num2.Size = new Size(76, 42);
            num2.TabIndex = 1;
            num2.Text = "2";
            num2.UseVisualStyleBackColor = true;
            num2.Click += calculate;
            // 
            // calcDisplay
            // 
            calcDisplay.BackColor = SystemColors.WindowFrame;
            calcDisplay.Font = new Font("Segoe UI", 16F);
            calcDisplay.Location = new Point(12, 12);
            calcDisplay.Multiline = true;
            calcDisplay.Name = "calcDisplay";
            calcDisplay.Size = new Size(347, 109);
            calcDisplay.TabIndex = 3;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(371, 446);
            Controls.Add(calcDisplay);
            Controls.Add(groupBox1);
            Name = "Calculator";
            Text = "Calculator";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button num1;
        private GroupBox groupBox1;
        private Button num3;
        private Button num2;
        private Button numDecimal;
        private Button numNegative;
        private Button num9;
        private Button num6;
        private Button num0;
        private Button num8;
        private Button num5;
        private Button num7;
        private Button num4;
        private Button numDivide;
        private Button numMultiply;
        private Button numSubtract;
        private Button numAdd;
        private Button numDelete;
        private TextBox calcDisplay;
        private Button numEnter;
        private Button numClear;
        private Button numBracketR;
        private Button numBracketL;
    }
}
