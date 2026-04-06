using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace passwordcsharp.Exceptions;
public class ErroPadronizado
{
    public DateTime TempoErro { get; set; } = DateTime.UtcNow;
    public int Status { get; set; }
    public string Erro {get;set;}
    public string Mensagem {get;set;}
    public string CaminhoUrl {get;set;}

    public ErroPadronizado(){}

    public ErroPadronizado(DateTime tempoErro, int status, string erro, string mensagem, string caminhoUrl)
    {
        TempoErro = tempoErro;
        Status = status;
        Erro = erro;
        Mensagem = mensagem;
        CaminhoUrl = caminhoUrl;
    }

}
