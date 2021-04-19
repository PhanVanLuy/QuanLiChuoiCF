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
        private BillExport(string iDOfBillExport, string idOfBranch, DateTime Date, int totalAmount)
        {
            this.IDOfBillExport = iDOfBillExport;
            this.IdOfBranch = idOfBranch;
            this.Date = Date;
            this.TotalAmount = totalAmount;
        }

        public BillExport(DataRow row)
        {
            this.IDOfBillExport = (row["IDOfBillExport"].ToString()).Trim();
            this.IdOfBranch = (row["IDOfBranch"].ToString()).Trim();
            this.Date = (DateTime)row["Date"];
            this.totalAmount = (int)float.Parse((row["totalAmount"].ToString()));
        }

        private string iDOfBillExport;
        private string idOfBranch;
        private DateTime Date;
        private int totalAmount;

        public string IDOfBillExport { get => iDOfBillExport; set => iDOfBillExport = value; }
        public DateTime Date1 { get => Date; set => Date = value; }
        public string IdOfBranch { get => idOfBranch; set => idOfBranch = value; }
        public int TotalAmount { get => totalAmount; set => totalAmount = value; }
    }
}
