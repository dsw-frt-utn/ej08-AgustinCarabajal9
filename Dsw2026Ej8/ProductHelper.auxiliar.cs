using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Dsw2026Ej8
{
    public partial class ProductHelper
    {
        private const string CulturaMoneda = "es-AR";
        private const string FormatoDeCodigo = "[{0}]";
        private string FormatearPrecio(decimal precio)
        {

            //la f funcion cultureInfo formatea el precio a la cultura especificada, 
            //"es-AR" es para Argentina, lo que incluye el simbolo de moneda y
            //el formato adecuado
            CultureInfo cultura = new CultureInfo(CulturaMoneda); 
            return precio.ToString("C", cultura); //este formato "C" indica que queremos formatear como moneda
        }
        private string FormatearCodigo(long code)
        {
            return string.Format(FormatoDeCodigo, code); 
            //este formato "[{0}]" indica que queremos mostrar el código entre corchetes
        }
    }
}


