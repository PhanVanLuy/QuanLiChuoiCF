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
        
        public List<DetailOfBill> GetListDetailOfBill(string id)
        {
            List<DetailOfBill> listDetailOfBill = new List<DetailOfBill>();
            DataTable data = DataProvider.Instance.ExecuteQuery("Select *from dbo.DetailOfBill where  idofbill='" + id + "'");
            foreach(DataRow item in data.Rows)
            {
                DetailOfBill detail = new DetailOfBill(item);
                listDetailOfBill.Add(detail);
            }
            return listDetailOfBill;
        }
      
}   
}
