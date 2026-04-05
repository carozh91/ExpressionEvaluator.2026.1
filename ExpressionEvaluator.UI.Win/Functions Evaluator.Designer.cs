namespace ExpressionEvaluator.UI.Win
{
    partial class Form1
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
            textDisplay = new TextBox();
            btn0 = new Button();
            btnDot = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btnPow = new Button();
            btnCloseParenthesis = new Button();
            btnOpenParenthesis = new Button();
            btnClear = new Button();
            btnMinus = new Button();
            btnPlus = new Button();
            btnDelete = new Button();
            btnMultiply = new Button();
            btnDivide = new Button();
            btnResult = new Button();
            SuspendLayout();
            // 
            // textDisplay
            // 
            textDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textDisplay.BackColor = Color.Green;
            textDisplay.Font = new Font("Segoe UI", 18F);
            textDisplay.ForeColor = Color.White;
            textDisplay.Location = new Point(12, 9);
            textDisplay.Name = "textDisplay";
            textDisplay.Size = new Size(531, 47);
            textDisplay.TabIndex = 0;
            // 
            // btn0
            // 
            btn0.BackColor = Color.DarkOrange;
            btn0.Font = new Font("Segoe UI", 18F);
            btn0.Location = new Point(12, 260);
            btn0.Name = "btn0";
            btn0.Size = new Size(160, 52);
            btn0.TabIndex = 1;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btn0_Click_1;
            // 
            // btnDot
            // 
            btnDot.BackColor = Color.DarkOrange;
            btnDot.Font = new Font("Segoe UI", 18F);
            btnDot.Location = new Point(179, 260);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(77, 52);
            btnDot.TabIndex = 2;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = false;
            btnDot.Click += btnDot_Click_1;
            // 
            // btn9
            // 
            btn9.BackColor = Color.DarkOrange;
            btn9.Font = new Font("Segoe UI", 18F);
            btn9.Location = new Point(178, 86);
            btn9.Name = "btn9";
            btn9.Size = new Size(77, 52);
            btn9.TabIndex = 6;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn9_Click_1;
            // 
            // btn8
            // 
            btn8.BackColor = Color.DarkOrange;
            btn8.Font = new Font("Segoe UI", 18F);
            btn8.Location = new Point(95, 86);
            btn8.Name = "btn8";
            btn8.Size = new Size(77, 52);
            btn8.TabIndex = 5;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click_1;
            // 
            // btn7
            // 
            btn7.BackColor = Color.DarkOrange;
            btn7.Font = new Font("Segoe UI", 18F);
            btn7.Location = new Point(12, 86);
            btn7.Name = "btn7";
            btn7.Size = new Size(77, 52);
            btn7.TabIndex = 4;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click_1;
            // 
            // btn6
            // 
            btn6.BackColor = Color.DarkOrange;
            btn6.Font = new Font("Segoe UI", 18F);
            btn6.Location = new Point(178, 144);
            btn6.Name = "btn6";
            btn6.Size = new Size(77, 52);
            btn6.TabIndex = 9;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click_1;
            // 
            // btn5
            // 
            btn5.BackColor = Color.DarkOrange;
            btn5.Font = new Font("Segoe UI", 18F);
            btn5.Location = new Point(95, 144);
            btn5.Name = "btn5";
            btn5.Size = new Size(77, 52);
            btn5.TabIndex = 8;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click_1;
            // 
            // btn4
            // 
            btn4.BackColor = Color.DarkOrange;
            btn4.Font = new Font("Segoe UI", 18F);
            btn4.Location = new Point(12, 144);
            btn4.Name = "btn4";
            btn4.Size = new Size(77, 52);
            btn4.TabIndex = 7;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click_1;
            // 
            // btn3
            // 
            btn3.BackColor = Color.DarkOrange;
            btn3.Font = new Font("Segoe UI", 18F);
            btn3.Location = new Point(178, 202);
            btn3.Name = "btn3";
            btn3.Size = new Size(77, 52);
            btn3.TabIndex = 12;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click_1;
            // 
            // btn2
            // 
            btn2.BackColor = Color.DarkOrange;
            btn2.Font = new Font("Segoe UI", 18F);
            btn2.Location = new Point(95, 202);
            btn2.Name = "btn2";
            btn2.Size = new Size(77, 52);
            btn2.TabIndex = 11;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click_1;
            // 
            // btn1
            // 
            btn1.BackColor = Color.DarkOrange;
            btn1.Font = new Font("Segoe UI", 18F);
            btn1.Location = new Point(12, 202);
            btn1.Name = "btn1";
            btn1.Size = new Size(77, 52);
            btn1.TabIndex = 10;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click_1;
            // 
            // btnPow
            // 
            btnPow.BackColor = Color.DarkOrange;
            btnPow.Font = new Font("Segoe UI", 18F);
            btnPow.Location = new Point(428, 202);
            btnPow.Name = "btnPow";
            btnPow.Size = new Size(117, 52);
            btnPow.TabIndex = 24;
            btnPow.Text = "^";
            btnPow.UseVisualStyleBackColor = false;
            btnPow.Click += btnPow_Click_1;
            // 
            // btnCloseParenthesis
            // 
            btnCloseParenthesis.BackColor = Color.DarkOrange;
            btnCloseParenthesis.Font = new Font("Segoe UI", 18F);
            btnCloseParenthesis.Location = new Point(345, 202);
            btnCloseParenthesis.Name = "btnCloseParenthesis";
            btnCloseParenthesis.Size = new Size(77, 52);
            btnCloseParenthesis.TabIndex = 23;
            btnCloseParenthesis.Text = ")";
            btnCloseParenthesis.UseVisualStyleBackColor = false;
            btnCloseParenthesis.Click += btnCloseParenthesis_Click_1;
            // 
            // btnOpenParenthesis
            // 
            btnOpenParenthesis.BackColor = Color.DarkOrange;
            btnOpenParenthesis.Font = new Font("Segoe UI", 18F);
            btnOpenParenthesis.Location = new Point(262, 202);
            btnOpenParenthesis.Name = "btnOpenParenthesis";
            btnOpenParenthesis.Size = new Size(77, 52);
            btnOpenParenthesis.TabIndex = 22;
            btnOpenParenthesis.Text = "(";
            btnOpenParenthesis.UseVisualStyleBackColor = false;
            btnOpenParenthesis.Click += btnOpenParenthesis_Click_1;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.DarkOrange;
            btnClear.Font = new Font("Segoe UI", 18F);
            btnClear.Location = new Point(428, 144);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(117, 52);
            btnClear.TabIndex = 21;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click_1;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = Color.DarkOrange;
            btnMinus.Font = new Font("Segoe UI", 18F);
            btnMinus.Location = new Point(345, 144);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(77, 52);
            btnMinus.TabIndex = 20;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += btnMinus_Click_1;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = Color.DarkOrange;
            btnPlus.Font = new Font("Segoe UI", 18F);
            btnPlus.Location = new Point(262, 144);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(77, 52);
            btnPlus.TabIndex = 19;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += btnPlus_Click_1;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DarkOrange;
            btnDelete.Font = new Font("Segoe UI", 18F);
            btnDelete.Location = new Point(428, 86);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(117, 52);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = Color.DarkOrange;
            btnMultiply.Font = new Font("Segoe UI", 18F);
            btnMultiply.Location = new Point(345, 86);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(77, 52);
            btnMultiply.TabIndex = 17;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = false;
            btnMultiply.Click += btnMultiply_Click_1;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = Color.DarkOrange;
            btnDivide.Font = new Font("Segoe UI", 18F);
            btnDivide.Location = new Point(262, 86);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(77, 52);
            btnDivide.TabIndex = 16;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += btnDivide_Click_1;
            // 
            // btnResult
            // 
            btnResult.BackColor = Color.DarkOrange;
            btnResult.Font = new Font("Segoe UI", 18F);
            btnResult.Location = new Point(262, 260);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(283, 52);
            btnResult.TabIndex = 13;
            btnResult.Text = "=";
            btnResult.UseVisualStyleBackColor = false;
            btnResult.Click += btnResult_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(555, 326);
            Controls.Add(btnPow);
            Controls.Add(btnCloseParenthesis);
            Controls.Add(btnOpenParenthesis);
            Controls.Add(btnClear);
            Controls.Add(btnMinus);
            Controls.Add(btnPlus);
            Controls.Add(btnDelete);
            Controls.Add(btnMultiply);
            Controls.Add(btnDivide);
            Controls.Add(btnResult);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btnDot);
            Controls.Add(btn0);
            Controls.Add(textDisplay);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textDisplay;
        private Button btn0;
        private Button btnDot;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btnPow;
        private Button btnCloseParenthesis;
        private Button btnOpenParenthesis;
        private Button btnClear;
        private Button btnMinus;
        private Button btnPlus;
        private Button btnDelete;
        private Button btnMultiply;
        private Button btnDivide;
        private Button btnResult;
    }
}
