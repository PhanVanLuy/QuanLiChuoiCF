using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLiChuoiCF.DTO
{
    public class Supplier
    {
        public Supplier() { }

        private Supplier(string iDOfSupplier, string name, string address)
        {
            this.IDOfSupplier = iDOfSupplier;
            this.Name = name;
            this.Address = address;
        }

        public Supplier(DataRow row)
        {
            this.IDOfSupplier = row["IDOfSupplier"].ToString().Trim();
            this.Name = row["Name"].ToString().Trim();
            this.Address = row["Address"].ToString().Trim();
        }

        private string iDOfSupplier;
        private string name;
        private string address;

        public string IDOfSupplier { get => iDOfSupplier; set => iDOfSupplier = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
    }
}
