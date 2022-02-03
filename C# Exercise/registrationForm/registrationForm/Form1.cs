using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace registrationForm
{
    public partial class Form1 : Form
    {
        public static string data;
        public Form1()
        {
            InitializeComponent();
            this.loginUserNametxtbox.Focus();
        }

        private void SignUpbtn_Click(object sender, EventArgs e)
        {
            user usr = new user();
            usr.username = usrnametxtbox.Text;
            usr.password = passwdtxtbox.Text;
            DBclass dbcls = new DBclass();
            dbcls.registerUser(usr);
            MessageBox.Show("Registration Successful");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            string username = loginUserNametxtbox.Text;
            string password = loginPasswdtxtbox.Text;
            DBclass db = new DBclass();
            
            if (db.authenticateUser(username, password)==0)
            {
                MessageBox.Show("Invalid Username/Password");
                loginUserNametxtbox.Clear();
                loginPasswdtxtbox.Clear();
                loginUserNametxtbox.Focus();
            }
            else
            {
                user.usrname = username;
                this.Hide();
                   home homepage = new home();
                homepage.Show();
                homepage.team1lbl.Text = db.setTeam(1, 1);
                homepage.team2lbl.Text = db.setTeam(1, 2);
                MemoryStream ms = new MemoryStream(db.setImage(1, 1));
                homepage.team1logo.Image = Image.FromStream(ms);
                MemoryStream ms2 = new MemoryStream(db.setImage(1, 2));
                homepage.team2logo.Image = Image.FromStream(ms2);

            }
        }
    }
}
