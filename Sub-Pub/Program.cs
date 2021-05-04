using System;

namespace Sub_Pub
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoEventi();
        }
        public static void DemoEventi()
        {
            Publisher youtube = new Publisher("youtube.com");
            Publisher instagram = new Publisher("instagram");

            //Subscriber
            Subscriber sub1 = new Subscriber("Mario");
            Subscriber sub2 = new Subscriber("Giada");
            Subscriber sub3 = new Subscriber("Maicol");

            //Iscrizione all'evento
            sub1.Subscribe(youtube);
            sub3.Subscribe(youtube);
            sub2.Subscribe(instagram);

            //Scateno l'evento
            youtube.Publish();

            Console.WriteLine("--------------------");

            instagram.Publish();

        }
    }
}
