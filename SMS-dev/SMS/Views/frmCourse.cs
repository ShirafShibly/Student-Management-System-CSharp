using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMS.Controllers;
using SMS.DAL;


namespace SMS.Views
{
    public partial class frmCourse : UserControl
    {
        CourseConroller courseConroller = new CourseConroller();

        Course_DAL course_DAL = new Course_DAL();
        public frmCourse()
        {
            InitializeComponent();
        }

        private void FrmCourse_Load(object sender, EventArgs e)
        {
            this.FillDGVCourse();

        }


        private void FillDGVCourse()
        {
            try
            {
                courseConroller.LoadAllCourseGridView(dgvCourse);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BtnAddCourse_Click_1(object sender, EventArgs e)
        {
            frmAddCourse frmAddCourse = new frmAddCourse();
            frmAddCourse.ShowDialog();
            this.FillDGVCourse();
        }

      
        private void DgvCourse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCourse.CurrentCell.ColumnIndex.Equals(4) && e.RowIndex != -1)
            {
                dgvCourse.CurrentRow.Selected = true;
                int CID = Convert.ToInt32(dgvCourse.Rows[e.RowIndex].Cells["CID"].FormattedValue.ToString());
                string CName = dgvCourse.Rows[e.RowIndex].Cells["CName"].FormattedValue.ToString();
                string CType = dgvCourse.Rows[e.RowIndex].Cells["CType"].FormattedValue.ToString();
                int Cstatus = Convert.ToInt32(dgvCourse.Rows[e.RowIndex].Cells["Cstatus"].FormattedValue.ToString());

                frmAddCourse frmAddCourse = new frmAddCourse(CID, CName, CType,Cstatus,"edit");
                frmAddCourse.ShowDialog();
                this.FillDGVCourse();
            }

            else if (dgvCourse.CurrentCell.ColumnIndex.Equals(5) && e.RowIndex != -1)
            {
                dgvCourse.CurrentRow.Selected = true;
                int CID = Convert.ToInt32(dgvCourse.Rows[e.RowIndex].Cells["CID"].FormattedValue.ToString());
                string CName = dgvCourse.Rows[e.RowIndex].Cells["CName"].FormattedValue.ToString();
                string CType = dgvCourse.Rows[e.RowIndex].Cells["CType"].FormattedValue.ToString();
                int Cstatus = Convert.ToInt32(dgvCourse.Rows[e.RowIndex].Cells["Cstatus"].FormattedValue.ToString());

                DialogResult dialogResult = System.Windows.Forms.MessageBox.Show(string.Format("Do You Want Delete this "+ CName + " Course ?", dgvCourse.CurrentRow.Cells["CID"].Value), "Comfrmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ;
                {
                    if (dialogResult == DialogResult.Yes)
                    {
                        this.DeleteCourse(CID);

                        System.Windows.MessageBox.Show(" "+CName+ "Is Delete Successfully");
                        
                    }
                    else if (dialogResult == DialogResult.No)
                    {

                    }
                }
            }
            else if (dgvCourse.CurrentCell.ColumnIndex.Equals(6) && e.RowIndex != -1)
            {
                dgvCourse.CurrentRow.Selected = true;
                int CID = Convert.ToInt32(dgvCourse.Rows[e.RowIndex].Cells["CID"].FormattedValue.ToString());
                string CName = dgvCourse.Rows[e.RowIndex].Cells["CName"].FormattedValue.ToString();
                string CType = dgvCourse.Rows[e.RowIndex].Cells["CType"].FormattedValue.ToString();
                int Cstatus = Convert.ToInt32(dgvCourse.Rows[e.RowIndex].Cells["Cstatus"].FormattedValue.ToString());

                frmAddCourse frmAddCourse = new frmAddCourse(CID, CName, CType, Cstatus, "view");
                frmAddCourse.ShowDialog();
                this.FillDGVCourse();
            }

                this.FillDGVCourse();
        }

        private void TxtCourseSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                
                string search_text = this.txtCourseSearch.Text.Trim();
                courseConroller.CourseSearch(dgvCourse, search_text);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

  
        private int DeleteCourse(int CID)
        {
            try
            {
                return courseConroller.DeleteCourse(CID);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}