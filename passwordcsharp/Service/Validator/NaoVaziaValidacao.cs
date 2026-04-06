using System.Text.RegularExpressions;
using passwordcsharp.Exceptions;

namespace passwordcsharp.Service.Validator;
public class NaoVaziaValidacao : ISenhaValidacao
{
    public bool Validar(string senha)
    {      
        if (senha == null || string.IsNullOrEmpty(senha))
            {
                throw new RegraDeNegocioException("A senha não deve ser vazia.");
            }
            
            return true;
    }
}