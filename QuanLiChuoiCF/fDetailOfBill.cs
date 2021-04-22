using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiChuoiCF.DAO;
using QuanLiChuoiCF.DTO;

namespace QuanLiChuoiCF
{
    public partial class fDetailOfBill : Form
    {
        public fDetailOfBill(string iDOfBill)
        {
            InitializeComponent();
            this.IDOfBill = iDOfBill;
            Load();
        }
        private void Load()
        {
            List<DetailOfBill> detailOfBills = new List<DetailOfBill>();
            detailOfBills = DetailOfBillDAO.Instance.GetDetailOfBills(iDOfBill);
            foreach(DetailOfBill item in detailOfBills)
            {
                Drink drink = new Drink();
                foreach(Drink tmp in fAdmin.drinks)
                {
                    if (item.IDOfDrink == tmp.ID)
                    {
                        drink = tmp;
                        break;
                    }
                }
                ListViewItem lsvItem = new ListViewItem(drink.Name.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(drink.Price.ToString());
                int totalAmount = item.Count * drink.Price;
                lsvItem.SubItems.Add(totalAmount.ToString());
                lsvDetailOfBill.Items.Add(lsvItem);
            }
        }

        private string iDOfBill;

        public string IDOfBill { get => iDOfBill; set => iDOfBill = value; }
    }
}
