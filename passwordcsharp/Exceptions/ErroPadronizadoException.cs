using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace passwordcsharp.Exceptions;
public class ErroPadronizado
{
    public bool SenhaValida { get; set; }
    public DateTime TempoErro { get; set; } = DateTime.UtcNow;
    public int Status { get; set; }
    public string Erro { get; set; } = string.Empty;
    public string Mensagem { get; set; } = string.Empty;
    public string CaminhoUrl { get; set; } = string.Empty;

    public ErroPadronizado(){}

    public ErroPadronizado(bool senhaValida, DateTime tempoErro, int status, string erro, string mensagem, string caminhoUrl)
    {
        SenhaValida = senhaValida;
        TempoErro = tempoErro;
        Status = status;
        Erro = erro;
        Mensagem = mensagem;
        CaminhoUrl = caminhoUrl;
    }

}
