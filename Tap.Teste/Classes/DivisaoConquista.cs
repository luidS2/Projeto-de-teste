using csUnit;
using Quick.Tortoise;

namespace Tap.Teste.Classes
{
    [TestFixture]
    public class DivisaoConquista
    {
        //Divisão e Conquista

        [Test]
        public void Teste1DivisaoConquista()
        {
            //output false
            QuickTortoise quickTortoise = new QuickTortoise("Divisão e Conquista Teste 1.txt");
            var teste = quickTortoise. ObterCaminho(0, 0, 2, 2);
            Assert.Equals(false, teste);
        }
        [Test]
        public void Teste2DivisaoConquista()
        {
            //output true
            QuickTortoise quickTortoise = new QuickTortoise("Divisão e Conquista Teste 1.txt");
            var teste = quickTortoise.ObterCaminho(0, 0, 0, 2);
            Assert.Equals(true, teste);
        }
        [Test]
        public void Teste3DivisaoConquista()
        {
            //output true
            QuickTortoise quickTortoise = new QuickTortoise("Divisão e Conquista Teste 1.txt");
            var teste = quickTortoise.ObterCaminho(0, 0, 2, 0);
            Assert.Equals(true, teste);
        }
        [Test]
        public void Teste4DivisaoConquista()
        {
            //output true
            QuickTortoise quickTortoise = new QuickTortoise("Divisão e Conquista Teste 1.txt");
            var teste = quickTortoise.ObterCaminho(0, 0, 0, 1);
            Assert.Equals(true, teste);
        }
        [Test]
        public void Teste5DivisaoConquista()
        {
            //output true
            QuickTortoise quickTortoise = new QuickTortoise("Divisão e Conquista Teste 1.txt");
            var teste = quickTortoise.ObterCaminho(0, 0, 1, 0);
            Assert.Equals(true, teste);
        }
    }
}

