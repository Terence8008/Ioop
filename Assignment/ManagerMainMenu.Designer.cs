namespace Assignment
{
    partial class ManagerMainMenu
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
            this.requestIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requesterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestStatuesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urgentStatuesDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.requestQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.iOOPAssignmentDataSet = new Assignment.IOOPAssignmentDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.requestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.requestTableAdapter = new Assignment.IOOPAssignmentDataSetTableAdapters.RequestTableAdapter();
            this.requestBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.AssignWorkerBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOPAssignmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
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
            this.dataGridView1.DataSource = this.requestBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(23, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(741, 183);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(23, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 27);
            this.label4.TabIndex = 21;
            this.label4.Text = "Check Work Status";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(478, 283);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(124, 47);
            this.button4.TabIndex = 20;
            this.button4.Text = "Close";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // requestBindingSource
            // 
            this.requestBindingSource.DataMember = "Request";
            this.requestBindingSource.DataSource = this.iOOPAssignmentDataSet;
            // 
            // requestTableAdapter
            // 
            this.requestTableAdapter.ClearBeforeFill = true;
            // 
            // requestBindingSource2
            // 
            this.requestBindingSource2.DataMember = "Request";
            this.requestBindingSource2.DataSource = this.iOOPAssignmentDataSet;
            // 
            // AssignWorkerBtn
            // 
            this.AssignWorkerBtn.Location = new System.Drawing.Point(207, 283);
            this.AssignWorkerBtn.Name = "AssignWorkerBtn";
            this.AssignWorkerBtn.Size = new System.Drawing.Size(113, 47);
            this.AssignWorkerBtn.TabIndex = 23;
            this.AssignWorkerBtn.Text = "Assign Worker";
            this.AssignWorkerBtn.UseVisualStyleBackColor = true;
            this.AssignWorkerBtn.Click += new System.EventHandler(this.AssignWorkerBtn_Click);
            // 
            // ManagerMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 342);
            this.Controls.Add(this.AssignWorkerBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Name = "ManagerMainMenu";
            this.Text = "Manager Main Menu";
            this.Load += new System.EventHandler(this.Check_Status_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOOPAssignmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private IOOPAssignmentDataSet iOOPAssignmentDataSet;
        private System.Windows.Forms.BindingSource requestBindingSource;
        private IOOPAssignmentDataSetTableAdapters.RequestTableAdapter requestTableAdapter;
        private System.Windows.Forms.BindingSource requestBindingSource1;
        private System.Windows.Forms.BindingSource requestBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requesterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestStatuesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn urgentStatuesDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button AssignWorkerBtn;
    }
}