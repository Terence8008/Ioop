namespace Assignment
{
    partial class WorkerMainMenu
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.requestBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.iOOPAssignmentDataSet = new Assignment.IOOPAssignmentDataSet();
            this.requestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CloseBtn = new System.Windows.Forms.Button();
            this.requestTableAdapter = new Assignment.IOOPAssignmentDataSetTableAdapters.RequestTableAdapter();
            this.UpdBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOPAssignmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(73, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(641, 197);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            // 
            // requestBindingSource1
            // 
            this.requestBindingSource1.DataMember = "Request";
            this.requestBindingSource1.DataSource = this.iOOPAssignmentDataSet;
            // 
            // iOOPAssignmentDataSet
            // 
            this.iOOPAssignmentDataSet.DataSetName = "IOOPAssignmentDataSet";
            this.iOOPAssignmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // requestBindingSource
            // 
            this.requestBindingSource.DataMember = "Request";
            this.requestBindingSource.DataSource = this.iOOPAssignmentDataSet;
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(454, 268);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(170, 46);
            this.CloseBtn.TabIndex = 1;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // requestTableAdapter
            // 
            this.requestTableAdapter.ClearBeforeFill = true;
            // 
            // UpdBtn
            // 
            this.UpdBtn.Location = new System.Drawing.Point(163, 268);
            this.UpdBtn.Name = "UpdBtn";
            this.UpdBtn.Size = new System.Drawing.Size(153, 46);
            this.UpdBtn.TabIndex = 2;
            this.UpdBtn.Text = "Update";
            this.UpdBtn.UseVisualStyleBackColor = true;
            this.UpdBtn.Click += new System.EventHandler(this.UpdBtn_Click);
            // 
            // WorkerMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 331);
            this.Controls.Add(this.UpdBtn);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "WorkerMainMenu";
            this.Text = "WorkerMainMenu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOPAssignmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button CloseBtn;
        private IOOPAssignmentDataSet iOOPAssignmentDataSet;
        private System.Windows.Forms.BindingSource requestBindingSource;
        private IOOPAssignmentDataSetTableAdapters.RequestTableAdapter requestTableAdapter;
        private System.Windows.Forms.BindingSource requestBindingSource1;
        private System.Windows.Forms.Button UpdBtn;
    }
}