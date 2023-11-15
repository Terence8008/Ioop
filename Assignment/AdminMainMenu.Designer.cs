namespace Assignment
{
    partial class AdminMainMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.Register_form_btn = new System.Windows.Forms.Button();
            this.Request_form_btn = new System.Windows.Forms.Button();
            this.Income_form_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Main Admin Page";
            // 
            // Register_form_btn
            // 
            this.Register_form_btn.Location = new System.Drawing.Point(183, 100);
            this.Register_form_btn.Name = "Register_form_btn";
            this.Register_form_btn.Size = new System.Drawing.Size(125, 63);
            this.Register_form_btn.TabIndex = 1;
            this.Register_form_btn.Text = "Register New User";
            this.Register_form_btn.UseVisualStyleBackColor = true;
            this.Register_form_btn.Click += new System.EventHandler(this.Register_form_btn_Click);
            // 
            // Request_form_btn
            // 
            this.Request_form_btn.Location = new System.Drawing.Point(183, 206);
            this.Request_form_btn.Name = "Request_form_btn";
            this.Request_form_btn.Size = new System.Drawing.Size(125, 58);
            this.Request_form_btn.TabIndex = 2;
            this.Request_form_btn.Text = "View Request Report";
            this.Request_form_btn.UseVisualStyleBackColor = true;
            this.Request_form_btn.Click += new System.EventHandler(this.Request_form_btn_Click);
            // 
            // Income_form_btn
            // 
            this.Income_form_btn.Location = new System.Drawing.Point(183, 308);
            this.Income_form_btn.Name = "Income_form_btn";
            this.Income_form_btn.Size = new System.Drawing.Size(125, 55);
            this.Income_form_btn.TabIndex = 3;
            this.Income_form_btn.Text = "Monthly income";
            this.Income_form_btn.UseVisualStyleBackColor = true;
            this.Income_form_btn.Click += new System.EventHandler(this.Income_form_btn_Click);
            // 
            // AdminMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 450);
            this.Controls.Add(this.Income_form_btn);
            this.Controls.Add(this.Request_form_btn);
            this.Controls.Add(this.Register_form_btn);
            this.Controls.Add(this.label1);
            this.Name = "AdminMainMenu";
            this.Text = "AdminMainMenu";
            this.Load += new System.EventHandler(this.AdminMainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Register_form_btn;
        private System.Windows.Forms.Button Request_form_btn;
        private System.Windows.Forms.Button Income_form_btn;
    }
}