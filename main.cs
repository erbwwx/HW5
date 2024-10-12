using System;

namespace BankApp
{
    public class BankAccount
    {
        public string AccountNumber { get; private set; }
        public decimal Balance { get; private set; }
        public string Owner { get; private set; }

        public BankAccount(string accountNumber, string owner)
        {
            AccountNumber = accountNumber;
            Owner = owner;
            Balance = 0;
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Успешно пополнено {amount}. Новый баланс: {Balance}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Успешно снято {amount}. Новый баланс: {Balance}");
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
        }

        public string GetAccountInfo()
        {
            return $"Account Number: {AccountNumber}, Owner: {Owner}, Balance: {Balance:C}";
        }

        public void Transfer(BankAccount targetAccount, decimal amount)
        {
            if (amount <= Balance)
            {
                Withdraw(amount);
                targetAccount.Deposit(amount);
                Console.WriteLine($"Переведено {amount} to {targetAccount.Owner}'s account.");
            }
            else
            {
                Console.WriteLine("Insufficient funds for transfer.");
            }
        }
    }

    // точка входа в программу
    class Program
    {
        static void Main(string[] args)
        {
            // Create two bank accounts
            BankAccount account1 = new BankAccount("123456789", "Bielenov Erbolat");
            BankAccount account2 = new BankAccount("987654321", "Miras Azamatuly");

            account1.Deposit(500);

            account1.Transfer(account2, 200);

            // информация об акк
            Console.WriteLine(account1.GetAccountInfo());
            Console.WriteLine(account2.GetAccountInfo());
        }
    }
}
