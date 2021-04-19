using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLiChuoiCF.DTO;

namespace QuanLiChuoiCF.DAO
{
    class DetailOfBillExportDAO
    {
        private static DetailOfBillExportDAO instance;
        public static DetailOfBillExportDAO Instance
        {
            get { if (instance == null) instance = new DetailOfBillExportDAO(); return instance; }
            private set { instance = value; }
        }
        private DetailOfBillExportDAO() { }

        public List<DetailOfBillExport> GetDetailOfBillExports()
        {
            List<DetailOfBillExport> detailOfBillExports = new List<DetailOfBillExport>();
            string query = "select * from dbo.DetailOfBillExport";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                detailOfBillExports.Add(new DetailOfBillExport(item));
            }
            return detailOfBillExports;
        }

        public bool AddDetailOfBillExport(string iDOfBillExport, string iDOfMaterial, int count)
        {
            string query = string.Format("insert dbo.DetailOfBillExport(IDOfBillExport, IDOfMaterial, Count) values ('{0}','{1}',{2})", iDOfBillExport, iDOfMaterial, count);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public bool UpdateDetailOfBillExport(string iDOfBillExport, string iDOfMaterial, int count)
        {
            string query = string.Format("update dbo.DetailOfBillExport set Count = {2} where IDOfBillExport = '{0}' and IDOfMaterial = '{1}'", iDOfBillExport, iDOfMaterial, count);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public bool DeleteDetailOfBillExport(string iDOfBillExport, string iDOfMaterial)
        {
            string query = string.Format("delete dbo.DetailOfBillExport where IDOfBillExport = '{0}' and IDOfMaterial = '{1}'", iDOfBillExport, iDOfMaterial);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
}
}
