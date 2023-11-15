namespace Assignment
{
    partial class AdminMonthlyIncome
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
            this.button1 = new System.Windows.Forms.Button();
            this.GenerateIncomeBtn = new System.Windows.Forms.Button();
            this.AdminUserlistBox = new System.Windows.Forms.ListBox();
            this.income_btn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(562, 143);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GenerateIncomeBtn
            // 
            this.GenerateIncomeBtn.Location = new System.Drawing.Point(329, 284);
            this.GenerateIncomeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.GenerateIncomeBtn.Name = "GenerateIncomeBtn";
            this.GenerateIncomeBtn.Size = new System.Drawing.Size(112, 33);
            this.GenerateIncomeBtn.TabIndex = 8;
            this.GenerateIncomeBtn.Text = "Generate report";
            this.GenerateIncomeBtn.UseVisualStyleBackColor = true;
            this.GenerateIncomeBtn.Click += new System.EventHandler(this.GenerateIncomeBtn_Click);
            // 
            // AdminUserlistBox
            // 
            this.AdminUserlistBox.FormattingEnabled = true;
            this.AdminUserlistBox.Location = new System.Drawing.Point(280, 75);
            this.AdminUserlistBox.Margin = new System.Windows.Forms.Padding(2);
            this.AdminUserlistBox.Name = "AdminUserlistBox";
            this.AdminUserlistBox.Size = new System.Drawing.Size(224, 173);
            this.AdminUserlistBox.TabIndex = 7;
            // 
            // income_btn
            // 
            this.income_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.income_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.income_btn.Location = new System.Drawing.Point(0, 0);
            this.income_btn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.income_btn.Name = "income_btn";
            this.income_btn.Size = new System.Drawing.Size(800, 30);
            this.income_btn.TabIndex = 6;
            this.income_btn.Text = "Monthly income";
            this.income_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdminMonthlyIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GenerateIncomeBtn);
            this.Controls.Add(this.AdminUserlistBox);
            this.Controls.Add(this.income_btn);
            this.Name = "AdminMonthlyIncome";
            this.Text = "AdminMonthlyIncome";
            this.Load += new System.EventHandler(this.AdminMonthlyIncome_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button GenerateIncomeBtn;
        private System.Windows.Forms.ListBox AdminUserlistBox;
        private System.Windows.Forms.Label income_btn;
    }
}