using EmployeePayrollMultiThreading;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace UnitTestPayRollTest
{
    public class Tests
    {
        List<EmployeeDetails> employeeDetails;
        EmployeePayrollOperation emppayroll;
        [SetUp]
        public void Setup()
        {
            employeeDetails = new List<EmployeeDetails>();
            emppayroll = new EmployeePayrollOperation();
        }

        [Test]
        public void CheckingTime_Required_For_Inserting_Details()
        {
            employeeDetails.Add(new EmployeeDetails(ID: 5, Name: "John", StartDate: Convert.ToDateTime("2024-05-12"), Gender: "M", PhoneNumber: 8546321452, Address: "Miami", Department: "Claims", BasicPay: 62000, Deduction: 300, TaxablePay: 200, IncomeTax: 100, NetPay: 61400));
            employeeDetails.Add(new EmployeeDetails(ID: 24, Name: "Sam", StartDate: Convert.ToDateTime("2024-07-17"), Gender: "M", PhoneNumber: 8475123698, Address: "Miami", Department: "Claims", BasicPay: 62000, Deduction: 300, TaxablePay: 200, IncomeTax: 100, NetPay: 61400));
            employeeDetails.Add(new EmployeeDetails(ID: 24, Name: "Hatie", StartDate: Convert.ToDateTime("2024-06-24"), Gender: "F", PhoneNumber: 8741245369, Address: "Miami", Department: "Claims", BasicPay: 62000, Deduction: 300, TaxablePay: 200, IncomeTax: 100, NetPay: 61400));
            employeeDetails.Add(new EmployeeDetails(ID: 27, Name: "Pablo", StartDate: Convert.ToDateTime("2024-01-08"), Gender: "M", PhoneNumber: 8563269874, Address: "Miami", Department: "Claims", BasicPay: 62000, Deduction: 300, TaxablePay: 200, IncomeTax: 100, NetPay: 61400));
            employeeDetails.Add(new EmployeeDetails(ID: 27, Name: "Rita", StartDate: Convert.ToDateTime("2024-03-02"), Gender: "F", PhoneNumber: 745124639, Address: "Miami", Department: "Claims", BasicPay: 62000, Deduction: 300, TaxablePay: 200, IncomeTax: 100, NetPay: 61400));

            // Without Threading
            DateTime StartDateTime = DateTime.Now;
            emppayroll.AddEmployee(employeeDetails);
            DateTime StopDateTimes = DateTime.Now;
            Console.WriteLine("Duration without threads: " + (StopDateTimes - StartDateTime));

            // With Threading
            DateTime startDateTimeThread = DateTime.Now;
            emppayroll.AddEmployeeToPayrollWithThread(employeeDetails);
            DateTime endDateTimeThread = DateTime.Now;
            Console.WriteLine("Duration with thread:" + (startDateTimeThread - endDateTimeThread));
        }
    }
}