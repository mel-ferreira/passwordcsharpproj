using passwordcsharp.Service.Validator;

namespace passwordcsharp.Service;
public class SenhaService
{
    private List<ISenhaValidacao> validacoes;

    public SenhaService()
    {
        validacoes = new List<ISenhaValidacao>
        {
             new NaoVaziaValidacao(),
            new MinimoCaracteresValidacao(),
            new LetraMaiusculaValidacao(),
            new LetraMinusculaValidacao(),
            new UmDigitoValidacao(),
            new EspacoBrancoValidacao(),
            new CaractereEspecialValidacao(),
            new RepetirCaractereValidacao()
        };
    }

    public bool Validar(string senha)
    {
        foreach (var validacao in validacoes)
        {
            if (!validacao.Validar(senha))
            {
                return false;
            }
        }
        return true;
    }
}
