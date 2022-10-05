using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Converter
    {
        private decimal UsdUah, EurUah;
        public Converter(decimal u, decimal e)
        {
            UsdUah = u; EurUah = e;
        }
        public decimal UahToUsd(decimal h) => h / UsdUah;
        public decimal UahToEur(decimal h) => h / EurUah;
        public decimal UsdToUah(decimal u) => u * UsdUah;
        public decimal EurToUah(decimal e) => e * EurUah;

    }
}
