using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Problema2
    {
        public string CrearResumenVenta(long productCode, string productDescription, int quantity, decimal unitPrice)
        {
            decimal total = CalcularTotal(quantity, unitPrice);


            var resumen = new
            {
                Code = productCode,
                Description = productDescription,
                Quantity = quantity,
                Total = total
            };

            return $"{resumen.Code}-{resumen.Description}-{resumen.Total}";
        }

        private decimal CalcularTotal(int quantity, decimal unitPrice)
        {
            if (quantity <= 0)
                return 0m;

            return quantity * unitPrice;
        }
    }
}

