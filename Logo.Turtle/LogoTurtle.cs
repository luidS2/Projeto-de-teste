using System.Collections.Generic;
using System.Linq;

namespace Logo.Turtle
{
    public class LogoTurtle
    {
        public LogoTurtle(string caminho, int nMudancas)
        {
            Tabela = caminho.ToCharArray();
            Mudancas = nMudancas;
        }
        public char[] Tabela { get; set; }
        public int Mudancas { get; set; }

        public int ObterDistancia()
        {
            var last = Tabela.Length - 1;
            var ts = ObterTurnAround();
            for (var i = 0; i < Mudancas; i++)
            {
                var t = ts.FirstOrDefault(x => x.IsImpar);
                if (t != null)
                {
                    Tabela[t.Posicao] = 'F';
                    t.Posicao++;
                    t.Quantidade--;
                }
                else if (Mudancas - i > 1)
                {
                    t = ts.FirstOrDefault(x => x.Quantidade > 0);
                    if (t != null)
                    {
                        Tabela[t.Posicao] = 'F';
                        t.Posicao++;
                        t.Quantidade--;
                    }
                    else
                        Tabela[last] = Tabela[last] == 'F' ? 'T' : 'F';

                }
                else
                    Tabela[last] = Tabela[last] == 'F' ? 'T' : 'F';
            }

            var cout = 0;
            var posicao = 'F';
            foreach (var comando in Tabela)
            {
                if (comando == 'T')//Mudar de posição
                    posicao = posicao == 'F' ? 'T' : 'F';
                else//Andar na direção da posição
                    cout += posicao == 'F' ? 1 : -1;
            }
            return cout;
        }

        private List<TurnAround> ObterTurnAround()
        {
            var ts = new List<TurnAround>();
            for (var i = 0; i < Tabela.Length - 1; i++)
            {
                int prox = ObterQuantidade(i, 'T');
                if (prox != i)
                {
                    int proxF = ObterQuantidade(i, 'F');
                    ts.Add(new TurnAround(i, prox - i, proxF));
                    i = prox;
                }
            }

            return ts.OrderByDescending(x => x.QuantidadeF).ToList();
        }

        private int ObterQuantidade(int i, char c)
        {
            var prox = i;
            while (Tabela[prox] == c)
            {
                if (prox == Tabela.Length - 1)
                    return prox;
                prox++;
            }
            return prox;
        }
    }
}
