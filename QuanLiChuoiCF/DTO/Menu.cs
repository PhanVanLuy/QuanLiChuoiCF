using System;
using System.Data;

namespace QuanLiChuoiCF.DTO
{
    public class Menu
    {
        private string drinkName;
        private int count;
        private float price;
        private float totalPrice;
        public Menu(string foodName, int count, float price, float totalPrice = 0)
        {
            this.DrinkName = foodName;
            this.Count = count;
            this.price = price;
            this.TotalPrice = totalPrice;
        }public Menu(DataRow row)
        {
            this.DrinkName = row["Name"].ToString();
            int v = (int)row["count"];
            this.Count = v;
            this.Price = (float)Convert.ToDouble(row["price"].ToString());
            this.TotalPrice = (float)Convert.ToDouble(row["totalPrice"].ToString());
        }


        public string DrinkName{ get => drinkName; set => drinkName = value; }
        public float Price { get => price; set => price = value; }
        public float TotalPrice { get => totalPrice; set => totalPrice = value; }
        public int Count { get => count; set => count = value; }
    }
}
