namespace WinFormsLab
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox wynikBox;
        private System.Windows.Forms.Button[] buttons = new System.Windows.Forms.Button[10];
        private System.Windows.Forms.Button buttonAdd, buttonSub, buttonMultiply, buttonDivide, buttonEquals, buttonClear;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.wynikBox = new System.Windows.Forms.TextBox();
            for (int i = 0; i < 10; i++)
                this.buttons[i] = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSub = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonEquals = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            this.wynikBox.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.wynikBox.Location = new System.Drawing.Point(12, 12);
            this.wynikBox.Size = new System.Drawing.Size(318, 43);
            this.wynikBox.ReadOnly = true;
            this.wynikBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Controls.Add(this.wynikBox);

            int buttonWidth = 70, buttonHeight = 50, margin = 10;
            int startX = 12, startY = 70;
            for (int i = 1; i <= 9; i++)
            {
                buttons[i].Font = new System.Drawing.Font("Segoe UI", 14F);
                buttons[i].Text = i.ToString();
                buttons[i].Size = new System.Drawing.Size(buttonWidth, buttonHeight);
                buttons[i].Location = new System.Drawing.Point(startX + ((i - 1) % 3) * (buttonWidth + margin), startY + ((i - 1) / 3) * (buttonHeight + margin));
                buttons[i].Click += button_Click;
                this.Controls.Add(buttons[i]);
            }
            buttons[0].Font = new System.Drawing.Font("Segoe UI", 14F);
            buttons[0].Text = "0";
            buttons[0].Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            buttons[0].Location = new System.Drawing.Point(startX, startY + 3 * (buttonHeight + margin));
            buttons[0].Click += button_Click;
            this.Controls.Add(buttons[0]);

            SetupButton(buttonAdd, "+", 3, 0, buttonAdd_Click);
            SetupButton(buttonSub, "-", 3, 1, buttonSub_Click);
            SetupButton(buttonMultiply, "*", 3, 2, buttonMultiply_Click);
            SetupButton(buttonDivide, "/", 3, 3, buttonDivide_Click);
            SetupButton(buttonClear, "C", 1, 3, buttonClear_Click);
            SetupButton(buttonEquals, "=", 2, 3, buttonEquals_Click);

            this.ClientSize = new System.Drawing.Size(342, 400);
            this.Name = "Form1";
            this.Text = "Kalkulator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void SetupButton(System.Windows.Forms.Button btn, string text, int col, int row, System.EventHandler click)
        {
            int buttonWidth = 70, buttonHeight = 50, margin = 10, startX = 12, startY = 70;
            btn.Font = new System.Drawing.Font("Segoe UI", 14F);
            btn.Text = text;
            btn.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            btn.Location = new System.Drawing.Point(startX + col * (buttonWidth + margin), startY + row * (buttonHeight + margin));
            btn.BackColor = System.Drawing.Color.LightSteelBlue;
            btn.Click += click;
            this.Controls.Add(btn);
        }
    }
}
