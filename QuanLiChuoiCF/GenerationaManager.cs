using QuanLiChuoiCF.DAO;
using QuanLiChuoiCF.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLiChuoiCF
{
    public partial class fTableManager : Form
    {
        private static List<Drink> drinks;
        private static int totalPrice;

        public static List<Drink> Drinks { get => drinks; set => drinks = value; }
        public static int TotalPrice { get => totalPrice; set => totalPrice = value; }

        public fTableManager()
        {
            InitializeComponent();
            LoadDrink();
        }
        #region Method
       
        void LoadDrink()
        {
            flpDrink.Controls.Clear();
            cbb_addDrink.Items.Clear();
            Drinks = DrinkDAO.Instance.GetListDrinks();
            foreach (Drink item in Drinks)
            {
                Button btn = new Button()
                {
                    Width = DrinkDAO.TableWidth,
                    Height = DrinkDAO.TableHeight
                };
                btn.Text = item.Name + Environment.NewLine+ item.Price;
                btn.Click += btn_Click;
                btn.Tag = item;
                flpDrink.Controls.Add(btn);
                flpDrink.FlowDirection = FlowDirection.LeftToRight;
                cbb_addDrink.Items.Add(item.Name);
            }

        }

        #endregion
        #region events
        void btn_Click(object sender, EventArgs e)
        {
            string drinkID = ((sender as Button).Tag as Drink).ID;
            foreach (Drink item in Drinks)
            {
                if(item.ID == drinkID)
                {
                    cbb_addDrink.SelectedItem = item.Name;
                    break;
                }
            }
        }
        void btn_AddDrink_click(object sender, EventArgs e)
        {
            string name = cbb_addDrink.Text;
            if (name == "") return;
            int count = Convert.ToInt32(numericUpDown1.Value);
            numericUpDown1.Value = 1;
            int price = 0, totalPriceRow;

            //get price from drinks list
            foreach (Drink item in Drinks)
            {
                if (item.Name == name)
                {
                    price = item.Price;
                    break;
                }
            }
            foreach(ListViewItem item in lsvBill.Items)
            {
                if (name == item.SubItems[0].Text)
                {
                    int last_count = int.Parse(item.SubItems[1].Text);

                    if(count + last_count <= 0)
                    {
                        item.Remove();
                        return;
                    }

                    totalPriceRow = (count + last_count) * price;
                    totalPrice += count * price;
                    item.SubItems[1].Text = (count+last_count).ToString();
                    item.SubItems[2].Text = price.ToString();
                    item.SubItems[3].Text = totalPriceRow.ToString();
                    txbTotalPrice.Text = totalPrice.ToString();

                    return;
                }
            }

            totalPriceRow = price * count;
            ListViewItem lsvItem = new ListViewItem(name);
            lsvItem.SubItems.Add(count.ToString());
            lsvItem.SubItems.Add(price.ToString());
            lsvItem.SubItems.Add(totalPriceRow.ToString());
            totalPrice += totalPriceRow;

            lsvBill.Items.Add(lsvItem);
            txbTotalPrice.Text = totalPrice.ToString();
        }
        private void fTableManager_Load(object sender, EventArgs e)
        {

        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            f.InsertDrink += f_InsertDrink;
            f.DeleteDrink += f_DeleteDrink;
            f.UpdateDrink += f_UpdateDrink;
            f.ShowDialog();

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccountProfile f = new fAccountProfile();
            f.ShowDialog();

        }
        
        private void flpBranch_Paint(object sender, PaintEventArgs e)
        {

        }

        void f_UpdateDrink(object sender, EventArgs e)
        {
            LoadDrink();
        }

        void f_DeleteDrink(object sender, EventArgs e)
        {
            LoadDrink();
        }

        void f_InsertDrink(object sender, EventArgs e)
        {
            LoadDrink();
        }

        #endregion

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbb_addDrink_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDeleteOrderClick(object sender, EventArgs e)
        {
            if(lsvBill.SelectedItems.Count > 0)
            {
                lsvBill.SelectedItems[0].Remove();
            }
        }

        private void labelCount_Click(object sender, EventArgs e)
        {

        }

        private void lsvSelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvBill.SelectedItems.Count > 0)
            {
                var item = lsvBill.SelectedItems[0];
                cbb_addDrink.SelectedItem = item.SubItems[0].Text;
                numericUpDown1.Value = int.Parse(item.SubItems[1].Text);
            }
        }

        private void numericUpDown1Click(object sender, EventArgs e)
        {
            if (lsvBill.SelectedItems.Count > 0)
            {
                var item = lsvBill.SelectedItems[0];
                item.SubItems[1].Text = numericUpDown1.Value.ToString();
            }
        }

    }
}
