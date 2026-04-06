using Xunit;
using passwordcsharp.Service.Validator;
using passwordcsharp.Exceptions;

namespace passwordcsharp.Tests.Service.Validator
{
    public class MinimoCaracteresValidacaoTests
    {
        private readonly MinimoCaracteresValidacao _validacao = new MinimoCaracteresValidacao();

        [Fact]
        public void DeveAceitarSenhaCom9OuMaisCaracteres()
        {
            string senha = "Ab1@cdefg"; // 9 caracteres

            bool resultado = _validacao.Validar(senha);

            Assert.True(resultado);
        }

        [Fact]
        public void DeveLancarErroQuandoMenorQue9()
        {
            string senha = "Ab1@def"; // 7 caracteres

            Assert.Throws<RegraDeNegocioException>(() => _validacao.Validar(senha));
        }
    }
}