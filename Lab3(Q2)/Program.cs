using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Q2_
{
    public class Employee
    {
        protected int employeeID;
        private string FullName;
        private double salary;

        public int getEmployeeID()
        {
            return this.employeeID;
        }

        //constructor
        public Employee(int employeeId, String FullName, double salary)
        {
            this.employeeID = employeeId;
            this.FullName = FullName;
            this.salary = salary;
        }

        public void DisplayEmployeeInfo()
        {
            Console.WriteLine("Employee ID: " + employeeID);
            Console.WriteLine("Employee Name: " + FullName);
            Console.WriteLine("Salary: " + salary);
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Employee em = new Employee(101, "saman", 50000);
            em.DisplayEmployeeInfo();
            Console.WriteLine("Reading the employee id: " + em.getEmployeeID());


            em.salary = 60000;
        }
    }
}