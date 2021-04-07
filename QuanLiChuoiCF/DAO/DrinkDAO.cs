using QuanLiChuoiCF.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiChuoiCF.DAO
{
    class DrinkDAO
    {
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
            public List<Drink> LoadTableList()
            {
                List<Drink> DrinkList = new List<Drink>();
                return DrinkList;
            }

        }

    }

