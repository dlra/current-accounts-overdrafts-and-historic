using System;
using System.Collections.Generic;

namespace TechnicalInterview
{
    public class SavingsAccount
    {
        public string PersonName { get; set; }
        public decimal Balance { get; set; }
        public DateTime LastWithdrawalDate { get; set; }
 
        public void Deposit(decimal amount)
        {
            var tempValue = Balance;
            var newValue = tempValue + amount;
            Balance = newValue;
        }

        public void Withdraw(int amount)
        {
            if (LastWithdrawalDate.Date == DateTime.Now.Date)
                throw new AlreadyWithdrawnTodayException();
            
            var tempValue = Balance;
            var newValue = tempValue - amount;
            if (newValue < 0)
                throw new AccountOverdrawnException();

            Balance = newValue;
        }
    }
}