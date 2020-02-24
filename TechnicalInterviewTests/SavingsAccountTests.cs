using TechnicalInterview;
using Xunit;

namespace TechnicalInterviewTests
{
    public class SavingsAccountTests
    {
        private SavingsAccount _savingsAccount;
        public SavingsAccountTests()
        {
            _savingsAccount = new SavingsAccount() { Balance = 100m, PersonName = "Jane Bloggs" };
        }

        [Fact]
        public void Should_Throw_AccountOverdrawnException()
        {
            _savingsAccount.Deposit(10);
            Assert.Throws<AccountOverdrawnException>(() => _savingsAccount.Withdraw(111));
        }

        [Fact]
        public void Should_Throw_AlreadyWithdrawnTodayException()
        {
            _savingsAccount.Withdraw(10);
            Assert.Throws<AlreadyWithdrawnTodayException>(() => _savingsAccount.Withdraw(10));
        }
    }
}
