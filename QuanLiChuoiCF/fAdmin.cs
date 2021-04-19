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
        BindingSource drinks = new BindingSource();
        BindingSource branches = new BindingSource();
        public static BindingSource accounts = new BindingSource();
        public static BindingSource employees = new BindingSource();
        BindingSource goods = new BindingSource();
        string lastIDDrink;
        string lastIDBranch;
        string lastIDAccount;
        public static string lastIDEmployees;
        string lastIDGood;

        public string LastID { get => lastIDDrink; set => lastIDDrink = value; }

        public fAdmin()
        {
            InitializeComponent();
            LoadAndBinding();
        }
        void LoadAndBinding()
        {
            dtgvCF.DataSource = drinks;
            dtgvBranches.DataSource = branches;
            dtgvAccount.DataSource = accounts;
            dtgvEmployees.DataSource = employees;
            dtgvGoods.DataSource = goods;

            LoadDrinks();
            LoadBranches();
            LoadEmployees();
            LoadAccounts();
            LoadGoods();

            AddDrinkBinding();
            AddBranchBinding();
            AddEmployeeBinding();
            AddAccountBinding();
            AddGoodBinding();

        }

        #region loadAndBinding
        void LoadDrinks()
        {
            List<Drink> data = DrinkDAO.Instance.GetListDrinks();
            drinks.DataSource = data;
            Drink[] arr = data.ToArray();
            if (arr.Length > 0) 
            { 
                lastIDDrink = arr[arr.Length - 1].ID; 
            }
            else
            {
                lastIDDrink = "DU01";
            }
        }

        void LoadBranches()
        {
            List<Branch> data = BranchDAO.Instance.GetBranches();
            branches.DataSource = data;
            Branch[] arr = data.ToArray();
            if (arr.Length > 0)
            {
                lastIDBranch = arr[arr.Length - 1].Id;
            }
            else
            {
                lastIDBranch = "CN01";
            }
        }

        void LoadEmployees()
        {
            List<Employee> data = EmployeeDAO.Instance.GetEmployees();
            employees.DataSource = data;
            Employee[] arr = data.ToArray();
            if(arr.Length>0)lastIDEmployees = arr[arr.Length - 1].IDOfEmployee;

            UpdateCbbSexualInTabEmployee();
            UpdateCbbShiftInTabEmployee();
            UpdateCbbBranchInTabEmployee();
        }

        void LoadAccounts()
        {
            List<Account> data = AccountDAO.Instance.GetAccounts();
            accounts.DataSource = data;
            Account[] arr = data.ToArray();
            if(arr.Length>0)lastIDAccount = arr[arr.Length - 1].Id;

            UpdateCbbAccountTypeInTabEmployee();
            UpdateCbbAccountIdInTabAccount();
        }

        void LoadGoods()
        {
            List<MaterialInWarehouse> data = WarehouseMaterial.Instance.GetMaterials();
            goods.DataSource = data;
            MaterialInWarehouse[] arr = data.ToArray();
            if (arr.Length > 0) lastIDGood = arr[arr.Length - 1].IDOfMaterial;
        }

        void AddDrinkBinding()
        {
            txb_Drink_ID.DataBindings.Add(new Binding("Text", dtgvCF.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txb_Drink_Name.DataBindings.Add(new Binding("Text", dtgvCF.DataSource, "Name", true, DataSourceUpdateMode.Never));
            nud_Drink_Price.DataBindings.Add(new Binding("Text", dtgvCF.DataSource, "Price", true, DataSourceUpdateMode.Never));
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
            cbb_Account_ID.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txb_Account_UserName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "DisplayName", true, DataSourceUpdateMode.Never));
            cbb_Account_AccountType.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "Type", true, DataSourceUpdateMode.Never));
        }

        void AddGoodBinding()
        {
            txb_Good_ID.DataBindings.Add(new Binding("Text", dtgvGoods.DataSource, "IDOfMaterial", true, DataSourceUpdateMode.Never));
            txb_Good_Name.DataBindings.Add(new Binding("Text", dtgvGoods.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txb_Good_Amount.DataBindings.Add(new Binding("Text", dtgvGoods.DataSource, "Amount", true, DataSourceUpdateMode.Never));
            txb_Good_Unit.DataBindings.Add(new Binding("Text", dtgvGoods.DataSource, "Unit", true, DataSourceUpdateMode.Never));
            txb_Good_Price.DataBindings.Add(new Binding("Text", dtgvGoods.DataSource, "Price", true, DataSourceUpdateMode.Never));
        }

        #endregion

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
        private void tpClick(object sender, EventArgs e)
        {
            switch (tab.SelectedTab.Text)
            {
                case "Money":
                    break;
                case "Drink":
                    LoadDrinks();
                    break;
                case "Branch":
                    LoadBranches();
                    break;
                case "Account":
                    LoadAccounts();
                    break;
                case "Employee":
                    LoadEmployees();
                    break;
                case "Good":
                    LoadGoods();
                    break;

            }
        }
        
        #region eventsDrink
        private void btnAddDrinkClick(object sender, EventArgs e)
        {
            string id = txb_Drink_ID.Text;
            foreach(Drink item in drinks)
            {
                if(id == item.ID)
                {
                    lb_Drink_Notify.Text = "NOTIFY: ID can't be duplicated";
                    return;
                }
            }

            string name = txb_Drink_Name.Text.Trim();
            if(name == "")
            {
                lb_Drink_Notify.Text = "NOTIFY: Name can't be empty";
                return;
            }

            int price = (int)nud_Drink_Price.Value;
            if (price == 0)
            {
                lb_Drink_Notify.Text = "NOTIFY: Price can't be lower than 0";
                return;
            }

            if (DrinkDAO.Instance.AddDrink(id, name, price))
            {
                MessageBox.Show("Drink Was Added Successfully");
                LoadDrinks();
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
            string id = txb_Drink_ID.Text;
            string name = txb_Drink_Name.Text.Trim();
            if (name == "")
            {
                lb_Drink_Notify.Text = "NOTIFY: Name can't be  empty";
                return;
            }

            int price = (int)nud_Drink_Price.Value;
            if (price == 0)
            {
                lb_Drink_Notify.Text = "NOTIFY: Price can't be lower than 0";
                return;
            }
            if (MessageBox.Show("Are you sure you want to update this drink", "Update Drink", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) != System.Windows.Forms.DialogResult.Yes)
            {
                return;
            }
            if (DrinkDAO.Instance.UpdateDrink(id, name, price))
            {
                MessageBox.Show("Drink Was Updated Successfully");
                LoadDrinks();
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
            string id = txb_Drink_ID.Text;
            if (DrinkDAO.Instance.DeleteDrink(id))
            {
                MessageBox.Show("Drink Was Deleted Successfully", "DELETE");
                LoadDrinks();
                if (deleteDrink != null)
                    deleteDrink(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Failed To Delete Drink");
            }
        }
        private void btnShowClicked(object sender, EventArgs e)
        {
            LoadDrinks();
        }

        private void btnNewDrinkClick(object sender, EventArgs e)
        {
            int lastIDrink_int = Int16.Parse(lastIDDrink.Substring(2)) + 1;
            string id;
            if (lastIDrink_int < 10)
            {
                id = "DU0" + lastIDrink_int.ToString();
            }
            else
            {
                id = "DU" + lastIDrink_int.ToString();
            }
            txb_Drink_ID.Text = id;
            txb_Drink_Name.Text = "";
            nud_Drink_Price.Value = 10000;
        }
        #endregion


        #region accountEvents
        private void btnAddAccountClick(object sender, EventArgs e)
        {
            fNewAccount f = new fNewAccount();
            f.ShowDialog();
            LoadAccounts();
        }

        private void btnDeleteAccountClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this Account", "Delete Account", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) != System.Windows.Forms.DialogResult.Yes)
            {
                return;
            }
            string id = cbb_Account_ID.Text;
            if (AccountDAO.Instance.DeleteAccount(id))
            {
                lb_Account_Notify.Text = "Account was deleted Successfully";
                LoadAccounts();
            }
            else
            {
                lb_Account_Notify.Text = "Failed to delete Account";
            }
        }

        private void btnUpdateAccountClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to update this Account", "Update Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) != System.Windows.Forms.DialogResult.Yes)
            {
                return;
            }
            string id = cbb_Account_ID.Text;
            string displayName = txb_Account_UserName.Text;
            int type = int.Parse(cbb_Account_AccountType.Text);
            if (AccountDAO.Instance.UpdateAccount(id, displayName, type))
            {
                lb_Account_Notify.Text = "NOTIFY: Account was updated Successfully";
                LoadAccounts();
            }
            else
            {
                lb_Account_Notify.Text = "Failed to update Account";
            }
        }


        private void btn_Account_ChangePasswordClick(object sender, EventArgs e)
        {
            Account account = new Account();
            foreach(Account item in accounts)
            {
                if(item.Id == cbb_Account_ID.Text)
                {
                    account = item;
                    break;
                }
            }
            fChangePassword f = new fChangePassword(account);
            f.ShowDialog();
            LoadAccounts();
        }

        private void btnAccountNewClick(object sender, EventArgs e)
        {
            cbb_Account_ID.SelectedItem = cbb_Account_ID.Items[0];
            txb_Account_UserName.Text = "";
            cbb_Account_AccountType.SelectedItem = cbb_Account_AccountType.Items[0];
        }

        private void btnRefreshAccountsClick(object sender, EventArgs e)
        {
            LoadAccounts();
        }

        #endregion

        #region noUse
        private void tabPage1_Click(object sender, EventArgs e)
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

        private void btnRefreshClicked(object sender, EventArgs e)
        {

        }
        #endregion

        #region EmployeesEvent
        private void btnAddEmployeeClick(object sender, EventArgs e)
        {
            string firstName = txb_Employee_FirstName.Text.Trim();
            string lastName = txb_Employee_LastName.Text.Trim();
            string id = txb_Employee_IDOfEmPloyee.Text.Trim();
            string phoneNumber = txb_Employee_PhoneNumber.Text.Trim();
            string sexual = cbb_Employee_Sexual.SelectedItem.ToString();
            string address = txb_Employee_Address.Text.Trim();
            DateTime dayIn = dtp_Employee_DayIn.Value;
            string shift = cbb_Employee_Shift.SelectedItem.ToString();
            int dayOff = (int)nud_Employee_DayOff.Value;
            int bonus = (int)nud_Employee_Bonus.Value;
            int salary = (int)nud_Employee_Salary.Value;
            string iDOfBranch = cbb_Employee_IDOfBranch.SelectedItem.ToString();
            if (EmployeeDAO.Instance.AddEmployee(firstName, lastName, id, phoneNumber, sexual, address,
                dayIn, shift, dayOff, bonus, salary, iDOfBranch))
            {
                lb_Employee_Notify.Text = "NOTIFY: Employee was added Successfully";
                LoadEmployees();
                newEmployee();
            }
            else
            {
                lb_Employee_Notify.Text = "NOTIFY: Failed to added Employee";
                newEmployee();
            }
        }

        private void btnDeleteEmployeeClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this Employee", "Delete Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) != System.Windows.Forms.DialogResult.Yes)
            {
                return;
            }
            string id = txb_Employee_IDOfEmPloyee.Text.Trim();
            if(EmployeeDAO.Instance.DeleteEmployee(id))
            {
                lb_Employee_Notify.Text = "NOTIFY: Employee was deleted Successfully";
                LoadEmployees();
            }
            else
            {
                lb_Employee_Notify.Text = "NOTIFY: Failed to delete Employee";
            }
        }

        private void btnUpdateEmployeeClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to update this Employee", "Update Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) != System.Windows.Forms.DialogResult.Yes)
            {
                return;
            }
            string firstName = txb_Employee_FirstName.Text.Trim();
            string lastName = txb_Employee_LastName.Text.Trim();
            string id = txb_Employee_IDOfEmPloyee.Text.Trim();
            string phoneNumber = txb_Employee_PhoneNumber.Text.Trim();
            string sexual = cbb_Employee_Sexual.SelectedItem.ToString();
            string address = txb_Employee_Address.Text.Trim();
            DateTime dayIn = dtp_Employee_DayIn.Value;
            string shift = cbb_Employee_Shift.SelectedItem.ToString();
            int dayOff = (int)nud_Employee_DayOff.Value;
            int bonus = (int)nud_Employee_Bonus.Value;
            int salary = (int)nud_Employee_Salary.Value;
            string iDOfBranch = cbb_Employee_IDOfBranch.SelectedItem.ToString();
            if (EmployeeDAO.Instance.UpdateEmployee(firstName, lastName, id, phoneNumber, sexual, address, dayIn, 
                shift, dayOff, bonus, salary, iDOfBranch))
            {
                lb_Employee_Notify.Text = "NOTIFY: Employee was updated Successfully";
                LoadEmployees();
            }
            else
            {
                lb_Employee_Notify.Text = "NOTIFY: Failed to update Employee";
            }
        }

        private void btnRefreshEmployeesClick(object sender, EventArgs e)
        {
            LoadEmployees();
        }

        private void btnNewEmployeeClick(object sender, EventArgs e)
        {
            newEmployee();
        }

        private void btnSearchEmployeesClick(object sender, EventArgs e)
        {

        }
        #endregion

        #region BranchEvents
        private void btnAddBranchClick(object sender, EventArgs e)
        {
            string branchId = txb_branch_ID.Text.Trim();
            foreach(Branch item in branches)
            {
                if(branchId == item.Id)
                {
                    lb_Branch_Notify.Text = "Can not added";
                    return;
                }
            }
            string branchName = txb_branch_Name.Text.Trim();
            if(branchName == "")
            {
                lb_Branch_Notify.Text = "Name can't be empty";
                return;
            }
            string manager = txb_branch_Manager.Text.Trim();
            if(manager == "")
            {
                lb_Branch_Notify.Text = "Manager can't be empty";
                return;
            }
            if (BranchDAO.Instance.AddBranch(branchId, branchName, manager))
            {
                lb_Branch_Notify.Text = "Branch Was Added Successfully";
                LoadBranches();
                newBrand();
            }
            else
            {
                lb_Branch_Notify.Text = "Failed To Added Branch";
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
                lb_Branch_Notify.Text = "Branch Was Deleted Successfully";
                LoadBranches();
            }
            else
            {
                lb_Branch_Notify.Text = "Failed To Delete Branch";
            }
        }

        private void btnUpdateBranchClick(object sender, EventArgs e)
        {
            string branchID = txb_branch_ID.Text.Trim();
            string branchName = txb_branch_Name.Text.Trim();
            string manager = txb_branch_Manager.Text.Trim();
            if (branchName == "")
            {
                lb_Branch_Notify.Text = "Name can't be empty";
                return;
            }
            if(manager == "")
            {
                lb_Branch_Notify.Text = "Manager can't be empty";
                return;
            }
            if (MessageBox.Show("Are you sure you want to update this branch", "Update branch", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) != System.Windows.Forms.DialogResult.Yes)
            {
                return;
            }
            if (BranchDAO.Instance.UpdateBranch(branchID, branchName, manager))
            {
                lb_Branch_Notify.Text = "Branch Was Updated Successfully";
                LoadBranches();
            }
            else
            {
                lb_Branch_Notify.Text = "Failed To Update Branch";
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

        #region GoodEvent

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

        private void newEmployee()
        {
            int lastIDEmployee_int = Int16.Parse(lastIDEmployees.Substring(2)) + 1;
            string id;
            if (lastIDEmployee_int < 10)
            {
                id = "NV0" + lastIDEmployee_int.ToString();
            }
            else
            {
                id = "NV" + lastIDEmployee_int.ToString();
            }

            txb_Employee_FirstName.Text = "";
            txb_Employee_LastName.Text = "";
            txb_Employee_IDOfEmPloyee.Text = id;
            txb_Employee_PhoneNumber.Text = "";
            cbb_Employee_Sexual.SelectedItem = cbb_Employee_Sexual.Items[0];
            txb_Employee_Address.Text = "";
            dtp_Employee_DayIn.Value = DateTime.Today;
            nud_Employee_DayOff.Value = 10;
            cbb_Employee_Shift.SelectedItem = cbb_Employee_Shift.Items[0];
            nud_Employee_Bonus.Value = 100000;
            nud_Employee_Salary.Value = 5000000;
            cbb_Employee_IDOfBranch.SelectedItem = cbb_Employee_IDOfBranch.Items[0];

        }

        private void UpdateCbbBranchInTabEmployee()
        {
            cbb_Employee_IDOfBranch.Items.Clear();
            foreach (Branch item in branches)
            {
                cbb_Employee_IDOfBranch.Items.Add(item.Id);
            }
        }

        private void UpdateCbbSexualInTabEmployee()
        {
            cbb_Employee_Sexual.Items.Clear();
            cbb_Employee_Sexual.Items.Add("Female");
            cbb_Employee_Sexual.Items.Add("Male");
            cbb_Employee_Sexual.Items.Add("Other");
        }

        private void UpdateCbbShiftInTabEmployee()
        {
            cbb_Employee_Shift.Items.Clear();
            cbb_Employee_Shift.Items.Add("Day");
            cbb_Employee_Shift.Items.Add("Morning");
            cbb_Employee_Shift.Items.Add("Noon");
            cbb_Employee_Shift.Items.Add("Afternoon");
            cbb_Employee_Shift.Items.Add("Night");
            cbb_Employee_Shift.Items.Add("Midnight");
        }

        private void UpdateCbbAccountTypeInTabEmployee()
        {
            cbb_Account_AccountType.Items.Clear();
            cbb_Account_AccountType.Items.Add("0");
            cbb_Account_AccountType.Items.Add("1");
        }

        private void UpdateCbbAccountIdInTabAccount()
        {
            cbb_Account_ID.Items.Clear();
            foreach(Employee employee in employees)
            {
                cbb_Account_ID.Items.Add(employee.IDOfEmployee);
            }
        }
    }
}
