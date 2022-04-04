using EmployeePayrollUsingMultiThreading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace EmployeePayarollTestCases
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Given10Employee_WhenAddedToList_ShouldMatchEmployeeEntries()
        {
            List<EmployeeDetails> employeeDetails = new List<EmployeeDetails>();
            employeeDetails.Add(new EmployeeDetails(EmployeeId: 1, EmployeeName: "AAAAA", PhoneNumber: 123456789, Address: "Sagar", Department: "AA", Gender: "M", BasicPay: 2422242, Deduction: 43535, TaxablePay: 234324, IncomeTax: 424, NetPay: 555435)); ;
            employeeDetails.Add(new EmployeeDetails(EmployeeId: 2, EmployeeName: "BBBBB", PhoneNumber: 123456789, Address: "Udre", Department: "AA", Gender: "M", BasicPay: 2422242, Deduction: 43535, TaxablePay: 234324, IncomeTax: 424, NetPay: 555435));
            employeeDetails.Add(new EmployeeDetails(EmployeeId: 3, EmployeeName: "CCCCC", PhoneNumber: 123456789, Address: "Karnataka", Department: "AA", Gender: "M", BasicPay: 2422242, Deduction: 43535, TaxablePay: 234324, IncomeTax: 424, NetPay: 555435));
            employeeDetails.Add(new EmployeeDetails(EmployeeId: 4, EmployeeName: "DDDDD", PhoneNumber: 123456789, Address: "Pune", Department: "AA", Gender: "M", BasicPay: 2422242, Deduction: 43535, TaxablePay: 234324, IncomeTax: 424, NetPay: 555435));
            employeeDetails.Add(new EmployeeDetails(EmployeeId: 5, EmployeeName: "EEEEE", PhoneNumber: 123456789, Address: "Mumbai", Department: "AA", Gender: "M", BasicPay: 2422242, Deduction: 43535, TaxablePay: 234324, IncomeTax: 424, NetPay: 555435)); ;

            EmployeePayrollUsingThreads employeePayrollUsingThreads = new EmployeePayrollUsingThreads();
            DateTime startDateTime = DateTime.Now;
            employeePayrollUsingThreads.addEmployeeToPayroll(employeeDetails);
            DateTime stopDateTime = DateTime.Now;
            Console.WriteLine("Duration without thread: " + (stopDateTime - startDateTime));


        }

    }
}