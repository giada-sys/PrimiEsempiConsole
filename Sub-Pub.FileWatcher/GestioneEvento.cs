using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sub_Pub.FileWatcher
{
     class GestioneEvento
    {
        public static void HandleNewTextFile(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"Un nuovo file è stato creato {e.Name}");

            //Lettura del file
            using (StreamReader reader = File.OpenText(e.FullPath))
            {
                Console.WriteLine($"--- Lettura di {e.Name} ---");

                string line;
                //Finchè reader legge una linea diversa da null
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
                reader.Close();
            }

            Console.WriteLine("Fine del contenuto");

            //Scrittura su file
            using (StreamWriter writer = File.CreateText(@"C:\Users\giada.lomasti\Desktop\Esempio\ProvaScrittura.txt"))
            {
                writer.WriteLine($"Prova");
                writer.Close();
            }

        }
    }
}
