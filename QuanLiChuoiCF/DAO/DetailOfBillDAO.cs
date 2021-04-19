using QuanLiChuoiCF.DTO;
using System.Collections.Generic;
using System.Data;

namespace QuanLiChuoiCF.DAO
{
    public class DetailOfBillDAO
    {
        private static DetailOfBillDAO instance;
            
        public static DetailOfBillDAO Instance
        {
            get
            {
                if (instance == null) instance = new DetailOfBillDAO(); return instance;
            }
            private set => instance = value; 
        } 
        private DetailOfBillDAO() { }
        
        public List<DetailOfBill> GetDetailOfBills(string id)
        {
            List<DetailOfBill> listDetailOfBill = new List<DetailOfBill>();
            DataTable data = DataProvider.Instance.ExecuteQuery("Select *from dbo.DetailOfBill where  idofbill='" + id + "' ORDER BY IDOfBill, IDOfDrink");
            foreach(DataRow item in data.Rows)
            {
                DetailOfBill detail = new DetailOfBill(item);
                listDetailOfBill.Add(detail);
            }
            return listDetailOfBill;
        }

        //Nguy Hiem Khong Nen Dung
        public bool DeleteBillInfoByDrinkID(string id)
        {
            return DataProvider.Instance.ExecuteNonQuery("delete dbo.DetailOfBill where IDOfDrink = N'" + id +"'")>0;
        }

        public bool AddDetailOfBill(string iDOfBill, string iDOfDrink, int count)
        {
            string query = string.Format("insert dbo.DetailOfBill(IDOfBill, IDOfDrink, Count) values ('{0}', '{1}', {2}", iDOfBill, iDOfDrink, count);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public bool UpdateDetailOfBill(string iDOfBill, string iDOfDrink, int count)
        {
            string query = string.Format("update dbo.DetailOfBill set IDOfDrink = '{1}', Count = {2}) where IDOfBill = '{0}'", iDOfBill, iDOfDrink, count);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public bool DeleteDetailOfBill(string iDOfBill, string iDOfDrink)
        {
            string query = string.Format("delete dbo.DetailOfBill where IDOfBill = '{0}' and IDOfDrink = '{1}'", iDOfBill, iDOfDrink);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
}
}
