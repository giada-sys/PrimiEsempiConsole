using System;
using System.Threading.Tasks;

namespace Sub_Pub.Async_Parallel
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("--- For Normale ---");
            //Metodi.ForNormale();
            //Console.WriteLine("----------------");


            ////Nel for parralelo perdo il controllo dell'esecuzione
            ////Io programmatore posso dire solo che è parallelo
            //Console.WriteLine("--- For Parallelo ---");
            //Metodi.ForParallelo();
            //Console.WriteLine("----------------");

            Console.WriteLine("----Metodi Sincroni----");
            Metodi.MetodoA();
            Metodi.MetodoB();
            Metodi.MetodoC();
            Console.WriteLine("----------------");

            //Esecuzione non sequenziale
            Console.WriteLine("----Metodi Asincroni----");
            //Devo creare un array di task perchè
            //i metodi Async non sono dei voi ma sono metodi
            //che sostituiscono dei task

            Task taskA = Metodi.MetodoAAsync();
            Task taskB = Metodi.MetodoBAsync();
            Task taskC = Metodi.MetodoCAsync();

            Console.ReadKey();

        }
    }
}
