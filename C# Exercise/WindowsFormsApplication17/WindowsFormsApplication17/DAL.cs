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
        private string constr = "SERVER=KAL; Database=sql;integrated Security=true;";

        public DataTable getUer(string fn, string ln)
        {
            SqlConnection con = new SqlConnection(constr);
            SqlDataAdapter adapter = new SqlDataAdapter("spGetUser", con);

            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddWithValue("@fn", fn);
            adapter.SelectCommand.Parameters.AddWithValue("@ln", ln);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "tUser");
            DataTable dt = ds.Tables["tUser"];
            return dt;
        }

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
                cmd.Parameters.AddWithValue("@photo", photo);

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