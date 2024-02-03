using System.Runtime.CompilerServices;

namespace Money
{
    internal class Program
    {
        private static readonly string FilepathBankNotes = @"Data\Banknotes.csv";
        private static readonly string FilepathCoins = @"Data\Coins.csv";

        private static void Main(string[] args)
        {
            var bank = new Bank(FilepathCoins, FilepathBankNotes);

            var money = bank.GiveItToMe("FiveEuro", 10).ToList();

            money.AddRange(bank.GiveItToMe("TenCent", 100));

            foreach (var item in money)
            {
                Console.WriteLine(item);
            }
        }
    }
}