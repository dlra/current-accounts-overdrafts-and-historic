namespace TechnicalInterview
{
    public interface IAccount
    {
        string PersonName { get; set; }
        int Overdraft { get; set; }
        void Withdraw(int amount);
        void Deposit(decimal amount);
        decimal Balance { get; set; }
    }
}