namespace WinFormsLab
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            buttonAdd = new Button();
            buttonSub = new Button();
            buttonMultiply = new Button();
            buttonDivide = new Button();
            wynikBox = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(283, 122);
            button1.Name = "button1";
            button1.Size = new Size(26, 23);
            button1.TabIndex = 14;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(347, 122);
            button2.Name = "button2";
            button2.Size = new Size(26, 23);
            button2.TabIndex = 15;
            button2.Text = "3";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button3_Click;
            // 
            // button3
            // 
            button3.Location = new Point(315, 122);
            button3.Name = "button3";
            button3.Size = new Size(26, 23);
            button3.TabIndex = 16;
            button3.Text = "2";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(315, 180);
            button4.Name = "button4";
            button4.Size = new Size(26, 23);
            button4.TabIndex = 19;
            button4.Text = "8";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button8_Click;
            // 
            // button5
            // 
            button5.Location = new Point(347, 180);
            button5.Name = "button5";
            button5.Size = new Size(26, 23);
            button5.TabIndex = 18;
            button5.Text = "9";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button9_Click;
            // 
            // button6
            // 
            button6.Location = new Point(283, 180);
            button6.Name = "button6";
            button6.Size = new Size(26, 23);
            button6.TabIndex = 17;
            button6.Text = "7";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button7_Click;
            // 
            // button7
            // 
            button7.Location = new Point(315, 151);
            button7.Name = "button7";
            button7.Size = new Size(26, 23);
            button7.TabIndex = 22;
            button7.Text = "5";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(347, 151);
            button8.Name = "button8";
            button8.Size = new Size(26, 23);
            button8.TabIndex = 21;
            button8.Text = "6";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(283, 151);
            button9.Name = "button9";
            button9.Size = new Size(26, 23);
            button9.TabIndex = 20;
            button9.Text = "4";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Location = new Point(315, 209);
            button10.Name = "button10";
            button10.Size = new Size(26, 23);
            button10.TabIndex = 23;
            button10.Text = "0";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(419, 122);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(26, 23);
            buttonAdd.TabIndex = 24;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonSub
            // 
            buttonSub.Location = new Point(419, 151);
            buttonSub.Name = "buttonSub";
            buttonSub.Size = new Size(26, 23);
            buttonSub.TabIndex = 25;
            buttonSub.Text = "-";
            buttonSub.UseVisualStyleBackColor = true;
            buttonSub.Click += buttonSub_Click;
            // 
            // buttonMultiply
            // 
            buttonMultiply.Location = new Point(419, 180);
            buttonMultiply.Name = "buttonMultiply";
            buttonMultiply.Size = new Size(26, 23);
            buttonMultiply.TabIndex = 26;
            buttonMultiply.Text = "*";
            buttonMultiply.UseVisualStyleBackColor = true;
            buttonMultiply.Click += buttonMultiply_Click;
            // 
            // buttonDivide
            // 
            buttonDivide.Location = new Point(419, 209);
            buttonDivide.Name = "buttonDivide";
            buttonDivide.Size = new Size(26, 23);
            buttonDivide.TabIndex = 27;
            buttonDivide.Text = "/";
            buttonDivide.UseVisualStyleBackColor = true;
            buttonDivide.Click += buttonDivide_Click;
            // 
            // wynikBox
            // 
            wynikBox.Location = new Point(283, 70);
            wynikBox.Name = "wynikBox";
            wynikBox.Size = new Size(162, 23);
            wynikBox.TabIndex = 28;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(wynikBox);
            Controls.Add(buttonDivide);
            Controls.Add(buttonMultiply);
            Controls.Add(buttonSub);
            Controls.Add(buttonAdd);
            Controls.Add(button10);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button buttonAdd;
        private Button buttonSub;
        private Button buttonMultiply;
        private Button buttonDivide;
        private TextBox wynikBox;
    }
}
