namespace registrationForm
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
            this.usrnametxtbox = new System.Windows.Forms.TextBox();
            this.passwdtxtbox = new System.Windows.Forms.TextBox();
            this.Usrnamelbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SignUpbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.loginUserNametxtbox = new System.Windows.Forms.TextBox();
            this.loginPasswdtxtbox = new System.Windows.Forms.TextBox();
            this.Loginbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usrnametxtbox
            // 
            this.usrnametxtbox.Location = new System.Drawing.Point(80, 79);
            this.usrnametxtbox.Name = "usrnametxtbox";
            this.usrnametxtbox.Size = new System.Drawing.Size(100, 20);
            this.usrnametxtbox.TabIndex = 0;
            // 
            // passwdtxtbox
            // 
            this.passwdtxtbox.Location = new System.Drawing.Point(258, 79);
            this.passwdtxtbox.Name = "passwdtxtbox";
            this.passwdtxtbox.PasswordChar = '*';
            this.passwdtxtbox.Size = new System.Drawing.Size(100, 20);
            this.passwdtxtbox.TabIndex = 1;
            // 
            // Usrnamelbl
            // 
            this.Usrnamelbl.AutoSize = true;
            this.Usrnamelbl.Location = new System.Drawing.Point(17, 82);
            this.Usrnamelbl.Name = "Usrnamelbl";
            this.Usrnamelbl.Size = new System.Drawing.Size(60, 13);
            this.Usrnamelbl.TabIndex = 2;
            this.Usrnamelbl.Text = "UserName:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password:";
            // 
            // SignUpbtn
            // 
            this.SignUpbtn.Location = new System.Drawing.Point(384, 77);
            this.SignUpbtn.Name = "SignUpbtn";
            this.SignUpbtn.Size = new System.Drawing.Size(75, 23);
            this.SignUpbtn.TabIndex = 4;
            this.SignUpbtn.Text = "Sign Up";
            this.SignUpbtn.UseVisualStyleBackColor = true;
            this.SignUpbtn.Click += new System.EventHandler(this.SignUpbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Not a Member? Sign Up here!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password";
            // 
            // loginUserNametxtbox
            // 
            this.loginUserNametxtbox.Location = new System.Drawing.Point(152, 191);
            this.loginUserNametxtbox.Name = "loginUserNametxtbox";
            this.loginUserNametxtbox.Size = new System.Drawing.Size(100, 20);
            this.loginUserNametxtbox.TabIndex = 8;
            this.loginUserNametxtbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // loginPasswdtxtbox
            // 
            this.loginPasswdtxtbox.Location = new System.Drawing.Point(152, 242);
            this.loginPasswdtxtbox.Name = "loginPasswdtxtbox";
            this.loginPasswdtxtbox.PasswordChar = '*';
            this.loginPasswdtxtbox.Size = new System.Drawing.Size(100, 20);
            this.loginPasswdtxtbox.TabIndex = 9;
            this.loginPasswdtxtbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Loginbtn
            // 
            this.Loginbtn.Location = new System.Drawing.Point(283, 304);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(75, 23);
            this.Loginbtn.TabIndex = 10;
            this.Loginbtn.Text = "Log in";
            this.Loginbtn.UseVisualStyleBackColor = true;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 503);
            this.Controls.Add(this.Loginbtn);
            this.Controls.Add(this.loginPasswdtxtbox);
            this.Controls.Add(this.loginUserNametxtbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SignUpbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Usrnamelbl);
            this.Controls.Add(this.passwdtxtbox);
            this.Controls.Add(this.usrnametxtbox);
            this.Name = "Form1";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usrnametxtbox;
        private System.Windows.Forms.TextBox passwdtxtbox;
        private System.Windows.Forms.Label Usrnamelbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SignUpbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox loginPasswdtxtbox;
        private System.Windows.Forms.Button Loginbtn;
        public System.Windows.Forms.TextBox loginUserNametxtbox;
    }
}

