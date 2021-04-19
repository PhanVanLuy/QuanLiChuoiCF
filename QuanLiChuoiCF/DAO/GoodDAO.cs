using QuanLiChuoiCF.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiChuoiCF.DAO
{
    class GoodDAO
    {
        private static GoodDAO instance;
        public static GoodDAO Instance
        {
            get { if (instance == null) instance = new GoodDAO(); return instance; }
            private set { instance = value; }
        }

        public List<Good> GetGoods()
        {
            List<Good> goods = new List<Good>();
            string query = "select * from dbo.Goods";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                goods.Add(new Good(item));
            }
            return goods;
        }

        public bool AddGood(string iDOfMaterial, string name, int amount, string unit, string price)
        {
            string query = string.Format("insert dbo.Goods(IDOfMaterial, Name, Amount, Unit, Price) values(N'{0}', N'{1}', {2},N'{3}','{4}')");
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public bool UpdateGood(string iDOfMaterial, string name, int amount, string unit, string price)
        {
            string query = string.Format("update dbo.Goods set Name =  N'{1}', Amount = {2}, Unit = N'{3}, Price = '{4}' where IDOfMaterial = N'{0}'",iDOfMaterial, name, amount, unit, price);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public bool DeleteGood(string iDOfMaterial)
        {
            string query = string.Format("delete dbo.Goods where IDOfMaterial = N'{0}'", iDOfMaterial);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

    }
}
