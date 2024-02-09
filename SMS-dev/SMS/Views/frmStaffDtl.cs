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
using SMS.Other;
using System.Text.RegularExpressions;
using System.Drawing.Imaging;
using System.IO;

namespace SMS.Views
{
    public partial class frmStaffDtl : Form
    {
        string fileName = "";
        
        StaffController StaffController = new StaffController();

        ValidationLab validationLab = new ValidationLab();
        Staff_DAL Staff_DAL = new Staff_DAL();

        //private string EID;
        private int EID;
        private string EFName;
        private string ELName;
        private string EFullName;
        private string ENameWithInit;
        private string EAddress;
        private string ENIC;
        private string EGende;
        private string EmartitalStatus;
        private string Enationality;
        private string EDOB;
        private string EEmail;
        private string EMobile;
        private string EHomeMobile;
        public string EDesignation;
        public string EEnrollDate;
        public string photo_data;
        private string status;
       

        public frmStaffDtl()
        {
            InitializeComponent();
        }

        public frmStaffDtl(int eID, string eFullName, string eAddress,string photo_data, string status)
        {
            InitializeComponent();

            this.Staff_DAL.EID = eID;
            this.Staff_DAL.EFullName = eFullName;
            this.Staff_DAL.EAddress = eAddress;
            this.Staff_DAL.photo_data = photo_data;
            this.status = status;
        }

        //public frmStaffDtl(int empID,string eFullName, string eAddress, string status)
        //{
        //    InitializeComponent();

        //    Staff_DAL.EID = empID;
        //    this.Staff_DAL.EFullName = eFullName;
        //    this.Staff_DAL.EAddress = eAddress;
        //    this.status = status;


        //}

