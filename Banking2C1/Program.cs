using Banking2C1.Models.Domain;
using System;

namespace Banking2C1
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount myBa = new BankAccount("123-123123123-23")
            {
                Balance = 50
            };
            BankAccount anotherBa = new BankAccount("456-456456-456-99", 150658);

            Console.WriteLine($"Balance is currently {anotherBa.Balance} euro");

            anotherBa.Deposit(10000);

            Console.WriteLine($"Your salary has been paid");
            Console.WriteLine($"Your salary has been paid");
            Console.WriteLine($"Balance is currently {anotherBa.Balance} euro");

            anotherBa.Withdraw(1259);

            Console.WriteLine("You've bought the new iPhone xs max!");
            Console.WriteLine($"Balance is currently {anotherBa.Balance} euro");

            Console.ReadLine();
        }
    }
}
