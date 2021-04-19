using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiChuoiCF.DTO;
using System.Data;

namespace QuanLiChuoiCF.DAO
{
    class BillExportDAO
    {
        private static BillExportDAO instance;
        public static BillExportDAO Instance
        {
            get { if (instance == null) instance = new BillExportDAO(); return instance; }
            private set { instance = value; }
        }

        private BillExportDAO() { }

        public List<BillExport> GetBillExports()
        {
            List<BillExport> billExports = new List<BillExport>();
            string query = "select * from dbo.BillExport";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                billExports.Add(new BillExport(item));
            }
            return billExports;
        }

        public bool AddBillExport(string iDOfBillExport, string idOfBranch, DateTime date, int totalAmount)
        {
            DateTime myDateTime = date;
            string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd");
            string query = string.Format("insert dbo.BillExport(IDOfBillExport, IdOfBranch, Date, TotalAmount) values('{0}', '{1}', '{2}', {3})", iDOfBillExport, idOfBranch, sqlFormattedDate, totalAmount);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public bool UpdateBillExport(string iDOfBillExport, string idOfBranch, DateTime date, int totalAmount)
        {
            DateTime myDateTime = date;
            string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd");
            string query = string.Format("update dbo.BillExport set IdOfBranch = '{1}', Date = '{2}', TotalAmount = {3} where IDOfBillExport = '{0}'", iDOfBillExport, idOfBranch, sqlFormattedDate, totalAmount);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public bool DeleteBillExport(string iDOfBillExport)
        {
            string query = string.Format("delete dbo.BillExport where IDOfBillExport = {0}", iDOfBillExport);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
    }
}
