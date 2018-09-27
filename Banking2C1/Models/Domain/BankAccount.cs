using System;
using System.Collections.Generic;
using System.Text;

namespace Banking2C1.Models.Domain
{
    public class BankAccount
    {
        #region comments
        /*private string _accountNumber;
        private decimal _balance;

        public decimal GetBalance()
        {
            return _balance;
        }

        private void SetBalance(decimal value)
        {
            _balance = value;
        }*/

        //public decimal Balance { get; private set; } //identiek als al het bovenstaande ivm balance! => automatic property
        /*
         gebruiken? vb bankaccount ba:
         ba.Balance = 20;
         console.writeLine(ba.Balance); 
         ba.Balance = ba.Balance + 100;
         */ 
        #endregion

        #region fields
        public const decimal WithdrawCost = 0.10M;
        private decimal _balance;
        #endregion

        #region properties
        public string AccountNumber { get; set; }
        public decimal Balance
        {
            get { return _balance; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Invalid value for balance"); //voorwaarde toevoegen
                _balance = value; //waarde van property is binnen property gekend als "value"
            }
        }
        #endregion

        #region constructors
        public BankAccount(String accountNumber)
        {
            AccountNumber = accountNumber;
        }

        public BankAccount(String accountNumber, decimal bedrag) : this(accountNumber)
        {
            //AccountNumber = accountNumber; of: zie hoofding constructor
            Balance = bedrag;
        }
        #endregion

        #region methods
        public void Deposit(decimal amount)
        {
            Balance += amount;
        }
        public void Withdraw(decimal amount)
        {
            Balance -= amount + WithdrawCost;
        } 
        #endregion
    }
}
