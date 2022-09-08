using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollMultiThreading
{
    public class EmployeeDetails
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public string Gender { get; set; }
        public long PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Department { get; set; }
        public double BasicPay { get; set; }
        public double Deduction { get; set; }
        public double TaxablePay { get; set; }
        public double IncomeTax { get; set; }
        public double NetPay { get; set; }
        public EmployeeDetails(int ID, string Name, DateTime StartDate, string Gender, long PhoneNumber, string Address, string Department, double BasicPay, double Deduction, double TaxablePay, double IncomeTax, double NetPay)
        {
            this.ID = ID;
            this.Name = Name;
            this.StartDate = StartDate;
            this.Gender = Gender;
            this.PhoneNumber = PhoneNumber;
            this.Address = Address;
            this.Department = Department;
            this.BasicPay = BasicPay;
            this.Deduction = Deduction;
            this.TaxablePay = TaxablePay;
            this.IncomeTax = IncomeTax;
            this.NetPay = NetPay;
        }
    }
}