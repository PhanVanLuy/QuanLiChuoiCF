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
    public partial class fChangePassword : Form
    {
        private Account account;
        public fChangePassword(Account account)
        {
            this.account = account;
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string password = txbPassword.Text;
            string newPassword = txbNewPassword.Text;
            string confirmNewPassword = txbConfirmNewPassword.Text;
            if(password == account.Password && newPassword == confirmNewPassword)
            {
                if (AccountDAO.Instance.ChangePassword(account.Id, newPassword))
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to change Password");
                }
            }
        }
    }
}
