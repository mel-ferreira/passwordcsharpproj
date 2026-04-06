using Xunit;
using passwordcsharp.Service;
using passwordcsharp.Exceptions;

namespace passwordcsharp.Tests.Service.Validator
{
    public class SenhaServiceTeste
    {
        private readonly SenhaService _validacao = new SenhaService();

        [Fact]
        public void DeveValidarSenhaCompleta()
        {
            string senha = "Ab1@cdefg"; // Senha válida

            bool resultado = _validacao.Validar(senha);

            Assert.True(resultado);
        }

        [Fact]
        public void DeveFalharQuandoSenhaInvalida()
        {
            string senha = "abcdefghi"; // Não válida

            Assert.Throws<RegraDeNegocioException>(() => _validacao.Validar(senha));
        }
    }
}