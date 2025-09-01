namespace SimpleCalculator
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
            panel1 = new Panel();
            buttonClearLine = new Button();
            buttonLog = new Button();
            buttonNeg = new Button();
            buttonRem = new Button();
            buttonRoot = new Button();
            buttonExp = new Button();
            buttonBackspace = new Button();
            buttonDecimal = new Button();
            buttonMul = new Button();
            buttonDiv = new Button();
            buttonAdd = new Button();
            buttonSub = new Button();
            buttonSum = new Button();
            button0 = new Button();
            buttonClear = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            textBox1 = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(buttonClearLine);
            panel1.Controls.Add(buttonLog);
            panel1.Controls.Add(buttonNeg);
            panel1.Controls.Add(buttonRem);
            panel1.Controls.Add(buttonRoot);
            panel1.Controls.Add(buttonExp);
            panel1.Controls.Add(buttonBackspace);
            panel1.Controls.Add(buttonDecimal);
            panel1.Controls.Add(buttonMul);
            panel1.Controls.Add(buttonDiv);
            panel1.Controls.Add(buttonAdd);
            panel1.Controls.Add(buttonSub);
            panel1.Controls.Add(buttonSum);
            panel1.Controls.Add(button0);
            panel1.Controls.Add(buttonClear);
            panel1.Controls.Add(button9);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(-1, 106);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(390, 382);
            panel1.TabIndex = 0;
            // 
            // buttonClearLine
            // 
            buttonClearLine.BackColor = Color.Brown;
            buttonClearLine.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonClearLine.Location = new Point(104, 10);
            buttonClearLine.Margin = new Padding(3, 2, 3, 2);
            buttonClearLine.Name = "buttonClearLine";
            buttonClearLine.Size = new Size(88, 56);
            buttonClearLine.TabIndex = 23;
            buttonClearLine.Text = "CE";
            buttonClearLine.UseVisualStyleBackColor = false;
            buttonClearLine.Click += buttonClearLine_Click;
            // 
            // buttonLog
            // 
            buttonLog.BackColor = SystemColors.ButtonShadow;
            buttonLog.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonLog.Location = new Point(11, 71);
            buttonLog.Margin = new Padding(3, 2, 3, 2);
            buttonLog.Name = "buttonLog";
            buttonLog.Size = new Size(88, 56);
            buttonLog.TabIndex = 22;
            buttonLog.Text = "log";
            buttonLog.UseVisualStyleBackColor = false;
            buttonLog.Click += buttonLog_Click;
            // 
            // buttonNeg
            // 
            buttonNeg.BackColor = SystemColors.ButtonShadow;
            buttonNeg.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonNeg.Location = new Point(11, 317);
            buttonNeg.Margin = new Padding(3, 2, 3, 2);
            buttonNeg.Name = "buttonNeg";
            buttonNeg.Size = new Size(88, 56);
            buttonNeg.TabIndex = 21;
            buttonNeg.Text = "-/+";
            buttonNeg.UseVisualStyleBackColor = false;
            buttonNeg.Click += buttonNeg_Click;
            // 
            // buttonRem
            // 
            buttonRem.BackColor = SystemColors.ButtonShadow;
            buttonRem.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonRem.Location = new Point(11, 10);
            buttonRem.Margin = new Padding(3, 2, 3, 2);
            buttonRem.Name = "buttonRem";
            buttonRem.Size = new Size(88, 56);
            buttonRem.TabIndex = 20;
            buttonRem.Text = "%";
            buttonRem.UseVisualStyleBackColor = false;
            buttonRem.Click += buttonRem_Click;
            // 
            // buttonRoot
            // 
            buttonRoot.BackColor = SystemColors.ButtonShadow;
            buttonRoot.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonRoot.Location = new Point(104, 71);
            buttonRoot.Margin = new Padding(3, 2, 3, 2);
            buttonRoot.Name = "buttonRoot";
            buttonRoot.Size = new Size(88, 56);
            buttonRoot.TabIndex = 19;
            buttonRoot.Text = "√x";
            buttonRoot.UseVisualStyleBackColor = false;
            buttonRoot.Click += buttonRoot_Click;
            // 
            // buttonExp
            // 
            buttonExp.BackColor = SystemColors.ButtonShadow;
            buttonExp.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonExp.Location = new Point(197, 71);
            buttonExp.Margin = new Padding(3, 2, 3, 2);
            buttonExp.Name = "buttonExp";
            buttonExp.Size = new Size(88, 56);
            buttonExp.TabIndex = 18;
            buttonExp.Text = "x²";
            buttonExp.UseVisualStyleBackColor = false;
            buttonExp.Click += buttonExp_Click;
            // 
            // buttonBackspace
            // 
            buttonBackspace.BackColor = Color.Brown;
            buttonBackspace.Image = Properties.Resources.backspace;
            buttonBackspace.Location = new Point(290, 10);
            buttonBackspace.Margin = new Padding(3, 2, 3, 2);
            buttonBackspace.Name = "buttonBackspace";
            buttonBackspace.Size = new Size(88, 56);
            buttonBackspace.TabIndex = 17;
            buttonBackspace.UseVisualStyleBackColor = false;
            buttonBackspace.Click += buttonBackspace_Click;
            // 
            // buttonDecimal
            // 
            buttonDecimal.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDecimal.Location = new Point(197, 317);
            buttonDecimal.Margin = new Padding(3, 2, 3, 2);
            buttonDecimal.Name = "buttonDecimal";
            buttonDecimal.Size = new Size(88, 56);
            buttonDecimal.TabIndex = 16;
            buttonDecimal.Text = ".";
            buttonDecimal.UseVisualStyleBackColor = true;
            buttonDecimal.Click += buttonDecimal_Click;
            // 
            // buttonMul
            // 
            buttonMul.BackColor = SystemColors.ButtonShadow;
            buttonMul.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonMul.Location = new Point(290, 134);
            buttonMul.Margin = new Padding(3, 2, 3, 2);
            buttonMul.Name = "buttonMul";
            buttonMul.Size = new Size(88, 56);
            buttonMul.TabIndex = 15;
            buttonMul.Text = "x";
            buttonMul.UseVisualStyleBackColor = false;
            buttonMul.Click += buttonMul_Click;
            // 
            // buttonDiv
            // 
            buttonDiv.BackColor = SystemColors.ButtonShadow;
            buttonDiv.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDiv.Location = new Point(290, 71);
            buttonDiv.Margin = new Padding(3, 2, 3, 2);
            buttonDiv.Name = "buttonDiv";
            buttonDiv.Size = new Size(88, 56);
            buttonDiv.TabIndex = 14;
            buttonDiv.Text = "/";
            buttonDiv.UseVisualStyleBackColor = false;
            buttonDiv.Click += buttonDiv_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = SystemColors.ButtonShadow;
            buttonAdd.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAdd.Location = new Point(290, 196);
            buttonAdd.Margin = new Padding(3, 2, 3, 2);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(88, 56);
            buttonAdd.TabIndex = 13;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonSub
            // 
            buttonSub.BackColor = SystemColors.ButtonShadow;
            buttonSub.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSub.Location = new Point(290, 256);
            buttonSub.Margin = new Padding(3, 2, 3, 2);
            buttonSub.Name = "buttonSub";
            buttonSub.Size = new Size(88, 57);
            buttonSub.TabIndex = 12;
            buttonSub.Text = "-";
            buttonSub.UseVisualStyleBackColor = false;
            buttonSub.Click += buttonSub_Click;
            // 
            // buttonSum
            // 
            buttonSum.BackColor = Color.Orange;
            buttonSum.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSum.Location = new Point(290, 317);
            buttonSum.Margin = new Padding(3, 2, 3, 2);
            buttonSum.Name = "buttonSum";
            buttonSum.Size = new Size(88, 56);
            buttonSum.TabIndex = 11;
            buttonSum.Text = "=";
            buttonSum.UseVisualStyleBackColor = false;
            buttonSum.Click += buttonSum_Click;
            // 
            // button0
            // 
            button0.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button0.Location = new Point(104, 317);
            button0.Margin = new Padding(3, 2, 3, 2);
            button0.Name = "button0";
            button0.Size = new Size(88, 56);
            button0.TabIndex = 10;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button0_Click;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = Color.Brown;
            buttonClear.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonClear.Location = new Point(197, 10);
            buttonClear.Margin = new Padding(3, 2, 3, 2);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(88, 56);
            buttonClear.TabIndex = 9;
            buttonClear.Text = "C";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button9.Location = new Point(197, 134);
            button9.Margin = new Padding(3, 2, 3, 2);
            button9.Name = "button9";
            button9.Size = new Size(88, 57);
            button9.TabIndex = 8;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.Location = new Point(104, 134);
            button8.Margin = new Padding(3, 2, 3, 2);
            button8.Name = "button8";
            button8.Size = new Size(88, 57);
            button8.TabIndex = 7;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.Location = new Point(11, 135);
            button7.Margin = new Padding(3, 2, 3, 2);
            button7.Name = "button7";
            button7.Size = new Size(88, 56);
            button7.TabIndex = 6;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.Location = new Point(197, 196);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new Size(88, 56);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(104, 196);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(88, 56);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(11, 196);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(88, 56);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(197, 256);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(88, 56);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(104, 256);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(88, 56);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(11, 256);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(88, 56);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(textBox1);
            panel2.Location = new Point(-1, -3);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(390, 88);
            panel2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ScrollBar;
            textBox1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(11, 12);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(366, 71);
            textBox1.TabIndex = 0;
            textBox1.Text = "0";
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Vivaldi", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(158, 86);
            label1.Name = "label1";
            label1.Size = new Size(58, 19);
            label1.TabIndex = 2;
            label1.Text = "JAE";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(389, 499);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Simple Calculator";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Panel panel2;
        private Button buttonMul;
        private Button buttonDiv;
        private Button buttonAdd;
        private Button buttonSub;
        private Button buttonSum;
        private Button button0;
        private Button buttonClear;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Label label1;
        private TextBox textBox1;
        private Button buttonDecimal;
        private Button buttonBackspace;
        private Button buttonExp;
        private Button buttonRoot;
        private Button buttonRem;
        private Button buttonLog;
        private Button buttonNeg;
        private Button buttonClearLine;
    }
}
