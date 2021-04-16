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
        BindingSource branches = new BindingSource();
        BindingSource accounts = new BindingSource();
        BindingSource employees = new BindingSource();
        string lastIDDrink;
        string lastIDBranch;
        string lastIDAccount;
        string lastIDEmployees;

        public string LastID { get => lastIDDrink; set => lastIDDrink = value; }

        public fAdmin()
        {
            InitializeComponent();
            Load();
        }
        void Load()
        {
            dtgvCF.DataSource = drinkList;
            dtgvBranches.DataSource = branches;
            dtgvAccount.DataSource = accounts;
            dtgvEmployees.DataSource = employees;

            LoadDrinkList();
            LoadBranches();
            LoadEmployees();
            LoadAccounts();

            AddDrinkBinding();
            AddBranchBinding();
            AddEmployeeBinding();
            AddAccountBinding();

        }

        void LoadDrinkList()
        {
            List<Drink> data = DrinkDAO.Instance.GetListDrinks();
            drinkList.DataSource = data;
            Drink[] arr = data.ToArray();
            lastIDDrink = arr[arr.Length - 1].ID;
        }

        void LoadBranches()
        {
            List<Branch> data = BranchDAO.Instance.GetBranches();
            branches.DataSource = data;
            Branch[] arr = data.ToArray();
            lastIDBranch = arr[arr.Length - 1].Id;
        }

        void LoadEmployees()
        {
            List<Employee> data = EmployeeDAO.Instance.GetEmployees();
            employees.DataSource = data;
            Employee[] arr = data.ToArray();
            lastIDEmployees = arr[arr.Length - 1].IDOfEmployee;
        }

        void LoadAccounts()
        {
            List<Account> data = AccountDAO.Instance.GetAccounts();
            accounts.DataSource = data;
            Account[] arr = data.ToArray();
            lastIDAccount = arr[arr.Length - 1].Id;
        }

        void AddDrinkBinding()
        {
            txbID.DataBindings.Add(new Binding("Text", dtgvCF.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txbDrinkName.DataBindings.Add(new Binding("Text", dtgvCF.DataSource, "Name", true, DataSourceUpdateMode.Never));
            nmPrice.DataBindings.Add(new Binding("Text", dtgvCF.DataSource, "Price", true, DataSourceUpdateMode.Never));
        }

        void AddBranchBinding()
        {
            txb_branch_ID.DataBindings.Add(new Binding("Text", dtgvBranches.DataSource, "Id", true, DataSourceUpdateMode.Never));
            txb_branch_Name.DataBindings.Add(new Binding("Text", dtgvBranches.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txb_branch_Manager.DataBindings.Add(new Binding("Text", dtgvBranches.DataSource, "Manager", true, DataSourceUpdateMode.Never));
        }

        void AddEmployeeBinding()
        {
            txb_Employee_FirstName.DataBindings.Add(new Binding("Text", dtgvEmployees.DataSource, "FirstName", true, DataSourceUpdateMode.Never));
            txb_Employee_LastName.DataBindings.Add(new Binding("Text", dtgvEmployees.DataSource, "LastName", true, DataSourceUpdateMode.Never));
            txb_Employee_IDOfEmPloyee.DataBindings.Add(new Binding("Text", dtgvEmployees.DataSource, "IDOfEmployee", true, DataSourceUpdateMode.Never));
            txb_Employee_PhoneNumber.DataBindings.Add(new Binding("Text", dtgvEmployees.DataSource, "PhoneNumber", true, DataSourceUpdateMode.Never));
            cbb_Employee_Sexual.DataBindings.Add(new Binding("Text", dtgvEmployees.DataSource, "Sexual", true, DataSourceUpdateMode.Never));
            txb_Employee_Address.DataBindings.Add(new Binding("Text", dtgvEmployees.DataSource, "Address", true, DataSourceUpdateMode.Never));
            dtp_Employee_DayIn.DataBindings.Add(new Binding("Text", dtgvEmployees.DataSource, "DayIn", true, DataSourceUpdateMode.Never));
            cbb_Employee_Shift.DataBindings.Add(new Binding("Text", dtgvEmployees.DataSource, "Shift", true, DataSourceUpdateMode.Never));
            nud_Employee_DayOff.DataBindings.Add(new Binding("Text", dtgvEmployees.DataSource, "DayOff", true, DataSourceUpdateMode.Never));
            nud_Employee_Bonus.DataBindings.Add(new Binding("Text", dtgvEmployees.DataSource, "Bonus", true, DataSourceUpdateMode.Never));
            nud_Employee_Salary.DataBindings.Add(new Binding("Text", dtgvEmployees.DataSource, "Salary", true, DataSourceUpdateMode.Never));
            cbb_Employee_IDOfBranch.DataBindings.Add(new Binding("Text", dtgvEmployees.DataSource, "IDOfBranch", true, DataSourceUpdateMode.Never));
        }

        void AddAccountBinding()
        {
            txb_Account_ID.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txb_Account_UserName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "DisplayName", true, DataSourceUpdateMode.Never));
            cbb_Account_AccountType.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "Password", true, DataSourceUpdateMode.Never));
        }

        #region DrinkHandler
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
        #endregion

        #region events
        #region eventsDrink
        private void btnAddDrinkClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to add this drink", "Add Drink", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) != System.Windows.Forms.DialogResult.Yes)
            {
                return;
            }
            int id_int = Int16.Parse(lastIDDrink.Substring(2)) + 1;
            string id;
            if (id_int < 10)
            {
                id = "DU0" + id_int.ToString();
            }
            else
            {
                id = "DU" + id_int.ToString();
            }
            string name = txbDrinkName.Text.Trim();
            int price = (int)nmPrice.Value;
            if (DrinkDAO.Instance.InsertDrink(id, name, price))
            {
                MessageBox.Show("Drink Was Added Successfully");
                LoadDrinkList();
                if (insertDrink != null)
                    insertDrink(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Failed To Added Drink");
            }
        }

        private void btnEditDrinkClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to update this drink", "Update Drink", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) != System.Windows.Forms.DialogResult.Yes)
            {
                return;
            }
            string id = txbID.Text;
            string name = txbDrinkName.Text;
            int price = (int)nmPrice.Value;
            if (DrinkDAO.Instance.UpdateDrink(id, name, price))
            {
                MessageBox.Show("Drink Was Updated Successfully");
                LoadDrinkList();
                if (updateDrink != null)
                    updateDrink(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Failed To Update Drink");
            }
        }

        private void btnDeleteDrinkClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this drink", "Delete Drink", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,MessageBoxDefaultButton.Button1) != System.Windows.Forms.DialogResult.Yes)
            {
                return;
            }
            string id = txbID.Text;
            if (DrinkDAO.Instance.DeleteDrink(id))
            {
                MessageBox.Show("Drink Was Deleted Successfully", "DELETE");
                LoadDrinkList();
                if (deleteDrink != null)
                    deleteDrink(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Failed To Delete Drink");
            }
        }
        #endregion

        #region accountEvents
        private void btnAddAccountClick(object sender, EventArgs e)
        {

        }

        private void btnDeleteAccountClick(object sender, EventArgs e)
        {

        }

        private void btnUpdateAccountClick(object sender, EventArgs e)
        {

        }

        private void btnAccountNewClick(object sender, EventArgs e)
        {

        }

        private void btnRefreshAccountsClick(object sender, EventArgs e)
        {

        }

        #endregion

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


        private void dtgvCF_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRefreshClicked(object sender, EventArgs e)
        {

        }

        private void labelAccountType_Click(object sender, EventArgs e)
        {

        }

        private void btnNewClick(object sender, EventArgs e)
        {

        }

        private void bntAddEmployee(object sender, EventArgs e)
        {

        }

        private void btnDeleteEmployee(object sender, EventArgs e)
        {

        }

        private void bntAddEmployeeClick(object sender, EventArgs e)
        {

        }

        private void btnDeleteEmployeeClick(object sender, EventArgs e)
        {

        }

        private void btnUpdateEmployeeClick(object sender, EventArgs e)
        {

        }

        private void btnRefreshEmployeesClick(object sender, EventArgs e)
        {

        }

        private void btnNewEmployeeClick(object sender, EventArgs e)
        {

        }

        private void btnSearchEmployeessListClick(object sender, EventArgs e)
        {

        }

        #region BranchEvents
        private void btnAddBranchClick(object sender, EventArgs e)
        {
            string branchId = txb_branch_ID.Text.Trim();
            foreach(Branch item in branches)
            {
                if(branchId == item.Id)
                {
                    lbNotify.Text = "Can not added";
                    return;
                }
            }
            string branchName = txb_branch_Name.Text.Trim();
            string manager = txb_branch_Manager.Text.Trim();
            if (BranchDAO.Instance.AddBranch(branchId, branchName, manager))
            {
                lbNotify.Text = "Branch Was Added Successfully";
                LoadBranches();
                newBrand();
            }
            else
            {
                lbNotify.Text = "Failed To Added Branch";
                newBrand();
            }
        }

        private void btnDeleteBranchClick(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to delete this branch", "Delete Branch", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) != System.Windows.Forms.DialogResult.Yes)
            {
                return;
            }
            string branchID = txb_branch_ID.Text.Trim();
            if (BranchDAO.Instance.DeleteBranch(branchID))
            {
                lbNotify.Text = "Branch Was Deleted Successfully";
                LoadBranches();
            }
            else
            {
                lbNotify.Text = "Failed To Delete Branch";
            }
        }

        private void btnUpdateBranchClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to update this branch", "Update branch", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) != System.Windows.Forms.DialogResult.Yes)
            {
                return;
            }
            string branchID = txb_branch_ID.Text.Trim();
            string branchName = txb_branch_Name.Text.Trim();
            string manager = txb_branch_Manager.Text.Trim();
            if (BranchDAO.Instance.UpdateBranch(branchID, branchName, manager))
            {
                lbNotify.Text = "Branch Was Updated Successfully";
                LoadBranches();
            }
            else
            {
                lbNotify.Text = "Failed To Update Branch";
            }
        }

        private void btnRefreshBranchClick(object sender, EventArgs e)
        {
            LoadBranches();
        }

        private void btnNewBranchClick(object sender, EventArgs e)
        {
            newBrand();
        }
        #endregion

        #endregion

        private void newBrand()
        {
            int lastIDBranch_int = Int16.Parse(lastIDBranch.Substring(2)) + 1;
            string id;
            if (lastIDBranch_int < 10)
            {
                id = "CN0" + lastIDBranch_int.ToString();
            }
            else
            {
                id = "CN" + lastIDBranch_int.ToString();
            }
            txb_branch_ID.Text = id;
            txb_branch_Name.Text = "";
            txb_branch_Manager.Text = "";
        }

    }
}
