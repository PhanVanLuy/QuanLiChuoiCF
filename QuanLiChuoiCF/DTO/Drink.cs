using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiChuoiCF.DTO
{
    public  class Drink
    {
        private Drink(string iD,string name, int price )
        {
            this.ID = iD;
            this.Name = name;
            this.Price = price;
        }

        public Drink() { }
      
        public Drink(DataRow row )   
        {
            this.ID = (row["IDofDrink"].ToString()).Trim();
            this.Name = row["name"].ToString().Trim();
            this.Price = (int)float.Parse(row["price"].ToString());
        }
        public string ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }

        private string iD;
        private string name;
        private int price;
    }
}
