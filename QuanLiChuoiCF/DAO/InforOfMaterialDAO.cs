using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiChuoiCF.DTO;
using System.Data;

namespace QuanLiChuoiCF.DAO
{
    class InforOfMaterialDAO
    {
        private static InforOfMaterialDAO instance;
        public static InforOfMaterialDAO Instance
        {
            get { if (instance == null) instance = new InforOfMaterialDAO(); return instance; }
            private set { instance = value; }
        }
        private InforOfMaterialDAO() { }

        public List<InforOfMaterial> GetInfoOfMaterials()
        {
            List<InforOfMaterial> infoOfMaterials = new List<InforOfMaterial>();
            string query = "select * from dbo.InforOfMaterial";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                infoOfMaterials.Add(new InforOfMaterial(item));
            }

            return infoOfMaterials;
        }

        public bool AddInfoOfMaterial(string iDOfMaterial, string name, string unit, int price, string iDOfSupplier)
        {
            string query = string.Format("insert InforOfMaterial(IDOfMaterial, Name, Unit, Price, IDOfMaterial) values ('{0}',N'{1}',N'{2}',{3},'{4})", iDOfMaterial, name, unit, price, iDOfSupplier);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public bool UpdateInfoOfMaterial(string iDOfMaterial, string name, string unit, int price, string iDOfSupplier)
        {
            string query = string.Format("update InforOfMaterial set Name = N'{1}', Unit = N'{2}', Price = {3}, IDOfSupplier = '{4}' where IDOfMaterial = '{0}'", iDOfMaterial, name, unit, price);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public bool DeleteInfoOfMaterial(string iDOfMaterial)
        {
            string query = string.Format("delete InforOfMaterial where IDOfMaterial = '{0}'", iDOfMaterial);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
    }
}
