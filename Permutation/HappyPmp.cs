using System.Collections.Generic;
using System.Linq;

namespace Permutation
{
    public class HappyPmp
    {
        public HappyPmp(List<Permutation> permutations)
        {
            Permutations = permutations;
        }

        public HappyPmp(string first, string second)
        {
            var valores = first.Split(' ');
            var posicao = second.Split(' ').ToList();
            Permutations = valores.Select(t => new Permutation(int.Parse(t), posicao.IndexOf(t))).ToList();
        }

        public static List<Permutation> Permutations { get; set; }
        private int Last => Permutations.Count - 1;

        public int ObterMimPermutation()
        {
            var nPermutations = 0;
            //Obtem o primeiro da lista que a posição é maior do que do último ou  do proximo
            for (int i = 0; i < Permutations.Count - 1; i++)
            {
                if (Permutations[i].Posicao > Permutations[Last].Posicao)
                {
                    MudarPosicao(i);
                    nPermutations++;
                    i = -1;//Reiniciar verificação
                }
                else if (Permutations[i].Posicao > Permutations[i + 1].Posicao)
                {
                    MudarPosicao(i + 1);
                    nPermutations++;
                    i = -1;//Reiniciar verificação
                }
            }
            return nPermutations;
        }
        

        private void MudarPosicao(int novaPosicao)
        {
            var permutation = Permutations[Last];
            Permutations.RemoveAt(Last);
            Permutations.Insert(novaPosicao, permutation);
        }
    }
}
