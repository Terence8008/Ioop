namespace Assignment
{
    partial class AdminIncomeReportForm
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
            this.DataGridSQL = new System.Windows.Forms.DataGridView();
            this.UserReportLbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridSQL)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridSQL
            // 
            this.DataGridSQL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridSQL.Location = new System.Drawing.Point(23, 59);
            this.DataGridSQL.Name = "DataGridSQL";
            this.DataGridSQL.Size = new System.Drawing.Size(680, 258);
            this.DataGridSQL.TabIndex = 0;
            // 
            // UserReportLbl
            // 
            this.UserReportLbl.AutoSize = true;
            this.UserReportLbl.Location = new System.Drawing.Point(317, 20);
            this.UserReportLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserReportLbl.Name = "UserReportLbl";
            this.UserReportLbl.Size = new System.Drawing.Size(80, 13);
            this.UserReportLbl.TabIndex = 1;
            this.UserReportLbl.Text = "Selected Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 17);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(306, 351);
            this.CloseBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(110, 30);
            this.CloseBtn.TabIndex = 5;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // AdminIncomeReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 392);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UserReportLbl);
            this.Controls.Add(this.DataGridSQL);
            this.Name = "AdminIncomeReportForm";
            this.Text = "AdminIncomeReportForm";
            this.Load += new System.EventHandler(this.AdminIncomeReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridSQL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridSQL;
        private System.Windows.Forms.Label UserReportLbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button CloseBtn;
    }
}