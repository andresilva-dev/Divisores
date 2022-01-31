using DivisorsOfNumbers.Negocio;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número e pressione ENTER: ");
            string valor = Console.ReadLine();

            Int32.TryParse(valor, out var valorInteiro);

            ObtensorDeDivisores obtensor = new ObtensorDeDivisores();
            var resultado = obtensor.ObtenhaDivisores(valorInteiro);

            Console.WriteLine($"O número informado foi: {resultado.Numero}");
            Console.WriteLine($"Números divisores: {string.Join(", ", resultado.Divisores)}");
            Console.WriteLine($"Divisores Primos: {string.Join(", ", resultado.DivisoresPrimos)}");
            Console.ReadKey();
        }
    }
}
