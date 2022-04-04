using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollUsingMultiThreading
{
    public class EmployeeDetails
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public long PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Department { get; set; }
        public string Gender { get; set; }
        public double BasicPay { get; set; }
        public double Deduction { get; set; }
        public double TaxablePay { get; set; }
        public double IncomeTax { get; set; }
        public double NetPay { get; set; }
        public DateTime StartDate { get; set; }

        public EmployeeDetails(int EmployeeId, string EmployeeName, long PhoneNumber, string Address, string Department, string Gender, double BasicPay, double Deduction, double TaxablePay, double IncomeTax, double NetPay)
        {
            this.EmployeeId = EmployeeId;
            this.EmployeeName = EmployeeName;
            this.PhoneNumber = PhoneNumber;
            this.Address = Address;
            this.Department = Department;
            this.Gender = Gender;
            this.BasicPay = BasicPay;
            this.Deduction = Deduction;
            this.TaxablePay = TaxablePay;
            this.IncomeTax = IncomeTax;
            this.NetPay = NetPay;
            this.StartDate = StartDate;

        }
    }
}
