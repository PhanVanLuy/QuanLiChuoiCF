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
            foreach(Employee employee in fAdmin.employees)
            {
                cbbID.Items.Add(employee.IDOfEmployee);
            }
        }

        private void btnOkClick(object sender, EventArgs e)
        {
            string id = cbbID.Text;
            string userName = txbUserName.Text;
            string passWord = txbPassword.Text;
            int type = int.Parse(cbbType.Text);
            if(AccountDAO.Instance.AddAccount(id,userName,passWord, type))
            {
                this.Close();
            }
        }
    }
}
