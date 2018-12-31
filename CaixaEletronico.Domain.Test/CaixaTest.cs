using Xunit;

namespace CaixaEletronico.Domain.Test
{
    public class CaixaTest
    {
        private readonly Caixa caixa = new Caixa();

        [Fact]
        public void SaqueContemMenorNumeroDeCedulas()
        {
            Assert.Equal(3, caixa.Saque(80).Count);
        }

        [Fact]
        public void SaqueComCedulasIndisponiveis()
        {
            Assert.False(caixa.ValidaCedulasDisponiveis(45));
        }

        [Fact]
        public void SaqueValido()
        {
            Assert.True(caixa.ValidaCedulasDisponiveis(510));
        }
    }
}
