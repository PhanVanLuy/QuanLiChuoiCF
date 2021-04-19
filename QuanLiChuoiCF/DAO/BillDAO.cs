using QuanLiChuoiCF.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLiChuoiCF.DAO
{
    class BillDAO
    {
        private static BillDAO instance;
        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return instance; }
            private set { instance = value; }
        }

        private BillDAO() { }

        public List<Bill> GetBills()
        {
            List<Bill> bills = new List<Bill>();
            string query = "select * from dbo.Bill ORDER BY IDOfBill";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                bills.Add(new Bill(item));
            }

            return bills;
        }

        public bool AddBill(string idOfBill, string iDOfbranch, DateTime dateCheckIn, int totalAmount)
        {
            DateTime myDateTime = dateCheckIn;
            string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd");
            string query = string.Format("insert dbo.Bill(IDOfBill, IDOfBranch, DateCheckIn, TotalAmount) values ('{0}', '{1}', '{2}', {3})", idOfBill, iDOfbranch, sqlFormattedDate, totalAmount);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public bool UpdateBill(string idOfBill, string iDOfbranch, DateTime dateCheckIn, int totalAmount)
        {
            DateTime myDateTime = dateCheckIn;
            string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd");
            string query = string.Format("update dbo.Bill set IDOfBranch = '{1}', DateCheckIn = '{2}', TotalAmount = {3} where IDOfBill = '{0}'", idOfBill, iDOfbranch, sqlFormattedDate, totalAmount);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public bool DeleteBill(string idOfBill)
        {
            string query = string.Format("delete dbo.Bill where IDOfBill = '{0}'", idOfBill);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

    }
}
