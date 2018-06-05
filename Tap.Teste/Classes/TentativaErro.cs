using csUnit;
using Hexagonal.Puzzle;

namespace Tap.Teste.Classes
{
    [TestFixture]
    public class TentativaErro
    {
        //37 - Hexagonal Puzzle - Tentativa e Erro	https://uva.onlinejudge.org/index.php?option=onlinejudge&page=show_problem&problem=4387
        [Test]
        public void Teste1TentativaErro()
        {
            //output Sim
            var hexagonalPuzzle = new HexagonalPuzzle("Tentativa e Erro1.txt");
            var teste = hexagonalPuzzle.ObterSolucao()[0];

            Assert.Equals("Sim", teste);
        }
        [Test]
        public void Teste2TentativaErro()
        {
            //output Sim
            var hexagonalPuzzle = new HexagonalPuzzle("Tentativa e Erro2.txt");
            var teste = hexagonalPuzzle.ObterSolucao()[0];

            Assert.Equals("Sim", teste);
        }
        [Test]
        public void Teste3TentativaErro()
        {
            //output Não
            var hexagonalPuzzle = new HexagonalPuzzle("Tentativa e Erro3.txt");
            var teste = hexagonalPuzzle.ObterSolucao()[0];

            Assert.Equals("Não", teste);
        }
    }
}

