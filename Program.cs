﻿using System;
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
            // instantiate an object
            var account = new Account();
           // account.AccountNumber = 1234;
            account.EmailAddress = "test@test.com";
            account.AccountType = "Savings";
            // account.Balance = 198429308423;

            account.Deposit(100);

            Console.WriteLine($"AN : {account.AccountNumber}, EA: { account.EmailAddress}, Balance : {account.Balance:C}, AT : {account.AccountType}");

            var account2 = new Account();

            Console.WriteLine($"AN : {account2.AccountNumber}, EA: { account2.EmailAddress}, Balance : {account2.Balance:C}, AT : {account2.AccountType}");
        }
    }
}
