using System.Text.RegularExpressions;
using passwordcsharp.Exceptions;

namespace passwordcsharp.Service.Validator;
public class UmDigitoValidacao : ISenhaValidacao
{
    public bool Validar(string senha)
    {      
        if (!Regex.IsMatch(senha, @".*\d.*"))
            {
                throw new RegraDeNegocioException("A senha deve ter pelo menos 1 dígito");
            }
            
            return true;
    }
}