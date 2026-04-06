using Xunit;
using passwordcsharp.Service.Validator;
using passwordcsharp.Exceptions;

namespace passwordcsharp.Tests.Service.Validator
{
    public class NaoVaziaValidacaoTeste
    {
        private readonly NaoVaziaValidacao _validacao = new NaoVaziaValidacao();

        [Fact]
        public void DeveAceitarSenhaNaoVazia()
        {
            string senha = "Ab1@cdefg"; //Não está vazia

            bool resultado = _validacao.Validar(senha);

            Assert.True(resultado);
        }

        [Fact]
        public void DeveLancarErroQuandoSenhaVazia()
        {
            string senha = ""; //Está vazia

            Assert.Throws<RegraDeNegocioException>(() => _validacao.Validar(senha));
        }
    }
}