using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiChuoiCF.DTO
{
    public class Bill
    {
        public Bill(string idOfBill,string iDOfbranch, DateTime dateCheckIn, int totalAmount)
        {
            this.IDOfBill = idOfBill;
            this.IDOfBranch = iDOfbranch;
            this.DateCheckIn = dateCheckIn;
            this.TotalAmount = totalAmount;
        }
        public Bill( DataRow row)
        {
            this.IDOfBill = ((string)row["IDOfBill"]).Trim();
            this.IDOfBranch = ((string)row[" IDOfbranch"]).Trim();
            this.DateCheckIn = (DateTime)row["DateCheckIn"];
            this.TotalAmount = (int)float.Parse(row["TotalAmount"].ToString().Trim());
        }

        public Bill() { }

        private string iDOfBill;
        private string iDOfBranch;
        private DateTime dateCheckIn;
        private int totalAmount;

        public string IDOfBill { get => iDOfBill; set => iDOfBill = value; }
        public string IDOfBranch { get => iDOfBranch; set => iDOfBranch = value; }
        public DateTime DateCheckIn { get => dateCheckIn; set => dateCheckIn = value; }
        public int TotalAmount { get => totalAmount; set => totalAmount = value; }
    }
}
