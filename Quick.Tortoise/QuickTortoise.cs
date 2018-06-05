using System.Collections.Generic;
using System.IO;

namespace Quick.Tortoise
{
    public class QuickTortoise
    {
        public QuickTortoise(string file)
        {
            var texto = File.ReadAllLines(file);
            var matriz = texto[0].Split(' ');
            var x = int.Parse(matriz[0]);
            var y = int.Parse(matriz[1]);
            Tabela = new string[x, y];
            for (var i = 0; i < x; i++)
                for (var j = 0; j < y; j++)
                    Tabela[i, j] = texto[i + 1][j].ToString();

            var linhaTeste = x + 1;
            QtdTeste = int.Parse(texto[linhaTeste]);
            Testes = new int[QtdTeste, 4];
            for (var i = linhaTeste + 1; i < texto.Length; i++)
            {
                var dados = texto[i].Split(' ');
                for (var j = 0; j < 4; j++)
                {
                    Testes[i - linhaTeste - 1, j] = int.Parse(dados[j]) - 1;
                }
            }
        }

        public string[,] Tabela { get; set; }
        public int TabelaX => Tabela.GetLength(0);
        public int TabelaY => Tabela.GetLength(1);
        public int QtdTeste { get; set; }
        public int[,] Testes { get; set; }

        public List<string> TestarCaminho()
        {
            var caminhos = new List<string>();
            for (var i = 0; i < QtdTeste; i++)
            {
                var caminho = ObterCaminho(Testes[i, 0], Testes[i, 1], Testes[i, 2], Testes[i, 3]);
                caminhos.Add((caminho ? "Sim" : "Não"));
            }
            return caminhos;
        }

        public bool ObterCaminho(int x1, int y1, int x2, int y2)
        {
            if (x1 == x2 && y1 == y2)
                return true;
            if (x1 >= TabelaX || y1 >= TabelaY)
                return false;
            if (Tabela[x1, y1] == "#")
                return false;
            return ObterCaminho(x1 + 1, y1, x2, y2) ||
                   ObterCaminho(x1, y1 + 1, x2, y2);
        }
    }
}
