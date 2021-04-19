using QuanLiChuoiCF.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiChuoiCF.DAO
{
    class WarehouseMaterial
    {
        private static WarehouseMaterial instance;
        public static WarehouseMaterial Instance
        {
            get { if (instance == null) instance = new WarehouseMaterial(); return instance; }
            private set { instance = value; }
        }

        public List<MaterialInWarehouse> GetMaterials()
        {
            List<MaterialInWarehouse> materials = new List<MaterialInWarehouse>();
            string query = "select * from dbo.WarehouseMaterial ORDER BY IDOfImportMaterial";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                materials.Add(new MaterialInWarehouse(item));
            }
            return materials;
        }

        public bool AddMaterial(string iDOfImportMaterial, string iDOfMaterial, int amount, int amountLeft, DateTime dateAdded, DateTime expiryDate)
        {
            DateTime myDateTime1 = dateAdded;
            string dateAddedConverted = myDateTime1.ToString("yyyy-MM-dd");
            DateTime myDateTime2 = expiryDate;
            string expiryDateConverted = myDateTime2.ToString("yyyy-MM-dd");
            string query = string.Format("insert dbo.WarehouseMaterial(IDOfImportMaterial,IDOfMaterial, Amount, AmountLeft, DateAdded, ExpiryDate) values('{0}', '{1}', {2}, {3}, '{4}', '{5}')",iDOfImportMaterial, iDOfMaterial, amount, amountLeft, dateAddedConverted, expiryDateConverted);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public bool UpdateMaterial(string iDOfImportMaterial, string iDOfMaterial, int amount, int amountLeft, DateTime dateAdded, DateTime expiryDate)
        {
            DateTime myDateTime1 = dateAdded;
            string dateAddedConverted = myDateTime1.ToString("yyyy-MM-dd");
            DateTime myDateTime2 = expiryDate;
            string expiryDateConverted = myDateTime2.ToString("yyyy-MM-dd");
            string query = string.Format("update dbo.WarehouseMaterial set IDOfMaterial = '{1}', Amount = {2}, AmountLeft = {3}, DateAdded = '{4}', ExpiryDate = '{5}' where IDOfImportMaterial = '{0}'", iDOfImportMaterial, iDOfMaterial, amount, amountLeft, dateAddedConverted, expiryDateConverted);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public bool DeleteMaterial(string iDOfImportMaterial)
        {
            string query = string.Format("delete dbo.WarehouseMaterial where IDOfImportMaterial = '{0}'", iDOfImportMaterial);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

    }
}
