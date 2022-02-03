using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.IO;

namespace registrationForm
{
    class DBclass
    {
        string constr = "Server=.;database=bet_database;uid='Kal/kalec';pwd=;";
        public void registerUser(user usr)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("spInsertUser", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter username = new SqlParameter();
                username.ParameterName = "@username";
                username.Value = usr.username;
                cmd.Parameters.Add(username);

                SqlParameter passwd = new SqlParameter();
                passwd.ParameterName = "@password";
                passwd.Value = usr.password;
                cmd.Parameters.Add(passwd);

                cmd.ExecuteNonQuery();
            }
        }

        public int authenticateUser(string un, string pwd)
        {
            int role;
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand cmd = new SqlCommand("spAuthenticateUser", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", un);
            cmd.Parameters.AddWithValue("@password", pwd);
            try
            {
                role = (int)cmd.ExecuteScalar();
            }
            catch (NullReferenceException nre) { role = 0; }
            return role;
        }


        public string setTeam(int i, int j)
        {
            string team;
            string query = "SELECT team" + j + " FROM match WHERE matchID =" + i;
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            team = (string)cmd.ExecuteScalar();
            return team;
        }

        public string setOdds(int i, int j)
        {
            decimal odd;
            string query = "SELECT odds FROM Odds WHERE matchID = " + i + " and betID = " + j;
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            odd = (decimal)cmd.ExecuteScalar();
            return odd.ToString();
        }

        public byte[] setImage(int i, int j)
        {
            byte[] teamlogo;
            string query = "SELECT team" + j + "Logo FROM match WHERE matchID =" + i;
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            teamlogo = (byte[])cmd.ExecuteScalar();
            return teamlogo;
        }
        public int makeBet(int bet, int win)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                int betMade = 1;

                string query = "SELECT userID FROM Users WHERE userName='" + user.usrname + "'";
                con.Open();
                SqlCommand cmd = new SqlCommand("spInsertBetDetail", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter betMoney = new SqlParameter();
                betMoney.ParameterName = "@bet";
                betMoney.Value = bet;
                cmd.Parameters.Add(betMoney);

                SqlParameter winMoney = new SqlParameter();
                winMoney.ParameterName = "@win";
                winMoney.Value = win;
                cmd.Parameters.Add(winMoney);

                SqlCommand txtcmd = new SqlCommand(query, con);
                txtcmd.CommandType = CommandType.Text;
                int id = (int)txtcmd.ExecuteScalar();

                SqlParameter userID = new SqlParameter();
                userID.ParameterName = "@usrID";
                userID.Value = id;
                cmd.Parameters.Add(userID);

                cmd.ExecuteNonQuery();
                return betMade;
            }

        }

        public int insertBet(string team,string betType)
        {
            int betInserted=1;
            using (SqlConnection con = new SqlConnection(constr))
            {
                string query = "SELECT userID FROM Users WHERE userName='" + user.usrname + "'";
                string query1 = "SELECT matchID FROM match WHERE team1='" + team + "'";
                int btID;
                con.Open();
                SqlCommand txtcmd = new SqlCommand(query, con);
                txtcmd.CommandType = CommandType.Text;
                int id = (int)txtcmd.ExecuteScalar();

                SqlCommand txtcmd1 = new SqlCommand(query1, con);
                txtcmd1.CommandType = CommandType.Text;
                int mID = (int)txtcmd1.ExecuteScalar();

                SqlCommand cmd = new SqlCommand("spInsertBet", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter userID = new SqlParameter();
                userID.ParameterName = "@usrID";
                userID.Value = id;
                cmd.Parameters.Add(userID);

                SqlParameter matchID = new SqlParameter();
                matchID.ParameterName = "@matchID";
                matchID.Value = mID;
                cmd.Parameters.Add(matchID);

                SqlParameter betID = new SqlParameter();
                betID.ParameterName = "@betID";
                if (betType.Equals("btnHomeWin"))
                {
                    btID = 1;
                    betID.Value = btID;
                }
                cmd.Parameters.Add(betID);
                try {
                    cmd.ExecuteNonQuery();
                }
                catch(SqlException se)
                {
                    betInserted = 0;
                }
                return betInserted;
            }
        }
    }
}