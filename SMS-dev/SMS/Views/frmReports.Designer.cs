namespace SMS.Views
{
    partial class frmReports
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
            this.tabRport = new System.Windows.Forms.TabControl();
            this.tabPageStudent = new System.Windows.Forms.TabPage();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabpageStaff = new System.Windows.Forms.TabPage();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalReport11 = new SMS.Report.CrystalReport1();
            this.tabPageCourse = new System.Windows.Forms.TabPage();
            this.crystalReportViewer2 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.allcou1 = new SMS.Report.allcou();
            this.tabRport.SuspendLayout();
            this.tabPageStudent.SuspendLayout();
            this.tabpageStaff.SuspendLayout();
            this.tabPageCourse.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabRport
            // 
            this.tabRport.Controls.Add(this.tabPageStudent);
            this.tabRport.Controls.Add(this.tabpageStaff);
            this.tabRport.Controls.Add(this.tabPageCourse);
            this.tabRport.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabRport.Location = new System.Drawing.Point(3, 3);
            this.tabRport.Name = "tabRport";
            this.tabRport.SelectedIndex = 0;
            this.tabRport.Size = new System.Drawing.Size(1083, 835);
            this.tabRport.TabIndex = 1;
            // 
            // tabPageStudent
            // 
            this.tabPageStudent.Controls.Add(this.radioButton3);
            this.tabPageStudent.Controls.Add(this.radioButton2);
            this.tabPageStudent.Controls.Add(this.radioButton1);
            this.tabPageStudent.Controls.Add(this.comboBox3);
            this.tabPageStudent.Controls.Add(this.comboBox2);
            this.tabPageStudent.Controls.Add(this.label4);
            this.tabPageStudent.Controls.Add(this.label3);
            this.tabPageStudent.Controls.Add(this.comboBox1);
            this.tabPageStudent.Controls.Add(this.label2);
            this.tabPageStudent.Location = new System.Drawing.Point(4, 31);
            this.tabPageStudent.Name = "tabPageStudent";
            this.tabPageStudent.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStudent.Size = new System.Drawing.Size(1075, 800);
            this.tabPageStudent.TabIndex = 0;
            this.tabPageStudent.Text = "Student";
            this.tabPageStudent.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.BackColor = System.Drawing.Color.Transparent;
            this.radioButton3.ForeColor = System.Drawing.Color.Black;
            this.radioButton3.Location = new System.Drawing.Point(470, 135);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(51, 26);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "All";
            this.radioButton3.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.ForeColor = System.Drawing.Color.Black;
            this.radioButton2.Location = new System.Drawing.Point(470, 90);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(51, 26);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "All";
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.ForeColor = System.Drawing.Color.Black;
            this.radioButton1.Location = new System.Drawing.Point(470, 51);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(51, 26);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "All";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(191, 131);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(251, 30);
            this.comboBox3.TabIndex = 4;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(191, 89);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(251, 30);
            this.comboBox2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(77, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Batch";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(77, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Year";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(191, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(251, 30);
            this.comboBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(77, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Course Name";
            // 
            // tabpageStaff
            // 
            this.tabpageStaff.Controls.Add(this.crystalReportViewer1);
            this.tabpageStaff.Location = new System.Drawing.Point(4, 31);
            this.tabpageStaff.Name = "tabpageStaff";
            this.tabpageStaff.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageStaff.Size = new System.Drawing.Size(1075, 800);
            this.tabpageStaff.TabIndex = 1;
            this.tabpageStaff.Text = "Staff";
            this.tabpageStaff.UseVisualStyleBackColor = true;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(3, 3);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.CrystalReport11;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1069, 794);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // tabPageCourse
            // 
            this.tabPageCourse.Controls.Add(this.crystalReportViewer2);
            this.tabPageCourse.Location = new System.Drawing.Point(4, 31);
            this.tabPageCourse.Name = "tabPageCourse";
            this.tabPageCourse.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCourse.Size = new System.Drawing.Size(1075, 800);
            this.tabPageCourse.TabIndex = 2;
            this.tabPageCourse.Text = "Course";
            this.tabPageCourse.UseVisualStyleBackColor = true;
            // 
            // crystalReportViewer2
            // 
            this.crystalReportViewer2.ActiveViewIndex = -1;
            this.crystalReportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer2.Location = new System.Drawing.Point(3, 3);
            this.crystalReportViewer2.Name = "crystalReportViewer2";
            this.crystalReportViewer2.ReportSource = this.allcou1;
            this.crystalReportViewer2.Size = new System.Drawing.Size(1069, 794);
            this.crystalReportViewer2.TabIndex = 0;
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabRport);
            this.Name = "frmReports";
            this.Size = new System.Drawing.Size(1083, 835);
            this.tabRport.ResumeLayout(false);
            this.tabPageStudent.ResumeLayout(false);
            this.tabPageStudent.PerformLayout();
            this.tabpageStaff.ResumeLayout(false);
            this.tabPageCourse.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabRport;
        private System.Windows.Forms.TabPage tabPageStudent;
        private System.Windows.Forms.TabPage tabpageStaff;
        private System.Windows.Forms.TabPage tabPageCourse;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private Report.CrystalReport1 CrystalReport11;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer2;
        private Report.allcou allcou1;
    }
}
