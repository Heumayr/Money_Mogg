using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    internal interface IAddable
    {
        int Value { get; }

        int AddMe(int value)
        {
            return value + Value;
        }
    }
}