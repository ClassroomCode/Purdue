using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComm.ConsoleApp
{
    internal class Class1
    {
        public static bool IsMatch(Decimal? v)
        {
            return (v!.Value > (Decimal)25.50);
        }
    }
}
