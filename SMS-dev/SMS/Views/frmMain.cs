using System;
using System.Drawing;
using System.Windows.Forms;
using FontAwesome.Sharp;
using SMS.Views;



namespace SMS
{
    public partial class Student : Form 
    {
        bool slidebarExpand;
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        public Form currentchildform;

        public Student()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            pSlider.Controls.Add(leftBorderBtn);


            //form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }


        public struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
           public static Color color2=Color.FromArgb(249,118,176);
           public static Color color3=Color.FromArgb(253,138,114);
           public static Color color4=Color.FromArgb(95,77,221  );
           public static Color color5=Color.FromArgb(249,88,155 );
           public static Color color6=Color.FromArgb(24,161,251 );
        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn !=null)
            {
                DisableButton();
                //button
                currentBtn=(IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37,36,81);
                currentBtn.ForeColor = color;
                //currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                //currentBtn.IconColor = color;
                //currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                //currentBtn.ImageAlign= ContentAlignment.MiddleRight;

                //leftboderbutton
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Icon current child form
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
                lblTitleChildForm.Text = currentBtn.Text;
            }
        }

        private void DisableButton()
        {
            if (currentBtn!= null)
            {
                currentBtn.BackColor = Color.FromArgb(0, 32, 96);
                

                currentBtn.ForeColor = Color.Gainsboro;
                //currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                //currentBtn.IconColor = Color.Gainsboro;
                //currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                //currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void TimSlidbarMenu_Tick(object sender, EventArgs e)
        {
            //set the minimaiz and maximize
            if (slidebarExpand)
            {
                pSlider.Width -= 10;
                if (pSlider.Width==pSlider.MinimumSize.Width)
                {
                    slidebarExpand = false;
                    timSlidbarMenu.Stop();

                }
            }
            else
            {
                pSlider.Width += 10;
                if (pSlider.Width==pSlider.MaximumSize.Width)
                {
                    slidebarExpand = true;
                    timSlidbarMenu.Stop();
                }
            }
        }



        public void OpenChildForm(Control control,Panel Content)
        {
            //if (iconCurrentChildForm != null)
            //{
            //    currentchildform.Close();
            //}
            //currentchildform = childForm;
            //childForm.TopLevel = false;
            //childForm.FormBorderStyle = FormBorderStyle.None;
            //childForm.Dock = DockStyle.Fill;
            //panelDesktop.Controls.Add(childForm);
            //panelDesktop.Tag = childForm;
            //childForm.BringToFront();
            //childForm.Show();
            //lblTitleChildForm.Text = childForm.Text;


            Content.Controls.Clear();

            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();

            Content.Controls.Add(control);
        }





        private void Menubutton_Click(object sender, EventArgs e)
        {
            timSlidbarMenu.Start();
            Reset();
        }

      


    

        private void BtnHomeL_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;

            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            lblTitleChildForm.Text = "Home";
        }


        private void BtnHome_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            frmDashBoard frmDashBoard = new frmDashBoard();

            OpenChildForm(frmDashBoard, panelDesktop);

        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            frmStudent frmStudent = new frmStudent();
            OpenChildForm(frmStudent, panelDesktop);
            
        }

        private void BtnStaff_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            //OpenChildForm(new frmStaff());
            frmStaff frmStaff = new frmStaff();
            OpenChildForm(frmStaff, panelDesktop);
        }

        private void BtnCourse_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            frmCourse frmCourse = new frmCourse();
            OpenChildForm(frmCourse,panelDesktop);
        }

        private void BtnCourseModule_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
        }

        private void BtnAttndence_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            frmAttendanceStudent frmAttendanceStudent = new frmAttendanceStudent();
            OpenChildForm(frmAttendanceStudent,panelDesktop);
        }

        private void BtnMarks_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            frmExam frmExam = new frmExam();
            OpenChildForm(frmExam,panelDesktop);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            frmReports frmReports = new frmReports();
            OpenChildForm(frmReports,panelDesktop);

        }
        private void BtnUser_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            frmUser frmUser = new frmUser();
            OpenChildForm(frmUser,panelDesktop);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure To Exit ?","Student Management System", MessageBoxButtons.YesNo,MessageBoxIcon.Stop);
            if (dialogResult==DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialogResult==DialogResult.No)
            {
               
            }
            
            
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnRestoreDown_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestoreDown.Visible = false;
            BtnMaximize.Visible = true;

           
        }

        private void BtnMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BtnMaximize.Visible = false;
            btnRestoreDown.Visible = true;
        }

        private void PanelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLoginForm frmLoginForm = new frmLoginForm();
            frmLoginForm.Show();
        }
    }
}
