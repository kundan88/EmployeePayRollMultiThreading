using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollMultiThreading
{
    public class EmployeePayrollOperation
    {
        public List<EmployeeDetails> employeeDatalist = new List<EmployeeDetails>();
        public void AddEmployee(List<EmployeeDetails> employeeDatalist)
        {
            employeeDatalist.ForEach(employeeData =>
            {
                Console.WriteLine("Employee being added: " + employeeData.Name);
                this.AddEmployeePayroll(employeeData);
                Console.WriteLine("Employee added: " + employeeData.Name);
            }
            );
            Console.WriteLine(this.employeeDatalist.ToString());
        }
        public void AddEmployeePayroll(EmployeeDetails employee)
        {
            employeeDatalist.Add(employee);
        }
        public void AddEmployeeToPayrollWithThread(List<EmployeeDetails> empPayrollsList)
        {
            empPayrollsList.ForEach(empPayrollData =>
            {
                Thread thread = new Thread(() =>
                {
                    Console.WriteLine("Employee being Added: " + empPayrollData.Name);
                    this.AddEmployeePayroll(empPayrollData);
                    Console.WriteLine("Employee added: " + empPayrollData.Name);
                });
                thread.Start();
            });
            Console.WriteLine(empPayrollsList.Count);
        }
    }

}