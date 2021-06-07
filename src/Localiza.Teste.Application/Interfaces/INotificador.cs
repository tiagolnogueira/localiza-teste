using Localiza.Teste.Application.Notificacoes;
using System.Collections.Generic;

namespace Localiza.Teste.Application.Interfaces
{
    public interface INotificador
    {
        bool TemNotificacao();
        List<Notificacao> ObterNotificacoes();
        void Handle(Notificacao notificacao);
    }
}
