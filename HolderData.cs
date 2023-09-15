using System.Globalization;

namespace BankAccount;

public class HolderData
{
    public int Account { get; private set; }
    public string Holder { get; set; } = string.Empty;
    public double Balance { get; private set; }

    public HolderData(int account, string holder, double balance)
    {
        Account = account;
        Holder = holder;
        Balance = balance;
    }

    public void Deposit(double deposit)
    {
        Balance += deposit;
    }

    public void Withdraw(double withdraw)
    {
        Balance -= withdraw;
        Balance -= 5; // Tarifa de desconto por saque
    }

    public override string ToString()
    {
        return $"Conta {Account}, Titular: {Holder}, Saldo $ {Balance.ToString("F2", CultureInfo.InvariantCulture)}";
    }

}
