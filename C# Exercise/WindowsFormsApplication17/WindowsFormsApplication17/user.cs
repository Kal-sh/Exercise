﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication17
{
    internal class user
    {
        public string UserID;
        public string FirstName;
        public string FatherName;
        public string Username;
        public string pwd;
        public string comboBox1;

        public user(string UserID, string FirstName, string FatherName, string Username, string pwd, string comboBox1, string text)
        {
            this.UserID = UserID;
            this.FirstName = FirstName;
            this.FatherName = FatherName;
            this.Username = Username;
            this.pwd = pwd;
            this.comboBox1 = comboBox1;
        }

        public void saveUser()
        {
            MessageBox.Show(this.UserID + " " + this.FirstName + " " + FatherName + " " + Username + " " + pwd + " " + comboBox1);
            DAL dal = new DAL();
            dal.saveUser(this);
        }
    }
}