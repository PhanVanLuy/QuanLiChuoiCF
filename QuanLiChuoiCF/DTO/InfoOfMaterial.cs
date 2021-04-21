using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLiChuoiCF.DTO
{
    class InfoOfMaterial
    {
        public InfoOfMaterial() { }

        private InfoOfMaterial(string iDOfMaterial, string name, string unit, int price)
        {
            this.IDOfMaterial = iDOfMaterial;
            this.Name = name;
            this.Unit = unit;
            this.Price = price;
            this.IDOfSupplier = iDOfSupplier;

        }

        public InfoOfMaterial(DataRow row)
        {
            this.IDOfMaterial = row["IDOfMaterial"].ToString().Trim();
            this.Name = row["Name"].ToString().Trim();
            this.Unit = row["Unit"].ToString().Trim();
            this.Price = (int)float.Parse(row["Price"].ToString());
            this.IDOfSupplier = row["IDOfSupplier"].ToString().Trim();
        }

        private string iDOfMaterial;
        private string name;
        private string unit;
        private int price;
        private string iDOfSupplier;

        public string IDOfMaterial { get => iDOfMaterial; set => iDOfMaterial = value; }
        public string Name { get => name; set => name = value; }
        public string Unit { get => unit; set => unit = value; }
        public int Price { get => price; set => price = value; }
        public string IDOfSupplier { get => iDOfSupplier; set => iDOfSupplier = value; }
    }
}
