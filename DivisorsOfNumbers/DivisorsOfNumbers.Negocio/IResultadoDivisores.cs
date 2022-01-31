using System.Collections.Generic;

namespace DivisorsOfNumbers.Negocio
{
    public interface IResultadoDivisores
    {
        HashSet<int> Divisores { get; }
        HashSet<int> DivisoresPrimos { get; }
        int Numero { get; }
    }
}