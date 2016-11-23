using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Threading;

namespace TiedontallennusCmd
{
    class Program
    {
        static void Main(string[] args)
        {
            int lämpötila = 0;
            Console.Write("Aseta uusi lämpötila:   ");
            string syöte = Console.ReadLine();
            lämpötila = int.Parse(syöte);

            //Tiedostoon kirjoittaminen
            string tiedosto = @"D:\Code\lämpötila.txt";
            File.WriteAllText(tiedosto, lämpötila.ToString());
            Console.WriteLine("Lämpötila tallennettu.");


            Console.ReadLine();
        }
    }
}
