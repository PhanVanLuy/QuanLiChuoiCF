using System;
using QuanLiChuoiCF.DTO;
using QuanLiChuoiCF.DAO;
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
    public partial class fAddSupplier : Form
    {
        private static List<Supplier> suppliers;
    public static List<Supplier> Suppliers { get => suppliers; set => suppliers = value; }

        public fAddSupplier()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_AddSupplier_Click(object sender, EventArgs e)
        {
            Supplier sp = new Supplier();
            suppliers = SupplierDAO.Instance.GetSuppliers();
            int max = 0;
            foreach(Supplier item in suppliers)
            {
                if(Int16.Parse(item.IDOfSupplier.Substring(2))>max)
                {
                    max = Int16.Parse(item.IDOfSupplier.Substring(2));
                }                 
            }
            if(max<9)
            {
                sp.IDOfSupplier = string.Concat("SP0", max + 1);
            }
            else
            {
                sp.IDOfSupplier = string.Concat("SP", max + 1);
            }
            txb_ID.Text = sp.IDOfSupplier;
            sp.Name= txb_Name.Text;
            sp.Address= txb_Address.Text;
            if(SupplierDAO.Instance.AddSupplier(sp.IDOfSupplier,sp.Name, sp.Address))
            {
                MessageBox.Show("Supplier Was Added Successfully!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed To Add Supplier!");
                txb_Name.Focus();
            }
        }
    }
}
