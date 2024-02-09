namespace SMS.Views
{
    partial class frmCourseModule
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnAddModule = new FontAwesome.Sharp.IconButton();
            this.txtModuleSearch = new System.Windows.Forms.TextBox();
            this.lblModuleSearch = new System.Windows.Forms.Label();
            this.dgvModule = new System.Windows.Forms.DataGridView();
            this.CID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnModuleSearch = new FontAwesome.Sharp.IconButton();
            this.lblModule = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModule)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnAddModule
            // 
            this.BtnAddModule.BackColor = System.Drawing.Color.Navy;
            this.BtnAddModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddModule.ForeColor = System.Drawing.Color.White;
            this.BtnAddModule.IconChar = FontAwesome.Sharp.IconChar.CirclePlus;
            this.BtnAddModule.IconColor = System.Drawing.Color.White;
            this.BtnAddModule.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAddModule.IconSize = 30;
            this.BtnAddModule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAddModule.Location = new System.Drawing.Point(67, 498);
            this.BtnAddModule.Name = "BtnAddModule";
            this.BtnAddModule.Size = new System.Drawing.Size(151, 44);
            this.BtnAddModule.TabIndex = 25;
            this.BtnAddModule.Text = "   Add Module";
            this.BtnAddModule.UseVisualStyleBackColor = false;
            // 
            // txtModuleSearch
            // 
            this.txtModuleSearch.Location = new System.Drawing.Point(651, 107);
            this.txtModuleSearch.Name = "txtModuleSearch";
            this.txtModuleSearch.Size = new System.Drawing.Size(324, 20);
            this.txtModuleSearch.TabIndex = 23;
            // 
            // lblModuleSearch
            // 
            this.lblModuleSearch.AutoSize = true;
            this.lblModuleSearch.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModuleSearch.ForeColor = System.Drawing.Color.Black;
            this.lblModuleSearch.Location = new System.Drawing.Point(502, 107);
            this.lblModuleSearch.Name = "lblModuleSearch";
            this.lblModuleSearch.Size = new System.Drawing.Size(134, 21);
            this.lblModuleSearch.TabIndex = 22;
            this.lblModuleSearch.Text = "Module Search :";
            // 
            // dgvModule
            // 
            this.dgvModule.AllowUserToAddRows = false;
            this.dgvModule.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvModule.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvModule.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvModule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvModule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CID,
            this.MID,
            this.MName,
            this.SID});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvModule.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvModule.GridColor = System.Drawing.Color.Black;
            this.dgvModule.Location = new System.Drawing.Point(67, 187);
            this.dgvModule.Name = "dgvModule";
            this.dgvModule.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvModule.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvModule.Size = new System.Drawing.Size(736, 293);
            this.dgvModule.TabIndex = 24;
            // 
            // CID
            // 
            this.CID.DataPropertyName = "CID";
            this.CID.HeaderText = "Course ID";
            this.CID.Name = "CID";
            this.CID.ReadOnly = true;
            // 
            // MID
            // 
            this.MID.DataPropertyName = "MID";
            this.MID.HeaderText = "Module ID";
            this.MID.Name = "MID";
            this.MID.ReadOnly = true;
            // 
            // MName
            // 
            this.MName.DataPropertyName = "MName";
            this.MName.HeaderText = "Module Name";
            this.MName.Name = "MName";
            this.MName.ReadOnly = true;
            // 
            // SID
            // 
            this.SID.DataPropertyName = "SID";
            this.SID.HeaderText = "Semester ID";
            this.SID.Name = "SID";
            this.SID.ReadOnly = true;
            // 
            // BtnModuleSearch
            // 
            this.BtnModuleSearch.BackColor = System.Drawing.Color.LightSlateGray;
            this.BtnModuleSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModuleSearch.ForeColor = System.Drawing.Color.White;
            this.BtnModuleSearch.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            this.BtnModuleSearch.IconColor = System.Drawing.Color.White;
            this.BtnModuleSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnModuleSearch.IconSize = 30;
            this.BtnModuleSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnModuleSearch.Location = new System.Drawing.Point(855, 133);
            this.BtnModuleSearch.Name = "BtnModuleSearch";
            this.BtnModuleSearch.Size = new System.Drawing.Size(120, 35);
            this.BtnModuleSearch.TabIndex = 26;
            this.BtnModuleSearch.Text = "Search";
            this.BtnModuleSearch.UseVisualStyleBackColor = false;
            // 
            // lblModule
            // 
            this.lblModule.AutoSize = true;
            this.lblModule.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModule.ForeColor = System.Drawing.Color.Blue;
            this.lblModule.Location = new System.Drawing.Point(61, 29);
            this.lblModule.Name = "lblModule";
            this.lblModule.Size = new System.Drawing.Size(142, 42);
            this.lblModule.TabIndex = 21;
            this.lblModule.Text = "Module";
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
            this.label16.Size = new System.Drawing.Size(546, 39);
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
            this.panel4.Size = new System.Drawing.Size(1010, 100);
            this.panel4.TabIndex = 62;
            // 
            // frmCourseModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.BtnAddModule);
            this.Controls.Add(this.txtModuleSearch);
            this.Controls.Add(this.lblModuleSearch);
            this.Controls.Add(this.dgvModule);
            this.Controls.Add(this.BtnModuleSearch);
            this.Controls.Add(this.lblModule);
            this.Name = "frmCourseModule";
            this.Size = new System.Drawing.Size(1010, 789);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModule)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton BtnAddModule;
        private System.Windows.Forms.TextBox txtModuleSearch;
        private System.Windows.Forms.Label lblModuleSearch;
        private System.Windows.Forms.DataGridView dgvModule;
        private System.Windows.Forms.DataGridViewTextBoxColumn CID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SID;
        private FontAwesome.Sharp.IconButton BtnModuleSearch;
        private System.Windows.Forms.Label lblModule;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel4;
    }
}
