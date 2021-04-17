using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiChuoiCF.DTO
{
    class Good
    {
        public Good(string iDOfMaterial, string name, int amount, string unit, string price)
        {
            this.iDOfMaterial = iDOfMaterial;
            this.name = name;
            this.amount = amount;
            this.unit = unit;
            this.price = price;
        }

        public Good(DataRow rows)
        {
            this.iDOfMaterial = rows["IDOfMaterial"].ToString();
            this.name = rows["Name"].ToString();
            this.amount = (int)rows["Amount"];
            this.unit = rows["Unit"].ToString();
            this.price = rows["Price"].ToString();
        }

        private string iDOfMaterial;
        private string name;
        private int amount;
        private string unit;
        private string price;

        public string IDOfMaterial { get => iDOfMaterial; set => iDOfMaterial = value; }
        public string Name { get => name; set => name = value; }
        public int Amount { get => amount; set => amount = value; }
        public string Unit { get => unit; set => unit = value; }
        public string Price { get => price; set => price = value; }
    }
}
