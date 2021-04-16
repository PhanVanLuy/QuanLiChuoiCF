﻿using QuanLiChuoiCF.DTO;
using System;
using System.Collections.Generic;
using System.Data;
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

        public Account GetAccountByID(string id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from dbo.account where ID = N'" + id + "'");

            if (data!=null)
            {
                return new Account(data.Rows[0]);
            }

            return null;
        }

        public List<Account> GetAccounts()
        {
            List<Account> accounts = new List<Account>();
            string query = "select * from dbo.Account";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                accounts.Add(new Account(item));
            }
            return accounts;
        }

        public bool AddAccount(string id, string displayName, string password, int type)
        {
            string query = string.Format("insert dbo.Account(ID, displayName, password, type)values(N'{0}', N'{1}', N'{2}, {3}')", id, displayName, password, type);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public bool UpdateAccount(string id, string displayName, string password, int type)
        {
            string query = string.Format("update dbo.Account set displayName = N'{0}', password = N'{1}', type = {2} where ID = N'{3}'", id, displayName, password, type);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public bool DeleteAccount(string id)
        {
            string query = string.Format("delete dbo.Account where ID = {0}", id);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

    }
}
