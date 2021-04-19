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
            this.Id = idBranch;
            this.Name = nameBranch;
            this.Manager = manager;
        }
        public Branch(DataRow row)
        {
            this.Id = ((string)row["IDOfBranch"]).Trim();
            this.Name = ((string)row["Name"]).Trim();
            this.Manager = ((string)row["Manager"]).Trim();
        }

        private string id;
        private string name;
        private string manager;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Manager { get => manager; set => manager = value; }
    }
}
