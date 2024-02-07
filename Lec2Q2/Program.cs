using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Q2
{
    public class BankAccount
    {
        public int AccountNumber;
        public Double Balance;

        public void deposite(double amount)
        {
            //updating balance
            Balance += amount;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();

            Console.Write("Enter the account number : ");
            account.AccountNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter the deposite amount : ");
            double amount = double.Parse(Console.ReadLine());

            account.deposite(amount);

            Console.WriteLine("Account number : " + account.AccountNumber);
            Console.WriteLine("Update balance : " + account.Balance);

            Console.ReadLine();

        }
    }
}