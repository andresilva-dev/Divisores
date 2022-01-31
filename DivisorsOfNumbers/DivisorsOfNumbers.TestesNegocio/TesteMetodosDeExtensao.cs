using DivisorsOfNumbers.Negocio;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DivisorsOfNumbers.TestesNegocio
{
    public class TesteMetodosDeExtensao
    {
        [Test]
        public void Deve_verificar_se_numero_eh_impar()
        {
            var numeroImpar = 35;
            var numeroPar = 158;

            Assert.IsTrue(numeroImpar.EhImpar());
            Assert.IsFalse(numeroPar.EhImpar());
        }

        [Test]
        public void Deve_verificar_se_numero_eh_primo()
        {
            var numeroPrimo = 31;
            var numeroNaoPrimo = 158;

            Assert.IsTrue(numeroPrimo.EhPrimo());
            Assert.IsFalse(numeroNaoPrimo.EhPrimo());
        }
    }
}
