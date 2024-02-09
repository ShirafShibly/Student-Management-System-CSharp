using SMS.DAL;
using SMS.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS.Controllers
{
    class CourseConroller
    {
        CourseModel courseModel = new CourseModel();

        public int AddCourse(Course_DAL course_DAL)
        {
            return courseModel.AddCourse(course_DAL);
        }

        public int UpdateCourse(Course_DAL course_DAL)
        {
            return courseModel.UpdateCourse(course_DAL);
        }


        public void LoadAllCourseGridView(DataGridView dgvCourse)
        {
            try
            {
                dgvCourse.AutoGenerateColumns = false;
                dgvCourse.DataSource = CourseModel.GetAllCourse();
                dgvCourse.DefaultCellStyle.ForeColor = Color.Black;
                dgvCourse.DefaultCellStyle.BackColor = Color.Beige;
                

            }
            catch (Exception)
            {
                throw;
            }
        }


        public int DeleteCourse(int CID)
        {
            return courseModel.DeleteCourse(CID);
        }

        public void CourseSearch(DataGridView dgvCourse,string search_text)
        {
            try
            {
                dgvCourse.AutoGenerateColumns = false;
                dgvCourse.DataSource = courseModel.CourseSearch(search_text);
                dgvCourse.DefaultCellStyle.ForeColor = Color.Blue;
                dgvCourse.DefaultCellStyle.BackColor = Color.Beige;
            }
            catch (Exception)
            {

                throw;
            } 
        }
    }
}
