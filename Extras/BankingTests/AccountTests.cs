using NUnit.Framework;
using BankAccountManager;

namespace BankingTests;

[TestFixture]
public class AccountTests
{
    private Account _account;

    [SetUp]
    public void Setup()
    {
        _account = new Account("12345");
    }

    [Test]
    public void TestInitialBalanceIsZero()
    {
        Assert.That(_account.GetBalance(), Is.EqualTo(0));
    }

    [Test]
    public void TestDepositIncreasesBalance()
    {
        _account.Deposit(100);
        Assert.That(_account.GetBalance(), Is.EqualTo(100));
    }

    [Test]
    public void TestMultipleDeposits()
    {
        _account.Deposit(100);
        _account.Deposit(50);
        Assert.That(_account.GetBalance(), Is.EqualTo(150));
    }

    [Test]
    public void TestWithdrawDecreasesBalance()
    {
        _account.Deposit(100);
        _account.Withdraw(40);
        Assert.That(_account.GetBalance(), Is.EqualTo(60));
    }

    [Test]
    public void TestWithdrawMoreThanBalance()
    {
        _account.Deposit(100);
        _account.Withdraw(150);
        // Balance should remain unchanged if withdrawal amount exceeds balance
        Assert.That(_account.GetBalance(), Is.EqualTo(100));
    }

    [Test]
    public void TestNegativeDeposit()
    {
        _account.Deposit(-50);
        Assert.That(_account.GetBalance(), Is.EqualTo(0));
    }

    [Test]
    public void TestNegativeWithdrawal()
    {
        _account.Deposit(100);
        _account.Withdraw(-50);
        Assert.That(_account.GetBalance(), Is.EqualTo(100));
    }
}
