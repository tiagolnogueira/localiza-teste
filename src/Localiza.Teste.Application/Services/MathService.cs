using Localiza.Teste.Application.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Localiza.Teste.Application.Services
{
    public class MathService : BaseService, IMathService
    {
        public MathService(INotificador notificador) : base(notificador)
        {

        }

        public List<int> CalcularDivisores(int valor)
        {
            var dividores = new List<int>();
            for (int i = 1; i <= valor; i++)
            {
                if (valor % i == 0)
                {
                    dividores.Add(i);
                }
            }
            return dividores;
        }

        public List<int> CalcularPrimos(int valor)
        {
            var primos = new List<int>();
            for (int i = 1; i <= valor; i++)
            {
                if (valor % i == 0)
                {
                    primos.Add(i);
                }
            }
            return primos;
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }
    }
}
