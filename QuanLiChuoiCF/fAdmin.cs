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
using System.Linq;

namespace QuanLiChuoiCF
{
    public partial class fAdmin : Form
    {
        public static List<Drink> drinks = new List<Drink>();
        public static List<Branch> branches = new List<Branch>();
        public static List<Account> accounts = new List<Account>();
        public static List<Employee> employees = new List<Employee>();
        public static List<InforOfMaterial> infoOfMaterials = new List<InforOfMaterial>();
        public static List<Supplier> suppliers = new List<Supplier>();
        public static List<Bill> bills = new List<Bill>();
        public static List<MaterialInWarehouse> materialInWarehouses = new List<MaterialInWarehouse>();
        public static string lastIDDrink;
        public static string lastIDBranch;
        public static string lastIDEmployees;
        public static string lastIDInfoOfMaterial;
        public static string lastIDBill;
        public static string lastIDSupplier;
        public static string lastIDMaterialInWarehouse;

        public fAdmin()
        {
            InitializeComponent();
            LoadAndBinding();
        }
        void LoadAndBinding()
        {
            LoadBranches();
            LoadSupplier();
            LoadDrinks();
            LoadEmployees();
            LoadAccounts();
            LoadInfoOfMaterial();
            LoadBill();
            LoadMaterialInWarehouse();

            AddDrinkBinding();
            AddBranchBinding();
            AddEmployeeBinding();
            AddAccountBinding();
            AddInfoOfMaterialBinding();
            AddBillBinding();
            AddSupplierBinding();
            AddMaterialInWarehouseBinding();


            cbb_Drink_SortBy.Items.Add("ID");
            cbb_Drink_SortBy.Items.Add("Drink Name");
            cbb_Drink_SortBy.Items.Add("Price");

            cbb_Drink_SearchBy.Items.Add("ID");
            cbb_Drink_SearchBy.Items.Add("Drink Name");
            cbb_Drink_SearchBy.Items.Add("Price");
            cbb_Drink_SearchBy.SelectedItem = cbb_Drink_SearchBy.Items[0];

            cbb_Branch_SortBy.Items.Add("ID");
            cbb_Branch_SortBy.Items.Add("Branch Name");
            cbb_Branch_SortBy.Items.Add("Manager");

            cbb_Branch_SearchBy.Items.Add("ID");
            cbb_Branch_SearchBy.Items.Add("Branch Name");
            cbb_Branch_SearchBy.Items.Add("Manager");
            cbb_Branch_SearchBy.SelectedItem = cbb_Branch_SearchBy.Items[0];

            cbb_Account_SortBy.Items.Add("User Name");
            cbb_Account_SortBy.Items.Add("ID of Employee");
            cbb_Account_SortBy.Items.Add("Type");

            cbb_Account_SearchBy.Items.Add("User Name");
            cbb_Account_SearchBy.Items.Add("ID of Employee");
            cbb_Account_SearchBy.Items.Add("Type");
            cbb_Account_SearchBy.SelectedItem = cbb_Account_SearchBy.Items[0];

            cbb_Employee_SortBy.Items.Add("ID of Employee");
            cbb_Employee_SortBy.Items.Add("First Name");
            cbb_Employee_SortBy.Items.Add("Last Name");
            cbb_Employee_SortBy.Items.Add("Phone Number");
            cbb_Employee_SortBy.Items.Add("Sexual");
            cbb_Employee_SortBy.Items.Add("Address");
            cbb_Employee_SortBy.Items.Add("Day In");
            cbb_Employee_SortBy.Items.Add("Day Off");
            cbb_Employee_SortBy.Items.Add("Shift");
            cbb_Employee_SortBy.Items.Add("Bonus");
            cbb_Employee_SortBy.Items.Add("Salary");
            cbb_Employee_SortBy.Items.Add("ID of Branch");

            cbb_Employee_SearchBy.Items.Add("ID of Employee");
            cbb_Employee_SearchBy.Items.Add("First Name");
            cbb_Employee_SearchBy.Items.Add("Last Name");
            cbb_Employee_SearchBy.Items.Add("Phone Number");
            cbb_Employee_SearchBy.Items.Add("Sexual");
            cbb_Employee_SearchBy.Items.Add("Address");
            cbb_Employee_SearchBy.Items.Add("Day In");
            cbb_Employee_SearchBy.Items.Add("Day Off");
            cbb_Employee_SearchBy.Items.Add("Shift");
            cbb_Employee_SearchBy.Items.Add("Bonus");
            cbb_Employee_SearchBy.Items.Add("Salary");
            cbb_Employee_SearchBy.Items.Add("ID of Branch");
            cbb_Employee_SearchBy.SelectedItem = cbb_Employee_SearchBy.Items[0];

            cbb_InfoOfMaterial_SortBy.Items.Add("ID of Material");
            cbb_InfoOfMaterial_SortBy.Items.Add("Name");
            cbb_InfoOfMaterial_SortBy.Items.Add("Unit");
            cbb_InfoOfMaterial_SortBy.Items.Add("Price");
            cbb_InfoOfMaterial_SortBy.Items.Add("ID of Supplier");

            cbb_InfoOfMaterial_SearchBy.Items.Add("ID of Material");
            cbb_InfoOfMaterial_SearchBy.Items.Add("Name");
            cbb_InfoOfMaterial_SearchBy.Items.Add("Unit");
            cbb_InfoOfMaterial_SearchBy.Items.Add("Price");
            cbb_InfoOfMaterial_SearchBy.Items.Add("ID of Supplier");
            cbb_InfoOfMaterial_SearchBy.SelectedItem = cbb_InfoOfMaterial_SearchBy.Items[0];

            cbb_Bill_SortBy.Items.Add("ID of Bill");
            cbb_Bill_SortBy.Items.Add("ID of Branch");
            cbb_Bill_SortBy.Items.Add("Day Check In");
            cbb_Bill_SortBy.Items.Add("Total Amount");

            cbb_Bill_SearchBy.Items.Add("ID of Bill");
            cbb_Bill_SearchBy.Items.Add("ID of Branch");
            cbb_Bill_SearchBy.Items.Add("Day Check In");
            cbb_Bill_SearchBy.Items.Add("Total Amount");
            cbb_Bill_SearchBy.SelectedItem = cbb_Bill_SearchBy.Items[0];

            cbb_Supplier_SortBy.Items.Add("ID of Supplier");
            cbb_Supplier_SortBy.Items.Add("Name");
            cbb_Supplier_SortBy.Items.Add("Address");

            cbb_Supplier_SearchBy.Items.Add("ID of Supplier");
            cbb_Supplier_SearchBy.Items.Add("Name");
            cbb_Supplier_SearchBy.Items.Add("Address");
            cbb_Supplier_SearchBy.SelectedItem = cbb_Supplier_SearchBy.Items[0];

            cbb_Warehouse_SortBy.Items.Add("ID of Import Material");
            cbb_Warehouse_SortBy.Items.Add("ID of Material");
            cbb_Warehouse_SortBy.Items.Add("Amount");
            cbb_Warehouse_SortBy.Items.Add("Amount Left");
            cbb_Warehouse_SortBy.Items.Add("Date Added");
            cbb_Warehouse_SortBy.Items.Add("Expiry Date");

            cbb_Warehouse_SearchBy.Items.Add("ID of Import Material");
            cbb_Warehouse_SearchBy.Items.Add("ID of Material");
            cbb_Warehouse_SearchBy.Items.Add("Amount");
            cbb_Warehouse_SearchBy.Items.Add("Amount Left");
            cbb_Warehouse_SearchBy.Items.Add("Date Added");
            cbb_Warehouse_SearchBy.Items.Add("Expiry Date");
            cbb_Warehouse_SearchBy.SelectedItem = cbb_Warehouse_SearchBy.Items[0];
        }

