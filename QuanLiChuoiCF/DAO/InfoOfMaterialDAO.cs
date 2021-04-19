using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiChuoiCF.DTO;
using System.Data;

namespace QuanLiChuoiCF.DAO
{
    class InfoOfMaterialDAO
    {
        private static InfoOfMaterialDAO instance;
        public static InfoOfMaterialDAO Instance
        {
            get { if (instance == null) instance = new InfoOfMaterialDAO(); return instance; }
            private set { instance = value; }
        }
        private InfoOfMaterialDAO() { }

        public List<InfoOfMaterial> GetInfoOfMaterialDAOs()
        {
            List<InfoOfMaterial> infoOfMaterials = new List<InfoOfMaterial>();
            string query = "select * from dbo.InfoOfMaterial";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                infoOfMaterials.Add(new InfoOfMaterial(item));
            }

            return infoOfMaterials;
        }

        public bool AddInfoOfMaterial(string iDOfMaterial, string name, string unit, int price)
        {
            string query = string.Format("insert InfoOfMaterial(IDOfMaterial, Name, Unit, Price) values ('{0}',N'{1}',N'{2}',{3})", iDOfMaterial, name, unit, price);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public bool UpdateInfoOfMaterial(string iDOfMaterial, string name, string unit, int price)
        {
            string query = string.Format("update InfoOfMaterial set Name = N'{1}', Unit = N'{2}', Price = {3} where IDOfMaterial = '{0}'", iDOfMaterial, name, unit, price);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public bool DeleteInfoOfMaterial(string iDOfMaterial)
        {
            string query = string.Format("delete InfoOfMaterial where IDOfMaterial = '{0}'", iDOfMaterial);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
    }
}
