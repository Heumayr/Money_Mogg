using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    internal class LoaderCoins
    {
        internal static Coin[] LoadValueCoins(string filepath)
        {
            {
                return File.ReadAllLines(filepath)
                           .Skip(1)
                           .Select(l => l.Split(';'))
                           .Select(d =>
                           {
                               return new Coin()
                               { //Id; Name;Material;Value;Diameter;Thickness;Weight;Color
                                   Id = d[0],
                                   Currency_Name = d[1],
                                   Material = d[2],
                                   Value = Convert.ToInt32(d[3]),
                                   Diameter = Convert.ToDouble(d[4]),
                                   Thickness = Convert.ToDouble(d[5]),
                                   Weight = Convert.ToDouble(d[6]),
                                   Color = d[7]
                               };
                           }).ToArray();
            }
        }
    }
}