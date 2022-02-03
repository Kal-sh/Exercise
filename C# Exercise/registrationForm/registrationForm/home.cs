using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace registrationForm
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            panel1.BackColor = Color.LightBlue;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = SystemColors.Control;
        }
        private void home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            DBclass db = new DBclass();
            if (!contentpane.Controls.Contains(odds_UserControl.Instance))
            {
                contentpane.Controls.Add(odds_UserControl.Instance);
                odds_UserControl.Instance.Dock = DockStyle.Fill;
                odds_UserControl.Instance.BringToFront();
                odds_UserControl.Instance.homelabel.Text = team1lbl.Text;
                odds_UserControl.Instance.awaylabel.Text = team2lbl.Text;
                odds_UserControl.Instance.btnHomeWin.Text = db.setOdds(1, 1);
                odds_UserControl.Instance.setHomePage(this);
            }
            else
            {
                odds_UserControl.Instance.BringToFront();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void betTextBox_TextChanged(object sender, EventArgs e)
        {
            double win_money;
            try
            {
                win_money = double.Parse(betTextBox.Text) * double.Parse(oddlabel.Text);
                winMoneylbl.Text = win_money.ToString();
            }
            catch (FormatException fe) { if (string.IsNullOrEmpty(betTextBox.Text)) winMoneylbl.Text = oddlabel.Text; }
        }

        private void btnBet_Click(object sender, EventArgs e)
        {
            DBclass db = new DBclass();
            try {
                db.makeBet(int.Parse(betTextBox.Text), int.Parse(winMoneylbl.Text));
            }
            catch(FormatException fe)
            {
                MessageBox.Show("Invalid Input");
            }
        }

        private void contentpane_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

   

