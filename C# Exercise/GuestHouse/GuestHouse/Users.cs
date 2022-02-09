using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GuestHouse
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=KAL;Initial Catalog=GuestHosueDB;Integrated Security=True");

        private void ShowUsers()
        {
            Con.Open();
            string Query = "select * from UserTbl";
            SqlDataAdapter sda=new SqlDataAdapter(Query,Con);
            SqlCommandBuilder builder=new SqlCommandBuilder(sda);
            var ds=new DataSet();
            sda.Fill(ds);
            UsersDGV.DataSource=ds.Tables[0];
        }
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (UnameTb.Text == "" || UphoneTb.Text == "" || UpassTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Insert into UserTbl(Uname,Uphone,Upass)values(@UN,@UP,@UPA)", Con);
                    cmd.Parameters.AddWithValue("@UN",UnameTb.Text);
                    cmd.Parameters.AddWithValue("@UP", UphoneTb.Text);
                    cmd.Parameters.AddWithValue("@UPA", UpassTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Saved");
                    Con.Close();
                    ShowUsers();
                }catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
