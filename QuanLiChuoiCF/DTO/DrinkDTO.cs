using QuanLiChuoiCF.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiChuoiCF.DTO
{
    class DrinkDTO
    {
        private static  DrinkDTO instance;
        public static int TableWidth = 100;
        public static int TableHeigth = 100;
        internal static DrinkDTO Instance {
            get
            { if (instance == null) instance = new DrinkDTO(); return instance; }
            private set => instance = value;
        }
        private DrinkDTO() { }
        public List<Drink> LoadBranchList()
        {
            List<Drink> drinkList = new List<Drink>();
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetDrinkList");
            foreach(DataRow item in data.Rows)
            {
                Drink drink = new Drink(item); 
                drinkList.Add(drink);


            }
            return drinkList;
        }
    }
}
