using System;

namespace Uppgift_5._5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] svaren = new string[10];

            svaren[0] = "Ja";
            svaren[1] = "Nej";
            svaren[2] = "Det kommer märkas inom en snar framtid.";
            svaren[3] = "Kanske";
            svaren[4] = "Ingen som vet";
            svaren[5] = "Vänta och se";
            svaren[6] = "Det kommer du aldrig få veta.";
            svaren[7] = "Vem vet";
            svaren[8] = ";)";
            svaren[9] = "Hur ska jag veta det?";

            string val = "";
            int slumptal = 0;
            Random rnd = new Random();

            while(val != "a")
            {
                slumptal = rnd.Next(10);
                Console.WriteLine("Skriv en fråga. (skriv a för att avsluta.)");
                val = Console.ReadLine();
                if(val == "a")
                {
                    Console.WriteLine("Programmet avslutas...");
                }
                else
                {
                    Console.WriteLine(svaren[slumptal]);
                }
            }
            Console.ReadKey();
        }
    }
}