using DivisorsOfNumbers.Negocio;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Threading.Tasks;


namespace DivisorsOfNumbers.GrpcService
{
    public class ObtensorDeDivisoresService : Divisores.DivisoresBase
    {
        public override Task<Retorno> ObtenhaDivisores(Number request, ServerCallContext context)
        {
            IObtensorDeDivisores obtensor = new ObtensorDeDivisores();
            IResultadoDivisores resultado = obtensor.ObtenhaDivisores(request.Numero);
            Retorno retorno = new Retorno() {
                Numero = resultado.Numero,
            };
            foreach (var numero in resultado.Divisores) {
                retorno.Divisores.Add(numero);
            }

            retorno.Divisores.AddRange(resultado.Divisores);
            retorno.DivisoresPrimos.AddRange(resultado.DivisoresPrimos);

            return Task.FromResult(retorno);
        }
    }
}
