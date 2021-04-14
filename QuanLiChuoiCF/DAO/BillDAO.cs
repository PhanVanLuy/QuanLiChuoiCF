using QuanLiChuoiCF.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiChuoiCF.DAO
{
    class BillDAO
    {
        private static BillDAO instance;
        public static BillDAO Instance
        {
            get
            {
                if(instance == null )
                {
                    instance = new BillDAO();
                }
                return BillDAO.instance;
            }
            private set
            {
                BillDAO.instance = value;
            }
        }
        private BillDAO() { }

        public string getBillID(string id)
        {
            DataTable  data= DataProvider.Instance.ExecuteQuery("Select bill.IDOfBill, IDOfBranch,DateCheckIn,Bill.Status from Bill, DetailOfBill where bill.IDOfBill=DetailOfBill.IDOfBill and dbo.DetailOfBill.IDOfDrink='DU01''" + id+"'");
            if(data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;
            }
            else
            {
                return "";
            }
        }
    }
}
