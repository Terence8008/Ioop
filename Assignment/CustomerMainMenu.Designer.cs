namespace Assignment
{
    partial class CustomerMainMenu
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
            this.SubmitReqBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.iOOPAssignmentDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iOOPAssignmentDataSet = new Assignment.IOOPAssignmentDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.requestTableAdapter = new Assignment.IOOPAssignmentDataSetTableAdapters.RequestTableAdapter();
            this.iOOPAssignmentDataSet1 = new Assignment.IOOPAssignmentDataSet();
            this.requestTableAdapter1 = new Assignment.IOOPAssignmentDataSetTableAdapters.RequestTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.requestBindingSource16 = new System.Windows.Forms.BindingSource(this.components);
            this.requestIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requesterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestStatuesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urgentStatuesDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.requestQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.iOOPAssignmentDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOPAssignmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOPAssignmentDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestBindingSource16)).BeginInit();
            this.SuspendLayout();
            // 
            // SubmitReqBtn
            // 
            this.SubmitReqBtn.Location = new System.Drawing.Point(34, 238);
            this.SubmitReqBtn.Name = "SubmitReqBtn";
            this.SubmitReqBtn.Size = new System.Drawing.Size(143, 44);
            this.SubmitReqBtn.TabIndex = 1;
            this.SubmitReqBtn.Text = "Submit new requests";
            this.SubmitReqBtn.UseVisualStyleBackColor = true;
            this.SubmitReqBtn.Click += new System.EventHandler(this.SubmitReqBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(517, 238);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(143, 44);
            this.CloseBtn.TabIndex = 2;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // iOOPAssignmentDataSetBindingSource
            // 
            this.iOOPAssignmentDataSetBindingSource.DataSource = this.iOOPAssignmentDataSet;
            this.iOOPAssignmentDataSetBindingSource.Position = 0;
            // 
            // iOOPAssignmentDataSet
            // 
            this.iOOPAssignmentDataSet.DataSetName = "IOOPAssignmentDataSet";
            this.iOOPAssignmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Request Statues";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(273, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 44);
            this.button1.TabIndex = 5;
            this.button1.Text = "Check total pending ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // requestTableAdapter
            // 
            this.requestTableAdapter.ClearBeforeFill = true;
            // 
            // iOOPAssignmentDataSet1
            // 
            this.iOOPAssignmentDataSet1.DataSetName = "IOOPAssignmentDataSet";
            this.iOOPAssignmentDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // requestTableAdapter1
            // 
            this.requestTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.requestIDDataGridViewTextBoxColumn,
            this.serviceIDDataGridViewTextBoxColumn,
            this.requesterDataGridViewTextBoxColumn,
            this.requestStatuesDataGridViewTextBoxColumn,
            this.urgentStatuesDataGridViewCheckBoxColumn,
            this.requestQuantityDataGridViewTextBoxColumn,
            this.workerNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.requestBindingSource16;
            this.dataGridView1.Location = new System.Drawing.Point(12, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(736, 150);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            // 
            // requestBindingSource16
            // 
            this.requestBindingSource16.DataMember = "Request";
            this.requestBindingSource16.DataSource = this.iOOPAssignmentDataSet;
            // 
            // requestIDDataGridViewTextBoxColumn
            // 
            this.requestIDDataGridViewTextBoxColumn.DataPropertyName = "RequestID";
            this.requestIDDataGridViewTextBoxColumn.HeaderText = "RequestID";
            this.requestIDDataGridViewTextBoxColumn.Name = "requestIDDataGridViewTextBoxColumn";
            this.requestIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serviceIDDataGridViewTextBoxColumn
            // 
            this.serviceIDDataGridViewTextBoxColumn.DataPropertyName = "ServiceID";
            this.serviceIDDataGridViewTextBoxColumn.HeaderText = "ServiceID";
            this.serviceIDDataGridViewTextBoxColumn.Name = "serviceIDDataGridViewTextBoxColumn";
            this.serviceIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // requesterDataGridViewTextBoxColumn
            // 
            this.requesterDataGridViewTextBoxColumn.DataPropertyName = "Requester";
            this.requesterDataGridViewTextBoxColumn.HeaderText = "Requester";
            this.requesterDataGridViewTextBoxColumn.Name = "requesterDataGridViewTextBoxColumn";
            this.requesterDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // requestStatuesDataGridViewTextBoxColumn
            // 
            this.requestStatuesDataGridViewTextBoxColumn.DataPropertyName = "RequestStatues";
            this.requestStatuesDataGridViewTextBoxColumn.HeaderText = "RequestStatues";
            this.requestStatuesDataGridViewTextBoxColumn.Name = "requestStatuesDataGridViewTextBoxColumn";
            this.requestStatuesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // urgentStatuesDataGridViewCheckBoxColumn
            // 
            this.urgentStatuesDataGridViewCheckBoxColumn.DataPropertyName = "UrgentStatues";
            this.urgentStatuesDataGridViewCheckBoxColumn.HeaderText = "UrgentStatues";
            this.urgentStatuesDataGridViewCheckBoxColumn.Name = "urgentStatuesDataGridViewCheckBoxColumn";
            this.urgentStatuesDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // requestQuantityDataGridViewTextBoxColumn
            // 
            this.requestQuantityDataGridViewTextBoxColumn.DataPropertyName = "RequestQuantity";
            this.requestQuantityDataGridViewTextBoxColumn.HeaderText = "RequestQuantity";
            this.requestQuantityDataGridViewTextBoxColumn.Name = "requestQuantityDataGridViewTextBoxColumn";
            this.requestQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // workerNameDataGridViewTextBoxColumn
            // 
            this.workerNameDataGridViewTextBoxColumn.DataPropertyName = "WorkerName";
            this.workerNameDataGridViewTextBoxColumn.HeaderText = "WorkerName";
            this.workerNameDataGridViewTextBoxColumn.Name = "workerNameDataGridViewTextBoxColumn";
            this.workerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CustomerMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 303);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.SubmitReqBtn);
            this.Name = "CustomerMainMenu";
            this.Text = "Customer Main Menu";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iOOPAssignmentDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOPAssignmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOPAssignmentDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestBindingSource16)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SubmitReqBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private IOOPAssignmentDataSet iOOPAssignmentDataSet;
        private IOOPAssignmentDataSetTableAdapters.RequestTableAdapter requestTableAdapter;
        private System.Windows.Forms.BindingSource iOOPAssignmentDataSetBindingSource;
        private IOOPAssignmentDataSet iOOPAssignmentDataSet1;
        private IOOPAssignmentDataSetTableAdapters.RequestTableAdapter requestTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource requestBindingSource16;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requesterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestStatuesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn urgentStatuesDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerNameDataGridViewTextBoxColumn;
    }
}