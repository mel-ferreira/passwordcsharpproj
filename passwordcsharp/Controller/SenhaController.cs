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
    public ActionResult<bool> Validador([FromBody] SenhaRequest senhaRequest)
    {
        return Ok(_senhaService.Validar(senhaRequest.Senha));
    }
}
