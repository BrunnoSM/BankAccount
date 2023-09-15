using System.Globalization;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            double accountBalance = 0.0;
            double depositAmount = 0.0;

            Console.Write("Entre o número da conta: ");
            int accountNumber = int.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            Console.Write("Entre o titular da conta: ");
            string accountHolder = Console.ReadLine()!;
            Console.Write("Haverá depósito inicial (s/n)? ");
            char Deposit = char.Parse(Console.ReadLine()!.ToUpper());

            if (Deposit == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                depositAmount = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
                accountBalance = depositAmount;
            }

            HolderData client = new HolderData(accountNumber, accountHolder, accountBalance);

            Console.WriteLine("\nDados da conta: ");
            Console.WriteLine(client);

            Console.Write("\nEntre um valor para depósito: ");
            depositAmount = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            client.Deposit(depositAmount);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(client);

            Console.Write("\nEntre um valor para saque: ");
            double withdrawAmount = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            client.Withdraw(withdrawAmount);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(client);

        }
    }
}
