namespace BankAccountManager;

public class Account
{
    private decimal _balance;
    private string _accountNumber;

    public Account(string accountNumber)
    {
        _accountNumber = accountNumber;
        _balance = 0;
    }

    public string GetAccountNumber()
    {
        return _accountNumber;
    }

    public decimal GetBalance()
    {
        return _balance;
    }

    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            _balance = _balance + amount;
        }
    }

    public void Withdraw(decimal amount)
    {
        if (amount > 0 && amount <= _balance)
        {
            _balance = _balance - amount;
        }
    }
}
