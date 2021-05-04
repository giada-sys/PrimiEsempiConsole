using System;
using System.IO;

namespace Sub_Pub.FileWatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            FileSystemWatcher fsw = new FileSystemWatcher();

            //Specifico la directory dove voglio salvare il file
            fsw.Path= @"C:\Users\giada.lomasti\Desktop\Esempio\";

            //Filtra i file che hanno estensione .txt
            fsw.Filter = ".txt";

            //Enum- filtro della notifica che si attiva quando
            //cambiano il nome oppure ...
            fsw.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName | NotifyFilters.LastAccess;

            //Abilito le notifiche
            fsw.EnableRaisingEvents = true;

            //Multicast delegate -> alla creazione del file viene gestito l'evento
            fsw.Created += GestioneEvento.HandleNewTextFile;

            Console.WriteLine("Inserisci q per chiudere il programma");
            while (Console.Read() != 'q') ;

        }
    }
}
