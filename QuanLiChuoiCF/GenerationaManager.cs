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
    public partial class fTableManager : Form
    {
        public fTableManager()
        {
            InitializeComponent();
            LoadMenu();
        }

       

        #region Method
        void LoadMenu()
        {
            List<DTO.Drink> branchList = DrinkDTO.Instance.LoadBranchList();
            foreach(DTO.Drink item in branchList)
            {
                Button btn = new Button()
                {
                    Width = DrinkDTO.TableWidth,
                    Height = DrinkDTO.TableHeigth
                };
                btn.Text = item.Name;
                flpBranch.Controls.Add(btn);
            }    

        }
        #endregion



        #region evnents
        private void fTableManager_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            f.ShowDialog();

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccountProfile f = new fAccountProfile();
            f.ShowDialog();

        }
        #endregion

    }
}
