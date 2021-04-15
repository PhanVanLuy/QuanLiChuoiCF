using QuanLiChuoiCF.DAO;
using QuanLiChuoiCF.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiChuoiCF
{
    public partial class fAdmin : Form
    {
        BindingSource drinkList = new BindingSource();
        string lastID;

        public string LastID { get => lastID; set => lastID = value; }

        public fAdmin()
        {
            InitializeComponent();
            Load();
        }
        void Load()
        {
            dtgvCF.DataSource = drinkList;

            LoadAccountList();
            LoadDrinkList();
            AddDrinkBinding();
        }
        void LoadAccountList()
        {
            String query = "exec dbo.USP_GetAccountByUserName @userName";
            dtgvTaiKhoan.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[] { "NV01" });
        }
        void LoadDrinkList()
        {
            List<Drink> data = DrinkDAO.Instance.GetListDrinks();
            drinkList.DataSource = data;
            Drink[] arr = data.ToArray();
            lastID = arr[arr.Length - 1].ID.Trim();
        }

        void AddDrinkBinding()
        {
            txbID.DataBindings.Add(new Binding("Text", dtgvCF.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txbDrinkName.DataBindings.Add(new Binding("Text", dtgvCF.DataSource, "Name", true, DataSourceUpdateMode.Never));
            nmPrice.DataBindings.Add(new Binding("Text", dtgvCF.DataSource, "Price", true, DataSourceUpdateMode.Never));
        }

        private event EventHandler insertDrink;
        public event EventHandler InsertDrink
        {
            add { insertDrink += value; }
            remove { insertDrink -= value; }
        }

        private event EventHandler updateDrink;
        public event EventHandler UpdateDrink
        {
            add { updateDrink += value; }
            remove { updateDrink -= value; }
        }

        private event EventHandler deleteDrink;
        public event EventHandler DeleteDrink
        {
            add { deleteDrink += value; }
            remove { deleteDrink -= value; }
        }

        #region events
        private void btnAddDrinkClick(object sender, EventArgs e)
        {
            int id_int = Int16.Parse(lastID.Substring(2)) + 1;
            string id;
            if (id_int < 10)
            {
                id = "DU0" + id_int.ToString();
            }
            else
            {
                id = "DU" + id_int.ToString();
            }
            string name = txbDrinkName.Text;
            int price = (int)nmPrice.Value;
            if (DrinkDAO.Instance.InsertDrink(id, name, price))
            {
                MessageBox.Show("added drink successful");
                LoadDrinkList();
                if (insertDrink != null)
                    insertDrink(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("added drink failed");
            }
        }

        private void btnEditDrinkClick(object sender, EventArgs e)
        {
            string id = txbID.Text;
            string name = txbDrinkName.Text;
            int price = (int)nmPrice.Value;
            if (DrinkDAO.Instance.UpdateDrink(id, name, price))
            {
                MessageBox.Show("edit drink successful");
                LoadDrinkList();
                if (updateDrink != null)
                    updateDrink(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("edit drink failed");
            }
        }

        private void btnDeleteDrinkClick(object sender, EventArgs e)
        {
            string id = txbID.Text;
            if (DrinkDAO.Instance.DeleteDrink(id))
            {
                MessageBox.Show("edit drink successful");
                LoadDrinkList();
                if (deleteDrink != null)
                    deleteDrink(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("edit drink failed");
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tbTaiKhoan_Click(object sender, EventArgs e)
        {

        }
        
        private void tpDanhMuc_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void tabDrinkClick(object sender, EventArgs e)
        {
        }

        private void btnShowClicked(object sender, EventArgs e)
        {
            LoadDrinkList();
        }

        #endregion
    }
}
