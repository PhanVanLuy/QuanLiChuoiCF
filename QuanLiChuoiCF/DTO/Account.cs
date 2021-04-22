using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiChuoiCF.DTO
{
    public class Account
    {
        private Account(string username, string iDOfEmployee, string password, int type)
        {
            this.Username = username;
            this.IDOfEmployee = iDOfEmployee;
            this.Password = password;
            this.Type = type;
        }

        public Account() { }

        public Account(DataRow row)
        {
            this.Username = ((string)row["Username"]).Trim();
            this.IDOfEmployee = ((string)row["IDOfEmployee"]).Trim();
            this.Password = ((string)row["Password"]).Trim(); ;
            this.Type = (int)row["Type"];
        }

        private string username;
        private string iDOfEmployee;
        private string password;
        private int type;

        public string Username { get => username; set => username = value; }
        public string IDOfEmployee { get => iDOfEmployee; set => iDOfEmployee = value; }
        public string Password { get => password; set => password = value; }
        public int Type { get => type; set => type = value; }
    }
}
