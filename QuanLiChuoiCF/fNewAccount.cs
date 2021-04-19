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
                cbbID.Items.Add(employee.IDOfEmployee);
            }
            if(cbbID.Items.Count>0)cbbID.SelectedItem = cbbID.Items[0];
        }

        private void btnOkClick(object sender, EventArgs e)
        {
            string id = cbbID.SelectedItem.ToString();
            if(id == "")
            {
                lbNotify.Text = "ID can't be empty";
                return;
            }
            string userName = txbUserName.Text;
            if(userName == "")
            {
                lbNotify.Text = "UserName can't be empty";
                return;
            }
            string password = txbPassword.Text;
            if(password == "")
            {
                lbNotify.Text = "Password can't be empty";
                return;
            }
            string confirmPassword = txbConfirmPassword.Text;
            if(confirmPassword == "")
            {
                lbNotify.Text = "Confirm password can't be empty";
                return;
            }
            if(confirmPassword != password)
            {
                lbNotify.Text = "Confirm password is wrong";
                return;
            }
            int type = int.Parse(cbbType.Text);
            if(AccountDAO.Instance.AddAccount(id,userName,password, type))
            {
                this.Close();
            }
        }
    }
}
