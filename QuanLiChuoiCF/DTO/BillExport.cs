using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiChuoiCF.DTO
{
    public class BillExport
    {
        public BillExport() { }
        private BillExport(string iDOfBillExport, string idOfBranch, DateTime date, int totalAmount)
        {
            this.IDOfBillExport = iDOfBillExport;
            this.IdOfBranch = idOfBranch;
            this.Date = date;
            this.TotalAmount = totalAmount;
        }

        public BillExport(DataRow row)
        {
            this.IDOfBillExport = (row["IDOfBillExport"].ToString()).Trim();
            this.IdOfBranch = (row["IDOfBranch"].ToString()).Trim();
            this.Date = (DateTime)row["Date"];
            this.TotalAmount = (int)float.Parse((row["totalAmount"].ToString()));
        }

        private string iDOfBillExport;
        private string idOfBranch;
        private DateTime date;
        private int totalAmount;

        public string IDOfBillExport { get => iDOfBillExport; set => iDOfBillExport = value; }
        public DateTime Date { get => date; set => date = value; }
        public string IdOfBranch { get => idOfBranch; set => idOfBranch = value; }
        public int TotalAmount { get => totalAmount; set => totalAmount = value; }
    }
}
