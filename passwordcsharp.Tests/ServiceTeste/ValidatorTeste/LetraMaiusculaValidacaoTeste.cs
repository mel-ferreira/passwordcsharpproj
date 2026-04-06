using Xunit;
using passwordcsharp.Service.Validator;
using passwordcsharp.Exceptions;

namespace passwordcsharp.Tests.Service.Validator
{
    public class LetraMaiusculaValidacaoTeste
    {
        private readonly LetraMaiusculaValidacao _validacao = new LetraMaiusculaValidacao();

        [Fact]
        public void DeveAceitarSenhaComLetraMaiuscula()
        {
            string senha = "Ab1@cdefg"; // Tem letra maiúscula

            bool resultado = _validacao.Validar(senha);

            Assert.True(resultado);
        }

        [Fact]
        public void DeveLancarErroQuandoNaoTemMaiuscula()
        {
            string senha = "ab1@cdefg"; // Não tem letra maiúscula

            Assert.Throws<RegraDeNegocioException>(() => _validacao.Validar(senha));
        }
    }
}