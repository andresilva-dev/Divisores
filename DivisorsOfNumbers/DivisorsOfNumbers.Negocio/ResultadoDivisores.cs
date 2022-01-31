using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DivisorsOfNumbers.Negocio
{
    public class ResultadoDivisores : IResultadoDivisores
    {
        private int _numero;
        private HashSet<int> _divisores;
        private HashSet<int> _divisoresPrimos;
        public ResultadoDivisores(int numero, HashSet<int> divisores)
        {
            if (divisores == null)
            {
                throw new Exception("O valor informado para os divisores é inválido.");
            }

            _numero = numero;
            _divisores = divisores;
        }

        public int Numero => _numero;

        public HashSet<int> Divisores => _divisores;

        public HashSet<int> DivisoresPrimos
        {
            get
            {
                if (_divisoresPrimos == null)
                    _divisoresPrimos = _divisores.Where(a => a.EhPrimo()).Select(n => n).ToHashSet();

                return _divisoresPrimos;
            }
        }

        public override bool Equals(object obj)
        {
            return (obj is ResultadoDivisores objeto) && objeto.Numero == Numero;
        }

        public override string ToString()
        {
            return $"Resultado do número: {Numero}";
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
