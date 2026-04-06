using passwordcsharp.Exceptions;

namespace passwordcsharp.Service.Validator
{
    public class MinimoCaracteresValidacao : ISenhaValidacao
    {
        public bool Validar(string senha)
        {      
           if (senha == null || senha.Length < 9)
                {
                    throw new RegraDeNegocioException("A senha deve ter no mínimo 9 caracteres");
                }
                
                return true;
        }
    }
}