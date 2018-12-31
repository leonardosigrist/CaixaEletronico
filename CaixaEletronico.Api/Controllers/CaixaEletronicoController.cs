﻿using CaixaEletronico.Domain;
using Microsoft.AspNetCore.Mvc;

namespace CaixaEletronico.Api.Controllers
{
    [Route("api/[controller]")]
    public class CaixaEletronicoController : Controller
    {
        private readonly ICaixa caixa;

        public CaixaEletronicoController(ICaixa caixa)
        {
            this.caixa = caixa;
        }

        [HttpPost("saque/{valor}")]
        public ActionResult Saque(int valor)
        {
            if (!this.caixa.ValidaCedulasDisponiveis(valor))
                return BadRequest("Valor não válido para saque. Notas disponíveis: 100, 50, 20 e 10");

            return Ok($"Receba seu saque: { string.Join(',', this.caixa.Saque(valor)) }");
        }
    }
}
