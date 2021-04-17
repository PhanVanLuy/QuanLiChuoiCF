using QuanLiChuoiCF.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiChuoiCF.DAO
{
    class EmployeeDAO
    {
        private static EmployeeDAO instance;

        public static EmployeeDAO Instance {
            get { if (instance == null) instance = new EmployeeDAO(); return instance; }
            private set { instance = value; }
        }

        EmployeeDAO() {}

        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            string query = "select * from dbo.Employee";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                employees.Add(new Employee(item));
            }
            return employees;
        }

        public bool AddEmployee(string firstName, string lastName, string iDOfEmployee, string phoneNumber, string sexual
            , string address, DateTime dayIn, string shift, int dayOff, int bonus, int salary, string iDOfBranch)
        {
            DateTime myDateTime = dayIn;
            string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd");
            string query = string.Format("insert dbo.Employee(FirstName, LastName,IDOfEmployee, Phone_Number, " +
                "Sexual, Address, DayIn, Shift, DayOff, Bonus, Salary, IDOfBranch)"+
                "values(N'{0}',N'{1}',N'{2}',{3},N'{4}',N'{5}','{6}',N'{7}',{8},'{9}','{10}',N'{11}')",
                firstName, lastName, iDOfEmployee, phoneNumber, sexual, address, sqlFormattedDate, shift, dayOff, bonus, salary, iDOfBranch);
            return DataProvider.Instance.ExecuteNonQuery(query)>0;
        }

        public bool UpdateEmployee(string firstName, string lastName, string iDOfEmployee, string phoneNumber, string sexual
            , string address, DateTime dayIn, string shift, int dayOff, int bonus, int salary, string iDOfBranch)
        {
            DateTime myDateTime = dayIn;
            string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd");
            string query = string.Format("update dbo.Employee set FirstName = N'{0}', LastName = N'{1}', Phone_Number = {3}, Sexual = N'{4}', Address = N'{5}', DayIn = '{6}', Shift = N'{7}', DayOff = {8}, Bonus = '{9}', Salary = '{10}', IDOfBranch = N'{11}' where  IDOfEmployee = N'{2}'",
                 firstName, lastName, iDOfEmployee, phoneNumber, sexual, address, sqlFormattedDate, shift, dayOff, bonus, salary, iDOfBranch);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public bool DeleteEmployee(string iDOfEmployee)
        {
            string query = string.Format("delete dbo.Employee where IDOfEmployee = N'{0}'", iDOfEmployee);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

    }
}
