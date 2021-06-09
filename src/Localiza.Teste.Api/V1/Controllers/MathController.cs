using AutoMapper;
using Localiza.Teste.Api.Controllers;
using Localiza.Teste.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Localiza.Teste.Api.V1.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}")]
    public class MathController : MainController
    {
        private readonly IMathService _mathService;
        private readonly IMapper _mapper;
        public MathController(INotificador notificador,
                                  IMathService mathService,
                                  IMapper mapper) : base(notificador)
        {
            _mathService = mathService;
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
