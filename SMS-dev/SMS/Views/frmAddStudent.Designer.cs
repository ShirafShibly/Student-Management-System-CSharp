namespace SMS.Views
{
    partial class frmAddStudent
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbSCourse = new System.Windows.Forms.ComboBox();
            this.cmbSCourseType = new System.Windows.Forms.ComboBox();
            this.dtpSBdate = new System.Windows.Forms.DateTimePicker();
            this.txtSPaymentStatus = new System.Windows.Forms.TextBox();
            this.txtSTP = new System.Windows.Forms.TextBox();
            this.txtSEmail = new System.Windows.Forms.TextBox();
            this.txtSNIC = new System.Windows.Forms.TextBox();
            this.txtSAddress = new System.Windows.Forms.TextBox();
            this.txtFStudentName = new System.Windows.Forms.TextBox();
            this.txtIStudentName = new System.Windows.Forms.TextBox();
            this.lbl11 = new System.Windows.Forms.Label();
            this.lbl10 = new System.Windows.Forms.Label();
            this.lbl9 = new System.Windows.Forms.Label();
            this.lbl8 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lbl14 = new System.Windows.Forms.Label();
            this.cmbSRelationshipType = new System.Windows.Forms.ComboBox();
            this.lbl13 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.lbl12 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new FontAwesome.Sharp.IconPictureBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnSaveStaff = new FontAwesome.Sharp.IconButton();
            this.btnStaffUpdate = new FontAwesome.Sharp.IconButton();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label25 = new System.Windows.Forms.Label();
            this.picBoxUserImage = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUserImage)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.White;
            this.lbl1.Location = new System.Drawing.Point(385, 20);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(187, 25);
            this.lbl1.TabIndex = 51;
            this.lbl1.Text = "Student Registration";
            this.lbl1.Click += new System.EventHandler(this.Lbl1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dtpSBdate);
            this.groupBox2.Controls.Add(this.txtSPaymentStatus);
            this.groupBox2.Controls.Add(this.txtSTP);
            this.groupBox2.Controls.Add(this.txtSEmail);
            this.groupBox2.Controls.Add(this.txtSNIC);
            this.groupBox2.Controls.Add(this.txtSAddress);
            this.groupBox2.Controls.Add(this.txtFStudentName);
            this.groupBox2.Controls.Add(this.txtIStudentName);
            this.groupBox2.Controls.Add(this.lbl11);
            this.groupBox2.Controls.Add(this.lbl10);
            this.groupBox2.Controls.Add(this.lbl7);
            this.groupBox2.Controls.Add(this.lbl6);
            this.groupBox2.Controls.Add(this.lbl5);
            this.groupBox2.Controls.Add(this.lbl4);
            this.groupBox2.Controls.Add(this.lbl3);
            this.groupBox2.Controls.Add(this.lbl2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(12, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(386, 296);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Student Details";
            // 
            // cmbSCourse
            // 
            this.cmbSCourse.FormattingEnabled = true;
            this.cmbSCourse.Items.AddRange(new object[] {
            "Certificate in Software Engineering",
            "Certificate in Network Engineering​",
            "Certificate Course in Business Management",
            "Certificate Course in Human Resource Management (Sinhala)",
            "Certificate in International Business",
            "Certificate in Digital Marketing",
            "Certificate in Computer Science",
            "Diploma in Network Engineering (Full Time)",
            "Diploma in Software Engineering (Full Time)",
            "Diploma in Business Information Systems",
            "Diploma in Information and Communication Technology",
            "Diploma in Quantity Surveying",
            "Diploma in English for Professionals",
            "Bachelor of Information & Communications Technology",
            "Bachelor of Engineering in Telecommunication Engineering",
            "Bachelor of Business Analytics",
            "BA (Hons) Management and Leadership",
            "BSc (Hons) Quantity Surveying & Commercial Management",
            "Bachelor of Engineering (Honours) -Civil Engineering"});
            this.cmbSCourse.Location = new System.Drawing.Point(137, 71);
            this.cmbSCourse.Name = "cmbSCourse";
            this.cmbSCourse.Size = new System.Drawing.Size(200, 25);
            this.cmbSCourse.TabIndex = 54;
            this.cmbSCourse.Text = "Select Course";
            // 
            // cmbSCourseType
            // 
            this.cmbSCourseType.FormattingEnabled = true;
            this.cmbSCourseType.Items.AddRange(new object[] {
            "3 Months",
            "6 Months",
            "1 Year "});
            this.cmbSCourseType.Location = new System.Drawing.Point(137, 42);
            this.cmbSCourseType.Name = "cmbSCourseType";
            this.cmbSCourseType.Size = new System.Drawing.Size(200, 25);
            this.cmbSCourseType.TabIndex = 53;
            this.cmbSCourseType.Text = "Select Course Type";
            // 
            // dtpSBdate
            // 
            this.dtpSBdate.Location = new System.Drawing.Point(134, 117);
            this.dtpSBdate.Name = "dtpSBdate";
            this.dtpSBdate.Size = new System.Drawing.Size(200, 23);
            this.dtpSBdate.TabIndex = 52;
            // 
            // txtSPaymentStatus
            // 
            this.txtSPaymentStatus.Location = new System.Drawing.Point(135, 245);
            this.txtSPaymentStatus.Name = "txtSPaymentStatus";
            this.txtSPaymentStatus.Size = new System.Drawing.Size(200, 23);
            this.txtSPaymentStatus.TabIndex = 51;
            // 
            // txtSTP
            // 
            this.txtSTP.Location = new System.Drawing.Point(135, 213);
            this.txtSTP.Name = "txtSTP";
            this.txtSTP.Size = new System.Drawing.Size(200, 23);
            this.txtSTP.TabIndex = 51;
            // 
            // txtSEmail
            // 
            this.txtSEmail.Location = new System.Drawing.Point(134, 172);
            this.txtSEmail.Name = "txtSEmail";
            this.txtSEmail.Size = new System.Drawing.Size(200, 23);
            this.txtSEmail.TabIndex = 50;
            // 
            // txtSNIC
            // 
            this.txtSNIC.Location = new System.Drawing.Point(134, 143);
            this.txtSNIC.Name = "txtSNIC";
            this.txtSNIC.Size = new System.Drawing.Size(200, 23);
            this.txtSNIC.TabIndex = 49;
            // 
            // txtSAddress
            // 
            this.txtSAddress.Location = new System.Drawing.Point(134, 85);
            this.txtSAddress.Name = "txtSAddress";
            this.txtSAddress.Size = new System.Drawing.Size(200, 23);
            this.txtSAddress.TabIndex = 48;
            // 
            // txtFStudentName
            // 
            this.txtFStudentName.Location = new System.Drawing.Point(134, 58);
            this.txtFStudentName.Name = "txtFStudentName";
            this.txtFStudentName.Size = new System.Drawing.Size(200, 23);
            this.txtFStudentName.TabIndex = 47;
            // 
            // txtIStudentName
            // 
            this.txtIStudentName.Location = new System.Drawing.Point(134, 27);
            this.txtIStudentName.Name = "txtIStudentName";
            this.txtIStudentName.Size = new System.Drawing.Size(200, 23);
            this.txtIStudentName.TabIndex = 46;
            // 
            // lbl11
            // 
            this.lbl11.AutoSize = true;
            this.lbl11.Location = new System.Drawing.Point(19, 249);
            this.lbl11.Name = "lbl11";
            this.lbl11.Size = new System.Drawing.Size(111, 17);
            this.lbl11.TabIndex = 45;
            this.lbl11.Text = "Payment Status:";
            // 
            // lbl10
            // 
            this.lbl10.AutoSize = true;
            this.lbl10.Location = new System.Drawing.Point(19, 216);
            this.lbl10.Name = "lbl10";
            this.lbl10.Size = new System.Drawing.Size(51, 17);
            this.lbl10.TabIndex = 44;
            this.lbl10.Text = "Tp No:";
            // 
            // lbl9
            // 
            this.lbl9.AutoSize = true;
            this.lbl9.Location = new System.Drawing.Point(21, 70);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(57, 17);
            this.lbl9.TabIndex = 43;
            this.lbl9.Text = "Course:";
            // 
            // lbl8
            // 
            this.lbl8.AutoSize = true;
            this.lbl8.Location = new System.Drawing.Point(21, 42);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(93, 17);
            this.lbl8.TabIndex = 42;
            this.lbl8.Text = "Course Type:";
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Location = new System.Drawing.Point(18, 175);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(51, 17);
            this.lbl7.TabIndex = 41;
            this.lbl7.Text = "E-mail:";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Location = new System.Drawing.Point(18, 146);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(81, 17);
            this.lbl6.TabIndex = 40;
            this.lbl6.Text = "National ID:";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(18, 118);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(94, 17);
            this.lbl5.TabIndex = 39;
            this.lbl5.Text = "Date Of Birth:";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(21, 88);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(48, 13);
            this.lbl4.TabIndex = 38;
            this.lbl4.Text = "Address:";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(21, 58);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(57, 13);
            this.lbl3.TabIndex = 37;
            this.lbl3.Text = "Full Name:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(21, 30);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(95, 13);
            this.lbl2.TabIndex = 36;
            this.lbl2.Text = "Name With Initials:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 82);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(386, 41);
            this.richTextBox1.TabIndex = 53;
            this.richTextBox1.Text = "Student ID";
            // 
            // lbl14
            // 
            this.lbl14.AutoSize = true;
            this.lbl14.Location = new System.Drawing.Point(418, 24);
            this.lbl14.Name = "lbl14";
            this.lbl14.Size = new System.Drawing.Size(62, 17);
            this.lbl14.TabIndex = 2;
            this.lbl14.Text = "Number:";
            // 
            // cmbSRelationshipType
            // 
            this.cmbSRelationshipType.FormattingEnabled = true;
            this.cmbSRelationshipType.Items.AddRange(new object[] {
            "Mother",
            "Father",
            "Brother",
            "Sister",
            ""});
            this.cmbSRelationshipType.Location = new System.Drawing.Point(236, 43);
            this.cmbSRelationshipType.Name = "cmbSRelationshipType";
            this.cmbSRelationshipType.Size = new System.Drawing.Size(137, 25);
            this.cmbSRelationshipType.TabIndex = 11;
            this.cmbSRelationshipType.Text = "Selecet Relationship";
            // 
            // lbl13
            // 
            this.lbl13.AutoSize = true;
            this.lbl13.Location = new System.Drawing.Point(232, 24);
            this.lbl13.Name = "lbl13";
            this.lbl13.Size = new System.Drawing.Size(90, 17);
            this.lbl13.TabIndex = 1;
            this.lbl13.Text = "Relationship:";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(411, 44);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(134, 23);
            this.textBox7.TabIndex = 9;
            // 
            // lbl12
            // 
            this.lbl12.AutoSize = true;
            this.lbl12.Location = new System.Drawing.Point(15, 24);
            this.lbl12.Name = "lbl12";
            this.lbl12.Size = new System.Drawing.Size(49, 17);
            this.lbl12.TabIndex = 0;
            this.lbl12.Text = "Name:";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(18, 43);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(183, 23);
            this.textBox8.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lbl14);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.cmbSRelationshipType);
            this.groupBox1.Controls.Add(this.lbl13);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.lbl12);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 443);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 149);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Relationship Contact Details:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Mother",
            "Father",
            "Brother",
            "Sister",
            ""});
            this.comboBox2.Location = new System.Drawing.Point(236, 117);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(137, 25);
            this.comboBox2.TabIndex = 11;
            this.comboBox2.Text = "Selecet Relationship";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mother",
            "Father",
            "Brother",
            "Sister",
            ""});
            this.comboBox1.Location = new System.Drawing.Point(236, 84);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(137, 25);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.Text = "Selecet Relationship";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(411, 118);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(134, 23);
            this.textBox4.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(411, 84);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(134, 23);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(18, 117);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(183, 23);
            this.textBox3.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 23);
            this.textBox1.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.lbl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 60);
            this.panel1.TabIndex = 60;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.TimesSquare;
            this.btnExit.IconColor = System.Drawing.Color.Red;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 29;
            this.btnExit.Location = new System.Drawing.Point(946, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(31, 29);
            this.btnExit.TabIndex = 52;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(7, 159);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(4);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(134, 40);
            this.iconButton1.TabIndex = 52;
            this.iconButton1.Text = "Browse";
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // btnSaveStaff
            // 
            this.btnSaveStaff.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSaveStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveStaff.ForeColor = System.Drawing.Color.Black;
            this.btnSaveStaff.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSaveStaff.IconColor = System.Drawing.Color.Black;
            this.btnSaveStaff.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSaveStaff.Location = new System.Drawing.Point(852, 443);
            this.btnSaveStaff.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveStaff.Name = "btnSaveStaff";
            this.btnSaveStaff.Size = new System.Drawing.Size(151, 46);
            this.btnSaveStaff.TabIndex = 53;
            this.btnSaveStaff.Text = "Save";
            this.btnSaveStaff.UseVisualStyleBackColor = false;
            // 
            // btnStaffUpdate
            // 
            this.btnStaffUpdate.BackColor = System.Drawing.Color.Orange;
            this.btnStaffUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnStaffUpdate.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnStaffUpdate.IconColor = System.Drawing.Color.Black;
            this.btnStaffUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStaffUpdate.Location = new System.Drawing.Point(852, 497);
            this.btnStaffUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnStaffUpdate.Name = "btnStaffUpdate";
            this.btnStaffUpdate.Size = new System.Drawing.Size(151, 46);
            this.btnStaffUpdate.TabIndex = 54;
            this.btnStaffUpdate.Text = "Update";
            this.btnStaffUpdate.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Gray;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCancel.IconColor = System.Drawing.Color.Black;
            this.btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancel.Location = new System.Drawing.Point(852, 548);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(151, 46);
            this.btnCancel.TabIndex = 55;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click_1);
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.panel14.Controls.Add(this.label25);
            this.panel14.Controls.Add(this.iconButton1);
            this.panel14.Controls.Add(this.picBoxUserImage);
            this.panel14.Location = new System.Drawing.Point(852, 83);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(151, 203);
            this.panel14.TabIndex = 61;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(17, 6);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(102, 18);
            this.label25.TabIndex = 17;
            this.label25.Text = "Student Image";
            // 
            // picBoxUserImage
            // 
            this.picBoxUserImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxUserImage.Location = new System.Drawing.Point(20, 28);
            this.picBoxUserImage.Name = "picBoxUserImage";
            this.picBoxUserImage.Size = new System.Drawing.Size(103, 124);
            this.picBoxUserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxUserImage.TabIndex = 16;
            this.picBoxUserImage.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.cmbSCourse);
            this.groupBox3.Controls.Add(this.comboBox6);
            this.groupBox3.Controls.Add(this.cmbSCourseType);
            this.groupBox3.Controls.Add(this.comboBox5);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBox5);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.lbl8);
            this.groupBox3.Controls.Add(this.lbl9);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(415, 129);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(357, 296);
            this.groupBox3.TabIndex = 54;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Student Details";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(137, 206);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(200, 23);
            this.textBox5.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 45;
            this.label1.Text = "Payment Status:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 43;
            this.label2.Text = "Year";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "Certificate in Software Engineering",
            "Certificate in Network Engineering​",
            "Certificate Course in Business Management",
            "Certificate Course in Human Resource Management (Sinhala)",
            "Certificate in International Business",
            "Certificate in Digital Marketing",
            "Certificate in Computer Science",
            "Diploma in Network Engineering (Full Time)",
            "Diploma in Software Engineering (Full Time)",
            "Diploma in Business Information Systems",
            "Diploma in Information and Communication Technology",
            "Diploma in Quantity Surveying",
            "Diploma in English for Professionals",
            "Bachelor of Information & Communications Technology",
            "Bachelor of Engineering in Telecommunication Engineering",
            "Bachelor of Business Analytics",
            "BA (Hons) Management and Leadership",
            "BSc (Hons) Quantity Surveying & Commercial Management",
            "Bachelor of Engineering (Honours) -Civil Engineering"});
            this.comboBox5.Location = new System.Drawing.Point(137, 109);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(200, 25);
            this.comboBox5.TabIndex = 54;
            this.comboBox5.Text = "Select Course";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 43;
            this.label5.Text = "Batch";
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "Certificate in Software Engineering",
            "Certificate in Network Engineering​",
            "Certificate Course in Business Management",
            "Certificate Course in Human Resource Management (Sinhala)",
            "Certificate in International Business",
            "Certificate in Digital Marketing",
            "Certificate in Computer Science",
            "Diploma in Network Engineering (Full Time)",
            "Diploma in Software Engineering (Full Time)",
            "Diploma in Business Information Systems",
            "Diploma in Information and Communication Technology",
            "Diploma in Quantity Surveying",
            "Diploma in English for Professionals",
            "Bachelor of Information & Communications Technology",
            "Bachelor of Engineering in Telecommunication Engineering",
            "Bachelor of Business Analytics",
            "BA (Hons) Management and Leadership",
            "BSc (Hons) Quantity Surveying & Commercial Management",
            "Bachelor of Engineering (Honours) -Civil Engineering"});
            this.comboBox6.Location = new System.Drawing.Point(137, 152);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(200, 25);
            this.comboBox6.TabIndex = 54;
            this.comboBox6.Text = "Select Course";
            // 
            // frmAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1084, 621);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSaveStaff);
            this.Controls.Add(this.btnStaffUpdate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAddStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddStudent";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUserImage)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbSCourse;
        private System.Windows.Forms.ComboBox cmbSCourseType;
        private System.Windows.Forms.DateTimePicker dtpSBdate;
        private System.Windows.Forms.TextBox txtSPaymentStatus;
        private System.Windows.Forms.TextBox txtSTP;
        private System.Windows.Forms.TextBox txtSEmail;
        private System.Windows.Forms.TextBox txtSNIC;
        private System.Windows.Forms.TextBox txtSAddress;
        private System.Windows.Forms.TextBox txtFStudentName;
        private System.Windows.Forms.TextBox txtIStudentName;
        private System.Windows.Forms.Label lbl11;
        private System.Windows.Forms.Label lbl10;
        private System.Windows.Forms.Label lbl9;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lbl14;
        private System.Windows.Forms.ComboBox cmbSRelationshipType;
        private System.Windows.Forms.Label lbl13;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label lbl12;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnSaveStaff;
        private FontAwesome.Sharp.IconButton btnStaffUpdate;
        private FontAwesome.Sharp.IconButton btnCancel;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.PictureBox picBoxUserImage;
        private FontAwesome.Sharp.IconPictureBox btnExit;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}