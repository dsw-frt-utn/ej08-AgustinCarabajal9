using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Problema3
    {
       public string CompararCopias(int originalValue, Product product)
       {
            int valorCopia = originalValue;
            valorCopia = Incrementar(valorCopia);

                                                                                                                                                    Product productoCopia = product;
            string nuevaDescripcion = GenerarDescripcionModificada(productoCopia.Description);
            productoCopia.ActualizarDescripcion(nuevaDescripcion);

            return $"{originalValue}-{valorCopia}-{product.Description}";
        }

        private int Incrementar(int valor){  
            return valor + 1; 
        }
        private string GenerarDescripcionModificada(string descripcionOriginal)
        {
            return $"{descripcionOriginal} [modificado]";
        }
            
    }
}

    

