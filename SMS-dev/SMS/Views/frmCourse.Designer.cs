namespace SMS.Views
{
    partial class frmCourse
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
            this.txtCourseSearch = new System.Windows.Forms.TextBox();
            this.lblCourseSearch = new System.Windows.Forms.Label();
            this.dgvCourse = new System.Windows.Forms.DataGridView();
            this.CID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.column_delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.column_view = new System.Windows.Forms.DataGridViewImageColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAddCourse = new FontAwesome.Sharp.IconButton();
            this.label16 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourse)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCourseSearch
            // 
            this.txtCourseSearch.Location = new System.Drawing.Point(557, 181);
            this.txtCourseSearch.Name = "txtCourseSearch";
            this.txtCourseSearch.Size = new System.Drawing.Size(260, 20);
            this.txtCourseSearch.TabIndex = 9;
            this.txtCourseSearch.TextChanged += new System.EventHandler(this.TxtCourseSearch_TextChanged);
            // 
            // lblCourseSearch
            // 
            this.lblCourseSearch.AutoSize = true;
            this.lblCourseSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseSearch.ForeColor = System.Drawing.Color.Black;
            this.lblCourseSearch.Location = new System.Drawing.Point(435, 184);
            this.lblCourseSearch.Name = "lblCourseSearch";
            this.lblCourseSearch.Size = new System.Drawing.Size(102, 17);
            this.lblCourseSearch.TabIndex = 8;
            this.lblCourseSearch.Text = "Course Search";
            // 
            // dgvCourse
            // 
            this.dgvCourse.AllowUserToAddRows = false;
            this.dgvCourse.AllowUserToDeleteRows = false;
            this.dgvCourse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCourse.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCourse.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CID,
            this.CName,
            this.CType,
            this.Cstatus,
            this.Edit,
            this.column_delete,
            this.column_view});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCourse.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCourse.GridColor = System.Drawing.Color.DodgerBlue;
            this.dgvCourse.Location = new System.Drawing.Point(73, 213);
            this.dgvCourse.Name = "dgvCourse";
            this.dgvCourse.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCourse.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCourse.Size = new System.Drawing.Size(744, 293);
            this.dgvCourse.TabIndex = 14;
            this.dgvCourse.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCourse_CellClick);
            // 
            // CID
            // 
            this.CID.DataPropertyName = "CID";
            this.CID.HeaderText = "Course ID";
            this.CID.Name = "CID";
            this.CID.ReadOnly = true;
            // 
            // CName
            // 
            this.CName.DataPropertyName = "CName";
            this.CName.HeaderText = "Course Name";
            this.CName.Name = "CName";
            this.CName.ReadOnly = true;
            // 
            // CType
            // 
            this.CType.DataPropertyName = "CType";
            this.CType.HeaderText = "Course Type";
            this.CType.Name = "CType";
            this.CType.ReadOnly = true;
            // 
            // Cstatus
            // 
            this.Cstatus.DataPropertyName = "Cstatus";
            this.Cstatus.HeaderText = "Course Status";
            this.Cstatus.Name = "Cstatus";
            this.Cstatus.ReadOnly = true;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Image = global::SMS.Properties.Resources._383148_edit_icon;
            this.Edit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            // 
            // column_delete
            // 
            this.column_delete.HeaderText = "Delete";
            this.column_delete.Name = "column_delete";
            this.column_delete.ReadOnly = true;
            this.column_delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.column_delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // column_view
            // 
            this.column_view.HeaderText = "View";
            this.column_view.Name = "column_view";
            this.column_view.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(78, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Course";
            // 
            // BtnAddCourse
            // 
            this.BtnAddCourse.BackColor = System.Drawing.Color.Navy;
            this.BtnAddCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddCourse.ForeColor = System.Drawing.Color.White;
            this.BtnAddCourse.IconChar = FontAwesome.Sharp.IconChar.CirclePlus;
            this.BtnAddCourse.IconColor = System.Drawing.Color.White;
            this.BtnAddCourse.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAddCourse.IconSize = 30;
            this.BtnAddCourse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAddCourse.Location = new System.Drawing.Point(73, 157);
            this.BtnAddCourse.Name = "BtnAddCourse";
            this.BtnAddCourse.Size = new System.Drawing.Size(151, 44);
            this.BtnAddCourse.TabIndex = 15;
            this.BtnAddCourse.Text = "   Add Course";
            this.BtnAddCourse.UseVisualStyleBackColor = false;
            this.BtnAddCourse.Click += new System.EventHandler(this.BtnAddCourse_Click_1);
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
            this.panel4.TabIndex = 16;
            // 
            // frmCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.BtnAddCourse);
            this.Controls.Add(this.txtCourseSearch);
            this.Controls.Add(this.lblCourseSearch);
            this.Controls.Add(this.dgvCourse);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCourse";
            this.Size = new System.Drawing.Size(1010, 789);
            this.Load += new System.EventHandler(this.FrmCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourse)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCourseSearch;
        private System.Windows.Forms.Label lblCourseSearch;
        private System.Windows.Forms.DataGridView dgvCourse;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton BtnAddCourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn CID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cstatus;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn column_delete;
        private System.Windows.Forms.DataGridViewImageColumn column_view;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel4;
        //private System.Windows.Forms.DataGridViewImageColumn DeleteCourse;
    }
}
