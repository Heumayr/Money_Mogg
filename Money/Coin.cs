using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    internal sealed class Coin : Money
    {
        public double Thickness { get; init; } = 0;
        public double Weight { get; init; } = 0;
        public double Diameter { get; init; } = 0;

        public override Money CreateMoney()
        {
            return new Coin()
            {
                Id = Id,
                Material = Material,
                Color = Color,
                Currency_Name = Currency_Name,
                Value = Value,
                Thickness = Thickness,
                Weight = Weight,
                Diameter = Diameter,
            };
        }
    }
}