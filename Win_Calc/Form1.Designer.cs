namespace Win_Calc
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
            this.percent = new System.Windows.Forms.Button();
            this.root = new System.Windows.Forms.Button();
            this.squared = new System.Windows.Forms.Button();
            this.clear_all = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.backspace = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.reciprocal = new System.Windows.Forms.Button();
            this.addition = new System.Windows.Forms.Button();
            this.subtract = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.deci = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.plus_minus = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // percent
            // 
            this.percent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.percent.Font = new System.Drawing.Font("Mercurius Script MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percent.Location = new System.Drawing.Point(12, 91);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(42, 40);
            this.percent.TabIndex = 0;
            this.percent.Text = "%";
            this.percent.UseVisualStyleBackColor = true;
            this.percent.Click += new System.EventHandler(this.percent_click);
            // 
            // root
            // 
            this.root.Cursor = System.Windows.Forms.Cursors.Hand;
            this.root.Font = new System.Drawing.Font("Mercurius Script MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.root.Location = new System.Drawing.Point(60, 91);
            this.root.Name = "root";
            this.root.Size = new System.Drawing.Size(42, 40);
            this.root.TabIndex = 1;
            this.root.Text = "√";
            this.root.UseVisualStyleBackColor = true;
            this.root.Click += new System.EventHandler(this.operater_click);
            // 
            // squared
            // 
            this.squared.Cursor = System.Windows.Forms.Cursors.Hand;
            this.squared.Font = new System.Drawing.Font("Mercurius Script MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.squared.Location = new System.Drawing.Point(108, 91);
            this.squared.Name = "squared";
            this.squared.Size = new System.Drawing.Size(42, 40);
            this.squared.TabIndex = 2;
            this.squared.Text = "x²";
            this.squared.UseVisualStyleBackColor = true;
            this.squared.Click += new System.EventHandler(this.operater_click);
            // 
            // clear_all
            // 
            this.clear_all.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear_all.Font = new System.Drawing.Font("Mercurius Script MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_all.Location = new System.Drawing.Point(12, 137);
            this.clear_all.Name = "clear_all";
            this.clear_all.Size = new System.Drawing.Size(42, 40);
            this.clear_all.TabIndex = 3;
            this.clear_all.Text = "CE";
            this.clear_all.UseVisualStyleBackColor = true;
            this.clear_all.Click += new System.EventHandler(this.clear_all_Click);
            // 
            // clear
            // 
            this.clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear.Font = new System.Drawing.Font("Mercurius Script MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(60, 137);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(42, 40);
            this.clear.TabIndex = 4;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_all_Click);
            // 
            // backspace
            // 
            this.backspace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backspace.Font = new System.Drawing.Font("Mercurius Script MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backspace.Location = new System.Drawing.Point(108, 137);
            this.backspace.Name = "backspace";
            this.backspace.Size = new System.Drawing.Size(42, 40);
            this.backspace.TabIndex = 5;
            this.backspace.Text = "⌫";
            this.backspace.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Font = new System.Drawing.Font("Mercurius Script MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(12, 183);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(42, 40);
            this.button7.TabIndex = 6;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button_Click);
            // 
            // button8
            // 
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.Font = new System.Drawing.Font("Mercurius Script MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(60, 183);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(42, 40);
            this.button8.TabIndex = 7;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button_Click);
            // 
            // button9
            // 
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.Font = new System.Drawing.Font("Mercurius Script MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(108, 183);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(42, 40);
            this.button9.TabIndex = 8;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button_Click);
            // 
            // multiply
            // 
            this.multiply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.multiply.Font = new System.Drawing.Font("Mercurius Script MT Bold", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiply.Location = new System.Drawing.Point(156, 183);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(42, 40);
            this.multiply.TabIndex = 11;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.operater_click);
            // 
            // divide
            // 
            this.divide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.divide.Font = new System.Drawing.Font("Mercurius Script MT Bold", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divide.Location = new System.Drawing.Point(156, 137);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(42, 40);
            this.divide.TabIndex = 10;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.operater_click);
            // 
            // reciprocal
            // 
            this.reciprocal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reciprocal.Font = new System.Drawing.Font("Mercurius Script MT Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reciprocal.Location = new System.Drawing.Point(156, 91);
            this.reciprocal.Name = "reciprocal";
            this.reciprocal.Size = new System.Drawing.Size(42, 40);
            this.reciprocal.TabIndex = 9;
            this.reciprocal.Text = "1/x";
            this.reciprocal.UseVisualStyleBackColor = true;
            this.reciprocal.Click += new System.EventHandler(this.operater_click);
            // 
            // addition
            // 
            this.addition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addition.Font = new System.Drawing.Font("Mercurius Script MT Bold", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addition.Location = new System.Drawing.Point(156, 275);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(42, 40);
            this.addition.TabIndex = 19;
            this.addition.Text = "+";
            this.addition.UseVisualStyleBackColor = true;
            this.addition.Click += new System.EventHandler(this.operater_click);
            // 
            // subtract
            // 
            this.subtract.Cursor = System.Windows.Forms.Cursors.Hand;
            this.subtract.Font = new System.Drawing.Font("Mercurius Script MT Bold", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtract.Location = new System.Drawing.Point(156, 229);
            this.subtract.Name = "subtract";
            this.subtract.Size = new System.Drawing.Size(42, 40);
            this.subtract.TabIndex = 18;
            this.subtract.Text = "-";
            this.subtract.UseVisualStyleBackColor = true;
            this.subtract.Click += new System.EventHandler(this.operater_click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Mercurius Script MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(108, 275);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(42, 40);
            this.button3.TabIndex = 17;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Mercurius Script MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(60, 275);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 40);
            this.button2.TabIndex = 16;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Mercurius Script MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 40);
            this.button1.TabIndex = 15;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_Click);
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Font = new System.Drawing.Font("Mercurius Script MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(108, 229);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(42, 40);
            this.button6.TabIndex = 14;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button_Click);
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("Mercurius Script MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(60, 229);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(42, 40);
            this.button5.TabIndex = 13;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Mercurius Script MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(12, 229);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(42, 40);
            this.button4.TabIndex = 12;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button_Click);
            // 
            // equals
            // 
            this.equals.Cursor = System.Windows.Forms.Cursors.Hand;
            this.equals.Font = new System.Drawing.Font("Mercurius Script MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equals.Location = new System.Drawing.Point(156, 321);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(42, 40);
            this.equals.TabIndex = 23;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = true;
            this.equals.Click += new System.EventHandler(this.equals_Click);
            // 
            // deci
            // 
            this.deci.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deci.Font = new System.Drawing.Font("Mercurius Script MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deci.Location = new System.Drawing.Point(108, 321);
            this.deci.Name = "deci";
            this.deci.Size = new System.Drawing.Size(42, 40);
            this.deci.TabIndex = 22;
            this.deci.Text = ".";
            this.deci.UseVisualStyleBackColor = true;
            // 
            // button0
            // 
            this.button0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button0.Font = new System.Drawing.Font("Mercurius Script MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.Location = new System.Drawing.Point(60, 321);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(42, 40);
            this.button0.TabIndex = 21;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button_Click);
            // 
            // plus_minus
            // 
            this.plus_minus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.plus_minus.Font = new System.Drawing.Font("Mercurius Script MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus_minus.Location = new System.Drawing.Point(12, 321);
            this.plus_minus.Name = "plus_minus";
            this.plus_minus.Size = new System.Drawing.Size(42, 40);
            this.plus_minus.TabIndex = 20;
            this.plus_minus.Text = "±";
            this.plus_minus.UseVisualStyleBackColor = true;
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(12, 12);
            this.result.Multiline = true;
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(185, 73);
            this.result.TabIndex = 24;
            this.result.Text = "0";
            this.result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 374);
            this.Controls.Add(this.result);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.deci);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.plus_minus);
            this.Controls.Add(this.addition);
            this.Controls.Add(this.subtract);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.reciprocal);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.backspace);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.clear_all);
            this.Controls.Add(this.squared);
            this.Controls.Add(this.root);
            this.Controls.Add(this.percent);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windows Calc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button percent;
        private System.Windows.Forms.Button root;
        private System.Windows.Forms.Button squared;
        private System.Windows.Forms.Button clear_all;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button backspace;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button reciprocal;
        private System.Windows.Forms.Button addition;
        private System.Windows.Forms.Button subtract;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.Button deci;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button plus_minus;
        private System.Windows.Forms.TextBox result;
    }
}

