namespace FPOS.AppGUI
{
    partial class fromProductBrand
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
            this.grpEntry = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOrigin = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.grpList = new System.Windows.Forms.GroupBox();
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSACTIVEDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cREATEUSERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cREATEDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cREATEDEVICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uPDATEUSERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uPDATEDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uPDATEDEVICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCTBRANDSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chkAct = new System.Windows.Forms.CheckBox();
            this.grpEntry.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.grpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBRANDSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grpEntry
            // 
            this.grpEntry.Controls.Add(this.chkAct);
            this.grpEntry.Controls.Add(this.label2);
            this.grpEntry.Controls.Add(this.label1);
            this.grpEntry.Controls.Add(this.txtOrigin);
            this.grpEntry.Controls.Add(this.txtName);
            this.grpEntry.Controls.Add(this.lblId);
            this.grpEntry.Controls.Add(this.txtId);
            this.grpEntry.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpEntry.Location = new System.Drawing.Point(0, 0);
            this.grpEntry.Name = "grpEntry";
            this.grpEntry.Size = new System.Drawing.Size(445, 135);
            this.grpEntry.TabIndex = 0;
            this.grpEntry.TabStop = false;
            this.grpEntry.Text = "Brand Setup";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Brand Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Brand Origin:";
            // 
            // txtOrigin
            // 
            this.txtOrigin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrigin.Location = new System.Drawing.Point(147, 96);
            this.txtOrigin.Name = "txtOrigin";
            this.txtOrigin.Size = new System.Drawing.Size(200, 24);
            this.txtOrigin.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(147, 64);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 24);
            this.txtName.TabIndex = 2;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(120, 34);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(23, 18);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "Id:";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(147, 32);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(100, 24);
            this.txtId.TabIndex = 0;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnPrint);
            this.pnlButtons.Controls.Add(this.btnDelete);
            this.pnlButtons.Controls.Add(this.btnSave);
            this.pnlButtons.Controls.Add(this.btnFind);
            this.pnlButtons.Location = new System.Drawing.Point(33, 144);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(385, 36);
            this.pnlButtons.TabIndex = 1;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnPrint.Enabled = false;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(99, 3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(90, 30);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Tomato;
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(291, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 30);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(195, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 30);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.Location = new System.Drawing.Point(3, 3);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(90, 30);
            this.btnFind.TabIndex = 0;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // grpList
            // 
            this.grpList.Controls.Add(this.dgvDetails);
            this.grpList.Location = new System.Drawing.Point(0, 189);
            this.grpList.Name = "grpList";
            this.grpList.Size = new System.Drawing.Size(445, 184);
            this.grpList.TabIndex = 2;
            this.grpList.TabStop = false;
            this.grpList.Text = "List";
            // 
            // dgvDetails
            // 
            this.dgvDetails.AllowUserToAddRows = false;
            this.dgvDetails.AllowUserToDeleteRows = false;
            this.dgvDetails.AutoGenerateColumns = false;
            this.dgvDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.iSACTIVEDataGridViewCheckBoxColumn,
            this.cREATEUSERDataGridViewTextBoxColumn,
            this.cREATEDATEDataGridViewTextBoxColumn,
            this.cREATEDEVICEDataGridViewTextBoxColumn,
            this.uPDATEUSERDataGridViewTextBoxColumn,
            this.uPDATEDATEDataGridViewTextBoxColumn,
            this.uPDATEDEVICEDataGridViewTextBoxColumn});
            this.dgvDetails.DataSource = this.pRODUCTBRANDSBindingSource;
            this.dgvDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetails.Location = new System.Drawing.Point(3, 18);
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.ReadOnly = true;
            this.dgvDetails.Size = new System.Drawing.Size(439, 163);
            this.dgvDetails.TabIndex = 0;
            this.dgvDetails.DoubleClick += new System.EventHandler(this.dgvDetails_DoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 44;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "BRAND_NAME";
            this.dataGridViewTextBoxColumn2.HeaderText = "Brand";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 69;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "BRAND_ORIGIN";
            this.dataGridViewTextBoxColumn3.HeaderText = "Origin";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 68;
            // 
            // iSACTIVEDataGridViewCheckBoxColumn
            // 
            this.iSACTIVEDataGridViewCheckBoxColumn.DataPropertyName = "IS_ACTIVE";
            this.iSACTIVEDataGridViewCheckBoxColumn.HeaderText = "Active";
            this.iSACTIVEDataGridViewCheckBoxColumn.Name = "iSACTIVEDataGridViewCheckBoxColumn";
            this.iSACTIVEDataGridViewCheckBoxColumn.ReadOnly = true;
            this.iSACTIVEDataGridViewCheckBoxColumn.Width = 51;
            // 
            // cREATEUSERDataGridViewTextBoxColumn
            // 
            this.cREATEUSERDataGridViewTextBoxColumn.DataPropertyName = "CREATE_USER";
            this.cREATEUSERDataGridViewTextBoxColumn.HeaderText = "CREATE_USER";
            this.cREATEUSERDataGridViewTextBoxColumn.Name = "cREATEUSERDataGridViewTextBoxColumn";
            this.cREATEUSERDataGridViewTextBoxColumn.ReadOnly = true;
            this.cREATEUSERDataGridViewTextBoxColumn.Visible = false;
            this.cREATEUSERDataGridViewTextBoxColumn.Width = 111;
            // 
            // cREATEDATEDataGridViewTextBoxColumn
            // 
            this.cREATEDATEDataGridViewTextBoxColumn.DataPropertyName = "CREATE_DATE";
            this.cREATEDATEDataGridViewTextBoxColumn.HeaderText = "CREATE_DATE";
            this.cREATEDATEDataGridViewTextBoxColumn.Name = "cREATEDATEDataGridViewTextBoxColumn";
            this.cREATEDATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.cREATEDATEDataGridViewTextBoxColumn.Visible = false;
            this.cREATEDATEDataGridViewTextBoxColumn.Width = 110;
            // 
            // cREATEDEVICEDataGridViewTextBoxColumn
            // 
            this.cREATEDEVICEDataGridViewTextBoxColumn.DataPropertyName = "CREATE_DEVICE";
            this.cREATEDEVICEDataGridViewTextBoxColumn.HeaderText = "CREATE_DEVICE";
            this.cREATEDEVICEDataGridViewTextBoxColumn.Name = "cREATEDEVICEDataGridViewTextBoxColumn";
            this.cREATEDEVICEDataGridViewTextBoxColumn.ReadOnly = true;
            this.cREATEDEVICEDataGridViewTextBoxColumn.Visible = false;
            this.cREATEDEVICEDataGridViewTextBoxColumn.Width = 120;
            // 
            // uPDATEUSERDataGridViewTextBoxColumn
            // 
            this.uPDATEUSERDataGridViewTextBoxColumn.DataPropertyName = "UPDATE_USER";
            this.uPDATEUSERDataGridViewTextBoxColumn.HeaderText = "UPDATE_USER";
            this.uPDATEUSERDataGridViewTextBoxColumn.Name = "uPDATEUSERDataGridViewTextBoxColumn";
            this.uPDATEUSERDataGridViewTextBoxColumn.ReadOnly = true;
            this.uPDATEUSERDataGridViewTextBoxColumn.Visible = false;
            this.uPDATEUSERDataGridViewTextBoxColumn.Width = 112;
            // 
            // uPDATEDATEDataGridViewTextBoxColumn
            // 
            this.uPDATEDATEDataGridViewTextBoxColumn.DataPropertyName = "UPDATE_DATE";
            this.uPDATEDATEDataGridViewTextBoxColumn.HeaderText = "UPDATE_DATE";
            this.uPDATEDATEDataGridViewTextBoxColumn.Name = "uPDATEDATEDataGridViewTextBoxColumn";
            this.uPDATEDATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.uPDATEDATEDataGridViewTextBoxColumn.Visible = false;
            this.uPDATEDATEDataGridViewTextBoxColumn.Width = 111;
            // 
            // uPDATEDEVICEDataGridViewTextBoxColumn
            // 
            this.uPDATEDEVICEDataGridViewTextBoxColumn.DataPropertyName = "UPDATE_DEVICE";
            this.uPDATEDEVICEDataGridViewTextBoxColumn.HeaderText = "UPDATE_DEVICE";
            this.uPDATEDEVICEDataGridViewTextBoxColumn.Name = "uPDATEDEVICEDataGridViewTextBoxColumn";
            this.uPDATEDEVICEDataGridViewTextBoxColumn.ReadOnly = true;
            this.uPDATEDEVICEDataGridViewTextBoxColumn.Visible = false;
            this.uPDATEDEVICEDataGridViewTextBoxColumn.Width = 121;
            // 
            // pRODUCTBRANDSBindingSource
            // 
            this.pRODUCTBRANDSBindingSource.DataSource = typeof(FPOS.AppModels.PRODUCT_BRANDS);
            // 
            // chkAct
            // 
            this.chkAct.AutoSize = true;
            this.chkAct.Location = new System.Drawing.Point(266, 34);
            this.chkAct.Name = "chkAct";
            this.chkAct.Size = new System.Drawing.Size(64, 20);
            this.chkAct.TabIndex = 6;
            this.chkAct.Text = "Active";
            this.chkAct.UseVisualStyleBackColor = true;
            // 
            // fromProductBrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 377);
            this.Controls.Add(this.grpList);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.grpEntry);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fromProductBrand";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fromProductBrand";
            this.grpEntry.ResumeLayout(false);
            this.grpEntry.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.grpList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBRANDSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEntry;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtOrigin;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.GroupBox grpList;
        private System.Windows.Forms.DataGridView dgvDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bRANDNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bRANDORIGINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn iSACTIVEDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cREATEUSERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cREATEDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cREATEDEVICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uPDATEUSERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uPDATEDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uPDATEDEVICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pRODUCTBRANDSBindingSource;
        private System.Windows.Forms.CheckBox chkAct;
    }
}