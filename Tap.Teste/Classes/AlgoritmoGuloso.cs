using csUnit;
using Permutation;

namespace Tap.Teste.Classes
{
    [TestFixture]
    public class AlgoritmoGuloso
    {
        //333 - Permutations - Algoritmo Guloso	http://codeforces.com/problemset/problem/187/A
        [Test]
        public void Teste1AlgoritmoGuloso()
        {
            //output 2
            var happyPmp = new HappyPmp("3 2 1", "1 2 3");
            var teste = happyPmp.ObterMimPermutation();
            Assert.Equals(2, teste);
        }
        [Test]
        public void Teste2AlgoritmoGuloso()
        {
            //output 1
            var happyPmp = new HappyPmp("1 2 3 4 5", "1 5 2 3 4");
            var teste = happyPmp.ObterMimPermutation();
            Assert.Equals(1, teste);
        }
        [Test]
        public void Teste3AlgoritmoGuloso()
        {
            //output 3
            var happyPmp = new HappyPmp("1 5 2 3 4", "1 2 3 4 5");
            var teste = happyPmp.ObterMimPermutation();
            Assert.Equals(3, teste);
        }
        [Test]
        public void Teste4AlgoritmoGuloso()
        {
            //output 3
            var happyPmp = new HappyPmp("2 1 10 3 7 8 5 6 9 4", "6 9 2 4 1 10 3 7 8 5");
            var teste = happyPmp.ObterMimPermutation();
            Assert.Equals(3, teste);
        }

    }
}

