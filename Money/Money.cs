using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    internal abstract class Money
    {
        public string Id { get; set; } = string.Empty;

        public string Currency_Name { get; set; } = string.Empty;

        public string Material { get; set; } = string.Empty;

        public string Color { get; init; } = string.Empty;

        public int Value { get; init; }

        public double EuroValue => Value / 100.0;

        public abstract Money CreateMoney();

        public override string ToString()
        {
            return $"{Id} {EuroValue} {Currency_Name}";
        }
    }
}