        #region loadAndBinding

        void LoadSupplier()
        {
            suppliers = SupplierDAO.Instance.GetSuppliers();
            dtgvSupplier.DataSource = suppliers;
            Supplier[] arr = suppliers.ToArray();
            if (arr.Length > 0)
            {
                lastIDSupplier = arr[arr.Length - 1].IDOfSupplier;
            }
            else
            {
                lastIDSupplier = "SP00";
            }
        }
        void LoadMaterialByIDOfSupplier()
        {
            List<InforOfMaterial> listInfoMaterial = InforOfMaterialDAO.Instance.GetInfoOfMaterials();
            string ID = txt_Supplier_ID.Text;
            List<InforOfMaterial> listMaterialByIDOfSupplier = new List<InforOfMaterial>();
            foreach (InforOfMaterial item in listInfoMaterial)
            {
                if (item.IDOfSupplier == ID)
                {
                    listMaterialByIDOfSupplier.Add(item);
                }
            }
            dtgv_Supplier_Material.DataSource = listMaterialByIDOfSupplier;
        }

        void LoadDrinks()
        {
            drinks = DrinkDAO.Instance.GetDrinks();
            dtgvCF.DataSource = drinks;
            Drink[] arr = drinks.ToArray();
            if (arr.Length > 0)
            {
                lastIDDrink = arr[arr.Length - 1].ID; 
            }
            else
            {
                lastIDDrink = "DR00";
            }
        }

        void LoadBranches()
        {
            branches = BranchDAO.Instance.GetBranches();
            dtgvBranches.DataSource = branches;
            Branch[] arr = branches.ToArray();
            if (arr.Length > 0)
            {
                lastIDBranch = arr[arr.Length - 1].Id;
            }
            else
            {
                lastIDBranch = "BR00";
            }
        }

        void LoadEmployees()
        {
            employees = EmployeeDAO.Instance.GetEmployees();
            dtgvEmployees.DataSource = employees;
            Employee[] arr = employees.ToArray();
            if(arr.Length>0) lastIDEmployees = arr[arr.Length - 1].IDOfEmployee;
                    else lastIDEmployees = "EM00";
        }

        void LoadAccounts()
        {
            accounts = AccountDAO.Instance.GetAccounts();
            dtgvAccount.DataSource = accounts;
        }

        void LoadInfoOfMaterial()
        {
            infoOfMaterials = InforOfMaterialDAO.Instance.GetInfoOfMaterials();
            dtgvInfoOfMaterial.DataSource = infoOfMaterials;
            InforOfMaterial[] arr = infoOfMaterials.ToArray();
            if (arr.Length > 0) lastIDInfoOfMaterial = arr[arr.Length - 1].IDOfMaterial;
            else
            {
                lastIDInfoOfMaterial = "IM00";
            }
        }

        void LoadBill()
        {
            bills = BillDAO.Instance.GetBills();
            dtgvBill.DataSource = bills;
            Bill[] arr = bills.ToArray();
            if (arr.Length > 0) lastIDBill = arr[arr.Length - 1].IDOfBill;
            else
            {
                lastIDBill = "BI00";
            }
        }

        void LoadMaterialInWarehouse()
        {
            materialInWarehouses = WarehouseMaterialDAO.Instance.GetMaterials();
            dtgvWarehouse.DataSource = materialInWarehouses;
            MaterialInWarehouse[] arr = materialInWarehouses.ToArray();
            if (arr.Length > 0) lastIDMaterialInWarehouse = arr[arr.Length - 1].IDOfImportMaterial;
            else
            {
                lastIDMaterialInWarehouse = "WM00";
            }
        }

