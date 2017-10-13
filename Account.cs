using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankerGems
{
    /// <summary>
    /// implementation of account class
    /// </summary>
    class Account
    {
        #region Properties
        /// <summary>
        /// properties of account class
        /// </summary>

        public int AccountNumber { get; set; } 
        public string EmailAddress { get; set; }
        public decimal Balance { get; set;}

        public string AccountType { get; set; }
        public DateTime CreatedDate { get; set; }
#endregion   
    }
}
