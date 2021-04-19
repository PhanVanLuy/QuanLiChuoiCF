using QuanLiChuoiCF.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiChuoiCF.DAO
{
    class SupplierDAO
    {
        private static SupplierDAO instance;

        SupplierDAO() { }

        internal static SupplierDAO Instance 
        {
            get { if (instance == null) instance = new SupplierDAO(); return instance; }
            private set => instance = value; 
        }
        public List<Supplier> GetSuppliers()
        {
            List<Supplier> bills = new List<Supplier>();
            string query = "select * from dbo.Supplier ORDER BY IDOfSupplier";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                bills.Add(new Supplier(item));
            }

            return bills;
        }
        public bool AddSupplier(string idOfSupplier, string Name,string Address)
        {
         
            string query = string.Format("insert dbo.Supplier(IDOfSupplier, Name, Address) values ('{0}', '{1}', '{2}')", idOfSupplier, Name, Address);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        public bool UpdateSupplier(string idOSupplier, string Name, string Address)
        {
            string query = string.Format("update dbo.Bill set Name = '{1}', Address = '{2}' where IDOfBill = '{0}'", idOSupplier, Name, Address);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        public bool DeleteSupplier(string iDOfSuplier)
        {
            string query = string.Format("delete dbo.Supplier where IDOfSupplier = '{0}'", iDOfSuplier);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
    }
}
