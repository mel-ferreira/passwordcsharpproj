using Xunit;
using passwordcsharp.Service.Validator;
using passwordcsharp.Exceptions;

namespace passwordcsharp.Tests.Service.Validator
{
    public class CaractereEspecialValidacaoTeste
    {
        private readonly CaractereEspecialValidacao _validacao = new CaractereEspecialValidacao();

        [Fact]
        public void DeveAceitarSenhaComCaractereEspecial()
        {
            string senha = "Ab1@cdefg"; // Tem caractere especial

            bool resultado = _validacao.Validar(senha);

            Assert.True(resultado);
        }

        [Fact]
        public void deveLancarErroQuandoNaoTemCaractereEspecial()
        {
            string senha = "Ab1cdefgh"; // Não tem caractere especial

            Assert.Throws<RegraDeNegocioException>(() => _validacao.Validar(senha));
        }
    }
}