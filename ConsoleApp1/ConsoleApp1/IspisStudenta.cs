using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class IspisStudenta
    {
        public static void IspišiSve()
        {
            Console.WriteLine("Unesi ime");
            string ime = Console.ReadLine();
            Console.WriteLine("Unesi prezime");
            string prezme = Console.ReadLine();
            Console.WriteLine("Unesi godinu rođenja");
            int godinaRođenja = int.Parse(Console.ReadLine());
            Student s = new Student(ime, prezme, godinaRođenja);
            s.Ocena = new List<int> { };
            Console.WriteLine("Unesi broj ocena");
            int broj = int.Parse(Console.ReadLine());
            for (int i = 0; i < broj; i++)
            {
                Console.WriteLine("Unesi ocenu:");
                try
                {
                    int ocena = int.Parse(Console.ReadLine());
                    if (ocena >= 1 && ocena <= 5)
                    {
                        s.Ocena.Add(ocena);
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Unesi broj od jedan do pet");
                        i--;
                    }
                }
                catch
                {
                    Console.WriteLine("unesite broj");
                    i--;
                }
            }
            s.Ispis();
            s.IzracunajProsek();
            s.OdrediUspeh();
        }
    }
}
