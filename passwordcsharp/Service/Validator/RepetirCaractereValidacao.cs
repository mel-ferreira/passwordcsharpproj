using System.Text.RegularExpressions;
using passwordcsharp.Exceptions;

namespace passwordcsharp.Service.Validator;
public class RepetirCaractereValidacao : ISenhaValidacao
{
    public bool Validar(string senha)
    {      
        var caracteres = new HashSet<char>();

        foreach (char c in senha)
        {
            if (!caracteres.Add(c))
            {
                throw new RegraDeNegocioException("A senha não pode conter caracteres repetidos");
            }
        }

        return true;
    }
}