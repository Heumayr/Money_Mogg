using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    internal abstract class Money : IComparable, IComparable<Money>, IAddable
    {
        public string Id { get; set; } = string.Empty;

        public string Currency_Name { get; set; } = string.Empty;

        public string Material { get; set; } = string.Empty;

        public string Color { get; init; } = string.Empty;

        public int Value { get; init; }

        public double EuroValue => Value / 100.0;

        //double IAddable.Value => throw new NotImplementedException();

        public abstract Money CreateMoney();

        public override string ToString()
        {
            return $"{Id} {EuroValue} {Currency_Name}";
        }

        //public abstract int CompareTo(object? obj)

        public int CompareTo(object? obj)
        {
            if (obj == null) return -1;

            if (obj is Money money)
            {
                //return this.Value <= money.Value ? -1 : 1;
                return money.Value.CompareTo(Value) * -1;
            }

            return -1;
        }

        public int CompareTo(Money? other)
        {
            if (other == null) return -1;

            return other.Value.CompareTo(Value) * -1;
        }

        public int AddMe(int value)
        {
            return value + Value;
        }
    }
}