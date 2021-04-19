using QuanLiChuoiCF.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLiChuoiCF.DAO
{
    class DrinkDAO
    {
        public static int TableWidth =100;
        public static int TableHeight =100;

        private static DrinkDAO instance;
        public static DrinkDAO Instance
        {
            get
            {
                if (instance == null) instance = new DrinkDAO();
                return DrinkDAO.instance;
            }
            private set
            {
                DrinkDAO.instance = value;
            }
        }

        private DrinkDAO() { }
        public List<Drink> GetListDrinks()
        {
            List<Drink> DrinkList = new List<Drink>();
            string query = "select * from dbo.Drink ORDER BY IDOfDrink";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach(DataRow item in data.Rows)
            {
                Drink drink = new Drink(item);
                DrinkList.Add(drink);
            }

            return DrinkList;
        }

        public bool InsertDrink(string id,string name,  float price)
        {
            string query = string.Format("insert dbo.Drink(IDOfDrink,Name,Price)values(N'{0}', N'{1}', {2})", id, name,price);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateDrink(string id, string name, float price)
        {
            string query = string.Format("update dbo.Drink SET name = N'{0}', price = {1} where IDOfDrink = N'{2}'", name, price, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteDrink(string id)
        {
            DetailOfBillDAO.Instance.DeleteBillInfoByDrinkID(id);
            string query = "delete dbo.Drink where IDOfDrink = N'" + id + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }

}

