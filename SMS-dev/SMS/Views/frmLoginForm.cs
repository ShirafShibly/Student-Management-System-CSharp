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
using SMS.Controllers;
using SMS.DAL;

namespace SMS.Views
{
    public partial class frmLoginForm : Form
    {
        
        public frmLoginForm()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.IsFormValid())
                {
                    //AuthController AuthController = new AuthController();
                    //Auth_DAL Auth_DAL = new Auth_DAL();

                    //Auth_DAL.UserName = txtUsername.Text.Trim();
                    //Auth_DAL.Password = txtPassword.Text.Trim();

                    

                    //int asd = AuthController.loginuser(Auth_DAL);
                    MessageBox.Show("Sucessfully Login", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    //List<string> data = auth.GetUserAuthentication(_authDAL);

                    // MessageBox.Show(data[0], "Message");
                    this.Hide();
                    Student Student = new Student();
                    Student.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsFormValid()
        {
            if (txtUsername.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Username Required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return false;
            }

            if (txtPassword.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Password Required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return false;
            }

            return true;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
