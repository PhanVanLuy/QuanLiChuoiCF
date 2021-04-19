using QuanLiChuoiCF.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiChuoiCF.DAO
{
    class BranchDAO
    {
        private static BranchDAO instance;
        public static BranchDAO Instance
        {
            get { if (instance == null) instance = new BranchDAO(); return instance; }
            private set { instance = value; }
        }
        private BranchDAO() { }

        public List<Branch> GetBranches()
        {
            List<Branch> branches = new List<Branch>();

            string query = "select * from Branch ORDER BY IDOfBranch";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach(DataRow item in data.Rows)
            {
                branches.Add(new Branch(item));
            }

            return branches;
        }

        public bool AddBranch(string branchId, string branchName, string manager)
        {
            string query = string.Format("insert dbo.Branch(IDOfBranch, Name, Manager)values(N'{0}', N'{1}', N'{2}')", branchId, branchName, manager);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public bool UpdateBranch(string branchId, string branchName, string manager)
        {
            string query = string.Format("update dbo.Branch set Name = N'{0}', manager = N'{1}' where IDOfBranch = N'{2}'", branchName, manager, branchId);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public bool DeleteBranch(string branchId)
        {
            string query = string.Format("delete dbo.Branch where IDOfBranch = N'{0}'", branchId);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

    }
}
