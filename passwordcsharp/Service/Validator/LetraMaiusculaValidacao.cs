using System.Text.RegularExpressions;
using passwordcsharp.Exceptions;

namespace passwordcsharp.Service.Validator;
public class LetraMaiusculaValidacao : ISenhaValidacao
{
    public bool Validar(string senha)
    {      
        if (!Regex.IsMatch(senha, @".*[A-Z].*"))
            {
                throw new RegraDeNegocioException("A senha deve ter uma letra maiúscula.");
            }
            
            return true;
    }
}