        private void btnAddQulification(object sender, EventArgs e)
        {
            frmStaffQulification addQulification = new frmStaffQulification();
            addQulification.ShowDialog();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            frmDashBoard frmDashBoard = new frmDashBoard();
            //OpenChildForm(frmDashBoard, panelDesktop);
            this.Hide();
            frmDashBoard.Show();
        }



        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Multiselect = false })
            {

                ofd.Filter = "Image File(*.jpe;*.jpeg;*.bmp;*.png) | *.jpg;*jpeg;*.bmp;*.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        fileName = ofd.FileName;
                        picBoxUserImage.Image = Image.FromFile(fileName);
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private bool IsValid()
        {
            Regex regex = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            bool isValid = regex.IsMatch(this.txtEmail.Text.Trim());
            if (!isValid)
            {
                MessageBox.Show("Invalid Email.");
                return false;
            }

            return true;

        }

        private void BtnSaveStaff_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtEFname.Text))
                {
                    MessageBox.Show("Please Check Your Ented Value ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (IsValid())
                    {
                        Staff_DAL.EFName = this.txtEFname.Text.Trim();
                        Staff_DAL.ELName = this.txtELname.Text.Trim();
                        Staff_DAL.EFullName = this.txtFullName.Text.Trim();
                        Staff_DAL.ENameWithInit = this.txtNameWithInitial.Text.Trim();
                        Staff_DAL.EAddress = this.txtAddress.Text.Trim();
                        Staff_DAL.ENIC = this.txtNIC.Text.Trim();
                        Staff_DAL.EGende = (radioMale.Checked == true) ? "Male" : "FeMale";
                        Staff_DAL.EmartitalStatus = (radioSingle.Checked == true) ? "Single" : (radioMarried.Checked == true) ? "Married" : "Divorced";
                        Staff_DAL.Enationality = this.txtNationality.Text.Trim();
                        Staff_DAL.EHomeMobile = this.txtTPHome.Text.Trim();
                        Staff_DAL.EMobile = this.txtMobile.Text.Trim();
                        Staff_DAL.EEmail = this.txtEmail.Text.Trim();
                        Staff_DAL.EDesignation = this.cmbdesignation.Text.Trim();
                        Staff_DAL.EDOB = this.dtpEBdate.Text.Trim();
                        Staff_DAL.EEnrollDate =(this.dtpEnrollemntDate.Value=System.DateTime.Now);
                        //Staff_DAL.photo_data = ImageToBase64(picBoxUserImage.Image, System.Drawing.Imaging.ImageFormat.Png);
                        Staff_DAL.photo_data = (picBoxUserImage.Image == null) ? "N/A" : ImageToBase64(picBoxUserImage.Image, System.Drawing.Imaging.ImageFormat.Png);



                        int asd = StaffController.AddStaff(Staff_DAL);
                        MessageBox.Show("Sucessfully Added Staff Details", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Place Enter valide Data","Worning" ,MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ImageToBase64(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Convert Image to byte[]
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();

                // Convert byte[] to Base64 String
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }

        private Image Base64ToImage(string base64String)
        {
            if (string.IsNullOrEmpty(base64String))
            {
                return null;
            }
            else
            {
                try
                {
                    // Convert Base64 String to byte[]
                    byte[] imageBytes = Convert.FromBase64String(base64String);
                    MemoryStream ms = new MemoryStream(imageBytes, 0,
                      imageBytes.Length);

                    // Convert byte[] to Image
                    ms.Write(imageBytes, 0, imageBytes.Length);
                    Image image = Image.FromStream(ms, true);
                    return image;
                }
                catch (Exception)
                {

                    throw;
                }
            }

        }

        private void Clear()
        {
            this.txtEFname.Text = "";
            this.txtELname.Text = "";
            this.txtFullName.Text = "";
            this.txtNameWithInitial.Text = "";
            this.txtNIC.Text = "";
            this.txtNationality.Text = "";
            this.txtTPHome.Text = "";
            this.txtMobile.Text = "";
            this.cmbdesignation.Text = "";
            this.dtpEBdate.Text = "";
            this.radioMale.Checked = false;
            this.radioFemale.Checked = false;
            this.txtAddress.Text = "";
            this.txtEmail.Text = "";
            this.cmbdesignation.SelectedIndex = -1; 

        }

        private void FrmStaffDtl_Load(object sender, EventArgs e)
        {
            if ( this.status == "edit")
            {
                

                this.txtEID.Text = Staff_DAL.EID.ToString();
                this.txtFullName.Text = Staff_DAL.EFullName.ToString();
                this.txtAddress.Text = Staff_DAL.EAddress.ToString();

                this.lblViewDtl.Visible = false;
                this.lblAddStaffDTL.Visible = false;
                this.btnSaveStaff.Visible = false;
                this.txtEID.Enabled=false;
                this.dtpEnrollemntDate.Enabled = false;
                picBoxUserImage.Image = Base64ToImage(Staff_DAL.photo_data);

            }

            else if (this.status == "view")
            {
                this.lblAddStaffDTL.Visible = false;

                this.txtEID.Text = Staff_DAL.EID.ToString();
                this.txtFullName.Text = Staff_DAL.EFullName.ToString();
                this.txtAddress.Text = Staff_DAL.EAddress.ToString();

                this.lblAddStaffDTL.Visible = false;
                this.btnSaveStaff.Visible = false;
                this.txtEID.Enabled = false;
                this.dtpEnrollemntDate.Enabled = false;

                this.btnStaffUpdate.Visible = false;
                this.lblUpdatestaff.Visible = false;
                this.btnBrowse.Visible = false;

                txtAddress.Enabled = false;
                txtEFname.Enabled = false;
                txtELname.Enabled = false;
                txtEmail.Enabled = false;
                txtFullName.Enabled = false;
                txtMobile.Enabled = false;
                txtNameWithInitial.Enabled = false;
                txtNationality.Enabled = false;
                txtNIC.Enabled = false;
                txtTPHome.Enabled = false;
                dtpEBdate.Enabled = false;
                radioDivorced.Enabled = false;
                radioFemale.Enabled = false;
                radioMale.Enabled = false;
                radioMarried.Enabled = false;
                radioSingle.Enabled = false;
                cmbdesignation.Enabled = false;





            }

            else
            {
                this.lblViewDtl.Visible = false;
                this.lblUpdatestaff.Visible = false;
                this.btnStaffUpdate.Visible = false;
                this.lblEnrollemntDate.Visible = false;
                this.dtpEnrollemntDate.Visible = false;
                this.txtEID.Visible = false;
                this.lblEID.Visible = false;
            }

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            frmDashBoard frmDashBoard = new frmDashBoard();
            this.Hide();
            frmDashBoard.Show();
        }
    }
}
