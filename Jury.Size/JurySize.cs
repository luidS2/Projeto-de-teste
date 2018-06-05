using System;
using System.Collections.Generic;
using System.IO;

namespace Jury.Size
{
    public class JurySize
    {
        public JurySize(string file)
        {
            var olympiads = new List<Olympiad>();
            var texto = File.ReadAllLines(file);
            for (var i = 1; i < texto.Length; i++)
            {
                var linha = texto[i].Split(' ');
                olympiads.Add(new Olympiad(linha));
            }
            Olympiads = olympiads;
        }

        private List<Olympiad> Olympiads { get; set; }

        public int ObterNumeroMinimoDePessoas()
        {
            var dictionary = new Dictionary<DateTime, int>();

            foreach (var olympiad in Olympiads)
            {
                //Verificar conflitos de datas de Olimpíada com preparação no mesmo dia
                for (var i = 0; i < olympiad.DiasPreparacao; i++)
                {
                    var dia = olympiad.DataInicioPreparacao.AddDays(i);
                    if (dictionary.ContainsKey(dia))
                        dictionary[dia] += olympiad.Pessoas;
                    else
                        dictionary.Add(olympiad.DataInicioPreparacao.AddDays(i), olympiad.Pessoas);
                }
            }

            var minimoDePessoas = 0;
            foreach (var key in dictionary)
            {
                //Obter maior número de pessoas
                if (key.Value > minimoDePessoas)
                    minimoDePessoas = key.Value;
            }

            return minimoDePessoas;
        }

    }
}
