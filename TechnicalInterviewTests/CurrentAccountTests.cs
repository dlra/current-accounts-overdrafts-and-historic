using TechnicalInterview;
using Xunit;

namespace TechnicalInterviewTests
{
    public class CurrentAccountTests
    {
        private IAccount _currentAccount;
        public CurrentAccountTests()
        {
            _currentAccount = new CurrentAccount() { Balance = 100m, Overdraft = 50, PersonName = "James Bond" };
        }

        [Fact]
        public void Should_Deposit_Amount()
        {
            _currentAccount.Deposit(10);
            Assert.Equal(110, _currentAccount.Balance);
        }

        [Fact]
        public void Should_Withdraw_Amount()
        {
            _currentAccount.Withdraw(90);
            Assert.Equal(10, _currentAccount.Balance);
        }

        [Fact]
        public void Should_Throw_AccountOverdrawnException()
        {
            _currentAccount.Deposit(10);
            Assert.Throws<AccountOverdrawnException>(() => _currentAccount.Withdraw(170));
        }
    }
}
