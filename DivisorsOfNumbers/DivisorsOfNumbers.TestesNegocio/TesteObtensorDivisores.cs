using DivisorsOfNumbers.Negocio;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace DivisorsOfNumbers.TestesNegocio
{
    public class TesteObtensorDivisores
    {
        ObtensorDeDivisores _obtensor;

        [SetUp]
        public void Setup()
        {
            _obtensor = new ObtensorDeDivisores();
        }

        [Test]
        public void Deve_disparar_excecao_caso_numero_seja_menor_ou_igual_a_zero()
        {
            Assert.Throws<Exception>(() => _obtensor.ObtenhaDivisores(-30));
        }

        [Test]
        public void Deve_retornar_divisores()
        {
            var resultado = _obtensor.ObtenhaDivisores(45);

            HashSet<int> divisores = new HashSet<int>() { 1, 3, 5, 9, 15, 45 };
            Assert.IsTrue(resultado.Divisores.SetEquals(divisores));

            resultado = _obtensor.ObtenhaDivisores(112);

            divisores = new HashSet<int>() { 1, 2, 4, 7, 8, 14, 16, 28, 56, 112 };
            Assert.IsTrue(resultado.Divisores.SetEquals(divisores));
        }

        [Test]
        public void Deve_retornar_divisores_primos()
        {
            var resultado = _obtensor.ObtenhaDivisores(45);

            HashSet<int> divisoresPrimos = new HashSet<int>() { 1, 3, 5 };
            Assert.IsTrue(resultado.DivisoresPrimos.SetEquals(divisoresPrimos));

            resultado = _obtensor.ObtenhaDivisores(112);

            divisoresPrimos = new HashSet<int>() { 1, 2, 7 };
            Assert.IsTrue(resultado.DivisoresPrimos.SetEquals(divisoresPrimos));
        }

        [Test]
        public void Divisores_primos_devem_estar_contidos_na_relacao_de_divisores()
        {
            var resultado = _obtensor.ObtenhaDivisores(258);

            Assert.IsTrue(resultado.DivisoresPrimos.IsSubsetOf(resultado.Divisores));
        }
    }
}