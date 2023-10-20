using System;
using System.Diagnostics.CodeAnalysis;

namespace Uppgift4_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in en sträng");
            string svar = Console.ReadLine();
            string tecken = "";

            for (int i = 0; i < svar.Length; i++)
            {
                if (svar[(i+1)..].Contains(svar[i]) && !tecken.Contains(svar[i])) //kollar om tecknet finns senare i ordet och om tecknet redan har skrivits ut
                {
                    tecken += svar[i]; // lägger till tecknet i listan av tecken som skrivts ut så det inte skrivs ut mer än 1 gång
                    Console.WriteLine($"'{svar[i]}' förekommer mer än en gång.");
                }
            }

            if (tecken == "")
            {
                Console.WriteLine("Inget tecken förekommer mer än en gång");
            }

            Console.WriteLine("Tryck på valfri knapp för att avsluta");
            Console.ReadKey();
        }
    }
}