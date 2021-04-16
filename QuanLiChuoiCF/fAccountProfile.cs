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
    public partial class fAccountProfile : Form
    {
        private static Account account;
        public fAccountProfile()
        {
            InitializeComponent();
            Load();
        }

        public void Load()
        {
            account = AccountDAO.Instance.GetAccountByID(fLogin.userName);
            txbID.Text = account.Id;
            txbUserName.Text = account.DisplayName;
        }
    }
}
