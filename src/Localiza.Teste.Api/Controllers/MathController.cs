using AutoMapper;
using Localiza.Teste.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Localiza.Teste.Api.Controllers
{
    [Route("api/math")]
    public class MathController : MainController
    {
        private readonly IMathService _mathService;
        private readonly IMapper _mapper;
        public MathController(INotificador notificador,
                                  IMathService mathService,
                                  IMapper mapper) : base(notificador)
        {

        }

        [HttpPost("calcular-primos/{valor:int}")]
        public ActionResult<List<int>> CalcularPrimos(int valor)
        {
            if (!ModelState.IsValid) return CustomResponse(ModelState);

            var result = _mathService.CalcularPrimos(valor);
            return CustomResponse(result);
        }

        [HttpPost("calcular-dividores/{valor:int}")]
        public ActionResult<List<int>> CalcularDivisores(int valor)
        {
            if (!ModelState.IsValid) return CustomResponse(ModelState);

            var result = _mathService.CalcularDivisores(valor);
            return CustomResponse(result);
        }
    }
}
