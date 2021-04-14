using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiChuoiCF.DTO
{
    public class Menu
    {
        private string iDOfBill;
        private string iDOfDrink;
        private int count;
        private double money;
        public Menu(string iDOfBill, string iDofDrink, int count, double money)
        {
            this.IDOfDrink = iDOfDrink;
            this.IDOfBill = iDOfBill;
            this.Count = count;
            this.Money = money;
        }
        public Menu (DataRow row )
        {
            this.IDOfDrink = (string)row["iDOfDrink"];
            this.IDOfBill = (string)row["iDOfBill"];
            this.Count = (int)row["count"];
            this.Money = (double)row["money"];
        }
            
        public string IDOfBill { get => iDOfBill; set => iDOfBill = value; }
        public string IDOfDrink { get => iDOfDrink; set => iDOfDrink = value; }
        public int Count { get => count; set => count = value; }
        public double Money { get => money; set => money = value; }
    }
}
