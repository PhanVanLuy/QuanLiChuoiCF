using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiChuoiCF.DTO
{
    public class DetailOfBillExport
    {
        public DetailOfBillExport() { }

        private DetailOfBillExport(string iDOfBillExport, string iDOfMaterial, int count)
        {
            this.IDOfBillExport = iDOfBillExport;
            this.IDOfMaterial = iDOfMaterial;
            this.Count = count;
        }

        public DetailOfBillExport(DataRow row)
        {
            this.IDOfBillExport = (row["IDOfBillExport"].ToString()).Trim();
            this.IDOfMaterial = (row["IDOfMaterial"].ToString()).Trim();
            this.Count = (int)row["Count"];
        }

        private string iDOfBillExport;
        private string iDOfMaterial;
        private int count;

        public string IDOfBillExport { get => iDOfBillExport; set => iDOfBillExport = value; }
        public string IDOfMaterial { get => iDOfMaterial; set => iDOfMaterial = value; }
        public int Count { get => count; set => count = value; }
    }
}
