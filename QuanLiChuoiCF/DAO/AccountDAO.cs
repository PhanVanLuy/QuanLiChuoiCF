using QuanLiChuoiCF.DTO;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiChuoiCF.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;
        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }
        private AccountDAO() { }
        public bool Login(string userName, string passWord)
        {
            string query = "USP_Login @userName , @passWord ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, passWord });
            return result.Rows.Count > 0;
        }

        public Account GetAccountByUsername(string username)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from dbo.account where Username = '" + username + "'");

            if (data!=null)
            {
                return new Account(data.Rows[0]);
            }

            return null;
        }

        public List<Account> GetAccounts()
        {
            List<Account> accounts = new List<Account>();
            string query = "select * from dbo.Account ORDER BY Username";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                accounts.Add(new Account(item));
            }
            return accounts;
        }

        public bool AddAccount(string username, string iDOfEmployee, string password, int type)
        {
            string query = string.Format("insert dbo.Account(Username, IDOfEmployee, Password, Type)values(N'{0}', N'{1}', N'{2}', {3})", username, iDOfEmployee, password, type);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public bool UpdateAccount(string username, string iDOfEmployee, int type)
        {
            string query = string.Format("update dbo.Account set IDOfEmployee = '{1}', Type = {2} where Username = '{0}'", username, iDOfEmployee, type);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public bool DeleteAccount(string username)
        {
            string query = string.Format("delete dbo.Account where Username = N'{0}'", username);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public bool ChangePassword(string username, string password)
        {
            string query = string.Format("update dbo.Account set Password = N'{0}' where ID = N'{1}'", password, username);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

    }
}
