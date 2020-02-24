namespace TechnicalInterview
{
    public class CurrentAccount : IAccount
    {
        #region Don't Modify This Section!
        public string PersonName { get; set; }
        public int Overdraft { get; set; }
        public decimal Balance { get; set; }
        /// <summary>
        /// Don't modify this.
        /// </summary>
        /// <param name="amount"></param>
        public void Deposit(decimal amount)
        {
            var tempValue = Balance;
            var newValue = tempValue + amount;
            Balance = newValue;
        }

        #endregion
        public void Withdraw(int amount)
        {
            var tempValue = Balance;
            var newValue = tempValue - amount;
            Balance = newValue;
        }
    }
}