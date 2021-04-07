using QuanLiChuoiCF.DAO;
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
        public fAdmin()
        {
            InitializeComponent();
            LoadAccountList();
            LoadCFlist();

        }
        void LoadAccountList()
        {
            String query = "exec dbo.USP_GetAccountByUserName @userName";
             dtgvTaiKhoan.DataSource =DataProvider.Instance.ExecuteQuery(query, new object[] { "NV01"});


        }
        void LoadCFlist()
        {
            String query = "select * from dbo.drink";
            dtgvDanhMuc.DataSource = DataProvider.Instance.ExecuteQuery(query);
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
    }
}
