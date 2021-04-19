using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiChuoiCF.DTO
{
    public class MaterialInWarehouse
    {
        public MaterialInWarehouse() { }

        public MaterialInWarehouse(string iDOfImportMaterial, string iDOfMaterial, int amount, int amountLeft, DateTime dateAdded, DateTime expiryDate)
        {
            this.iDOfImportMaterial = iDOfImportMaterial;
            this.IDOfMaterial = iDOfMaterial;
            this.Amount = amount;
            this.AmountLeft = amountLeft;
            this.DateAdded = dateAdded;
            this.ExpiryDate = expiryDate;
        }

        public MaterialInWarehouse(DataRow row)
        {
            this.iDOfImportMaterial = row["IDOfImportMaterial"].ToString().Trim();
            this.IDOfMaterial = row["IDOfMaterial"].ToString().Trim();
            this.Amount = (int)row["Amount"];
            this.AmountLeft = (int)row["AmountLeft"];
            this.DateAdded = (DateTime)row["DateAdded"];
            this.ExpiryDate = (DateTime)row["ExpiryDate"];
        }

        private string iDOfImportMaterial;
        private string iDOfMaterial;
        private int amount;
        private int amountLeft;
        private DateTime dateAdded;
        private DateTime expiryDate;

        public string IDOfImportMaterial { get => iDOfImportMaterial; set => iDOfImportMaterial = value; }
        public string IDOfMaterial { get => iDOfMaterial; set => iDOfMaterial = value; }
        public int Amount { get => amount; set => amount = value; }
        public int AmountLeft { get => amountLeft; set => amountLeft = value; }
        public DateTime DateAdded { get => dateAdded; set => dateAdded = value; }
        public DateTime ExpiryDate { get => expiryDate; set => expiryDate = value; }
    }
}
