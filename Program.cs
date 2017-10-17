using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankerGems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********************************");
            Console.WriteLine("Welcome to my bank");
            Console.WriteLine("********************************");
            while (true)
            {                                  // never ending loop, will continue until it exit at '0'
                Console.WriteLine("Please choose an option below : ");
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Create an account");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Print all accounts");
                Console.WriteLine("5. Print all transaction");

                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "0":
                        return;

                    case "1":
                        Console.Write("Email Address :");
                        var emailAddress = Console.ReadLine();
                        Console.WriteLine("Account type: ");
                        var accountTypes = Enum.GetNames(typeof(TypeOfAccount));
                        for (var i = 0; i < accountTypes.Length; i++)
                        {
                            Console.WriteLine($"{i}. {accountTypes[i]}");
                        }
                        var accountType = (TypeOfAccount)Enum.Parse(typeof(TypeOfAccount), Console.ReadLine());
                        Console.Write("Amount to deposit: ");
                        var amount = Convert.ToDecimal(Console.ReadLine());
                        var account = BankFactory.CreateAccount(emailAddress, accountType, amount);
                        Console.WriteLine($"AN: {account.AccountNumber}, AT: {account.AccountType}, Balance: {account.Balance:C}, Created Date:{account.CreatedDate}");
                        break;

                    case "2":
                        PrintAllAccounts();
                        Console.Write("AccountNumber:");
                        var accountNumber = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Amount to deposit:");
                        amount = Convert.ToDecimal(Console.ReadLine());
                        BankFactory.Deposit(accountNumber, amount);
                        Console.WriteLine("Deposit was successful !");
                        break;

                    case "3":
                        PrintAllAccounts();
                        Console.Write("AccountNumber:");
                        accountNumber = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Amount to withdraw:");
                        amount = Convert.ToDecimal(Console.ReadLine());
                        BankFactory.Withdraw(accountNumber, amount);
                        Console.WriteLine("Withdraw  was successful !");
                        
                        break;
                      
                    case "4":
                        PrintAllAccounts();
                        break;

                    default:
                        break;

                   case "5":
                        PrintAllAccounts();
                        Console.Write("Account Number:");
                        accountNumber = Convert.ToInt32(Console.ReadLine());
                        var transaction = BankFactory.GetAllTransactions(accountNumber);
                        foreach(var tran in transactions){
                            Console.WriteLine($"id:{tran.TransactionId}, Date:{tran.TransactionDate}, Type: {tran.TypeOfTransaction}, Amount:{tran.Amount},Description:{tran.Description}");
}
                        break;


                }
            }
        }

        private static void PrintAllAccounts(){
            Console.Write("Email Address :"); 
            var emailAddress = Console.ReadLine();
            var accounts = BankFactory.getAllAccounts(emailAddress);
            foreach(var item in accounts)
            {
            Console.WriteLine($"AN: {item.AccountNumber}, AT: {item.AccountType}, Balance: {item.Balance:C}, Created Date:{item.CreatedDate}");
            }
        }
    }
}
