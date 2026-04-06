using Xunit;
using passwordcsharp.Service.Validator;
using passwordcsharp.Exceptions;

namespace passwordcsharp.Tests.Service.Validator
{
    public class EspacoBrancoValidacaoTeste
    {
        private readonly EspacoBrancoValidacao _validacao = new EspacoBrancoValidacao();

        [Fact]
        public void DeveAceitarSenhaSemEspaco()
        {
            string senha = "Ab1@cdefg"; // Tem espaço branco

            bool resultado = _validacao.Validar(senha);

            Assert.True(resultado);
        }

        [Fact]
        public void DeveLancarErroQuandoTemEspaco()
        {
            string senha = "Ab1 @cd efg"; // Não tem espaço branco

            Assert.Throws<RegraDeNegocioException>(() => _validacao.Validar(senha));
        }
    }
}