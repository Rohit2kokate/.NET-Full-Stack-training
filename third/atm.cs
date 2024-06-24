using System;

namespace ATM
{
    class ATM
    {

        static void CheckBalance(decimal balance)
        {
            Console.WriteLine($"Your current balance is: ${balance}");
        }

        static decimal DepositCash(decimal balance)
        {
            Console.Write("Enter the amount to deposit: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal depositAmount) && depositAmount > 0)
            {
                balance += depositAmount;
                Console.WriteLine($"${depositAmount} has been deposited. Your new balance is: ${balance}");
            }
            else
            {
                Console.WriteLine("Invalid amount. Please enter a positive number.");
            }
            return balance;
        }

        static decimal WithdrawCash(decimal balance)
        {
            Console.Write("Enter the amount to withdraw: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal withdrawAmount) && withdrawAmount > 0)
            {
                if (withdrawAmount <= balance)
                {
                    balance -= withdrawAmount;
                    Console.WriteLine($"${withdrawAmount} has been withdrawn. Your new balance is: ${balance}");
                }
                else
                {
                    Console.WriteLine("Insufficient funds. Please enter a smaller amount.");
                }
            }
            else
            {
                Console.WriteLine("Invalid amount. Please enter a positive number.");
            }
            return balance;
        }
    }
}
