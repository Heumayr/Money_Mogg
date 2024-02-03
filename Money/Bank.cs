using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    internal class Bank : IAddable
    {
        private static bool isInit = false;

        private static Dictionary<string, Money> currency = new();

        public int Value => currency.Count();

        public Bank(string coinPath, string billPath)
        {
            Init(coinPath, billPath);
        }

        private void Init(string coinPath, string billPath)
        {
            if (isInit) return;

            var coins = LoaderCoins.LoadValueCoins(coinPath);

            var bills = LoaderBanknotes.LoadBankNotes(billPath);

            foreach (var coin in coins)
            {
                if (!currency.ContainsKey(coin.Id))
                    currency.Add(coin.Id, coin);
            }

            foreach (var bill in bills)
            {
                if (!currency.ContainsKey(bill.Id))
                    currency.Add(bill.Id, bill);
            }

            isInit = true;
        }

        public Money[] GiveItToMe(string currencyId, int amount)
        {
            var result = new List<Money>();

            if (!currency.ContainsKey(currencyId))
            {
                Console.WriteLine("This currency is not valid");
                return result.ToArray();
            }

            if (amount <= 0)
            {
                Console.WriteLine("Not valid amount");
                return result.ToArray();
            }

            for (var i = 0; i < amount; i++)
            {
                result.Add(currency[currencyId].CreateMoney());
            }

            return result.ToArray();
        }

        //public int AddMe(int value)
        //{
        //    return value - Value;
        //    //return value + Value * 100;
        //}
    }
}