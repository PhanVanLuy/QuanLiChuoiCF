using QuanLiChuoiCF.DTO;
using System.Collections.Generic;
using System.Data;

namespace QuanLiChuoiCF.DAO
{
    class MenuDAO
    {
        private static MenuDAO instance;

        public static MenuDAO Instance 
        {
            get
            {
                if (instance == null) instance = new MenuDAO(); return MenuDAO.instance;
            }
            private  set => instance = value; 
        }
        private MenuDAO() { }
        public List<Menu> GetListMenu(string iD, string iDOfBranch)
        {
            List<Menu> listMenu = new List<Menu>();
            string query = "select dr.Name, de.Count, dr.Price, dr.Price*de.Count from dbo.DetailOfBill as de, dbo.Bill as bi, dbo.Drink as dr where de.IDOfBill = bi.IDOfBill and de.IDOfDrink = Dr.IDOfDrink and bi.IDOfBranch = '"+iDOfBranch+ "' and dr.IDOfDrink='"+iD+"'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                listMenu.Add(menu);
            }

            return listMenu;
        }
    }
}
