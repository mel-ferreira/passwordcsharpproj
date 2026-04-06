using System.Text.RegularExpressions;
using passwordcsharp.Exceptions;

namespace passwordcsharp.Service.Validator;
public class EspacoBrancoValidacao : ISenhaValidacao
{
    public bool Validar(string senha)
    {      
        if (senha.Contains(" "))
            {
                throw new RegraDeNegocioException("A senha não deve conter espaços em branco");
            }
            
            return true;
    }
}