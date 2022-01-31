using System;
using System.Collections.Generic;
using System.Text;

namespace DivisorsOfNumbers.Negocio
{
    public static class MetodosDeExtensao
    {
        public static bool EhImpar(this int numero)
        {
            int resto = numero % 2;
            return resto != 0;
        }

        public static bool EhNumeroPrimo(this int numero)
        {
            int cont = 0;
            for (int i = 1; i <= numero; i += 1)
            {
                if ((numero % i) == 0 || i == 1)
                {
                    cont++;

                    if (cont > 2)
                        return false;
                }
            }

            return true;
        }

    }
}
