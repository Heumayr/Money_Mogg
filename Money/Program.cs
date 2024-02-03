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

            var money = bank.GiveItToMe("FiveEuro", 1).ToList();
            money.AddRange(bank.GiveItToMe("TenCent", 1));
            money.AddRange(bank.GiveItToMe("FiveHundredEuro", 1));

            var moneyArray = money.ToArray();

            Array.Sort(moneyArray);

            foreach (var item in moneyArray)
            {
                Console.WriteLine(item);
            }

            //var tempList = new List<IAddable>();

            //tempList.AddRange(money);
            //tempList.Add(bank);

            //var result = 0;

            //foreach (var item in tempList)
            //{
            //    //if(item is Money m)
            //    //{
            //    //}

            //    result = item.AddMe(result);
            //}

            //Console.WriteLine(result);
        }
    }
}