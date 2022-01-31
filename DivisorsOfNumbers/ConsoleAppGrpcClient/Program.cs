using Grpc.Net.Client;
using System;
using System.Threading.Tasks;

namespace ConsoleAppGrpcClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new Divisores.DivisoresClient(channel);
            var resultado = await client.ObtenhaDivisoresAsync(new Number { Numero = 7000 });

            Console.WriteLine($"O número informado foi: {resultado.Numero}");
            Console.WriteLine($"Números Divisores: {string.Join(", ", resultado.Divisores)}");
            Console.WriteLine($"Divisores Primos: {string.Join(", ", resultado.DivisoresPrimos)}");
            Console.ReadKey();
        }
    }
}
