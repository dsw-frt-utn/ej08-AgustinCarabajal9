using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Problema5
    {
        public decimal ObtenerImporteFinal(Sale sale)
        {
            return sale.CalculateTotal();
        }

        private string ObtenerTipoVenta(Sale sale)
        {
            return sale.GetType().Name;
        } 
    }
}
