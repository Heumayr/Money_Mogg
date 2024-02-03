using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Money
{
    internal class LoaderBanknotes
    {
        internal static Bill[] LoadBankNotes(string filepath)
        {
            //Id, Name; Material; Value; Lenght; Width; Color

            {
                return File.ReadAllLines(filepath)
                           .Skip(1)
                           .Select(l => l.Split(';'))
                           .Select(d =>
                           {
                               return new Bill()
                               {
                                   Id = d[0],
                                   Currency_Name = d[1],
                                   Material = d[2],
                                   Value = Convert.ToInt32(d[3]),
                                   Length = Convert.ToDouble(d[4]),
                                   Width = Convert.ToDouble(d[5]),
                                   Color = d[6]
                               };
                           }).ToArray();
            }
        }
    }
}