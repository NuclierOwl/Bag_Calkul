﻿namespace form
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.buttonOne = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.labelCurrentOperation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOne
            // 
            this.buttonOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOne.Location = new System.Drawing.Point(29, 90);
            this.buttonOne.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOne.Name = "buttonOne";
            this.buttonOne.Size = new System.Drawing.Size(60, 55);
            this.buttonOne.TabIndex = 0;
            this.buttonOne.Text = "7";
            this.buttonOne.UseVisualStyleBackColor = true;
            this.buttonOne.Click += new System.EventHandler(this.button_click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(97, 90);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 55);
            this.button1.TabIndex = 1;
            this.button1.Text = "8";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(165, 90);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 55);
            this.button2.TabIndex = 2;
            this.button2.Text = "9";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(233, 90);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 55);
            this.button3.TabIndex = 3;
            this.button3.Text = "/";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.operator_click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(301, 90);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(71, 55);
            this.button4.TabIndex = 4;
            this.button4.Text = "CE";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(301, 153);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(71, 55);
            this.button5.TabIndex = 9;
            this.button5.Text = "C";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(233, 153);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(60, 55);
            this.button6.TabIndex = 8;
            this.button6.Text = "*";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.operator_click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(165, 153);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(60, 55);
            this.button7.TabIndex = 7;
            this.button7.Text = "6";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button_click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(97, 153);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(60, 55);
            this.button8.TabIndex = 6;
            this.button8.Text = "5";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button_click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(29, 153);
            this.button9.Margin = new System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(60, 55);
            this.button9.TabIndex = 5;
            this.button9.Text = "4";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button_click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(233, 215);
            this.button11.Margin = new System.Windows.Forms.Padding(4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(60, 55);
            this.button11.TabIndex = 13;
            this.button11.Text = "-";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.operator_click);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(165, 215);
            this.button12.Margin = new System.Windows.Forms.Padding(4);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(60, 55);
            this.button12.TabIndex = 12;
            this.button12.Text = "3";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button_click);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(97, 215);
            this.button13.Margin = new System.Windows.Forms.Padding(4);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(60, 55);
            this.button13.TabIndex = 11;
            this.button13.Text = "2";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button_click);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(29, 215);
            this.button14.Margin = new System.Windows.Forms.Padding(4);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(60, 55);
            this.button14.TabIndex = 10;
            this.button14.Text = "1";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button_click);
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(301, 215);
            this.button15.Margin = new System.Windows.Forms.Padding(4);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(71, 118);
            this.button15.TabIndex = 19;
            this.button15.Text = "=";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.Location = new System.Drawing.Point(233, 278);
            this.button16.Margin = new System.Windows.Forms.Padding(4);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(60, 55);
            this.button16.TabIndex = 18;
            this.button16.Text = "+";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.operator_click);
            // 
            // button17
            // 
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.Location = new System.Drawing.Point(165, 278);
            this.button17.Margin = new System.Windows.Forms.Padding(4);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(60, 55);
            this.button17.TabIndex = 17;
            this.button17.Text = ",";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button_click);
            // 
            // button19
            // 
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.Location = new System.Drawing.Point(29, 278);
            this.button19.Margin = new System.Windows.Forms.Padding(4);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(128, 55);
            this.button19.TabIndex = 15;
            this.button19.Text = "0";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button_click);
            // 
            // button20
            // 
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20.Location = new System.Drawing.Point(233, 341);
            this.button20.Margin = new System.Windows.Forms.Padding(4);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(60, 55);
            this.button20.TabIndex = 22;
            this.button20.Text = "sin";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.operator_click);
            // 
            // button21
            // 
            this.button21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.Location = new System.Drawing.Point(302, 341);
            this.button21.Margin = new System.Windows.Forms.Padding(4);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(68, 55);
            this.button21.TabIndex = 21;
            this.button21.Text = "cos";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.operator_click);
            // 
            // textBox_Result
            // 
            this.textBox_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Result.Location = new System.Drawing.Point(29, 49);
            this.textBox_Result.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.Size = new System.Drawing.Size(341, 34);
            this.textBox_Result.TabIndex = 20;
            this.textBox_Result.Text = "0";
            this.textBox_Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelCurrentOperation
            // 
            this.labelCurrentOperation.AutoSize = true;
            this.labelCurrentOperation.BackColor = System.Drawing.SystemColors.Window;
            this.labelCurrentOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentOperation.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelCurrentOperation.Location = new System.Drawing.Point(24, 16);
            this.labelCurrentOperation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCurrentOperation.Name = "labelCurrentOperation";
            this.labelCurrentOperation.Size = new System.Drawing.Size(0, 29);
            this.labelCurrentOperation.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 416);
            this.Controls.Add(this.labelCurrentOperation);
            this.Controls.Add(this.textBox_Result);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonOne);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Button buttonOne;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        public System.Windows.Forms.TextBox textBox_Result;
        private System.Windows.Forms.Label labelCurrentOperation;
    }
}
