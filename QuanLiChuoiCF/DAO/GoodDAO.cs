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

    }
}
