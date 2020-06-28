﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Meetup.Api.Financeiro.Controllers
{
    [Route("[controller]")]
    [Authorize, Authorize(Policy = "AcessoRestrito")]
    public class AdminController : ControllerBase
    {
        [HttpPost, Route("acesso-restrito")]
        public IActionResult Restrito()
        {
            // Without internet test
            return Ok(new
            {
                Acao = "Atualizado cache da aplicação"
            });
        }

    }
}