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
        private Account(string id, string displayName, string password, int type)
        {
            this.id = id;
            this.displayName = displayName;
            this.password = password;
            this.type = type;
        }
        public Account(DataRow row)
        {
            this.id = ((string)row["ID"]).Trim();
            this.displayName = (string)row["DisplayName"];
            this.password = (string)row["Password"];
            this.type = (int)row["Type"];
        }

        private string id;
        private string displayName;
        private string password;
        private int type;

        public string Id { get => id; set => id = value; }
        public string DisplayName { get => displayName; set => displayName = value; }
        public string Password { get => password; set => password = value; }
        public int Type { get => type; set => type = value; }
    }
}
