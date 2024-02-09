namespace SMS.Views
{
    partial class frmStaff
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddStaff = new FontAwesome.Sharp.IconButton();
            this.dgvStaffDtl = new System.Windows.Forms.DataGridView();
            this.label16 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.EID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EFName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ELName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ENIC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EGende = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmartitalStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Enationality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EDOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EHomeMobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EDesignation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EEnrollDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photo_data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.view = new System.Windows.Forms.DataGridViewImageColumn();
            this.edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffDtl)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.BackColor = System.Drawing.Color.Navy;
            this.btnAddStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStaff.ForeColor = System.Drawing.Color.White;
            this.btnAddStaff.IconChar = FontAwesome.Sharp.IconChar.CirclePlus;
            this.btnAddStaff.IconColor = System.Drawing.Color.White;
            this.btnAddStaff.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddStaff.IconSize = 30;
            this.btnAddStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddStaff.Location = new System.Drawing.Point(44, 125);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(151, 44);
            this.btnAddStaff.TabIndex = 16;
            this.btnAddStaff.Text = "   Add Staff";
            this.btnAddStaff.UseVisualStyleBackColor = false;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // dgvStaffDtl
            // 
            this.dgvStaffDtl.AllowUserToAddRows = false;
            this.dgvStaffDtl.AllowUserToDeleteRows = false;
            this.dgvStaffDtl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaffDtl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EID,
            this.EFullName,
            this.EFName,
            this.ELName,
            this.EAddress,
            this.ENIC,
            this.EGende,
            this.EmartitalStatus,
            this.Enationality,
            this.EDOB,
            this.EEmail,
            this.EMobile,
            this.EHomeMobile,
            this.EDesignation,
            this.EEnrollDate,
            this.photo_data,
            this.view,
            this.edit,
            this.Delete});
            this.dgvStaffDtl.Location = new System.Drawing.Point(44, 199);
            this.dgvStaffDtl.Name = "dgvStaffDtl";
            this.dgvStaffDtl.ReadOnly = true;
            this.dgvStaffDtl.Size = new System.Drawing.Size(938, 378);
            this.dgvStaffDtl.TabIndex = 17;
            this.dgvStaffDtl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvStaffDtl_CellClick);
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(225, 33);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(541, 39);
            this.label16.TabIndex = 0;
            this.label16.Text = "Design And Developed By Uovt Software 2020/2021 B2-Batch (Group -6)";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.panel4.Controls.Add(this.label16);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 689);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1005, 100);
            this.panel4.TabIndex = 62;
            // 
            // EID
            // 
            this.EID.DataPropertyName = "EID";
            this.EID.HeaderText = "EID";
            this.EID.Name = "EID";
            this.EID.ReadOnly = true;
            // 
            // EFullName
            // 
            this.EFullName.DataPropertyName = "EFullName";
            this.EFullName.HeaderText = "Full Name";
            this.EFullName.Name = "EFullName";
            this.EFullName.ReadOnly = true;
            // 
            // EFName
            // 
            this.EFName.DataPropertyName = "EFName";
            this.EFName.HeaderText = "FName";
            this.EFName.Name = "EFName";
            this.EFName.ReadOnly = true;
            this.EFName.Visible = false;
            // 
            // ELName
            // 
            this.ELName.DataPropertyName = "ELName";
            this.ELName.HeaderText = "ELName";
            this.ELName.Name = "ELName";
            this.ELName.ReadOnly = true;
            this.ELName.Visible = false;
            // 
            // EAddress
            // 
            this.EAddress.DataPropertyName = "EAddress";
            this.EAddress.HeaderText = "Address";
            this.EAddress.Name = "EAddress";
            this.EAddress.ReadOnly = true;
            this.EAddress.Visible = false;
            // 
            // ENIC
            // 
            this.ENIC.DataPropertyName = "ENIC";
            this.ENIC.HeaderText = "NIC";
            this.ENIC.Name = "ENIC";
            this.ENIC.ReadOnly = true;
            // 
            // EGende
            // 
            this.EGende.DataPropertyName = "EGende";
            this.EGende.HeaderText = "EGende";
            this.EGende.Name = "EGende";
            this.EGende.ReadOnly = true;
            this.EGende.Visible = false;
            // 
            // EmartitalStatus
            // 
            this.EmartitalStatus.DataPropertyName = "EmartitalStatus";
            this.EmartitalStatus.HeaderText = "EmartitalStatus";
            this.EmartitalStatus.Name = "EmartitalStatus";
            this.EmartitalStatus.ReadOnly = true;
            this.EmartitalStatus.Visible = false;
            // 
            // Enationality
            // 
            this.Enationality.DataPropertyName = "Enationality";
            this.Enationality.HeaderText = "Enationality";
            this.Enationality.Name = "Enationality";
            this.Enationality.ReadOnly = true;
            this.Enationality.Visible = false;
            // 
            // EDOB
            // 
            this.EDOB.DataPropertyName = "EDOB";
            this.EDOB.HeaderText = "EDOB";
            this.EDOB.Name = "EDOB";
            this.EDOB.ReadOnly = true;
            this.EDOB.Visible = false;
            // 
            // EEmail
            // 
            this.EEmail.DataPropertyName = "EEmail";
            this.EEmail.HeaderText = "EEmail";
            this.EEmail.Name = "EEmail";
            this.EEmail.ReadOnly = true;
            // 
            // EMobile
            // 
            this.EMobile.DataPropertyName = "EMobile";
            this.EMobile.HeaderText = "EMobile";
            this.EMobile.Name = "EMobile";
            this.EMobile.ReadOnly = true;
            // 
            // EHomeMobile
            // 
            this.EHomeMobile.DataPropertyName = "EHomeMobile";
            this.EHomeMobile.HeaderText = "EHomeMobile";
            this.EHomeMobile.Name = "EHomeMobile";
            this.EHomeMobile.ReadOnly = true;
            this.EHomeMobile.Visible = false;
            // 
            // EDesignation
            // 
            this.EDesignation.DataPropertyName = "EDesignation";
            this.EDesignation.HeaderText = "Designation";
            this.EDesignation.Name = "EDesignation";
            this.EDesignation.ReadOnly = true;
            // 
            // EEnrollDate
            // 
            this.EEnrollDate.DataPropertyName = "EEnrollDate";
            this.EEnrollDate.HeaderText = "EEnrollDate";
            this.EEnrollDate.Name = "EEnrollDate";
            this.EEnrollDate.ReadOnly = true;
            this.EEnrollDate.Visible = false;
            // 
            // photo_data
            // 
            this.photo_data.DataPropertyName = "photo_data";
            this.photo_data.HeaderText = "photo_data";
            this.photo_data.Name = "photo_data";
            this.photo_data.ReadOnly = true;
            this.photo_data.Visible = false;
            // 
            // view
            // 
            this.view.HeaderText = "View";
            this.view.Name = "view";
            this.view.ReadOnly = true;
            this.view.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.view.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // edit
            // 
            this.edit.HeaderText = "Edit";
            this.edit.Name = "edit";
            this.edit.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            // 
            // frmStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dgvStaffDtl);
            this.Controls.Add(this.btnAddStaff);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmStaff";
            this.Size = new System.Drawing.Size(1005, 789);
            this.Load += new System.EventHandler(this.FrmStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffDtl)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnAddStaff;
        private System.Windows.Forms.DataGridView dgvStaffDtl;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn EID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EFName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ELName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ENIC;
        private System.Windows.Forms.DataGridViewTextBoxColumn EGende;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmartitalStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Enationality;
        private System.Windows.Forms.DataGridViewTextBoxColumn EDOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn EEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn EHomeMobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn EDesignation;
        private System.Windows.Forms.DataGridViewTextBoxColumn EEnrollDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn photo_data;
        private System.Windows.Forms.DataGridViewImageColumn view;
        private System.Windows.Forms.DataGridViewImageColumn edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}
