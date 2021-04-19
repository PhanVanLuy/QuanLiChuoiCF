using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiChuoiCF.DTO
{
    public class Branch
    {
        private Branch(string idBranch, string nameBranch, string manager)
        {
            this.id = idBranch;
            this.name = nameBranch;
            this.manager = manager;
        }
        public Branch(DataRow row)
        {
            this.Id = ((string)row["IDOfBranch"]).Trim();
            this.name = (string)row["Name"];
            this.manager = (string)row["Manager"];
        }

        private string id;
        private string name;
        private string manager;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Manager { get => manager; set => manager = value; }
    }
}
