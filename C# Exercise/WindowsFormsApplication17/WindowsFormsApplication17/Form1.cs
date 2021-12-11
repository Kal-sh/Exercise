using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string pwd = txtPwd.Text;
            string cpwd = txtCpwd.Text;
            if (cpwd.CompareTo(pwd) == 0)
            {
                MessageBox.Show("the same");
                user u = new user(txtUserId.Text, txtFirstname.Text, txtFathername.Text, txtUsername.Text, txtPwd.Text, txtCpwd.Text, cmbRole.Text);
                u.saveUser();
            }
            else
            {
                MessageBox.Show("not the same");
            }
        }

        private void txtUserId_Leave(object sender, EventArgs e)
        {
            //MessageBox.Show("I'm Leaving");
        }

        private void txtFirstname_Leave(object sender, EventArgs e)
        {
            txtUsername.Text = txtFirstname.Text.Substring(0, 1).ToUpper() + txtFirstname.Text.Substring(1).ToLower();
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cmbRole_KeyUp(object sender, KeyEventArgs e)
        {
            cmbRole.Text = " ";
        }
    }
}