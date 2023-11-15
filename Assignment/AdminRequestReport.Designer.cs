namespace Assignment
{
    partial class AdminRequestReport
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
            ((System.ComponentModel.ISupportInitialize)(this.DataGridSQL)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridSQL
            // 
            this.DataGridSQL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridSQL.Location = new System.Drawing.Point(77, 52);
            this.DataGridSQL.Name = "DataGridSQL";
            this.DataGridSQL.Size = new System.Drawing.Size(492, 234);
            this.DataGridSQL.TabIndex = 0;
            // 
            // AdminRequestReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 450);
            this.Controls.Add(this.DataGridSQL);
            this.Name = "AdminRequestReport";
            this.Text = "AdminRequestReport";
            this.Load += new System.EventHandler(this.AdminRequestReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridSQL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridSQL;
    }
}