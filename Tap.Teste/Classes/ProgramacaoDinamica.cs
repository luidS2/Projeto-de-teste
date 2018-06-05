using csUnit;
using Logo.Turtle;

namespace Tap.Teste.Classes
{
    [TestFixture]
    public class ProgramacaoDinamica
    {
        [Test]
        public void Teste1ProgramacaoDinamica()
        {
            var logoTurtle = new LogoTurtle("FT", 1);
            var teste=  logoTurtle.ObterDistancia();
            Assert.Equals(2, teste);
        }
        [Test]
        public void Teste2ProgramacaoDinamica()
        {
            var logoTurtle = new LogoTurtle("FFFTFFF", 2);
            var teste = logoTurtle.ObterDistancia();
            Assert.Equals(6, teste);
        }
        [Test]
        public void Teste3ProgramacaoDinamica()
        {
            var logoTurtle = new LogoTurtle("F", 1);
            var teste = logoTurtle.ObterDistancia();
            Assert.Equals(0, teste);
        }
        [Test]
        public void Teste4ProgramacaoDinamica()
        {

            var logoTurtle = new LogoTurtle("FTFTFTFFFFTFTFTTTTTTFFTTTTFFTFFFTFTFTFFTFTFTFFFTTTFTTFTTTTTFFFFTTT", 12);
            var teste = logoTurtle.ObterDistancia();
            Assert.Equals(41, teste);
        }
    }
}