        void AddDrinkBinding()
        {
            txb_Drink_ID.DataBindings.Add(new Binding("Text", dtgvCF.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txb_Drink_Name.DataBindings.Add(new Binding("Text", dtgvCF.DataSource, "Name", true, DataSourceUpdateMode.Never));
            nud_Drink_Price.DataBindings.Add(new Binding("Value", dtgvCF.DataSource, "Price", true, DataSourceUpdateMode.Never));
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
            dtp_Employee_DayIn.DataBindings.Add(new Binding("Value", dtgvEmployees.DataSource, "DayIn", true, DataSourceUpdateMode.Never));
            cbb_Employee_Shift.DataBindings.Add(new Binding("Text", dtgvEmployees.DataSource, "Shift", true, DataSourceUpdateMode.Never));
            nud_Employee_DayOff.DataBindings.Add(new Binding("Value", dtgvEmployees.DataSource, "DayOff", true, DataSourceUpdateMode.Never));
            nud_Employee_Bonus.DataBindings.Add(new Binding("Value", dtgvEmployees.DataSource, "Bonus", true, DataSourceUpdateMode.Never));
            nud_Employee_Salary.DataBindings.Add(new Binding("Value", dtgvEmployees.DataSource, "Salary", true, DataSourceUpdateMode.Never));
            cbb_Employee_IDOfBranch.DataBindings.Add(new Binding("Text", dtgvEmployees.DataSource, "IDOfBranch", true, DataSourceUpdateMode.Never));
        }

        void AddAccountBinding()
        {
            txb_Account_Username.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "Username", true, DataSourceUpdateMode.Never));
            cbb_Account_IDOfEmployee.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "IDOfEmployee", true, DataSourceUpdateMode.Never));
            cbb_Account_AccountType.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "Type", true, DataSourceUpdateMode.Never));
        }

        void AddInfoOfMaterialBinding()
        {
            txb_InforOfMaterial_ID.DataBindings.Add(new Binding("Text", dtgvInfoOfMaterial.DataSource, "IDOfMaterial", true, DataSourceUpdateMode.Never));
            txb_InforOfMaterial_Name.DataBindings.Add(new Binding("Text", dtgvInfoOfMaterial.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txb_InforOfMaterial_Unit.DataBindings.Add(new Binding("Text", dtgvInfoOfMaterial.DataSource, "Unit", true, DataSourceUpdateMode.Never));
            nud_InforOfMaterial_Price.DataBindings.Add(new Binding("Value", dtgvInfoOfMaterial.DataSource, "Price", true, DataSourceUpdateMode.Never));
            cbb_InforOfMaterial_Supplier.DataBindings.Add(new Binding("Text", dtgvInfoOfMaterial.DataSource, "IDOfSupplier", true, DataSourceUpdateMode.Never));
        }

        void AddBillBinding()
        {
            txb_Bill_IDofBill.DataBindings.Add(new Binding("Text", dtgvBill.DataSource, "IDOfBill", true, DataSourceUpdateMode.Never));
            cbb_Bill_IDofBranch.DataBindings.Add(new Binding("SelectedItem", dtgvBill.DataSource, "IDOfBranch", true, DataSourceUpdateMode.Never));
            dtp_Bill_DateCheckIn.DataBindings.Add(new Binding("Value", dtgvBill.DataSource, "DateCheckIn", true, DataSourceUpdateMode.Never));
            nud_Bill_TotalAmount.DataBindings.Add(new Binding("Value", dtgvBill.DataSource, "TotalAmount", true, DataSourceUpdateMode.Never));
        }

        void AddSupplierBinding()
        {
            txt_Supplier_Address.DataBindings.Add(new Binding("Text", dtgvSupplier.DataSource, "Address", true, DataSourceUpdateMode.Never));
            txt_Supplier_ID.DataBindings.Add(new Binding("Text", dtgvSupplier.DataSource, "IDOfSupplier", true, DataSourceUpdateMode.Never));
            txt_Supplier_Name.DataBindings.Add(new Binding("Text", dtgvSupplier.DataSource, "Name", true, DataSourceUpdateMode.Never));
        }

        void AddMaterialInWarehouseBinding()
        {
            txb_Warehouse_IDOfImportMaterial.DataBindings.Add(new Binding("Text", dtgvWarehouse.DataSource, "IDOfImportMaterial", true, DataSourceUpdateMode.Never));
            cbb_Warehouse_IDOfMaterial.DataBindings.Add(new Binding("SelectedItem", dtgvWarehouse.DataSource, "IDOfMaterial", true, DataSourceUpdateMode.Never));
            nud_Warehouse_Amount.DataBindings.Add(new Binding("Value", dtgvWarehouse.DataSource, "Amount", true, DataSourceUpdateMode.Never));
            nud_Warehouse_AmountLeft.DataBindings.Add(new Binding("Value", dtgvWarehouse.DataSource, "AmountLeft", true, DataSourceUpdateMode.Never));
            dtp_Warehouse_DateImport.DataBindings.Add(new Binding("Value", dtgvWarehouse.DataSource, "dateAdded", true, DataSourceUpdateMode.Never));
            dtp_Warehouse_ExpiryDate.DataBindings.Add(new Binding("Value", dtgvWarehouse.DataSource, "ExpiryDate", true, DataSourceUpdateMode.Never));
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
                    break;
                case "Branch":
                    break;
                case "Account":
                    UpdateCbbAccountTypeInTabEmployee();
                    UpdateCbbAccountIdInTabAccount();
                    break;
                case "Employee":
                    UpdateCbbSexualInTabEmployee();
                    UpdateCbbShiftInTabEmployee();
                    UpdateCbbBranchInTabEmployee();
                    break;
                case "InfoOfMaterial":
                    UpdateCbbSupplierInTabInforOfMaterial();
                    break;
                case "Bill":
                    UpdateCbbBranchInTabBill();
                    break;
                case "Supplier":
                    LoadMaterialByIDOfSupplier();
                    break;

            }
        }

        #region eventsDrink

        private void tbSearchCF_TextChanged(object sender, EventArgs e)
        {
            string searchingText = txb_Drink_Search.Text;
            switch (cbb_Drink_SearchBy.Text)
            {
                case "ID":
                    dtgvCF.DataSource = drinks.FindAll(item => item.ID.Contains(searchingText));
                    break;
                case "Drink Name":
                    dtgvCF.DataSource = drinks.FindAll(item => item.Name.Contains(searchingText));
                    break;
                case "Price":
                    dtgvCF.DataSource = drinks.FindAll(item => item.Price.ToString().Contains(searchingText));
                    break;
            }
        }

        private void btn_Drink_AddClick(object sender, EventArgs e)
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
                txb_Drink_Name.Focus();
                return;
            }

            int price = (int)nud_Drink_Price.Value;
            if (price == 0)
            {
                lb_Drink_Notify.Text = "NOTIFY: Price can't be lower than 0";
                nud_Drink_Price.Focus();
                return;
            }

            if (DrinkDAO.Instance.AddDrink(id, name, price))
            {
                lb_Drink_Notify.Text = "NOTIFY: Drink was added Successfully";
                LoadDrinks();
                newDrink();
                if (insertDrink != null)
                    insertDrink(this, new EventArgs());
            }
            else
            {
                lb_Drink_Notify.Text = "NOTIFY: Failed to add Drink";
            }
        }

        private void btn_Drink_UpdateClick(object sender, EventArgs e)
        {
            string id = txb_Drink_ID.Text;
            string name = txb_Drink_Name.Text.Trim();
            if (name == "")
            {
                lb_Drink_Notify.Text = "NOTIFY: Name can't be  empty";
                txb_Drink_Name.Focus();
                return;
            }

            int price = (int)nud_Drink_Price.Value;
            if (price == 0)
            {
                lb_Drink_Notify.Text = "NOTIFY: Price can't be lower than 0";
                nud_Drink_Price.Focus();
                return;
            }
            if (MessageBox.Show("Are you sure you want to update this drink", "Update Drink", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) != System.Windows.Forms.DialogResult.Yes)
            {
                return;
            }
            if (DrinkDAO.Instance.UpdateDrink(id, name, price))
            {
                lb_Drink_Notify.Text = "NOTIFY: Drink was updated Successfully";
                LoadDrinks();
                if (updateDrink != null)
                    updateDrink(this, new EventArgs());
            }
            else
            {
                lb_Drink_Notify.Text = "NOTIFY: Failed to update Drink";
            }
        }

        private void btn_Drink_DeleteCLick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this drink", "Delete Drink", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,MessageBoxDefaultButton.Button1) != System.Windows.Forms.DialogResult.Yes)
            {
                return;
            }
            string id = txb_Drink_ID.Text;
            if (DrinkDAO.Instance.DeleteDrink(id))
            {
                lb_Drink_Notify.Text = "NOTIFY: Drink was deleted Successfully"; 
                LoadDrinks();
                if (deleteDrink != null)
                    deleteDrink(this, new EventArgs());
            }
            else
            {
                lb_Drink_Notify.Text = "Failed To Delete Drink";
            }
        }

        private void bnt_Drink_NewClick(object sender, EventArgs e)
        {
            newDrink();
        }

        private void cbb_Drink_SortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbb_Drink_SortBy.Text)
            {
                case "ID":
                    drinks = drinks.OrderBy(o => o.ID).ToList();
                    break;
                case "Drink Name":
                    drinks = drinks.OrderBy(o => o.Name).ToList();
                    break;
                case "Price":
                    drinks = drinks.OrderBy(o => o.Price).ToList();
                    break;
            }
            dtgvCF.DataSource = drinks;
        }

        #endregion

        #region accountEvents

        private void txb_Account_Search_TextChanged(object sender, EventArgs e)
        {
            string searchingText = txb_Account_Search.Text;
            switch (cbb_Account_SearchBy.Text)
            {
                case "User Name":
                    dtgvAccount.DataSource = accounts.FindAll(item => item.Username.Contains(searchingText));
                    break;
                case "ID of Employee":
                    dtgvAccount.DataSource = accounts.FindAll(item => item.IDOfEmployee.Contains(searchingText));
                    break;
                case "Type":
                    dtgvAccount.DataSource = accounts.FindAll(item => item.Type.ToString().Contains(searchingText));
                    break;
            }
            dtgvAccount.DataSource = accounts;
        }

        private void cbb_Account_SortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbb_Account_SortBy.Text)
            {
                case "User Name":
                    accounts = accounts.OrderBy(o => o.Username).ToList();
                    break;
                case "ID of Employee":
                    accounts = accounts.OrderBy(o => o.IDOfEmployee).ToList();
                    break;
                case "Type":
                    accounts = accounts.OrderBy(o => o.Type).ToList();
                    break;
            }
            dtgvAccount.DataSource = accounts;
        }

        private void btnDeleteAccountClick(object sender, EventArgs e)
        {
            string username = txb_Account_Username.Text;
            if(username == "")
            {
                lb_Account_Notify.Text = "NOTIFY: Username can't be empty";
                txb_Account_Username.Focus();
            }
            if (MessageBox.Show("Are you sure you want to delete this Account", "Delete Account", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) != System.Windows.Forms.DialogResult.Yes)
            {
                return;
            }
            if (AccountDAO.Instance.DeleteAccount(username))
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
            string username = txb_Account_Username.Text;
            if(username == "")
            {
                lb_Employee_Notify.Text = "NOTIFY: Username can't be empty";
                txb_Account_Username.Focus();
                return;
            }
            string iDOfEmployee = cbb_Account_IDOfEmployee.Text;
            int type = int.Parse(cbb_Account_AccountType.Text);
            if (MessageBox.Show("Are you sure you want to update this Account", "Update Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) != System.Windows.Forms.DialogResult.Yes)
            {
                return;
            }
            if (AccountDAO.Instance.UpdateAccount(username, iDOfEmployee, type))
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
            foreach(Account item in accounts)
            {
                if(item.Username == txb_Account_Username.Text)
                {
                    fChangePassword f = new fChangePassword(item);
                    f.ShowDialog();
                    LoadAccounts();
                    break;
                }
            }
            
        }

        private void btnAccountNewClick(object sender, EventArgs e)
        {
            fNewAccount f = new fNewAccount();
            f.ShowDialog();
            LoadAccounts();
        }

        #endregion

        #region EmployeesEvent


        private void txb_Employee_Search_TextChanged(object sender, EventArgs e)
        {
            string searchingText = txb_Account_Search.Text;
            switch (cbb_Employee_SearchBy.Text)
            {
                case "ID of Employee":
                    dtgvEmployees.DataSource = employees.FindAll(o => o.IDOfEmployee.Contains(searchingText));
                    break;
                case "First Name":
                    dtgvEmployees.DataSource = employees.FindAll(o => o.FirstName.Contains(searchingText));
                    break;
                case "Last Name":
                    dtgvEmployees.DataSource = employees.FindAll(o => o.LastName.Contains(searchingText));
                    break;
                case "Phone Number":
                    dtgvEmployees.DataSource = employees.FindAll(o => o.PhoneNumber.Contains(searchingText));
                    break;
                case "Sexual":
                    dtgvEmployees.DataSource = employees.FindAll(o => o.Sexual.Contains(searchingText));
                    break;
                case "Address":
                    dtgvEmployees.DataSource = employees.FindAll(o => o.Address.Contains(searchingText));
                    break;
                case "Day In":
                    dtgvEmployees.DataSource = employees.FindAll(o => o.DayIn.ToString().Contains(searchingText));
                    break;
                case "Day Off":
                    dtgvEmployees.DataSource = employees.FindAll(o => o.DayOff.ToString().Contains(searchingText));
                    break;
                case "Shift":
                    dtgvEmployees.DataSource = employees.FindAll(o => o.Shift.Contains(searchingText));
                    break;
                case "Bonus":
                    dtgvEmployees.DataSource = employees.FindAll(o => o.Bonus.ToString().Contains(searchingText));
                    break;
                case "Salary":
                    dtgvEmployees.DataSource = employees.FindAll(o => o.Salary.ToString().Contains(searchingText));
                    break;
                case "ID of Branch":
                    dtgvEmployees.DataSource = employees.FindAll(o => o.IDOfBranch.ToString().Contains(searchingText));
                    break;
            }
        }

        private void cbb_Employee_SortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbb_Employee_SortBy.Text)
            {
                case "ID of Employee":
                    employees = employees.OrderBy(o => o.IDOfEmployee).ToList();
                    break;
                case "First Name":
                    employees = employees.OrderBy(o => o.FirstName).ToList();
                    break;
                case "Last Name":
                    employees = employees.OrderBy(o => o.LastName).ToList();
                    break;
                case "Phone Number":
                    employees = employees.OrderBy(o => o.PhoneNumber).ToList();
                    break;
                case "Sexual":
                    employees = employees.OrderBy(o => o.Sexual).ToList();
                    break;
                case "Address":
                    employees = employees.OrderBy(o => o.Address).ToList();
                    break;
                case "Day In":
                    employees = employees.OrderBy(o => o.DayIn).ToList();
                    break;
                case "Day Off":
                    employees = employees.OrderBy(o => o.DayOff).ToList();
                    break;
                case "Shift":
                    employees = employees.OrderBy(o => o.Shift).ToList();
                    break;
                case "Bonus":
                    employees = employees.OrderBy(o => o.Bonus).ToList();
                    break;
                case "Salary":
                    employees = employees.OrderBy(o => o.Salary).ToList();
                    break;
                case "ID of Branch":
                    employees = employees.OrderBy(o => o.IDOfBranch).ToList();
                    break;
            }
            dtgvEmployees.DataSource = employees;
        }

        private void btnAddEmployeeClick(object sender, EventArgs e)
        {
            string id = txb_Employee_IDOfEmPloyee.Text;
            string firstName = txb_Employee_FirstName.Text.Trim();
            if (firstName == "")
            {
                lb_InforOfMaterial_Notify.Text = "NOTIFY: First Name can't be empty";
                txb_Employee_FirstName.Focus();
                return;
            }
            string lastName = txb_Employee_LastName.Text.Trim();
            if (lastName == "")
            {
                lb_InforOfMaterial_Notify.Text = "NOTIFY: Last Name can't be empty";
                txb_Employee_LastName.Focus();
                return;
            }
            string phoneNumber = txb_Employee_PhoneNumber.Text.Trim();
            if (phoneNumber == "")
            {
                lb_InforOfMaterial_Notify.Text = "NOTIFY: Phone Number can't be empty";
                txb_Employee_PhoneNumber.Focus();
                return;
            }
            string sexual = cbb_Employee_Sexual.SelectedItem.ToString();
            string address = txb_Employee_Address.Text.Trim();
            if (address == "")
            {
                lb_InforOfMaterial_Notify.Text = "NOTIFY: Address can't be empty";
                txb_Employee_Address.Focus();
                return;
            }
            DateTime dayIn = dtp_Employee_DayIn.Value;
            string shift = cbb_Employee_Shift.SelectedItem.ToString();
            int dayOff = (int)nud_Employee_DayOff.Value;
            if (dayOff <= 0)
            {
                lb_InforOfMaterial_Notify.Text = "NOTIFY: Day Off must be greater than 0";
                nud_Employee_DayOff.Focus();
                return;
            }
            int bonus = (int)nud_Employee_Bonus.Value;
            if (bonus <= 0)
            {
                lb_InforOfMaterial_Notify.Text = "NOTIFY: Bonus must be greater than 0";
                nud_Employee_Bonus.Focus();
                return;
            }
            int salary = (int)nud_Employee_Salary.Value;
            if(salary <= 0)
            {
                lb_InforOfMaterial_Notify.Text = "NOTIFY: Salary must be greater than 0";
                nud_Employee_Salary.Focus();
                return;
            }

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
            string id = txb_Employee_IDOfEmPloyee.Text;
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
            string id = txb_Employee_IDOfEmPloyee.Text;
            string firstName = txb_Employee_FirstName.Text.Trim();
            if (firstName == "")
            {
                lb_InforOfMaterial_Notify.Text = "NOTIFY: First Name can't be empty";
                txb_Employee_FirstName.Focus();
                return;
            }
            string lastName = txb_Employee_LastName.Text.Trim();
            if (lastName == "")
            {
                lb_InforOfMaterial_Notify.Text = "NOTIFY: Last Name can't be empty";
                txb_Employee_LastName.Focus();
                return;
            }
            string phoneNumber = txb_Employee_PhoneNumber.Text.Trim();
            if (phoneNumber == "")
            {
                lb_InforOfMaterial_Notify.Text = "NOTIFY: Phone Number can't be empty";
                txb_Employee_PhoneNumber.Focus();
                return;
            }
            string sexual = cbb_Employee_Sexual.SelectedItem.ToString();
            string address = txb_Employee_Address.Text.Trim();
            if (address == "")
            {
                lb_InforOfMaterial_Notify.Text = "NOTIFY: Address can't be empty";
                txb_Employee_Address.Focus();
                return;
            }
            DateTime dayIn = dtp_Employee_DayIn.Value;
            string shift = cbb_Employee_Shift.SelectedItem.ToString();
            int dayOff = (int)nud_Employee_DayOff.Value;
            if (dayOff <= 0)
            {
                lb_InforOfMaterial_Notify.Text = "NOTIFY: Day Off must be greater than 0";
                nud_Employee_DayOff.Focus();
                return;
            }
            int bonus = (int)nud_Employee_Bonus.Value;
            if (bonus <= 0)
            {
                lb_InforOfMaterial_Notify.Text = "NOTIFY: Bonus must be greater than 0";
                nud_Employee_Bonus.Focus();
                return;
            }
            int salary = (int)nud_Employee_Salary.Value;
            if (salary <= 0)
            {
                lb_InforOfMaterial_Notify.Text = "NOTIFY: Salary must be greater than 0";
                nud_Employee_Salary.Focus();
                return;
            }
            if (MessageBox.Show("Are you sure you want to update this Employee", "Update Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) != System.Windows.Forms.DialogResult.Yes)
            {
                return;
            }
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

        private void btnNewEmployeeClick(object sender, EventArgs e)
        {
            newEmployee();
        }

        private void btnSearchEmployeesClick(object sender, EventArgs e)
        {

        }
        #endregion

        #region BranchEvents

        private void txb_Branch_Search_TextChanged(object sender, EventArgs e)
        {
            string searchingText = txb_Branch_Search.Text;
            switch (cbb_Branch_SearchBy.Text)
            {
                case "ID":
                    dtgvBranches.DataSource = branches.FindAll(item => item.Id.Contains(searchingText));
                    break;
                case "Branch Name":
                    dtgvBranches.DataSource = branches.FindAll(item => item.Id.Contains(searchingText));
                    break;
                case "Manager":
                    dtgvBranches.DataSource = branches.FindAll(item => item.Id.Contains(searchingText));
                    break;
            }
        }

        private void btnAddBranchClick(object sender, EventArgs e)
        {
            string branchId = txb_branch_ID.Text;
            foreach(Branch item in branches)
            {
                if(branchId == item.Id)
                {
                    lb_Branch_Notify.Text = "Can not added";
                    txb_branch_ID.Focus();
                    return;
                }
            }
            string branchName = txb_branch_Name.Text.Trim();
            if(branchName == "")
            {
                lb_Branch_Notify.Text = "Name can't be empty";
                txb_branch_Name.Focus();
                return;
            }
            string manager = txb_branch_Manager.Text.Trim();
            if(manager == "")
            {
                lb_Branch_Notify.Text = "Manager can't be empty";
                txb_branch_Manager.Focus();
                return;
            }
            if (BranchDAO.Instance.AddBranch(branchId, branchName, manager))
            {
                lb_Branch_Notify.Text = "Branch Was Added Successfully";
                LoadBranches();
                newBranch();
            }
            else
            {
                lb_Branch_Notify.Text = "Failed To Added Branch";
                newBranch();
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
            newBranch();
        }

        private void cbb_Branch_SortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbb_Branch_SortBy.Text)
            {
                case "ID":
                    branches = branches.OrderBy(o => o.Id).ToList();
                    break;
                case "Branch Name":
                    branches = branches.OrderBy(o => o.Name).ToList();
                    break;
                case "Manager":
                    branches = branches.OrderBy(o => o.Manager).ToList();
                    break;
            }
            dtgvBranches.DataSource = branches;
        }
        #endregion

        #region InforOfMaterialEvent

        private void txb_InfoOfMaterial_Search_TextChanged(object sender, EventArgs e)
        {
            string searchingText = txb_InfoOfMaterial_Search.Text;
            switch (cbb_InfoOfMaterial_SearchBy.Text)
            {
                case "ID of Material":
                    dtgvInfoOfMaterial.DataSource = infoOfMaterials.FindAll(o => o.IDOfMaterial.Contains(searchingText));
                    break;
                case "Name":
                    dtgvInfoOfMaterial.DataSource = infoOfMaterials.FindAll(o => o.Name.Contains(searchingText));
                    break;
                case "Unit":
                    dtgvInfoOfMaterial.DataSource = infoOfMaterials.FindAll(o => o.Unit.Contains(searchingText));
                    break;
                case "Price":
                    dtgvInfoOfMaterial.DataSource = infoOfMaterials.FindAll(o => o.Price.ToString().Contains(searchingText));
                    break;
                case "ID of Supplier":
                    dtgvInfoOfMaterial.DataSource = infoOfMaterials.FindAll(o => o.IDOfSupplier.Contains(searchingText));
                    break;
            }
        }

        private void cbb_InfoOfMaterial_SortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbb_InfoOfMaterial_SortBy.Text)
            {
                case "ID of Material":
                    infoOfMaterials = infoOfMaterials.OrderBy(o => o.IDOfMaterial).ToList();
                    break;
                case "Name":
                    infoOfMaterials = infoOfMaterials.OrderBy(o => o.Name).ToList();
                    break;
                case "Unit":
                    infoOfMaterials = infoOfMaterials.OrderBy(o => o.Unit).ToList();
                    break;
                case "Price":
                    infoOfMaterials = infoOfMaterials.OrderBy(o => o.Price).ToList();
                    break;
                case "ID of Supplier":
                    infoOfMaterials = infoOfMaterials.OrderBy(o => o.IDOfSupplier).ToList();
                    break;
            }
            dtgvInfoOfMaterial.DataSource = infoOfMaterials;
        }

        private void btn_InfoOfMaterial_Delete_Click(object sender, EventArgs e)
        {
            string iD = txb_InforOfMaterial_ID.Text;
            if (InforOfMaterialDAO.Instance.DeleteInfoOfMaterial(iD))
            {
                lb_InforOfMaterial_Notify.Text = "NOTIFY: Information of material was deleted successfully";
                LoadInfoOfMaterial();
            }
            else
            {
                lb_InforOfMaterial_Notify.Text = "NOTIFY: failed to delete";
            }
        }

        private void btn_InfoOfMaterial_Update_Click(object sender, EventArgs e)
        {
            string iD = txb_InforOfMaterial_ID.Text;
            string name = txb_InforOfMaterial_Name.Text;
            if (name == "")
            {
                lb_InforOfMaterial_Notify.Text = "NOTIFY: Name can't be empty";
                txb_InforOfMaterial_Name.Focus();
                return;
            }
            string unit = txb_InforOfMaterial_Unit.Text;
            if (unit == "")
            {
                lb_InforOfMaterial_Notify.Text = "NOTIFY: unit can't be empty";
                txb_InforOfMaterial_Unit.Focus();
                return;
            }
            int price = int.Parse(nud_InforOfMaterial_Price.Text);
            if (price < 1000)
            {
                lb_InforOfMaterial_Notify.Text = "NOTIFY: Price can't be lower than 1000VND";
                nud_InforOfMaterial_Price.Focus();
                return;
            }
            string supplier = cbb_InforOfMaterial_Supplier.Text;
            if (InforOfMaterialDAO.Instance.UpdateInfoOfMaterial(iD, name, unit, price, supplier))
            {
                lb_InforOfMaterial_Notify.Text = "NOTIFY: Information of material was updated successfully";
                LoadInfoOfMaterial();
            }
            else
            {
                lb_InforOfMaterial_Notify.Text = "NOTIFY: failed to update";
            }
        }

        private void btn_InfoOfMaterial_New_Click(object sender, EventArgs e)
        {
            newInforOfMaterial();
        }

        private void btn_InforOfMaterial_Add_Click(object sender, EventArgs e)
        {
            string iD = txb_InforOfMaterial_ID.Text;
            foreach (InforOfMaterial item in infoOfMaterials)
            {
                if (iD == item.IDOfMaterial)
                {
                    lb_InforOfMaterial_Notify.Text = "WARNING: ID was existed in database, please press new for new ID";
                    return;
                }
            }
            string name = txb_InforOfMaterial_Name.Text;
            if (name == "")
            {
                lb_InforOfMaterial_Notify.Text = "NOTIFY: Name can't be empty";
                txb_InforOfMaterial_Name.Focus();
                return;
            }
            string unit = txb_InforOfMaterial_Unit.Text;
            if (unit == "")
            {
                lb_InforOfMaterial_Notify.Text = "NOTIFY: unit can't be empty";
                txb_InforOfMaterial_Unit.Focus();
                return;
            }
            int price = int.Parse(nud_InforOfMaterial_Price.Text);
            if (price < 1000)
            {
                lb_InforOfMaterial_Notify.Text = "NOTIFY: Price can't be lower than 1000VND";
                nud_InforOfMaterial_Price.Focus();
                return;
            }
            string supplier = cbb_InforOfMaterial_Supplier.Text;
            if (InforOfMaterialDAO.Instance.AddInfoOfMaterial(iD, name, unit, price, supplier))
            {
                lb_InforOfMaterial_Notify.Text = "NOTIFY: InforOfMaterial was added successfully";
            }
            else
            {
                lb_InforOfMaterial_Notify.Text = "NOTIFY: failed to added";
            }
        }
        #endregion

        #region BillEvent

        private void txb_Bill_Search_TextChanged(object sender, EventArgs e)
        {
            string searchingText = txb_Bill_Search.Text;
            switch (cbb_Bill_SearchBy.Text)
            {
                case "ID of Bill":
                    dtgvBill.DataSource = bills.FindAll(o => o.IDOfBill.Contains(searchingText));
                    break;
                case "ID of Branch":
                    dtgvBill.DataSource = bills.FindAll(o => o.IDOfBranch.Contains(searchingText));
                    break;
                case "Day Check In":
                    dtgvBill.DataSource = bills.FindAll(o => o.DateCheckIn.ToString().Contains(searchingText));
                    break;
                case "Total Amount":
                    dtgvBill.DataSource = bills.FindAll(o => o.TotalAmount.ToString().Contains(searchingText));
                    break;
            }
        }

        private void cbb_Bill_SortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbb_Bill_SortBy.Text)
            {
                case "ID of Bill":
                    bills = bills.OrderBy(o => o.IDOfBill).ToList();
                    break;
                case "ID of Branch":
                    bills = bills.OrderBy(o => o.IDOfBranch).ToList();
                    break;
                case "Day Check In":
                    bills = bills.OrderBy(o => o.DateCheckIn).ToList();
                    break;
                case "Total Amount":
                    bills = bills.OrderBy(o => o.TotalAmount).ToList();
                    break;
            }
            dtgvBill.DataSource = bills;
        }

        private void btn_Bill_NewClick(object sender, EventArgs e)
        {
            newBill();
        }

        private void btn_Bill_AddClick(object sender, EventArgs e)
        {
            string iDOfBill = txb_Bill_IDofBill.Text;
            foreach(Bill item in bills)
            {
                if(iDOfBill == item.IDOfBill)
                {
                    lb_Bill_Notify.Text = "WARNING: ID was existed in database, please press new for new ID";
                    btn_Bill_New.Focus();
                    return;
                }
            }
            string iDOfBranch = cbb_Bill_IDofBranch.SelectedItem.ToString();
            if(iDOfBranch == "")
            {
                lb_Bill_Notify.Text = "WARNING: ID of branch can't be empty";
                cbb_Bill_IDofBranch.Focus();
                return;
            }
            DateTime dateCheckIn = dtp_Bill_DateCheckIn.Value;
            int totalAmount = (int)nud_Bill_TotalAmount.Value;
            if(totalAmount < 1000)
            {
                lb_Bill_Notify.Text = "WARNING: Total amount can't be lower than 1000";
                nud_Bill_TotalAmount.Focus();
                return;
            }
            if (BillDAO.Instance.AddBill(iDOfBill, iDOfBranch, dateCheckIn, totalAmount))
            {
                lb_Bill_Notify.Text = "NOTIFY: Bill was added Successfully";
                LoadBill();
                newBill();
            }
            else
            {
                lb_Bill_Notify.Text = "NOTIFY: Failed to added bill";
            }
        }

        private void btn_Bill_UpdateClick(object sender, EventArgs e)
        {
            string iDOfBill = txb_Bill_IDofBill.Text;
            string iDOfBranch = cbb_Bill_IDofBranch.SelectedItem.ToString();
            if (iDOfBranch == "")
            {
                lb_Bill_Notify.Text = "WARNING: ID of branch can't be empty";
                return;
            }
            DateTime dateCheckIn = dtp_Bill_DateCheckIn.Value;
            int totalAmount = (int)nud_Bill_TotalAmount.Value;
            if (totalAmount < 1000)
            {
                lb_Bill_Notify.Text = "WARNING: Total amount can't be lower than 1000";
                return;
            }
            if (BillDAO.Instance.UpdateBill(iDOfBill, iDOfBranch, dateCheckIn, totalAmount))
            {
                lb_Bill_Notify.Text = "NOTIFY: Bill was updated Successfully";
                LoadBill();
            }
            else
            {
                lb_Bill_Notify.Text = "NOTIFY: Failed to update bill";
            }
        }

        private void btn_Bill_DeleteClick(object sender, EventArgs e)
        {
            string iDOfBill = txb_Bill_IDofBill.Text;
            if (BillDAO.Instance.DeleteBill(iDOfBill))
            {
                lb_Bill_Notify.Text = "NOTIFY: Bill was deleted Successfully";
                LoadBill();
            }
            else
            {
                lb_Bill_Notify.Text = "NOTIFY: Failed to delete bill";
            }
        }

        private void btn_Bill_DetailOfBillClick(object sender, EventArgs e)
        {
            fDetailOfBill f = new fDetailOfBill(txb_Bill_IDofBill.Text);
            f.ShowDialog();
        }

        #endregion

        #region SupplierEvent

        private void txb_Supplier_Search_TextChanged(object sender, EventArgs e)
        {
            string searchingText = txb_Account_Search.Text;
            switch (cbb_Supplier_SearchBy.Text)
            {
                case "ID of Supplier":
                    dtgvSupplier.DataSource = suppliers.FindAll(o => o.IDOfSupplier.Contains(searchingText));
                    break;
                case "Name":
                    dtgvSupplier.DataSource = suppliers.FindAll(o => o.Name.Contains(searchingText));
                    break;
                case "Address":
                    dtgvSupplier.DataSource = suppliers.FindAll(o => o.Address.Contains(searchingText));
                    break;
            }
        }

        private void cbb_Supplier_SortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbb_Supplier_SortBy.Text)
            {
                case "ID of Supplier":
                    suppliers = suppliers.OrderBy(o => o.IDOfSupplier).ToList();
                    break;
                case "Name":
                    suppliers = suppliers.OrderBy(o => o.Name).ToList();
                    break;
                case "Address":
                    suppliers = suppliers.OrderBy(o => o.Address).ToList();
                    break;
            }
            dtgvBill.DataSource = suppliers;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string Address = txt_Supplier_Address.Text;
            string Name = txt_Supplier_Name.Text;
            if (Name == "")
            {
                MessageBox.Show("Name cann't be empty!");
                txt_Supplier_Name.Focus();
                return;
            }
            if (Address == "")
            {
                MessageBox.Show("Address cann't be empty!");
                txt_Supplier_Address.Focus();
                return;
            }
            if ((MessageBox.Show("Are you sure you want to add this supplier", "Add supplier", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
            {
                if (SupplierDAO.Instance.AddSupplier(lastIDSupplier, Name, Address))
                {
                    MessageBox.Show("Supplier Was Added successfully!");
                    LoadSupplier();
                }
                else
                {
                    MessageBox.Show("Failed To Add Supplier");
                }
                return;
            }
        }

        private void btn_Supplier_New(object sender, EventArgs e)
        {
            lastIDSupplier = getIDIncrea(lastIDSupplier);
            txt_Supplier_ID.Text = lastIDSupplier;
            txt_Supplier_Address.Text = "";
            txt_Supplier_Name.Text = "";
            txt_Supplier_Name.Focus();

        }

        private void btn_Supplier_Delete_Click(object sender, EventArgs e)
        {
            string iD = txt_Supplier_ID.Text.Trim();
            if (MessageBox.Show("Are you sure you want to delete this branch", "Delete Branch", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {

                if (SupplierDAO.Instance.DeleteSupplier(iD))
                {
                    MessageBox.Show("Supplier Was Deleted Successfully!");
                    LoadSupplier();
                }
                else
                {
                    MessageBox.Show("Fail To Delete Supplier!");
                    return;
                }
            }

        }

        private void btn_Supplier_Update_Click(object sender, EventArgs e)
        {
            string Name = txt_Supplier_Name.Text.Trim();
            string Address = txt_Supplier_Address.Text.Trim();
            string iD = txt_Supplier_ID.Text.Trim();
            foreach (Supplier item in suppliers)
            {
                if (item.IDOfSupplier == iD)
                {
                    if (item.Address == Address && item.Name == Name)
                    {
                        MessageBox.Show("Nothing Change To Update!!");
                        return;
                    }
                }
            }
            if (SupplierDAO.Instance.UpdateSupplier(iD, Name, Address))
            {
                MessageBox.Show("Supplier Was Updated Successfully!!");
                LoadSupplier();
                return;
            }


        }

        private void dtgvSupplier_Click(object sender, EventArgs e)
        {
            LoadMaterialByIDOfSupplier();
        }
        #endregion

        #region Warehouse

        private void txb_Warehouse_Search_TextChanged(object sender, EventArgs e)
        {
            string searchingText = txb_Account_Search.Text;
            switch (cbb_Warehouse_SearchBy.Text)
            {
                case "ID of Import Material":
                    dtgvInfoOfMaterial.DataSource = materialInWarehouses.FindAll(o => o.IDOfImportMaterial.Contains(searchingText));
                    break;
                case "ID of Material":
                    dtgvInfoOfMaterial.DataSource = materialInWarehouses.FindAll(o => o.IDOfMaterial.Contains(searchingText));
                    break;
                case "Amount":
                    dtgvInfoOfMaterial.DataSource = materialInWarehouses.FindAll(o => o.Amount.ToString().Contains(searchingText));
                    break;
                case "AmountLeft":
                    dtgvInfoOfMaterial.DataSource = materialInWarehouses.FindAll(o => o.AmountLeft.ToString().Contains(searchingText));
                    break;
                case "Date Added":
                    dtgvInfoOfMaterial.DataSource = materialInWarehouses.FindAll(o => o.DateAdded.ToString().Contains(searchingText));
                    break;
                case "Expiry Date":
                    dtgvInfoOfMaterial.DataSource = materialInWarehouses.FindAll(o => o.ExpiryDate.ToString().Contains(searchingText));
                    break;
            }
        }

        private void cbb_Warehouse_SortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbb_Warehouse_SortBy.Text)
            {
                case "ID of Import Material":
                    materialInWarehouses = materialInWarehouses.OrderBy(o => o.IDOfImportMaterial).ToList();
                    break;
                case "ID of Material":
                    materialInWarehouses = materialInWarehouses.OrderBy(o => o.IDOfMaterial).ToList();
                    break;
                case "Amount":
                    materialInWarehouses = materialInWarehouses.OrderBy(o => o.Amount).ToList();
                    break;
                case "AmountLeft":
                    materialInWarehouses = materialInWarehouses.OrderBy(o => o.AmountLeft).ToList();
                    break;
                case "Date Added":
                    materialInWarehouses = materialInWarehouses.OrderBy(o => o.DateAdded).ToList();
                    break;
                case "Expiry Date":
                    materialInWarehouses = materialInWarehouses.OrderBy(o => o.ExpiryDate).ToList();
                    break;
            }
            dtgvBill.DataSource = materialInWarehouses;
        }

        private void btn_Warehouse_NewClick(object sender, EventArgs e)
        {
            txb_Warehouse_IDOfImportMaterial.Text = getIDIncrea(lastIDMaterialInWarehouse);
            cbb_Warehouse_IDOfMaterial.SelectedItem = cbb_Warehouse_IDOfMaterial.Items[0];
            nud_Warehouse_Amount.Value = 0;
            nud_Warehouse_AmountLeft.Value = 0;
            dtp_Warehouse_DateImport.Value = DateTime.Now;
            dtp_Warehouse_ExpiryDate.Value = DateTime.Now;
        }

        private void btn_Warehouse_AddClick(object sender, EventArgs e)
        {
            string iDOfImportMaterial = txb_Warehouse_IDOfImportMaterial.Text;
            string iDOfMaterial = cbb_Warehouse_IDOfMaterial.Text;
            int amount = (int)nud_Warehouse_Amount.Value;
            if (amount <= 0)
            {
                lb_Warehouse_Notify.Text = "NOTIFY: Amount must be greater than 0";
                nud_Warehouse_Amount.Focus();
                return;
            }
            int amountLeft = (int)nud_Warehouse_AmountLeft.Value;
            if (amountLeft <= 0)
            {
                lb_Warehouse_Notify.Text = "NOTIFY: Amount left must be greater than 0";
                nud_Warehouse_AmountLeft.Focus();

                return;
            }
            DateTime dateAdded = dtp_Warehouse_DateImport.Value;
            DateTime expiryDate = dtp_Warehouse_ExpiryDate.Value;
            if (WarehouseMaterialDAO.Instance.AddMaterial(iDOfImportMaterial, iDOfMaterial, amount, amountLeft, dateAdded, expiryDate))
            {
                lb_Warehouse_Notify.Text = "NOTIFY: Material was added Successfully";
            }
            else
            {
                lb_Warehouse_Notify.Text = "NOTIFY: Failed to add Material";
            }
        }

        private void btn_Warehouse_DeleteClick(object sender, EventArgs e)
        {
            string iDOfImportMaterial = txb_Warehouse_IDOfImportMaterial.Text;
            if (WarehouseMaterialDAO.Instance.DeleteMaterial(iDOfImportMaterial))
            {
                lb_Warehouse_Notify.Text = "NOTIFY: Material was deleted Successfully";
            }
            else
            {
                lb_Warehouse_Notify.Text = "NOTIFY: Failed to delete Material";
            }
        }

        private void btn_Warehouse_UpdateClick(object sender, EventArgs e)
        {
            string iDOfImportMaterial = txb_Warehouse_IDOfImportMaterial.Text;
            string iDOfMaterial = cbb_Warehouse_IDOfMaterial.Text;
            int amount = (int)nud_Warehouse_Amount.Value;
            if (amount <= 0)
            {
                lb_Warehouse_Notify.Text = "NOTIFY: Amount must be greater than 0";
                nud_Warehouse_Amount.Focus();
                return;
            }
            int amountLeft = (int)nud_Warehouse_AmountLeft.Value;
            if (amountLeft <= 0)
            {
                lb_Warehouse_Notify.Text = "NOTIFY: Amount left must be greater than 0";
                nud_Warehouse_AmountLeft.Focus();

                return;
            }
            DateTime dateAdded = dtp_Warehouse_DateImport.Value;
            DateTime expiryDate = dtp_Warehouse_ExpiryDate.Value;
            if (WarehouseMaterialDAO.Instance.UpdateMaterial(iDOfImportMaterial, iDOfMaterial, amount, amountLeft, dateAdded, expiryDate))
            {
                lb_Warehouse_Notify.Text = "NOTIFY: Material was updated Successfully";
            }
            else
            {
                lb_Warehouse_Notify.Text = "NOTIFY: Failed to update Material";
            }
        }
        #endregion

        #endregion

        private void newDrink()
        {
            txb_Drink_ID.Text = getIDIncrea(lastIDDrink);
            txb_Drink_Name.Text = "";
            nud_Drink_Price.Value = 20000;
            txb_Drink_Name.Focus();
        }

        private void newBranch()
        {
            txb_branch_ID.Text = getIDIncrea(lastIDBranch);
            txb_branch_Name.Text = "";
            txb_branch_Manager.Text = "";
            txb_branch_Name.Focus();
        }

        private void newEmployee()
        {
            txb_Employee_IDOfEmPloyee.Text = getIDIncrea(lastIDEmployees);
            txb_Employee_FirstName.Text = "";
            txb_Employee_LastName.Text = "";
            txb_Employee_PhoneNumber.Text = "";
            cbb_Employee_Sexual.SelectedItem = cbb_Employee_Sexual.Items[0];
            txb_Employee_Address.Text = "";
            dtp_Employee_DayIn.Value = DateTime.Today;
            nud_Employee_DayOff.Value = 10;
            cbb_Employee_Shift.SelectedItem = cbb_Employee_Shift.Items[0];
            nud_Employee_Bonus.Value = 100000;
            nud_Employee_Salary.Value = 5000000;
            cbb_Employee_IDOfBranch.SelectedItem = cbb_Employee_IDOfBranch.Items[0];
            txb_Employee_FirstName.Focus();
        }

        private void newInforOfMaterial()
        {
            txb_InforOfMaterial_ID.Text = getIDIncrea(lastIDInfoOfMaterial);
            txb_InforOfMaterial_Name.Text = "";
            txb_InforOfMaterial_Unit.Text = "";
            nud_InforOfMaterial_Price.Value = 100000;
            cbb_InforOfMaterial_Supplier.SelectedItem = cbb_InforOfMaterial_Supplier.Items[0];
            txb_InforOfMaterial_Name.Focus();
        }


        private void newBill()
        {
            txb_Bill_IDofBill.Text = getIDIncrea(lastIDBill);
            cbb_Bill_IDofBranch.SelectedItem = cbb_Bill_IDofBranch.Items[0];
            dtp_Bill_DateCheckIn.Value = DateTime.Now;
            nud_Bill_TotalAmount.Value = 100000;
            cbb_Bill_IDofBranch.Focus();
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
            cbb_Account_IDOfEmployee.Items.Clear();
            foreach(Employee employee in employees)
            {
                cbb_Account_IDOfEmployee.Items.Add(employee.IDOfEmployee);
            }
        }

        private void UpdateCbbSupplierInTabInforOfMaterial()
        {
            cbb_InforOfMaterial_Supplier.Items.Clear();
            foreach(Supplier supplier in suppliers)
            {
                cbb_InforOfMaterial_Supplier.Items.Add(supplier.IDOfSupplier);
            }
        }

        private void UpdateCbbBranchInTabBill()
        {
            cbb_Bill_IDofBranch.Items.Clear();
            foreach(Branch branch in branches)
            {
                cbb_Bill_IDofBranch.Items.Add(branch.Id);
            }
        }

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


        //vùng click nhầm :)))))

        private void panel19_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

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

    }
}
