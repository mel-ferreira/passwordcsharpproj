using System.Net;
using System.Net.Http.Json;
using FluentAssertions;
using passwordcsharp.Dto;
using passwordcsharp.Controller;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

public class SenhaControllerIntegrationTest 
    : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly HttpClient _client;

    public SenhaControllerIntegrationTest(WebApplicationFactory<Program> factory)
    {
        _client = factory.CreateClient();
    }

    [Fact(DisplayName = "Deve retornar true quando a senha for válida")]
    public async Task DeveRetornarTrueQuandoSenhaForValida()
    {
        var request = new
        {
            senha = "AbTp9!fok"
        };

        var response = await _client.PostAsJsonAsync("/Senha", request);

        response.StatusCode.Should().Be(HttpStatusCode.OK);

        var body = await response.Content.ReadFromJsonAsync<SenhaResponse>();
        
        body!.SenhaValidada.Should().BeTrue();
    }

    [Fact(DisplayName = "Deve retornar false quando a senha for inválida")]
    public async Task DeveRetornarFalseQuandoSenhaForInvalida()
    {
        var request = new
        {
            senha = "123"
        };

        var response = await _client.PostAsJsonAsync("/Senha", request);

        response.StatusCode.Should().Be(HttpStatusCode.BadRequest);

        var body = await response.Content.ReadFromJsonAsync<SenhaResponse>();
        
        body!.SenhaValidada.Should().BeFalse();
    }
}