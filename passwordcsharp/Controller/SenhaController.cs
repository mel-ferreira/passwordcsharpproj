using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using passwordcsharp.Dto;
using passwordcsharp.Service;

namespace passwordcsharp.Controller;

[ApiController]
[Route("[controller]")]
public class SenhaController : ControllerBase
{
    private readonly SenhaService _senhaService;

    public SenhaController(SenhaService senhaService)
    {
        _senhaService = senhaService;
    }

    [HttpPost]
    public IActionResult Validador([FromBody] SenhaRequest senhaRequest)
    {
        var resultado = _senhaService.Validar(senhaRequest.Senha);

        if (!resultado)
            throw new Exception("Regra de negócio"); 
        return Ok(new SenhaResponse
        {
            SenhaValidada = true
        });
    }
}
