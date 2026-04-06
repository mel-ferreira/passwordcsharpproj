using System.Net;

namespace passwordcsharp.Exceptions;
public class GlobalException
{
    private readonly RequestDelegate _requestDelegate;

    public GlobalException(RequestDelegate requestDelegate)
    {
        this._requestDelegate =  requestDelegate;
    }

    public async Task InvokeAsync(HttpContext contexto)
    {
        try
        {
            await _requestDelegate(contexto);
        }
        catch(RegraDeNegocioException ex)
        {
            await HandleExceptionAsync(contexto, ex);
        }
    }

    private static Task HandleExceptionAsync(HttpContext contexto, RegraDeNegocioException ex)
    {
        var response = contexto.Response;
        response.ContentType = "application/json";
        response.StatusCode =  (int)HttpStatusCode.BadRequest;

        var err = new ErroPadronizado
        {
            TempoErro = DateTime.UtcNow,
            Status = response.StatusCode,
            Erro = "Regra de negócio",
            Mensagem = ex.Message,
            CaminhoUrl = contexto.Request.Path
        };

        return response.WriteAsJsonAsync(err);
    }
}