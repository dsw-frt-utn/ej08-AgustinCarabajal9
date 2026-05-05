using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class WholesaleSale : Sale
    {
        private const decimal DescuentoMayorista = 0.10m;

        public WholesaleSale(decimal amount) : base(amount) { }

        public override decimal CalculateTotal() => Amount * (1 - DescuentoMayorista);
    }
}
