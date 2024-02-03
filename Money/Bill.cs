using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    internal sealed class Bill : Money
    {
        public double Length { get; init; } = 0;
        public double Width { get; init; } = 0;

        public override Money CreateMoney()
        {
            return new Bill()
            {
                Id = Id,
                Material = Material,
                Color = Color,
                Currency_Name = Currency_Name,
                Value = Value,
                Length = Length,
                Width = Width,
            };
        }

        //public override string ToString()
        //{
        //    return $"{base.ToString()} {Length}";
        //}
    }
}