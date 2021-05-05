using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sub_Pub.Async_Parallel
{
    public class Metodi
    {
        //FOR NORMALE
        public static void ForNormale()
        {
            
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Start " + i);
                //Aggiungo una chiamata che introduce un elemento
                //di ritardo
                Task.Delay(10).Wait();
                Console.WriteLine("End " + i);
            }
        }

        //FOR PARALLELO
        public static void ForParallelo()
        {
            Parallel.For(0, 10, i =>
            {
                Console.WriteLine("Start Parallel: " + i);
                Task.Delay(10).Wait();
                Console.WriteLine("End Parallel: " + i);
            });
        }

        //Versione Sincrona
        public static void MetodoA()
        {
            Console.WriteLine("Inizio Metodo A");
            Thread.Sleep(3000);
            Console.WriteLine("Fine Metodo A");
        }

        //Versione Asincrono => può viaggiare in maniera parallela
        //Convenzione nel scrivere un metodo async
        //ritorna sempre un task
        public static async Task MetodoAAsync()
        {
            Console.WriteLine("Inizio metodo async A");
            await Task.Delay(3000);
            Console.WriteLine("Fine metodo async A");
        }

        //Versione Sincrona
        public static void MetodoB()
        {
            Console.WriteLine("Inizio Metodo B");
            Thread.Sleep(3000);
            Console.WriteLine("Fine Metodo B");
        }

        //Versione Asincrono => può viaggiare in maniera parallela
        //Convenzione nel scrivere un metodo async
        //ritorna sempre un task
        public static async Task MetodoBAsync()
        {
            Console.WriteLine("Inizio metodo async B");
            await Task.Delay(3000);
            Console.WriteLine("Fine metodo async B");
        }

        //Versione Sincrona
        public static void MetodoC()
        {
            Console.WriteLine("Inizio Metodo C");
            Thread.Sleep(3000);
            Console.WriteLine("Fine Metodo C");
        }

        //Versione Asincrono => può viaggiare in maniera parallela
        //Convenzione nel scrivere un metodo async
        //ritorna sempre un task
        public static async Task MetodoCAsync()
        {
            Console.WriteLine("Inizio metodo async C");
            await Task.Delay(3000);
            Console.WriteLine("Fine metodo async C");
        }
    }
}
