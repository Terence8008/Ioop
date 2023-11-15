namespace Assignment
{
    partial class CustNewRequestForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.TextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.CalculateBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CostLbl = new System.Windows.Forms.Label();
            this.NewReqBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Service type";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "A4 - BW",
            "A4 - Color",
            "Binding - CB",
            "Binding - TC",
            "Poster",
            "Banner"});
            this.listBox1.Location = new System.Drawing.Point(34, 171);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 43);
            this.listBox1.TabIndex = 1;
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(314, 51);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(100, 20);
            this.TextBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Amount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cost:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(381, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "    ";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(265, 87);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(207, 30);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Urgent (Will be priotized \r\nhowever there is a subcharge of 30%) ";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.Location = new System.Drawing.Point(265, 171);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Size = new System.Drawing.Size(103, 23);
            this.CalculateBtn.TabIndex = 7;
            this.CalculateBtn.Text = "Calculate";
            this.CalculateBtn.UseVisualStyleBackColor = true;
            this.CalculateBtn.Click += new System.EventHandler(this.CalculateBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(397, 226);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(75, 23);
            this.CloseBtn.TabIndex = 8;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // accountsTableAdapter1
            // 
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 78);
            this.label5.TabIndex = 9;
            this.label5.Text = "Printing A4 - Black and white\r\nPrinting A4 - Color\r\nBinding - Comb Binding\r\nBindi" +
    "ng - Thick Cover\r\nPoster printing (A0 - A3)\r\nBanner";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(180, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 104);
            this.label6.TabIndex = 10;
            this.label6.Text = "Fees (RM)\r\n\r\n0.8 / page\r\n2.50 / page\r\n5 / page\r\n15 / book\r\n3 / page\r\n10 / banner\r" +
    "\n";
            // 
            // CostLbl
            // 
            this.CostLbl.AutoSize = true;
            this.CostLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CostLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CostLbl.Location = new System.Drawing.Point(300, 139);
            this.CostLbl.Name = "CostLbl";
            this.CostLbl.Size = new System.Drawing.Size(33, 15);
            this.CostLbl.TabIndex = 11;
            this.CostLbl.Text = "        ";
            // 
            // NewReqBtn
            // 
            this.NewReqBtn.Location = new System.Drawing.Point(265, 209);
            this.NewReqBtn.Name = "NewReqBtn";
            this.NewReqBtn.Size = new System.Drawing.Size(110, 40);
            this.NewReqBtn.TabIndex = 12;
            this.NewReqBtn.Text = "Submit new Request";
            this.NewReqBtn.UseVisualStyleBackColor = true;
            this.NewReqBtn.Click += new System.EventHandler(this.NewReqBtn_Click);
            // 
            // CustNewRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.NewReqBtn);
            this.Controls.Add(this.CostLbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.CalculateBtn);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Name = "CustNewRequestForm";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.CustNewRequestForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.MaskedTextBox TextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button CalculateBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label CostLbl;
        private System.Windows.Forms.Button NewReqBtn;
    }
}