using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            /*
            string pwd = txtPwd.Text;
            string cpwd = txtCpwd.Text;
            if (cpwd.CompareTo(pwd) == 0)
            {
                MessageBox.Show("the same");
                user u = new user(txtUserId.Text, txtFirstname.Text, txtlastname.Text,
                    txtUsername.Text, txtPwd.Text, txtCpwd.Text, cmbRole.Text);
                u.saveUser();
            }
            else
            {
                MessageBox.Show("not the same");
            }
            */
            MemoryStream ms = new MemoryStream();
            picUser.BackgroundImage.Save(ms, picUser.BackgroundImage.RawFormat);
            byte[] photo = ms.ToArray();

            user u = new user(txtUserId.Text, txtFirstname.Text,
                txtlastname.Text,
                txtlastname.Text, txtEmail.Text, txtUsername.Text, txtPwd.Text, cmbRole.Text, photo);
            u.saveUser();
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

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "choose Photo (*.jpg; *.png; *.jpeg; *.bmp) | " + "*.jpg; *.png; *.jpeg; *.bmp;";
            if (op.ShowDialog() == DialogResult.OK)
            {
                picUser.BackgroundImage = Image.FromFile(op.FileName);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            user U = new user();
            DataTable dt = U.getUser(txtSfn.Text, txtSln.Text);
            dgvUser.DataSource = dt;
        }

        private void dgvUser_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtUserId.Text = dgvUser.CurrentRow.Cells[0].Value.ToString();
            txtFirstname.Text = dgvUser.CurrentRow.Cells[1].Value.ToString();
            txtlastname.Text = dgvUser.CurrentRow.Cells[2].Value.ToString();
            txtUsername.Text = dgvUser.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dgvUser.CurrentRow.Cells[4].Value.ToString();
            txtPwd.Text = dgvUser.CurrentRow.Cells[5].Value.ToString();
            cmbRole.Text = dgvUser.CurrentRow.Cells[6].Value.ToString();

            byte[] photo = (byte[])dgvUser.CurrentRow.Cells[7].Value;
            MemoryStream ms = new MemoryStream(photo);
            picUser.BackgroundImage = Image.FromStream(ms);
        }
    }
}