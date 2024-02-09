using SMS.Controllers;
using SMS.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS.Views
{
    public partial class frmAddCourse : Form
    {
        CourseConroller courseConroller = new CourseConroller();

        Course_DAL course_DAL = new Course_DAL();
        private int cID;
        private string cName;
        private string cType;
        private int cstatus;
        string status;

        public frmAddCourse()
        {
            InitializeComponent();
        }

        public frmAddCourse(int cID, string cName, string cType, int cstatus, string status)
        {
            InitializeComponent();

            this.course_DAL.CID = cID;
            this.course_DAL.CName = cName;
            this.course_DAL.CType = cType;
            this.course_DAL.Cstatus = cstatus;
            this.status = status;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure To Cancel ?", "Add Course ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

   

        private void BtnExit_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure To Cancel ?", "Add Course ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

       

        public void Clear()
        {
            txtCName.Text = "";
            cmbCType.SelectedIndex = -1;
            cmbCStatus.SelectedIndex = -1;
        }

        private void FrmAddCourse_Load(object sender, EventArgs e)
        {
            if (course_DAL.CID != 0 && this.status == "edit")
            {
                this.lblAddCourseDTL.Visible = false;
                this.lblviewcoursedtl.Visible = false;
                this.txtCID.Enabled = false;
                this.txtCID.Text = course_DAL.CID.ToString();
                this.txtCName.Text = course_DAL.CName.ToString();
                this.cmbCType.Text = course_DAL.CType.ToString();
                if (course_DAL.Cstatus == 1)
                {
                    this.cmbCStatus.Text = "SHOW";
                }
                else
                {
                    this.cmbCStatus.Text = "HIDE";
                }
                this.btnSaveCourse.Visible = false;
            }
            else if (course_DAL.CID != 0 && this.status == "view")
            {
                this.lblAddCourseDTL.Visible = false;
                this.txtCID.Enabled = false;
                this.txtCName.Enabled = false;
                this.cmbCType.Enabled = false;
                this.cmbCStatus.Enabled = false;

                this.txtCID.Text = course_DAL.CID.ToString();
                this.txtCName.Text = course_DAL.CName.ToString();
                this.cmbCType.Text = course_DAL.CType.ToString();
                if (course_DAL.Cstatus == 1)
                {
                    this.cmbCStatus.Text = "SHOW";
                }
                else
                {
                    this.cmbCStatus.Text = "HIDE";
                }

                this.lblUpdate.Visible = false;
                this.btnSaveCourse.Visible = false;
                this.btnCourseUpdate.Visible = false;
            }
            else
            {
                this.lblviewcoursedtl.Visible = false;
                this.lblUpdate.Visible = false;
                this.lblCourseId.Visible = false;
                this.txtCID.Visible = false;
                this.btnCourseUpdate.Visible = false;
            }
        }

        private void BtnCourseUpdate_Click(object sender, EventArgs e)
        {
            course_DAL.CID = (string.IsNullOrEmpty(this.txtCID.Text)) ? 0 : Int32.Parse(this.txtCID.Text.Trim());
            course_DAL.CName = (string.IsNullOrEmpty(this.txtCName.Text)) ? "N/A" : this.txtCName.Text.Trim();
            course_DAL.CType = (string.IsNullOrEmpty(this.cmbCType.Text)) ? "N/A" : this.cmbCType.SelectedItem.ToString();
            course_DAL.Cstatus = (this.cmbCStatus.Text.Trim() == "Show") ? 1 : 0;

            if (this.updateCourse(course_DAL)>0)
            {
                MessageBox.Show("Course Update Success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Clear();
                this.Hide();
            }
        }

        int updateCourse(Course_DAL course_DAL)
        {
            try
            {
                return courseConroller.UpdateCourse(course_DAL);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BtnSaveCourse_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtCName.Text))
                {
                    MessageBox.Show("Please Enter Course Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
                }
                else {
                    course_DAL.CName = this.txtCName.Text.Trim();
                    course_DAL.CType = this.cmbCType.Text.Trim();
                    course_DAL.Cstatus = (this.cmbCStatus.Text.Trim() == "Show") ? 1 : 0;

                    int asd = courseConroller.AddCourse(course_DAL);
                    MessageBox.Show("Sucessfully Added Course Details", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
