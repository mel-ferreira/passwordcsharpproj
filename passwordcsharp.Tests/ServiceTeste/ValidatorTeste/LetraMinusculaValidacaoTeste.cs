using Xunit;
using passwordcsharp.Service.Validator;
using passwordcsharp.Exceptions;

namespace passwordcsharp.Tests.Service.Validator
{
    public class LetraMinusculaValidacaoTeste
    {
        private readonly LetraMinusculaValidacao _validacao = new LetraMinusculaValidacao();

        [Fact]
        public void DeveAceitarSenhaComLetraMinuscula()
        {
            string senha = "Ab1@cdefg"; // Tem letra minúscula

            bool resultado = _validacao.Validar(senha);

            Assert.True(resultado);
        }

        [Fact]
        public void DeveLancarErroQuandoNaoTemMinuscula()
        {
            string senha = "AB1@CDEFG"; // Não tem letra minúscula

            Assert.Throws<RegraDeNegocioException>(() => _validacao.Validar(senha));
        }
    }
}