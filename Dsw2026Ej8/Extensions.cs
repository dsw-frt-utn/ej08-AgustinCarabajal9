using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public static class Extensions
    {
        public static string ToProductCode(this string? code)
        {
            if (code is null)
            {
                return "SIN-CODIGO";
            }
                

            return code //esta parte tambien me ayude con la IA :D
                .Trim()
                .ToUpper()
                .Replace(" ", "-");
        }
    }
}
