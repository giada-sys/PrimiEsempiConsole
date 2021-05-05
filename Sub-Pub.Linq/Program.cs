using System;
using System.Collections.Generic;
using System.Linq;

namespace Sub_Pub.Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Valutazione> voti = CaricaValutazione();

            //Recupero tutti i voti di francesca
            //Lambda Expression
            var votiFrancesca = voti.Where(votazione => votazione.NomeStudente.Equals("Francesca"));
            //Query Syntax o fluent API

            var votiFrancescaFluentAPI =
                from valutazione in voti
                where valutazione.NomeStudente.Equals("Francesca")
                select valutazione;

            //Stampo
            foreach (Valutazione valutazione in votiFrancesca)
                Console.WriteLine($"Nome: {valutazione.NomeStudente}\n" +
                    $"Data: {valutazione.DataValutazione.ToShortDateString()}\n" +
                    $"Voto: {valutazione.Voto}\n" +
                    $"Materia: {valutazione.Materia}\n" +
                    $"----------------------------");

            Console.WriteLine();
            foreach(Valutazione valutazione in votiFrancescaFluentAPI)
                Console.WriteLine($"Nome: {valutazione.NomeStudente}\n" +
                    $"Data: {valutazione.DataValutazione.ToShortDateString()}\n" +
                    $"Voto: {valutazione.Voto}\n" +
                    $"Materia: {valutazione.Materia}\n" +
                    $"----------------------------");

            //Voti matematica ordinati per data
            //lambda expression
            var votiMatematicaOrdinati= voti.Where(v=> v.Materia== Materia.Matematica)
                                            .OrderBy(v=> v.DataValutazione)
                                            //.ThenBy(v=>v.Voto) se voglio utilizzare più orderBy
                                            ;
            foreach (Valutazione valutazione in votiMatematicaOrdinati)
                Console.WriteLine($"Nome: {valutazione.NomeStudente}\n" +
                    $"Data: {valutazione.DataValutazione.ToShortDateString()}\n" +
                    $"Voto: {valutazione.Voto}\n" +
                    $"Materia: {valutazione.Materia}\n" +
                    $"----------------------------");

            //Fluent API
            var votiMatematicaOrdinatiFA =
                from voto in voti
                where voto.Materia == Materia.Matematica
                orderby voto.DataValutazione
                select voto;

            foreach (var val in votiMatematicaOrdinatiFA)
                Console.WriteLine($"Nome: {val.NomeStudente}\n" +
                    $"Data: {val.DataValutazione.ToShortDateString()}\n" +
                    $"Voto: {val.Voto}\n" +
                    $"Materia: {val.Materia}\n" +
                    $"----------------------------");

            //Solo voti
            //new ti crea una lista di anonimus Type
            //Perchè voglio solo i voti e devo dargli un tipo
            //è per questo che usiamo var
            var soloVoti = voti.Where(v => v.NomeStudente.Equals("Giada"))
                .Select(v => new { v.Voto });

            var soloVotiFA =
                from voto in voti
                where voto.NomeStudente.Equals("Giada")
                select new { voto.Voto };

            foreach (var voto in soloVoti)
                Console.WriteLine(voto + "\n");

            foreach(var voto in soloVotiFA)
                Console.WriteLine(voto + "\n");

            //Media voti per ogni studente
            //La chaive è il nome del gruppo di raggruppamento
            var mediaVotiStudente = voti
                .GroupBy(
                v => v.NomeStudente,
                (key, grp) => new { Nome= key , 
                                    Media= grp.Average(v=> v.Voto),
                                    Max= grp.Max(v=> v.Voto),
                                    Min= grp.Min(v=> v.Voto)
                });

            //FluentAPI

            var mediaVotiStudentiFA =
                from voto in voti
                group voto by voto.NomeStudente into grp
                select new
                {
                    Nome = grp.Key,
                    Media = grp.Average(v => v.Voto),
                    Max = grp.Max(v => v.Voto),
                    Min = grp.Min(v => v.Voto)
                };

      

        }
        public static List<Valutazione> CaricaValutazione()
        {
            List<Valutazione> valutazioni = new List<Valutazione>();

            Valutazione s1 = new Valutazione
            {
                NomeStudente = "Giada",
                DataValutazione = new DateTime(2021, 05, 05),
                Voto = 8,
                Materia = Materia.Geografia
            };
            Valutazione s2 = new Valutazione
            {
                NomeStudente = "Giada",
                DataValutazione = new DateTime(2021, 04, 27),
                Voto = 3,
                Materia = Materia.Matematica
            };
            Valutazione s3 = new Valutazione
            {
                NomeStudente = "Giada",
                DataValutazione = new DateTime(2021, 02, 01),
                Voto = 9,
                Materia = Materia.Storia
            };
            Valutazione s4 = new Valutazione
            {
                NomeStudente = "Francesca",
                DataValutazione = new DateTime(2021, 01, 15),
                Voto = 6,
                Materia = Materia.Matematica
            };
            Valutazione s5 = new Valutazione
            {
                NomeStudente = "Francesca",
                DataValutazione = new DateTime(2021, 01, 15),
                Voto = 9,
                Materia = Materia.Fisica
            };
            valutazioni.Add(s1);
            valutazioni.Add(s2);
            valutazioni.Add(s3);
            valutazioni.Add(s4);
            valutazioni.Add(s5);

            return valutazioni;
        }
    }
}
