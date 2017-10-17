using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Key] 
        public int AccountNumber { get; private set; } 

        [Required]
        [StringLength(50, ErrorMessage = "Email address cannot be more than 50 characters in length")]
        public string EmailAddress { get; set; }
        public decimal Balance { get; private set; }

        [Required]
        public TypeOfAccount AccountType { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual ICollection<Transaction> Transactions { get; set; }
        #endregion

        #region Constructors
        public Account()
        {
            AccountNumber = ++lastAccountNumber;            //pre increment to lastAccountNumber and assign to AccountNumber;
            CreatedDate = DateTime.UtcNow;
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
