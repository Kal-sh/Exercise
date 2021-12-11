using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication17
{
    internal class DAL
    {
        private string constr = "SERVER=________; Database=_______;integrated Security=true;";

        public void saveUser(user u)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("spInsertUser", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", u.UserID);
                cmd.Parameters.AddWithValue("@fName", u.FirstName);
                cmd.Parameters.AddWithValue("@lName", u.FatherName);
                cmd.Parameters.AddWithValue("uName", u.Username);
                cmd.Parameters.AddWithValue("@pwd", u.pwd);
                cmd.Parameters.AddWithValue("cBox", u.comboBox1);

                int rowAffected = cmd.ExecuteNonQuery();
                if (rowAffected > 0)
                {
                    MessageBox.Show("Save Successful");
                    con.Close();
                }
            }
        }
    }
}