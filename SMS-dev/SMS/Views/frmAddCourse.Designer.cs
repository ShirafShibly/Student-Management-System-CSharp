namespace SMS.Views
{
    partial class frmAddCourse
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCourseId = new System.Windows.Forms.Label();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lblCourseType = new System.Windows.Forms.Label();
            this.lblCourseStatus = new System.Windows.Forms.Label();
            this.cmbCStatus = new System.Windows.Forms.ComboBox();
            this.txtCID = new System.Windows.Forms.TextBox();
            this.txtCName = new System.Windows.Forms.TextBox();
            this.cmbCType = new System.Windows.Forms.ComboBox();
            this.btnSaveCourse = new FontAwesome.Sharp.IconButton();
            this.btnCourseUpdate = new FontAwesome.Sharp.IconButton();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconPictureBox();
            this.lblAddCourseDTL = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblviewcoursedtl = new System.Windows.Forms.Label();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblCourseId);
            this.groupBox1.Controls.Add(this.lblCourseName);
            this.groupBox1.Controls.Add(this.lblCourseType);
            this.groupBox1.Controls.Add(this.lblCourseStatus);
            this.groupBox1.Controls.Add(this.cmbCStatus);
            this.groupBox1.Controls.Add(this.txtCID);
            this.groupBox1.Controls.Add(this.txtCName);
            this.groupBox1.Controls.Add(this.cmbCType);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(104, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 215);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Course Details";
            // 
            // lblCourseId
            // 
            this.lblCourseId.AutoSize = true;
            this.lblCourseId.Location = new System.Drawing.Point(25, 26);
            this.lblCourseId.Name = "lblCourseId";
            this.lblCourseId.Size = new System.Drawing.Size(79, 17);
            this.lblCourseId.TabIndex = 1;
            this.lblCourseId.Text = "Course ID";
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Location = new System.Drawing.Point(25, 56);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(105, 17);
            this.lblCourseName.TabIndex = 1;
            this.lblCourseName.Text = "Course Name";
            // 
            // lblCourseType
            // 
            this.lblCourseType.AutoSize = true;
            this.lblCourseType.Location = new System.Drawing.Point(25, 97);
            this.lblCourseType.Name = "lblCourseType";
            this.lblCourseType.Size = new System.Drawing.Size(100, 17);
            this.lblCourseType.TabIndex = 1;
            this.lblCourseType.Text = "Course Type";
            // 
            // lblCourseStatus
            // 
            this.lblCourseStatus.AutoSize = true;
            this.lblCourseStatus.Location = new System.Drawing.Point(25, 143);
            this.lblCourseStatus.Name = "lblCourseStatus";
            this.lblCourseStatus.Size = new System.Drawing.Size(110, 17);
            this.lblCourseStatus.TabIndex = 1;
            this.lblCourseStatus.Text = "Course Status";
            // 
            // cmbCStatus
            // 
            this.cmbCStatus.FormattingEnabled = true;
            this.cmbCStatus.Items.AddRange(new object[] {
            "Show",
            "Hide"});
            this.cmbCStatus.Location = new System.Drawing.Point(179, 135);
            this.cmbCStatus.Name = "cmbCStatus";
            this.cmbCStatus.Size = new System.Drawing.Size(324, 25);
            this.cmbCStatus.TabIndex = 3;
            // 
            // txtCID
            // 
            this.txtCID.Location = new System.Drawing.Point(179, 19);
            this.txtCID.Name = "txtCID";
            this.txtCID.Size = new System.Drawing.Size(324, 23);
            this.txtCID.TabIndex = 2;
            // 
            // txtCName
            // 
            this.txtCName.Location = new System.Drawing.Point(179, 53);
            this.txtCName.Name = "txtCName";
            this.txtCName.Size = new System.Drawing.Size(324, 23);
            this.txtCName.TabIndex = 2;
            // 
            // cmbCType
            // 
            this.cmbCType.FormattingEnabled = true;
            this.cmbCType.Items.AddRange(new object[] {
            "Cetificate",
            "Diploma",
            "HND"});
            this.cmbCType.Location = new System.Drawing.Point(179, 94);
            this.cmbCType.Name = "cmbCType";
            this.cmbCType.Size = new System.Drawing.Size(324, 25);
            this.cmbCType.TabIndex = 3;
            // 
            // btnSaveCourse
            // 
            this.btnSaveCourse.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSaveCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveCourse.ForeColor = System.Drawing.Color.Black;
            this.btnSaveCourse.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSaveCourse.IconColor = System.Drawing.Color.Black;
            this.btnSaveCourse.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSaveCourse.Location = new System.Drawing.Point(340, 317);
            this.btnSaveCourse.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveCourse.Name = "btnSaveCourse";
            this.btnSaveCourse.Size = new System.Drawing.Size(151, 46);
            this.btnSaveCourse.TabIndex = 18;
            this.btnSaveCourse.Text = "Save";
            this.btnSaveCourse.UseVisualStyleBackColor = false;
            this.btnSaveCourse.Click += new System.EventHandler(this.BtnSaveCourse_Click);
            // 
            // btnCourseUpdate
            // 
            this.btnCourseUpdate.BackColor = System.Drawing.Color.Orange;
            this.btnCourseUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourseUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnCourseUpdate.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCourseUpdate.IconColor = System.Drawing.Color.Black;
            this.btnCourseUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCourseUpdate.Location = new System.Drawing.Point(340, 317);
            this.btnCourseUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCourseUpdate.Name = "btnCourseUpdate";
            this.btnCourseUpdate.Size = new System.Drawing.Size(151, 46);
            this.btnCourseUpdate.TabIndex = 19;
            this.btnCourseUpdate.Text = "Update";
            this.btnCourseUpdate.UseVisualStyleBackColor = false;
            this.btnCourseUpdate.Click += new System.EventHandler(this.BtnCourseUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Gray;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCancel.IconColor = System.Drawing.Color.Black;
            this.btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancel.Location = new System.Drawing.Point(499, 317);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(151, 46);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.TimesSquare;
            this.btnExit.IconColor = System.Drawing.Color.Red;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 29;
            this.btnExit.Location = new System.Drawing.Point(714, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(31, 29);
            this.btnExit.TabIndex = 52;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click_1);
            // 
            // lblAddCourseDTL
            // 
            this.lblAddCourseDTL.AutoSize = true;
            this.lblAddCourseDTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCourseDTL.ForeColor = System.Drawing.Color.White;
            this.lblAddCourseDTL.Location = new System.Drawing.Point(263, 19);
            this.lblAddCourseDTL.Name = "lblAddCourseDTL";
            this.lblAddCourseDTL.Size = new System.Drawing.Size(181, 25);
            this.lblAddCourseDTL.TabIndex = 51;
            this.lblAddCourseDTL.Text = "Add Course Details";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.lblviewcoursedtl);
            this.panel1.Controls.Add(this.lblUpdate);
            this.panel1.Controls.Add(this.lblAddCourseDTL);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 60);
            this.panel1.TabIndex = 61;
            // 
            // lblviewcoursedtl
            // 
            this.lblviewcoursedtl.AutoSize = true;
            this.lblviewcoursedtl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblviewcoursedtl.ForeColor = System.Drawing.Color.White;
            this.lblviewcoursedtl.Location = new System.Drawing.Point(256, 19);
            this.lblviewcoursedtl.Name = "lblviewcoursedtl";
            this.lblviewcoursedtl.Size = new System.Drawing.Size(188, 25);
            this.lblviewcoursedtl.TabIndex = 51;
            this.lblviewcoursedtl.Text = "View Course Details";
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdate.ForeColor = System.Drawing.Color.White;
            this.lblUpdate.Location = new System.Drawing.Point(256, 19);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(208, 25);
            this.lblUpdate.TabIndex = 51;
            this.lblUpdate.Text = "Update Course Details";
            // 
            // frmAddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSaveCourse);
            this.Controls.Add(this.btnCourseUpdate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCourse";
            this.Load += new System.EventHandler(this.FrmAddCourse_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCourseId;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lblCourseType;
        private System.Windows.Forms.Label lblCourseStatus;
        private System.Windows.Forms.ComboBox cmbCStatus;
        private System.Windows.Forms.TextBox txtCID;
        private System.Windows.Forms.TextBox txtCName;
        private System.Windows.Forms.ComboBox cmbCType;
        private FontAwesome.Sharp.IconButton btnSaveCourse;
        private FontAwesome.Sharp.IconButton btnCourseUpdate;
        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconPictureBox btnExit;
        private System.Windows.Forms.Label lblAddCourseDTL;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.Label lblviewcoursedtl;
    }
}