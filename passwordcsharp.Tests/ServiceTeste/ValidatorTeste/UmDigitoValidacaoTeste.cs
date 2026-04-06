using Xunit;
using passwordcsharp.Service.Validator;
using passwordcsharp.Exceptions;

namespace passwordcsharp.Tests.Service.Validator
{
    public class UmDigitoValidacaoTeste
    {
        private readonly UmDigitoValidacao _validacao = new UmDigitoValidacao();

        [Fact]
        public void DeveAceitarSenhaComDigito()
        {
            string senha = "Ab1@cdefg"; //Tem dígito

            bool resultado = _validacao.Validar(senha);

            Assert.True(resultado);
        }

        [Fact]
        public void DeveLancarErroQuandoNaoTemDigito()
        {
            string senha = "Ab@cdefgh"; //Não tem dígito

            Assert.Throws<RegraDeNegocioException>(() => _validacao.Validar(senha));
        }
    }
}