using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Problema4
    {
        private const int NotaMinima = 0;
        private const int NotaMaxima = 10;

        public double CalcularPromedio(int? nota1, int? nota2, int? nota3)
        {
            var notasValidas = FiltrarNotasValidas(nota1, nota2, nota3);

            if (notasValidas.Count == 0)
                return 0;

            return notasValidas.Sum() / (double)notasValidas.Count;
        }

        private List<int> FiltrarNotasValidas(params int?[] notas) //esta parte no me salia bien y me ayude un poco de la IA :D
        {
            var resultado = new List<int>();

            foreach (var nota in notas)
            {
                if (nota.HasValue && nota.Value >= NotaMinima && nota.Value <= NotaMaxima)
                {
                    resultado.Add(nota.Value);
                }
            }

            return resultado;
        }

    }
}
