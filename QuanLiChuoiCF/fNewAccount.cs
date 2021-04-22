using QuanLiChuoiCF.DAO;
using QuanLiChuoiCF.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiChuoiCF
{
    public partial class fNewAccount : Form
    {
        public fNewAccount()
        {
            InitializeComponent();
            Load();
        }

        public void Load()
        {
            cbbType.Items.Add("0");
            cbbType.Items.Add("1");
            cbbType.SelectedItem = cbbType.Items[0];

            foreach(Employee employee in fAdmin.employees)
            {
                cbbIDOfEmployee.Items.Add(employee.IDOfEmployee);
            }
            if(cbbIDOfEmployee.Items.Count>0)cbbIDOfEmployee.SelectedItem = cbbIDOfEmployee.Items[0];
        }

        private void btnOkClick(object sender, EventArgs e)
        {
            string username = txbUserName.Text;
            if(username == "")
            {
                lbNotify.Text = "NOTIFY: Username can't be empty";
                txbUserName.Focus();
                return;
            }
            foreach(Account item in fAdmin.accounts)
            {
                if(username == item.Username)
                {
                    lbNotify.Text = "NOTIFY: Username was be used";
                    txbUserName.Focus();
                    return;
                }
            }
            string iDOfEmployee = cbbIDOfEmployee.Text;
            string password = txbPassword.Text;
            if(password == "")
            {
                lbNotify.Text = "NOTIFY: Password can't be empty";
                txbPassword.Focus();
                return;
            }
            string confirmPassword = txbConfirmPassword.Text;
            if(confirmPassword == "")
            {
                lbNotify.Text = "NOTIFY: Confirm password can't be empty";
                txbConfirmPassword.Focus();
                return;
            }
            if(confirmPassword != password)
            {
                lbNotify.Text = "NOTIFY: Confirm password is wrong";
                txbConfirmPassword.Focus();
                return;
            }
            int type = int.Parse(cbbType.Text);
            if(AccountDAO.Instance.AddAccount(username,iDOfEmployee,password, type))
            {
                lbNotify.Text = "NOTIFY: Account was added Successully";
                this.Close();
            }
            else
            {
                lbNotify.Text = "NOTIFY: Failed to add Account";
                return;
            }
        }
    }
}
