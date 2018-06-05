using System.Collections.Generic;
using System.IO;

namespace Hexagonal.Puzzle
{
    public class HexagonalPuzzle
    {
        private List<string[,]> QuebraCabecas { get; }
        private string[,] QuebraCabeca { get; set; }

        public HexagonalPuzzle(string file)
        {
            QuebraCabecas = new List<string[,]>();
            var quebraCabeca = new string[7, 6];
            var texto = File.ReadAllLines(file);
            for (int x = 0; x < texto.Length; x++)
            {
                var hexagonal = texto[x].Split(' ');
                var posicao = x % 7;
                for (int i = 0; i < 6; i++)
                    quebraCabeca[posicao, i] = hexagonal[i];

                if (posicao == 6)
                {
                    QuebraCabecas.Add(quebraCabeca);
                    quebraCabeca = new string[7, 6];
                }
            }
        }
        public List<string> ObterSolucao()
        {
            var possuiSolucao = new List<string>();
            foreach (var quebraCabeca in QuebraCabecas)
            {
                QuebraCabeca = quebraCabeca;
                bool possui = ResolverQuebraCabeca();
                possuiSolucao.Add((possui ? "Sim" : "Não"));
            }
            return possuiSolucao;
        }

        private bool ResolverQuebraCabeca()
        {
            for (int i = 0; i < 7; i++)
            {
                bool possuiSolucao = DefinirHexagonalDoMeio(i);
                if (possuiSolucao) return true;
            }
            return false;
        }

        private bool DefinirHexagonalDoMeio(int h1)
        {
            var pecasNaoUtilizadas = new List<int> { 0, 1, 2, 3, 4, 5, 6 };
            pecasNaoUtilizadas.Remove(h1);
            for (int j = 0; j < 7; j++)
            {
                if (h1 != j)
                {
                    for (int i = 0; i < 6; i++)
                    {
                        bool possuiSolucao = VerificarCombinacao(i, h1, j, pecasNaoUtilizadas);
                        if (possuiSolucao) return true;
                    }
                }
            }
            return false;
        }

        private bool VerificarCombinacao(int priLado, int h1, int h2, List<int> pecasNaoUtilizadas)
        {
            pecasNaoUtilizadas.Remove(h2);
            for (int j = 0; j < 7; j++)
            {
                if (pecasNaoUtilizadas.Contains(j))
                {
                    bool possuiSolucao = VerificarCombinacao(priLado, h1, h2, h2, j, pecasNaoUtilizadas);
                    if (possuiSolucao) return true;
                }
            }
            pecasNaoUtilizadas.Add(h2);
            return false;
        }

        private bool VerificarCombinacao(int priLado, int h1, int h2, int hx, int hy, List<int> pecasNaoUtilizadas)
        {
            var count = (pecasNaoUtilizadas.Count - 6) * -1;
            var ladoAtual = priLado + count - 1;
            if (ladoAtual > 5)
                ladoAtual = (ladoAtual % 5) - 1;
            var ladoAtualPox = ObterLadoPox(ladoAtual);
            pecasNaoUtilizadas.Remove(hy);
            var ladox = ObterLado(h1, ladoAtual, hx);
            var ladoxMenos = ObterLadoAnt(ladox);
            var ladoy = ObterLado(h1, ladoAtualPox, hy);
            var ladoYMais = ObterLadoPox(ladoy);

            var lado1 = QuebraCabeca[hy, ladoYMais];
            var lado2 = QuebraCabeca[hx, ladoxMenos];

            if (count == 5)
            {
                var ladoyMenos = ObterLadoAnt(ladoy);
                var ladoH2 = ObterLado(h1, priLado, h2);
                var ladoH2Mais = ObterLadoPox(ladoH2);

                var lado3 = QuebraCabeca[hy, ladoyMenos];
                var lado4 = QuebraCabeca[ladoH2, ladoH2Mais];

                pecasNaoUtilizadas.Add(hy);
                return lado1 == lado2 && lado3 == lado4;
            }

            if (lado1 == lado2)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (pecasNaoUtilizadas.Contains(j))
                    {
                        bool possuiSolucao = VerificarCombinacao(priLado, h1, h2, hy, j, pecasNaoUtilizadas);
                        if (possuiSolucao) return true;
                    }
                }
            }

            pecasNaoUtilizadas.Add(hy);

            return false;
        }

        private int ObterLado(int x1, int y1, int x2)
        {
            for (int j = 0; j < 6; j++)
                if (QuebraCabeca[x1, y1] == QuebraCabeca[x2, j])
                    return j;
            return -1;
        }

        private int ObterLadoAnt(int lado)
        {
            return lado - 1 == -1 ? 5 : lado - 1;
        }

        private int ObterLadoPox(int lado)
        {
            return lado + 1 == 6 ? 0 : lado + 1;
        }
    }
}
