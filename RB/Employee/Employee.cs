using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RB.Employee
{
    public class Paycheck
    {
        private readonly decimal _hourlyRate;
        private readonly int _hoursWorked;
        public Paycheck(decimal hourlyRate, int hoursWorked)
        {
            _hourlyRate = hourlyRate;
            _hoursWorked = hoursWorked;
        }
        public decimal CalculatePay()
        {
            return _hourlyRate * _hoursWorked;
        }
    }
    /*public class Employee : Paycheck
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Employee(decimal hourlyRate, int hoursWorked)
            : base(hourlyRate, hoursWorked)
        {
        }
    }*/
    public class Employee
    {
        private readonly Paycheck _paycheck;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Employee(decimal hourlyRate, int hoursWorked)
        {
            _paycheck = new Paycheck(hourlyRate, hoursWorked);
        }
        public Employee(Paycheck paycheck)
        {
            _paycheck = paycheck;
        }
        public decimal CalculatePay()
        {
            return _paycheck.CalculatePay();
        }
    }
}
