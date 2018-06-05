using System;

namespace Jury.Size
{
    public class Olympiad
    {
        public Olympiad(string[] args)
        {
            DataInicioOlimpiada = DateTime.Parse(args[1] + "/" + args[0] + "/2013");
            Pessoas = int.Parse(args[2]);
            DiasPreparacao = int.Parse(args[3]);
        }
        public int Pessoas { get; set; }
        public int DiasPreparacao { get; set; }
        public DateTime DataInicioOlimpiada { get; set; }
        public DateTime DataInicioPreparacao => DataInicioOlimpiada.AddDays(DiasPreparacao * -1);
        public DateTime DataFimPreparacao => DataInicioOlimpiada.AddDays(-1);
    }
}
