using System;
using DjordjeGajic;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Zdravo, DjordjeGajic!");
        List<int> ocene = new List<int>();
        int unos = 1;
        do
        {
            Console.WriteLine("Unesite ocenu (ili '0' za kraj unosa).");
            unos = Validator.Validacija();
            int ocena = unos;
            if (ocena != 0)
            {
                ocene.Add(ocena);
            }
        } while (unos != 0);
        Student student = new Student("Djordje", "Gajic", 2007, ocene);
        Console.ReadKey();
    }

    
}