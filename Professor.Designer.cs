namespace StudentRegSys
{
    partial class Professor
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
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lbxSelected = new System.Windows.Forms.ListBox();
            this.lbxAvailable = new System.Windows.Forms.ListBox();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtConfirm = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel35 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCurrent = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNew = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel23 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel25 = new MaterialSkin.Controls.MaterialLabel();
            this.btnPassword = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUsername = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.lblQulf = new MaterialSkin.Controls.MaterialLabel();
            this.lblPhone = new MaterialSkin.Controls.MaterialLabel();
            this.lblEmail = new MaterialSkin.Controls.MaterialLabel();
            this.lblAddress = new MaterialSkin.Controls.MaterialLabel();
            this.lblDOB = new MaterialSkin.Controls.MaterialLabel();
            this.lblGender = new MaterialSkin.Controls.MaterialLabel();
            this.lblReg = new MaterialSkin.Controls.MaterialLabel();
            this.lblName = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.datagridModule = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbxModule = new System.Windows.Forms.ComboBox();
            this.datagridStudent = new System.Windows.Forms.DataGridView();
            this.lblregValue = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridModule)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage4);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 100);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(900, 580);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnRemove);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.lbxSelected);
            this.tabPage1.Controls.Add(this.lbxAvailable);
            this.tabPage1.Controls.Add(this.materialLabel9);
            this.tabPage1.Controls.Add(this.materialLabel10);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(892, 554);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Register";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(427, 284);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(39, 42);
            this.btnRemove.TabIndex = 14;
            this.btnRemove.Text = "<";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(427, 236);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(39, 42);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = ">";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Depth = 0;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(664, 498);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Primary = true;
            this.btnSave.Size = new System.Drawing.Size(55, 36);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbxSelected
            // 
            this.lbxSelected.FormattingEnabled = true;
            this.lbxSelected.Location = new System.Drawing.Point(494, 84);
            this.lbxSelected.Name = "lbxSelected";
            this.lbxSelected.Size = new System.Drawing.Size(320, 394);
            this.lbxSelected.TabIndex = 11;
            // 
            // lbxAvailable
            // 
            this.lbxAvailable.FormattingEnabled = true;
            this.lbxAvailable.Location = new System.Drawing.Point(78, 84);
            this.lbxAvailable.Name = "lbxAvailable";
            this.lbxAvailable.Size = new System.Drawing.Size(320, 394);
            this.lbxAvailable.TabIndex = 10;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(172, 54);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(132, 19);
            this.materialLabel9.TabIndex = 9;
            this.materialLabel9.Text = "Available Modules";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(590, 54);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(129, 19);
            this.materialLabel10.TabIndex = 8;
            this.materialLabel10.Text = "Selected Modules";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel5);
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(892, 554);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Settings";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.txtConfirm);
            this.panel5.Controls.Add(this.materialLabel35);
            this.panel5.Controls.Add(this.txtCurrent);
            this.panel5.Controls.Add(this.txtNew);
            this.panel5.Controls.Add(this.materialLabel23);
            this.panel5.Controls.Add(this.materialLabel25);
            this.panel5.Controls.Add(this.btnPassword);
            this.panel5.Location = new System.Drawing.Point(46, 398);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(800, 168);
            this.panel5.TabIndex = 4;
            // 
            // txtConfirm
            // 
            this.txtConfirm.Depth = 0;
            this.txtConfirm.Hint = "";
            this.txtConfirm.Location = new System.Drawing.Point(206, 101);
            this.txtConfirm.MaxLength = 32767;
            this.txtConfirm.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.PasswordChar = '\0';
            this.txtConfirm.SelectedText = "";
            this.txtConfirm.SelectionLength = 0;
            this.txtConfirm.SelectionStart = 0;
            this.txtConfirm.Size = new System.Drawing.Size(200, 23);
            this.txtConfirm.TabIndex = 56;
            this.txtConfirm.TabStop = false;
            this.txtConfirm.UseSystemPasswordChar = true;
            // 
            // materialLabel35
            // 
            this.materialLabel35.AutoSize = true;
            this.materialLabel35.Depth = 0;
            this.materialLabel35.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel35.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel35.Location = new System.Drawing.Point(40, 103);
            this.materialLabel35.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel35.Name = "materialLabel35";
            this.materialLabel35.Size = new System.Drawing.Size(137, 19);
            this.materialLabel35.TabIndex = 55;
            this.materialLabel35.Text = "Confirm Password:";
            // 
            // txtCurrent
            // 
            this.txtCurrent.Depth = 0;
            this.txtCurrent.Hint = "";
            this.txtCurrent.Location = new System.Drawing.Point(206, 19);
            this.txtCurrent.MaxLength = 32767;
            this.txtCurrent.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCurrent.Name = "txtCurrent";
            this.txtCurrent.PasswordChar = '\0';
            this.txtCurrent.SelectedText = "";
            this.txtCurrent.SelectionLength = 0;
            this.txtCurrent.SelectionStart = 0;
            this.txtCurrent.Size = new System.Drawing.Size(200, 23);
            this.txtCurrent.TabIndex = 51;
            this.txtCurrent.TabStop = false;
            this.txtCurrent.UseSystemPasswordChar = true;
            // 
            // txtNew
            // 
            this.txtNew.Depth = 0;
            this.txtNew.Hint = "";
            this.txtNew.Location = new System.Drawing.Point(206, 60);
            this.txtNew.MaxLength = 32767;
            this.txtNew.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNew.Name = "txtNew";
            this.txtNew.PasswordChar = '\0';
            this.txtNew.SelectedText = "";
            this.txtNew.SelectionLength = 0;
            this.txtNew.SelectionStart = 0;
            this.txtNew.Size = new System.Drawing.Size(200, 23);
            this.txtNew.TabIndex = 50;
            this.txtNew.TabStop = false;
            this.txtNew.UseSystemPasswordChar = true;
            // 
            // materialLabel23
            // 
            this.materialLabel23.AutoSize = true;
            this.materialLabel23.Depth = 0;
            this.materialLabel23.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel23.Location = new System.Drawing.Point(40, 21);
            this.materialLabel23.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel23.Name = "materialLabel23";
            this.materialLabel23.Size = new System.Drawing.Size(132, 19);
            this.materialLabel23.TabIndex = 49;
            this.materialLabel23.Text = "Current Password:";
            // 
            // materialLabel25
            // 
            this.materialLabel25.AutoSize = true;
            this.materialLabel25.Depth = 0;
            this.materialLabel25.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel25.Location = new System.Drawing.Point(40, 62);
            this.materialLabel25.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel25.Name = "materialLabel25";
            this.materialLabel25.Size = new System.Drawing.Size(113, 19);
            this.materialLabel25.TabIndex = 47;
            this.materialLabel25.Text = "New Password:";
            // 
            // btnPassword
            // 
            this.btnPassword.AutoSize = true;
            this.btnPassword.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPassword.Depth = 0;
            this.btnPassword.Icon = null;
            this.btnPassword.Location = new System.Drawing.Point(628, 118);
            this.btnPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Primary = true;
            this.btnPassword.Size = new System.Drawing.Size(153, 36);
            this.btnPassword.TabIndex = 46;
            this.btnPassword.Text = "Change Password";
            this.btnPassword.UseVisualStyleBackColor = true;
            this.btnPassword.Click += new System.EventHandler(this.btnPassword_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Controls.Add(this.materialLabel13);
            this.panel1.Controls.Add(this.lblQulf);
            this.panel1.Controls.Add(this.lblPhone);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.lblAddress);
            this.panel1.Controls.Add(this.lblDOB);
            this.panel1.Controls.Add(this.lblGender);
            this.panel1.Controls.Add(this.lblReg);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.materialLabel8);
            this.panel1.Controls.Add(this.materialLabel7);
            this.panel1.Controls.Add(this.materialLabel6);
            this.panel1.Controls.Add(this.materialLabel5);
            this.panel1.Controls.Add(this.materialLabel4);
            this.panel1.Controls.Add(this.materialLabel3);
            this.panel1.Controls.Add(this.materialLabel2);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Location = new System.Drawing.Point(46, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 374);
            this.panel1.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Depth = 0;
            this.lblUsername.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUsername.Location = new System.Drawing.Point(563, 23);
            this.lblUsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(77, 19);
            this.lblUsername.TabIndex = 17;
            this.lblUsername.Text = "Username";
            this.lblUsername.Click += new System.EventHandler(this.lblYear_Click);
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel13.Location = new System.Drawing.Point(401, 23);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(81, 19);
            this.materialLabel13.TabIndex = 16;
            this.materialLabel13.Text = "Username:";
            // 
            // lblQulf
            // 
            this.lblQulf.AutoSize = true;
            this.lblQulf.Depth = 0;
            this.lblQulf.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblQulf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblQulf.Location = new System.Drawing.Point(202, 331);
            this.lblQulf.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblQulf.Name = "lblQulf";
            this.lblQulf.Size = new System.Drawing.Size(102, 19);
            this.lblQulf.TabIndex = 15;
            this.lblQulf.Text = "Qualifications";
            this.lblQulf.Click += new System.EventHandler(this.lblYear_Click);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Depth = 0;
            this.lblPhone.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPhone.Location = new System.Drawing.Point(202, 287);
            this.lblPhone.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(108, 19);
            this.lblPhone.TabIndex = 14;
            this.lblPhone.Text = "Phone Number";
            this.lblPhone.Click += new System.EventHandler(this.lblYear_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Depth = 0;
            this.lblEmail.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEmail.Location = new System.Drawing.Point(202, 243);
            this.lblEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(106, 19);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "Email Address";
            this.lblEmail.Click += new System.EventHandler(this.lblYear_Click);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Depth = 0;
            this.lblAddress.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAddress.Location = new System.Drawing.Point(202, 199);
            this.lblAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(64, 19);
            this.lblAddress.TabIndex = 12;
            this.lblAddress.Text = "Address";
            this.lblAddress.Click += new System.EventHandler(this.lblYear_Click);
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Depth = 0;
            this.lblDOB.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDOB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDOB.Location = new System.Drawing.Point(202, 155);
            this.lblDOB.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(93, 19);
            this.lblDOB.TabIndex = 11;
            this.lblDOB.Text = "Date of Birth";
            this.lblDOB.Click += new System.EventHandler(this.lblYear_Click);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Depth = 0;
            this.lblGender.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblGender.Location = new System.Drawing.Point(202, 111);
            this.lblGender.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(56, 19);
            this.lblGender.TabIndex = 10;
            this.lblGender.Text = "Gender";
            this.lblGender.Click += new System.EventHandler(this.lblYear_Click);
            // 
            // lblReg
            // 
            this.lblReg.AutoSize = true;
            this.lblReg.Depth = 0;
            this.lblReg.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblReg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblReg.Location = new System.Drawing.Point(202, 23);
            this.lblReg.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblReg.Name = "lblReg";
            this.lblReg.Size = new System.Drawing.Size(121, 19);
            this.lblReg.TabIndex = 9;
            this.lblReg.Text = "Register Number";
            this.lblReg.Click += new System.EventHandler(this.lblYear_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Depth = 0;
            this.lblName.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblName.Location = new System.Drawing.Point(202, 67);
            this.lblName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(77, 19);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Full Name";
            this.lblName.Click += new System.EventHandler(this.lblYear_Click);
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(40, 331);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(106, 19);
            this.materialLabel8.TabIndex = 7;
            this.materialLabel8.Text = "Qualifications:";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(40, 287);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(112, 19);
            this.materialLabel7.TabIndex = 6;
            this.materialLabel7.Text = "Phone Number:";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(40, 243);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(110, 19);
            this.materialLabel6.TabIndex = 5;
            this.materialLabel6.Text = "Email Address:";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(40, 199);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(68, 19);
            this.materialLabel5.TabIndex = 4;
            this.materialLabel5.Text = "Address:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(40, 155);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(97, 19);
            this.materialLabel4.TabIndex = 3;
            this.materialLabel4.Text = "Date of Birth:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(40, 111);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(60, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Gender:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(40, 23);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(125, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Register Number:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(40, 67);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(81, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Full Name:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.datagridModule);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(892, 554);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Modules";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // datagridModule
            // 
            this.datagridModule.AllowUserToAddRows = false;
            this.datagridModule.AllowUserToDeleteRows = false;
            this.datagridModule.AllowUserToOrderColumns = true;
            this.datagridModule.AllowUserToResizeColumns = false;
            this.datagridModule.AllowUserToResizeRows = false;
            this.datagridModule.BackgroundColor = System.Drawing.Color.White;
            this.datagridModule.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.datagridModule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridModule.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datagridModule.EnableHeadersVisualStyles = false;
            this.datagridModule.Location = new System.Drawing.Point(46, 18);
            this.datagridModule.Name = "datagridModule";
            this.datagridModule.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.datagridModule.ShowCellErrors = false;
            this.datagridModule.ShowCellToolTips = false;
            this.datagridModule.ShowEditingIcon = false;
            this.datagridModule.ShowRowErrors = false;
            this.datagridModule.Size = new System.Drawing.Size(800, 548);
            this.datagridModule.TabIndex = 20;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.materialLabel11);
            this.tabPage4.Controls.Add(this.cmbxModule);
            this.tabPage4.Controls.Add(this.datagridStudent);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(892, 554);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Students";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(61, 515);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(63, 19);
            this.materialLabel11.TabIndex = 23;
            this.materialLabel11.Text = "Module:";
            // 
            // cmbxModule
            // 
            this.cmbxModule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxModule.FormattingEnabled = true;
            this.cmbxModule.Location = new System.Drawing.Point(160, 513);
            this.cmbxModule.Name = "cmbxModule";
            this.cmbxModule.Size = new System.Drawing.Size(200, 21);
            this.cmbxModule.TabIndex = 22;
            this.cmbxModule.SelectedIndexChanged += new System.EventHandler(this.cmbxSYear_SelectedIndexChanged);
            // 
            // datagridStudent
            // 
            this.datagridStudent.AllowUserToAddRows = false;
            this.datagridStudent.AllowUserToDeleteRows = false;
            this.datagridStudent.AllowUserToOrderColumns = true;
            this.datagridStudent.AllowUserToResizeColumns = false;
            this.datagridStudent.AllowUserToResizeRows = false;
            this.datagridStudent.BackgroundColor = System.Drawing.Color.White;
            this.datagridStudent.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.datagridStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridStudent.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datagridStudent.EnableHeadersVisualStyles = false;
            this.datagridStudent.Location = new System.Drawing.Point(46, 18);
            this.datagridStudent.Name = "datagridStudent";
            this.datagridStudent.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.datagridStudent.ShowCellErrors = false;
            this.datagridStudent.ShowCellToolTips = false;
            this.datagridStudent.ShowEditingIcon = false;
            this.datagridStudent.ShowRowErrors = false;
            this.datagridStudent.Size = new System.Drawing.Size(800, 475);
            this.datagridStudent.TabIndex = 21;
            // 
            // lblregValue
            // 
            this.lblregValue.BaseTabControl = this.materialTabControl1;
            this.lblregValue.Depth = 0;
            this.lblregValue.Location = new System.Drawing.Point(0, 64);
            this.lblregValue.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblregValue.Name = "lblregValue";
            this.lblregValue.Size = new System.Drawing.Size(900, 36);
            this.lblregValue.TabIndex = 2;
            // 
            // Professor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 680);
            this.Controls.Add(this.lblregValue);
            this.Controls.Add(this.materialTabControl1);
            this.MaximizeBox = false;
            this.Name = "Professor";
            this.Text = "Professor";
            this.Load += new System.EventHandler(this.Student_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridModule)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private MaterialSkin.Controls.MaterialTabSelector lblregValue;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel lblQulf;
        private MaterialSkin.Controls.MaterialLabel lblPhone;
        private MaterialSkin.Controls.MaterialLabel lblEmail;
        private MaterialSkin.Controls.MaterialLabel lblAddress;
        private MaterialSkin.Controls.MaterialLabel lblDOB;
        private MaterialSkin.Controls.MaterialLabel lblGender;
        private MaterialSkin.Controls.MaterialLabel lblReg;
        private MaterialSkin.Controls.MaterialLabel lblName;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.Panel panel5;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtConfirm;
        private MaterialSkin.Controls.MaterialLabel materialLabel35;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCurrent;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNew;
        private MaterialSkin.Controls.MaterialLabel materialLabel23;
        private MaterialSkin.Controls.MaterialLabel materialLabel25;
        private MaterialSkin.Controls.MaterialRaisedButton btnPassword;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView datagridModule;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private MaterialSkin.Controls.MaterialRaisedButton btnSave;
        private System.Windows.Forms.ListBox lbxSelected;
        private System.Windows.Forms.ListBox lbxAvailable;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private System.Windows.Forms.DataGridView datagridStudent;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private System.Windows.Forms.ComboBox cmbxModule;
        private MaterialSkin.Controls.MaterialLabel lblUsername;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
    }
}