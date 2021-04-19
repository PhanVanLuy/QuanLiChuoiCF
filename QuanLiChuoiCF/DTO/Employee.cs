using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiChuoiCF.DTO
{
    public class Employee
    {
        public Employee() { }

        private Employee(string firstName, string lastName, string iDOfEmployee, string phoneNumber, string sexual
            , string address, DateTime dayIn, string shift, int dayOff, int bonus, int salary, string iDOfBranch)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.iDOfEmployee = iDOfEmployee;
            this.phoneNumber = phoneNumber;
            this.sexual = sexual;
            this.address = address;
            this.dayIn = dayIn;
            this.shift = shift;
            this.dayOff = dayOff;
            this.bonus = bonus;
            this.salary = salary;
            this.iDOfBranch = iDOfBranch;
        }
        public Employee(DataRow row)
        {
            this.firstName = ((string)row["FirstName"]).Trim();
            this.lastName = ((string)row["LastName"]).Trim();
            this.iDOfEmployee = ((string)row["IDOfEmployee"]).Trim();
            this.phoneNumber = ((string)row["Phone_Number"]).Trim();
            this.sexual = ((string)row["Sexual"]).Trim();
            this.address = ((string)row["Address"]).Trim();
            this.dayIn = (DateTime)row["DayIn"];
            this.shift = ((string)row["Shift"]).Trim();
            Byte tmp = (Byte)row["DayOff"];
            this.dayOff = tmp;
            this.bonus = (int)(float.Parse(row["Bonus"].ToString()));
            this.salary = (int)(float.Parse(row["Salary"].ToString()));
            this.iDOfBranch = ((string)row["IDOfBranch"]).Trim();
        }

        private string firstName;
        private string lastName;
        private string iDOfEmployee;
        private string phoneNumber;
        private string sexual;
        private string address;
        private DateTime dayIn;
        private string shift;
        private int dayOff;
        private int bonus;
        private int salary;
        private string iDOfBranch;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string IDOfEmployee { get => iDOfEmployee; set => iDOfEmployee = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Sexual { get => sexual; set => sexual = value; }
        public string Address { get => address; set => address = value; }
        public DateTime DayIn { get => dayIn; set => dayIn = value; }
        public string Shift { get => shift; set => shift = value; }
        public int DayOff { get => dayOff; set => dayOff = value; }
        public int Bonus { get => bonus; set => bonus = value; }
        public int Salary { get => salary; set => salary = value; }
        public string IDOfBranch { get => iDOfBranch; set => iDOfBranch = value; }
    }
}
