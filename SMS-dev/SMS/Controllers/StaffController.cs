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
    class StaffController
    {
        StaffModel staffModel = new StaffModel();

        public int AddStaff(Staff_DAL staff_DAL)
        {
            return staffModel.AddStaff(staff_DAL);
        }

        public void LoadAllStaffGridView(DataGridView dgvStaffDtl)
        {
            try
            {
                dgvStaffDtl.AutoGenerateColumns = false;
                dgvStaffDtl.DataSource = staffModel.GetAllStaffDtl();
                dgvStaffDtl.DefaultCellStyle.ForeColor = Color.Blue;
                dgvStaffDtl.DefaultCellStyle.BackColor = Color.Beige;
            }
            catch (Exception)
            {
                throw;
            }
        }

        }
}
