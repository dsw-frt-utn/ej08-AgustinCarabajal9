using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Problema6
    {
        public string NormalizarCodigoProducto(string code)
        {
            return code.ToProductCode();
        }

        private bool EsCodigoValido(string codigoNormalizado)
        {
            return !string.IsNullOrWhiteSpace(codigoNormalizado) && codigoNormalizado != "SIN-CODIGO";
        }
    }
}
