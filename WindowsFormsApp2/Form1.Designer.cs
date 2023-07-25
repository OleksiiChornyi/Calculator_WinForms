namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Close = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Equal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Sub = new System.Windows.Forms.Button();
            this.Multiplication = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.PlusMinus = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.Comma = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Backspace = new System.Windows.Forms.Button();
            this.SQRT = new System.Windows.Forms.Button();
            this.COS = new System.Windows.Forms.Button();
            this.Factorial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(415, 422);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(91, 46);
            this.Close.TabIndex = 2;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.button_close);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 54);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(483, 50);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(299, 333);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(91, 46);
            this.Add.TabIndex = 3;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.button_Add);
            // 
            // Equal
            // 
            this.Equal.Location = new System.Drawing.Point(299, 397);
            this.Equal.Name = "Equal";
            this.Equal.Size = new System.Drawing.Size(91, 71);
            this.Equal.TabIndex = 4;
            this.Equal.Text = "=";
            this.Equal.UseVisualStyleBackColor = true;
            this.Equal.Click += new System.EventHandler(this.button_Equal);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 5;
            // 
            // Sub
            // 
            this.Sub.Location = new System.Drawing.Point(299, 270);
            this.Sub.Name = "Sub";
            this.Sub.Size = new System.Drawing.Size(91, 46);
            this.Sub.TabIndex = 6;
            this.Sub.Text = "-";
            this.Sub.UseVisualStyleBackColor = true;
            this.Sub.Click += new System.EventHandler(this.button_Minus);
            // 
            // Multiplication
            // 
            this.Multiplication.Location = new System.Drawing.Point(299, 208);
            this.Multiplication.Name = "Multiplication";
            this.Multiplication.Size = new System.Drawing.Size(91, 46);
            this.Multiplication.TabIndex = 7;
            this.Multiplication.Text = "*";
            this.Multiplication.UseVisualStyleBackColor = true;
            this.Multiplication.Click += new System.EventHandler(this.button_Mul);
            // 
            // Divide
            // 
            this.Divide.Location = new System.Drawing.Point(299, 141);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(91, 46);
            this.Divide.TabIndex = 8;
            this.Divide.Text = "/";
            this.Divide.UseVisualStyleBackColor = true;
            this.Divide.Click += new System.EventHandler(this.button_Divide);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(197, 208);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(60, 46);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button_9);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(111, 208);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(60, 46);
            this.button8.TabIndex = 10;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button_8);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(23, 208);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(60, 46);
            this.button7.TabIndex = 11;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button_7);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(197, 270);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(60, 46);
            this.button6.TabIndex = 12;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button_6);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(111, 270);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(60, 46);
            this.button5.TabIndex = 13;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button_5);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(23, 270);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 46);
            this.button4.TabIndex = 14;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button_4);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(197, 333);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 46);
            this.button3.TabIndex = 15;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_3);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(111, 333);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 46);
            this.button2.TabIndex = 16;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_2);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 46);
            this.button1.TabIndex = 17;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_1);
            // 
            // PlusMinus
            // 
            this.PlusMinus.Location = new System.Drawing.Point(23, 397);
            this.PlusMinus.Name = "PlusMinus";
            this.PlusMinus.Size = new System.Drawing.Size(60, 46);
            this.PlusMinus.TabIndex = 18;
            this.PlusMinus.Text = "+/-";
            this.PlusMinus.UseVisualStyleBackColor = true;
            this.PlusMinus.Click += new System.EventHandler(this.button_Minus_Plus);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(111, 397);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(60, 46);
            this.button0.TabIndex = 19;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button_0);
            // 
            // Comma
            // 
            this.Comma.Location = new System.Drawing.Point(197, 397);
            this.Comma.Name = "Comma";
            this.Comma.Size = new System.Drawing.Size(60, 46);
            this.Comma.TabIndex = 20;
            this.Comma.Text = ".";
            this.Comma.UseVisualStyleBackColor = true;
            this.Comma.Click += new System.EventHandler(this.button_comma);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(23, 141);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(60, 46);
            this.Clear.TabIndex = 21;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.buttonClear);
            // 
            // Backspace
            // 
            this.Backspace.Location = new System.Drawing.Point(197, 141);
            this.Backspace.Name = "Backspace";
            this.Backspace.Size = new System.Drawing.Size(60, 46);
            this.Backspace.TabIndex = 22;
            this.Backspace.Text = "<-";
            this.Backspace.UseVisualStyleBackColor = true;
            this.Backspace.Click += new System.EventHandler(this.button_Backspace);
            // 
            // SQRT
            // 
            this.SQRT.Location = new System.Drawing.Point(415, 141);
            this.SQRT.Name = "SQRT";
            this.SQRT.Size = new System.Drawing.Size(91, 46);
            this.SQRT.TabIndex = 23;
            this.SQRT.Text = "√x";
            this.SQRT.UseVisualStyleBackColor = true;
            this.SQRT.Click += new System.EventHandler(this.button_SQRT);
            // 
            // COS
            // 
            this.COS.Location = new System.Drawing.Point(415, 208);
            this.COS.Name = "COS";
            this.COS.Size = new System.Drawing.Size(91, 46);
            this.COS.TabIndex = 24;
            this.COS.Text = "cos(x)";
            this.COS.UseVisualStyleBackColor = true;
            this.COS.Click += new System.EventHandler(this.button_COS);
            // 
            // Factorial
            // 
            this.Factorial.Location = new System.Drawing.Point(415, 270);
            this.Factorial.Name = "Factorial";
            this.Factorial.Size = new System.Drawing.Size(91, 46);
            this.Factorial.TabIndex = 25;
            this.Factorial.Text = "x!";
            this.Factorial.UseVisualStyleBackColor = true;
            this.Factorial.Click += new System.EventHandler(this.button_factorial);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(537, 482);
            this.Controls.Add(this.Factorial);
            this.Controls.Add(this.COS);
            this.Controls.Add(this.SQRT);
            this.Controls.Add(this.Backspace);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Comma);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.PlusMinus);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.Multiplication);
            this.Controls.Add(this.Sub);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Equal);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Close);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Калькулятор";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Equal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Sub;
        private System.Windows.Forms.Button Multiplication;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button PlusMinus;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button Comma;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Backspace;
        private System.Windows.Forms.Button SQRT;
        private System.Windows.Forms.Button COS;
        private System.Windows.Forms.Button Factorial;
    }
}

