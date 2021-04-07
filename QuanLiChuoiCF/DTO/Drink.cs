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
        private Drink(string iD,string name, string price      )
        {
            this.ID = iD;
            this.Name = name;
            this.Price = price;
        }
      
      
        public Drink(DataRow row )
        {
            this.ID = row["IDofDrink"].ToString();
            this.Name = row["name"].ToString();
            this.Price =row["price"].ToString();
        }
        public string Name { get => name; set => name = value; }
        public string Price { get => price; set => price = value; }
        public string ID { get => iD; set => iD = value; }
         private string iD;
        private string name;

        private string price;
    }
}
