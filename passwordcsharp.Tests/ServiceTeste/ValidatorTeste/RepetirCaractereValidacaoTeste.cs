using Xunit;
using passwordcsharp.Service.Validator;
using passwordcsharp.Exceptions;

namespace passwordcsharp.Tests.Service.Validator
{
    public class RepetirCaractereValidacaoTeste
    {
        private readonly RepetirCaractereValidacao _validacao = new RepetirCaractereValidacao();

        [Fact]
        public void DeveAceitarSenhaSemCaracteresRepetidos()
        {
            string senha = "Ab1@cdefg"; //Não repete

            bool resultado = _validacao.Validar(senha);

            Assert.True(resultado);
        }

        [Fact]
        public void DeveLancarErroQuandoTemCaracterRepetido()
        {
            string senha = "Ab@cccdefffgh"; //Repete digito

            Assert.Throws<RegraDeNegocioException>(() => _validacao.Validar(senha));
        }
    }
}