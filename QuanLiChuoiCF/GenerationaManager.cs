using QuanLiChuoiCF.DAO;
using QuanLiChuoiCF.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Menu = QuanLiChuoiCF.DTO.Menu;

namespace QuanLiChuoiCF
{
    public partial class fTableManager : Form
    {
        public fTableManager()
        {
            InitializeComponent();
            //Bill bill = new Bill();
            LoadDrink();
        }
        #region Method
        public string getIDIncrea(string ID)
        {
            string iD_Temp;
            string numericID;
            int num;
            num = int.Parse(ID.Substring(2));
            if (num < 9)
            {
                numericID = ID.Substring(3);
                iD_Temp = ID.Substring(0, 3);
            }
            else
            {
                numericID = ID.Substring(2);
                iD_Temp = ID.Substring(0, 2);
            }
            num++;
            iD_Temp = String.Concat(iD_Temp, num);
            return iD_Temp;
        }
        void LoadDrink()
        {
            List<Drink> drinkList = DrinkDTO.Instance.LoadBranchList();
            foreach(Drink item in drinkList)
            {
                Button btn = new Button()
                {
                    Width = DrinkDTO.TableWidth,
                    Height = DrinkDTO.TableHeigth
                };
                btn.Text = item.Name + Environment.NewLine+item.Price ;
                btn.Click += btn_Click;
                btn.Tag = item;
                flpDrink.Controls.Add(btn);
                flpDrink.FlowDirection = FlowDirection.LeftToRight;
            }    

        }
        #endregion
        #region evnents
        void ShowBill(string iD)
        {
            //Tạm cho chi nhánh của nhân viên đăng nhập vào là chi nhánh quận 9
            // sau có câu lệnh: 	select Branch.IDOfBranch from dbo.Branch, dbo.Employee, dbo.Account where Branch.IDOfBranch=Employee.IDOfBranch and Employee.IDOfEmloyee='NV01      '
            // Để truy xuất đến chi nhánh mà nhân viên đã đăng nhập
            string iDOfBranch = "CN09";
            // lsvBill.Items.Clear();
            //Bill new_Bill = new Bill();
            //new_Bill.ID = getIDIncrea(new_Bill.ID);


            /* Này dùng để hiện thị trên listview, tuy nhiên phần quản lý nhiều chi nhánh thì ko cần*/
            float totalPrice=0;

            List<Menu> listDrink = MenuDAO.Instance.GetListMenu(iD, iDOfBranch);
            foreach (Menu item in listDrink)
            {
                ListViewItem lsvItem = new ListViewItem(item.DrinkName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                totalPrice += item.TotalPrice;

                lsvBill.Items.Add(lsvItem);
            }
            txbTotalPrice.Text = totalPrice.ToString();


        }
        void btn_Click(object sender, EventArgs e)
        {
            string drinkID = ((sender as Button).Tag as Drink).ID;
            ShowBill(drinkID);
        }
        private void fTableManager_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
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
        #endregion

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
