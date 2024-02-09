using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMS.Properties;
using SMS.DAL;
using SMS.Controllers;

namespace SMS.Views
{
    public partial class frmStaff : UserControl
    {

        StaffController staffController = new StaffController();

        Staff_DAL Staff_DAL = new Staff_DAL();

        public frmStaff()
        {
            InitializeComponent();
        }

      

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            frmStaffDtl frmStaffDtl = new frmStaffDtl();
            frmStaffDtl.ShowDialog();
            this.FillDGVStaff();
        }

        private void DgvStaffDtl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvStaffDtl.CurrentCell.ColumnIndex.Equals(17) && e.RowIndex != -1)
            {
                dgvStaffDtl.CurrentRow.Selected = true;
                int EID = Convert.ToInt32(dgvStaffDtl.Rows[e.RowIndex].Cells["EID"].FormattedValue.ToString());
                string EFullName = dgvStaffDtl.Rows[e.RowIndex].Cells["EFullName"].FormattedValue.ToString();
                string EAddress = dgvStaffDtl.Rows[e.RowIndex].Cells["EAddress"].FormattedValue.ToString();
                string photo_data = dgvStaffDtl.Rows[e.RowIndex].Cells["photo_data"].FormattedValue.ToString();

                //picBoxUserImage.Image = Base64ToImage(dgvStaff.Rows[e.RowIndex].Cells["photo_data"].FormattedValue.ToString());


                frmStaffDtl frmStaffDtl = new frmStaffDtl(EID, EFullName, EAddress, photo_data ,"edit");
                frmStaffDtl.ShowDialog();
                this.FillDGVStaff();
            }

            else if (dgvStaffDtl.CurrentCell.ColumnIndex.Equals(16) && e.RowIndex != -1)
            {
                dgvStaffDtl.CurrentRow.Selected = true;
                int EID = Convert.ToInt32(dgvStaffDtl.Rows[e.RowIndex].Cells["EID"].FormattedValue.ToString());
                string EFullName = dgvStaffDtl.Rows[e.RowIndex].Cells["EFullName"].FormattedValue.ToString();
                string EAddress = dgvStaffDtl.Rows[e.RowIndex].Cells["EAddress"].FormattedValue.ToString();
                string photo_data=dgvStaffDtl.Rows[e.RowIndex].Cells["photo_data"].FormattedValue.ToString();


                frmStaffDtl frmStaffDtl = new frmStaffDtl(EID, EFullName, EAddress, photo_data ,"view");
                frmStaffDtl.ShowDialog();
                this.FillDGVStaff();
            }
            this.FillDGVStaff();
        }

        private void FrmStaff_Load(object sender, EventArgs e)
        {
            this.FillDGVStaff();
        }

        private void FillDGVStaff()
        {
            try
            {
                staffController.LoadAllStaffGridView(dgvStaffDtl);

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
