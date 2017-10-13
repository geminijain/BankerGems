using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankerGems
{
    public enum TypeOfAccount
    {
        Checking,
        Savings,
        Loan,
        CD
    }

    /// <summary>
    /// implementation of account class
    /// </summary>
    public class Account
    {
        private static int lastAccountNumber = 0;

        #region Properties
        /// <summary>
        /// properties of account class
        /// </summary>

        public int AccountNumber { get; } 
        public string EmailAddress { get; set; }
        public decimal Balance { get; private set; }

        public TypeOfAccount AccountType { get; set; }
        public DateTime CreatedDate { get; set; }
        #endregion

        #region Constructors
        public Account()
        {
            AccountNumber = ++lastAccountNumber;            //pre increment to lastAccountNumber and assign to AccountNumber;
        }
        #endregion


        #region Method
        public decimal Deposit(decimal amount)
        {
            Balance += amount;              // balance = balance + amount
            return Balance;
        }

        public void Withdraw(decimal amount)
        {
            Balance -= amount;              // balance = balance - amount
        }
        #endregion
    }
}
