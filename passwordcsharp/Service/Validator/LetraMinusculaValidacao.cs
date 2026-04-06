using System.Text.RegularExpressions;
using passwordcsharp.Exceptions;

namespace passwordcsharp.Service.Validator;
public class LetraMinusculaValidacao : ISenhaValidacao
{
    public bool Validar(string senha)
    {      
        if (!Regex.IsMatch(senha, @".*[a-z].*"))
            {
                throw new RegraDeNegocioException("A senha deve ter uma letra minúscula.");
            }
            
            return true;
    }
}
