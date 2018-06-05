using csUnit;
using Jury.Size;

namespace Tap.Teste.Classes
{
    [TestFixture]
    public class TesteForcaBruta
    {
        //268 - Jury Size - Força Bruta	http://codeforces.com/problemset/problem/254/B	
        [Test]
        public void Teste1ForcaBruta()
        {
            //output 2
            var jurySize = new JurySize("Teste 1 Força Bruta.txt");
            var teste = jurySize.ObterNumeroMinimoDePessoas();

            Assert.Equals(2, teste);
        }
        [Test]
        public void Teste2ForcaBruta()
        {
            //output 3
            var jurySize = new JurySize("Teste 2 Força Bruta.txt");
            var teste = jurySize.ObterNumeroMinimoDePessoas();

            Assert.Equals(3, teste);
        }
        [Test]
        public void Teste3ForcaBruta()
        {
            //output 1
            var jurySize = new JurySize("Teste 3 Força Bruta.txt");
            var teste = jurySize.ObterNumeroMinimoDePessoas();

            Assert.Equals(1, teste);
        }
    }
}

