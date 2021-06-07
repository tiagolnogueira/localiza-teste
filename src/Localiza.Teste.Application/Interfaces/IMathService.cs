using System;
using System.Collections.Generic;

namespace Localiza.Teste.Application.Interfaces
{
    public interface IMathService : IDisposable
    {
        List<int> CalcularPrimos(int valor);
        List<int> CalcularDivisores(int valor);
    }
}
