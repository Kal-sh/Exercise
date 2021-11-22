namespace WindowsFormsApplication17
{
    partial class Form1
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
            this.userID = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.fatherName = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.confirmPassword = new System.Windows.Forms.Label();
            this.txtFathername = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtCpwd = new System.Windows.Forms.TextBox();
            this.role = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userID
            // 
            this.userID.AutoSize = true;
            this.userID.Location = new System.Drawing.Point(69, 71);
            this.userID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userID.Name = "userID";
            this.userID.Size = new System.Drawing.Size(56, 20);
            this.userID.TabIndex = 0;
            this.userID.Text = "user id";
            this.userID.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(165, 66);
            this.txtUserId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(228, 26);
            this.txtUserId.TabIndex = 1;
            this.txtUserId.Leave += new System.EventHandler(this.txtUserId_Leave);
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Location = new System.Drawing.Point(46, 111);
            this.firstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(86, 20);
            this.firstName.TabIndex = 2;
            this.firstName.Text = "First Name";
            this.firstName.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(165, 106);
            this.txtFirstname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(228, 26);
            this.txtFirstname.TabIndex = 3;
            this.txtFirstname.Leave += new System.EventHandler(this.txtFirstname_Leave);
            // 
            // fatherName
            // 
            this.fatherName.AutoSize = true;
            this.fatherName.Location = new System.Drawing.Point(30, 154);
            this.fatherName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fatherName.Name = "fatherName";
            this.fatherName.Size = new System.Drawing.Size(102, 20);
            this.fatherName.TabIndex = 4;
            this.fatherName.Text = "Father Name";
            this.fatherName.Click += new System.EventHandler(this.label3_Click);
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Location = new System.Drawing.Point(50, 194);
            this.userName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(83, 20);
            this.userName.TabIndex = 5;
            this.userName.Text = "Username";
            this.userName.Click += new System.EventHandler(this.label4_Click);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(46, 234);
            this.password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(78, 20);
            this.password.TabIndex = 6;
            this.password.Text = "Password";
            this.password.Click += new System.EventHandler(this.label5_Click);
            // 
            // confirmPassword
            // 
            this.confirmPassword.AutoSize = true;
            this.confirmPassword.Location = new System.Drawing.Point(32, 274);
            this.confirmPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.confirmPassword.Name = "confirmPassword";
            this.confirmPassword.Size = new System.Drawing.Size(102, 20);
            this.confirmPassword.TabIndex = 7;
            this.confirmPassword.Text = "Confirm pass";
            // 
            // txtFathername
            // 
            this.txtFathername.Location = new System.Drawing.Point(165, 149);
            this.txtFathername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFathername.Name = "txtFathername";
            this.txtFathername.Size = new System.Drawing.Size(228, 26);
            this.txtFathername.TabIndex = 8;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(165, 189);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(228, 26);
            this.txtUsername.TabIndex = 9;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(165, 229);
            this.txtPwd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(228, 26);
            this.txtPwd.TabIndex = 10;
            // 
            // txtCpwd
            // 
            this.txtCpwd.Location = new System.Drawing.Point(165, 269);
            this.txtCpwd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCpwd.Name = "txtCpwd";
            this.txtCpwd.PasswordChar = '*';
            this.txtCpwd.Size = new System.Drawing.Size(228, 26);
            this.txtCpwd.TabIndex = 11;
            // 
            // role
            // 
            this.role.AutoSize = true;
            this.role.Location = new System.Drawing.Point(88, 314);
            this.role.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(42, 20);
            this.role.TabIndex = 12;
            this.role.Text = "Role";
            // 
            // cmbRole
            // 
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "Sys Admin",
            "Student",
            "Staff"});
            this.cmbRole.Location = new System.Drawing.Point(165, 309);
            this.cmbRole.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(180, 28);
            this.cmbRole.TabIndex = 13;
            this.cmbRole.SelectedIndexChanged += new System.EventHandler(this.cmbRole_SelectedIndexChanged);
            this.cmbRole.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmbRole_KeyUp);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(86, 365);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(112, 35);
            this.btnLogin.TabIndex = 14;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(250, 365);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 35);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(54, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(299, 29);
            this.label8.TabIndex = 16;
            this.label8.Text = "User Registeration Form";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(426, 438);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.role);
            this.Controls.Add(this.txtCpwd);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtFathername);
            this.Controls.Add(this.confirmPassword);
            this.Controls.Add(this.password);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.fatherName);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.userID);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userID;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.Label fatherName;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label confirmPassword;
        private System.Windows.Forms.TextBox txtFathername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtCpwd;
        private System.Windows.Forms.Label role;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label8;
    }
}

