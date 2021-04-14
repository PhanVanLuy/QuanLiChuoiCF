using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiChuoiCF.DTO
{
    public class DetailOfBill
    {
        public DetailOfBill( string iDOfBill, int iDOfDrink, int count, float totalPrice)
        {
            this.IDOfBill = iDOfBill;
            this.IDOfDrink = IDOfDrink;
            this.Count = count;
            this.TotalPrice = totalPrice;
        }public DetailOfBill(DataRow row)
        {
            this.IDOfBill = row["iDOfBill"].ToString();
            this.IDOfDrink = row["IDOfDrink"].ToString();
            this.Count = (int)row["count"];
            this.TotalPrice =(float)Convert.ToDouble(row["TotalPrice"].ToString()); 
        }
        private int count;
        private string iDOfBill;
        private string iDOfDrink; 
        private float totalPrice; 
        public int Count { get => count; set => count = value; }
        public string IDOfBill { get => iDOfBill; set => iDOfBill = value; }
        public string IDOfDrink { get => iDOfDrink; set => iDOfDrink = value; }
        public float TotalPrice { get => totalPrice; set => totalPrice = value; }
    }
}
