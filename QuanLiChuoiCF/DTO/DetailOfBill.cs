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
        public DetailOfBill() { }

        public DetailOfBill(string iDOfBill, string iDOfDrink, int count)
        {
            this.IDOfBill = iDOfBill;
            this.IDOfDrink = iDOfDrink;
            this.Count = count;
        }
        
        public DetailOfBill(DataRow row)
        {
            this.IDOfBill = (row["iDOfBill"].ToString()).Trim();
            this.IDOfDrink = (row["IDOfDrink"].ToString()).Trim();
            this.Count = (int)row["count"];
        }

        private string iDOfBill;
        private string iDOfDrink;
        private int count;
        public int Count { get => count; set => count = value; }
        public string IDOfBill { get => iDOfBill; set => iDOfBill = value; }
        public string IDOfDrink { get => iDOfDrink; set => iDOfDrink = value; }
    }
}
