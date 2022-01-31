using System;
using System.Collections.Generic;

namespace DivisorsOfNumbers.Negocio
{
    public class ObtensorDeDivisores
    {
        public ResultadoDivisores ObtenhaDivisores(int numero)
        {
            if (numero <= 0)
            {
                throw new Exception("O número informado é negativo ou igual a 0.");
            }

            HashSet<int> divisores = new HashSet<int>();
            int fatorIncremento = numero.EhImpar() ? 2 : 1;

            for (int i = 1; i <= numero; i += fatorIncremento)
            {
                if ((numero % i) == 0 || i == 1)
                {
                    divisores.Add(i);
                }
            }

            ResultadoDivisores resultado = new ResultadoDivisores(numero, divisores);

            return resultado;
        }
    }
}
