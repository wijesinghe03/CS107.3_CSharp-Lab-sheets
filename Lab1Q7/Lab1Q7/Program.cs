using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Q7
{
    class ATM
    {
        private double balance;

        public ATM()
        {
            balance = 0;
        }

        public void DisplayBalance()
        {
            Console.WriteLine($"Your current balance is ${balance}");
        }


        public void Deposit(double amount)
        {
            balance += amount;
            Console.WriteLine($"${amount} deposited successfully.");
            DisplayBalance();
        }

        public void Withdraw(double amount)
        {
            if (amount > balance)
            {
                Console.WriteLine("Insufficient funds.");
            }
            else
            {
                balance -= amount;
                Console.WriteLine($"${amount} withdrawn successfully.");
                DisplayBalance();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ATM atm = new ATM();

            while (true)
            {
                Console.WriteLine("\n1. Check Balance");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        atm.DisplayBalance();
                        break;
                    case "2":
                        Console.Write("Enter the amount to deposit: ");
                        double depositAmount = Convert.ToDouble(Console.ReadLine());
                        atm.Deposit(depositAmount);
                        break;
                    case "3":
                        Console.Write("Enter the amount to withdraw: ");
                        double withdrawAmount = Convert.ToDouble(Console.ReadLine());
                        atm.Withdraw(withdrawAmount);
                        break;
                    case "4":
                        Console.WriteLine("Thank you for using our ATM. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}