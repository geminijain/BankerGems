using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankerGems
{/// <summary>
/// factory design pattern implementation
/// </summary>
    public static class BankFactory
    {
        private static BankModel db = new BankModel(); 
        
        /// <summary>
    /// bankFactory creats an account
    /// </summary>
    /// <param name="emailAddress"> email address of the account</param>
    /// <param name="accountType"> type of account</param>
    /// <param name="initialDeposit">intial amount to deposit</param>
    /// <returns>returns the new account</returns>
        public static Account CreateAccount(string emailAddress, TypeOfAccount accountType = TypeOfAccount.Checking, decimal initialDeposit = 0)
        {
            var account = new Account
            {
                EmailAddress = emailAddress,
                AccountType = accountType
            };
           
            if(initialDeposit > 0)
            {
                account.Deposit(initialDeposit);
            }
            db.Accounts.Add(account);
            db.SaveChanges();
            return account;
        }

        public static List<Account> getAllAccounts(string emailAddress)
        {
            return db.Accounts.Where(a => a.EmailAddress == emailAddress).ToList();
        }
    }
}
