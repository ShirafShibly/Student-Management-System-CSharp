using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS.Views
{
    public partial class frmStudent : UserControl
    {
        public frmStudent()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

      

        private void BtnAddStudent_Click(object sender, EventArgs e)
        {
            frmAddStudent frmAddStudent = new frmAddStudent();
            frmAddStudent.ShowDialog();
        }
    }
}
