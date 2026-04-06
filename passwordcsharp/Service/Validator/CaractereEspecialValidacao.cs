using System.Text.RegularExpressions;
using passwordcsharp.Exceptions;

namespace passwordcsharp.Service.Validator;
public class CaractereEspecialValidacao : ISenhaValidacao
{
    public bool Validar(string senha)
    {      
        if (!Regex.IsMatch(senha, @".*[!@#$%^&*()\-\+].*"))
            {
                throw new RegraDeNegocioException("A senha deve ter caractere especial");
            }
            
            return true;
    }
}
