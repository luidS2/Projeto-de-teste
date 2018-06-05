using Jury.Size;
using System;
using Hexagonal.Puzzle;
using Logo.Turtle;
using Permutation;
using Quick.Tortoise;

namespace Tap.Projeto1
{
    static class Program
    {
        //TESTES Grupo 8
        static void Main()
        {
            TestarForcaBruta();
            TestarTentativaErro();
            TestarDivisaoConquista();
            TestarAlgoritmoGuloso();
            TestarProgramacaoDinamica();
        }

        private static void TestarForcaBruta()
        {
            //268 - Jury Size - Força Bruta	http://codeforces.com/problemset/problem/254/B	
            Console.WriteLine("268 - Jury Size - Força Bruta");

            //Teste 1 output 2
            var jurySize = new JurySize("Teste 1 Força Bruta.txt");
            Console.WriteLine("Teste 1 output: " + jurySize.ObterNumeroMinimoDePessoas());

            //Teste 2 output 3
            jurySize = new JurySize("Teste 2 Força Bruta.txt");
            Console.WriteLine("Teste 2 output: " + jurySize.ObterNumeroMinimoDePessoas());

            //Teste 3 output 1
            jurySize = new JurySize("Teste 3 Força Bruta.txt");
            Console.WriteLine("Teste 3 output: " + jurySize.ObterNumeroMinimoDePessoas());

            Console.ReadKey();
            Console.Clear();
        }

        private static void TestarTentativaErro()
        {
            //37 - Hexagonal Puzzle - Tentativa e Erro	https://uva.onlinejudge.org/index.php?option=onlinejudge&page=show_problem&problem=4387
            Console.WriteLine("37 - Hexagonal Puzzle - Tentativa e Erro");

            //Teste 1 output 2
            var hexagonalPuzzle = new HexagonalPuzzle("Tentativa e Erro.txt");
            var possuiSolucao = hexagonalPuzzle.ObterSolucao();
            foreach (var possui in possuiSolucao)
            {
                Console.WriteLine(possui);
            }

            Console.ReadKey();
            Console.Clear();
        }

        private static void TestarDivisaoConquista()
        {
            //Divisão e Conquista
            Console.WriteLine("Divisão e Conquista");

            var quickTortoise = new QuickTortoise("Divisão e Conquista Teste 1.txt");
            var caminhos = quickTortoise.TestarCaminho();
            foreach (var caminho in caminhos)
                Console.WriteLine(caminho);

            Console.WriteLine("");

            quickTortoise = new QuickTortoise("Divisão e Conquista Teste 2.txt");
            caminhos = quickTortoise.TestarCaminho();
            foreach (var caminho in caminhos)
                Console.WriteLine(caminho);

            Console.ReadKey();
            Console.Clear();
        }

        private static void TestarAlgoritmoGuloso()
        {
            //333 - Permutations - Algoritmo Guloso	http://codeforces.com/problemset/problem/187/A
            Console.WriteLine("333 - Permutations - Algoritmo Guloso");

            var happyPmp = new HappyPmp("3 2 1", "1 2 3");
            ImprimirHappyPmp(happyPmp);

            happyPmp = new HappyPmp("1 2 3 4 5", "1 5 2 3 4");
            ImprimirHappyPmp(happyPmp);

            happyPmp = new HappyPmp("1 5 2 3 4", "1 2 3 4 5");
            ImprimirHappyPmp(happyPmp);

            happyPmp = new HappyPmp("2 1 10 3 7 8 5 6 9 4", "6 9 2 4 1 10 3 7 8 5");
            ImprimirHappyPmp(happyPmp);

            happyPmp = new HappyPmp("1 6 5 3 2 4", "1 2 3 4 5 6");
            ImprimirHappyPmp(happyPmp);

            happyPmp = new HappyPmp("1 5 3 2 4 6", "1 2 3 4 5 6");
            ImprimirHappyPmp(happyPmp);

            happyPmp = new HappyPmp("2 1 3", "1 2 3");
            ImprimirHappyPmp(happyPmp);


            Console.ReadKey();
            Console.Clear();
        }

        private static void ImprimirHappyPmp(HappyPmp happyPmp)
        {
            Console.Write("Entrada: ");
            foreach (var permutation in HappyPmp.Permutations)
                Console.Write(permutation.Valor + " ");
            Console.Write("\nSaida:   ");
            var nPermutation = happyPmp.ObterMimPermutation();
            foreach (var permutation in HappyPmp.Permutations)
                Console.Write(permutation.Valor + " ");
            Console.WriteLine("\nPermutations: " + nPermutation);
            Console.WriteLine(" ");
        }

        private static void TestarProgramacaoDinamica()
        {
            //Programação Dinâmica	
            Console.WriteLine("Programação Dinâmica");

            var logoTurtle = new LogoTurtle("FT", 1);
            Console.WriteLine(logoTurtle.ObterDistancia());
            Console.WriteLine(" ");

            logoTurtle = new LogoTurtle("FFFTFFF", 2);
            Console.WriteLine(logoTurtle.ObterDistancia());
            Console.WriteLine(" ");

            logoTurtle = new LogoTurtle("F", 1);
            Console.WriteLine(logoTurtle.ObterDistancia());
            Console.WriteLine(" ");

            logoTurtle = new LogoTurtle("FTFTFTFFFFTFTFTTTTTTFFTTTTFFTFFFTFTFTFFTFTFTFFFTTTFTTFTTTTTFFFFTTT", 12);
            Console.WriteLine(logoTurtle.ObterDistancia());
            Console.WriteLine(" ");

            logoTurtle = new LogoTurtle("TTFFTFTTFTTTFFFTFTFFTFFTTFFTFTFTFTFFTTTFTFFTFFTTTTFTTTFFT", 46);
            Console.WriteLine(logoTurtle.ObterDistancia());
            Console.WriteLine(" ");

            logoTurtle = new LogoTurtle("TTFFFFFFFTTTTFTTFTFFTTFFFTFTTTFFFFTFFFTFTTTFTTF", 24);
            Console.WriteLine(logoTurtle.ObterDistancia());
            Console.WriteLine(" ");

            Console.ReadKey();
            Console.Clear();


        }
    }
}
