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
        public Bill(string id, DateTime? dateCheckIn,int status,string iDOfbranch)
        {
            this.ID = id;
            this.DateCheckIn = dateCheckIn;
            this.IDOfbranch = iDOfbranch;
            this.Status = status;
        }
        public Bill( DataRow row)
        {
            this.ID = ((string)row["IDOfBill"]).Trim();
            this.IDOfbranch = (string)row[" IDOfbranch"];
            this.DateCheckIn = (DateTime?)row["DateCheckIn"];         
            this.Status = (int)row["Status"];
        }

        public Bill()
        {
            this.ID = "HD00";
            this.DateCheckIn =null;
            this.IDOfbranch = "";
            this.Status = 0;
        }

        private int status;
        private DateTime? dateCheckIn;
        private string iD;
        private string iDOfbranch;

        public string IDOfbranch { get => iDOfbranch; set => iDOfbranch = value; }
        public int Status { get => status; set => status = value; }
        public DateTime? DateCheckIn { get => dateCheckIn; set => dateCheckIn = value; }
        public string ID { get => iD; set => iD = value; }
    }
}
