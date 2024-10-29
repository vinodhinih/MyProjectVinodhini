using capgeminisample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capgeminisample
{
    class InsufficientFuncException : System.Exception
    {
        public InsufficientFuncException(string message) : base(message)
        { }
        public int TransactionAmount { get; set; }
        public int AccountBalance { get; set; }
        public string AccountName { get; set; }

        public InsufficientFuncException(int transactionAmount, int accountBalance, string accountNmae)
        {
            TransactionAmount = transactionAmount;
            AccountBalance = accountBalance;
            AccountName = accountNmae;
        }

    }
    class Account
    {
        public string name { get; set; }
        public int Balance { get; set; }

        public int Debit(int amount)
        {
            if (amount>Balance)
            {
                throw new InsufficientFuncException("Transactin Amount exceeds balance");
            }
            else
            {
                Balance -= amount;
                return Balance;
            }
        }
        public int Credit(int amount)
        {
            Balance += amount;
            return Balance;
        }

    }
}
class Program
{
    static void Main(string[] args)
    {
        try
        {

            Account account = new Account();

            string name = "vinodhini";

            int initialBalance = 35000;

            int debitAmount = 5000;

            account.Credit(initialBalance);

            Console.WriteLine($"Debiting {debitAmount} from the account...");
            account.Debit(debitAmount);
            Console.WriteLine($"New balance:{account.Balance}");
        }
        catch (InsufficientFuncException ex)
        {
            Console.WriteLine($"Insufficient funds! {ex.Message}");
        }
        //catch (FormatException ex)
        //{
        //    Console.WriteLine($"Invalid input! Please enter a valid number. {ex.Message}");
        //}
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }

    }
}
    

