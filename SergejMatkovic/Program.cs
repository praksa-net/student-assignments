using SergejMatkovic;
using System;

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student();

        Console.Write("Unesi ime: ");
        student.Ime = Console.ReadLine();

        Console.Write("Unesi prezime: ");
        student.Prezime = Console.ReadLine();

        Console.Write("Unesi godinu ro?enja: ");
        student.GodinaRodjenja = int.Parse(Console.ReadLine());

        Console.Write("Unesi broj ocena: ");
        int brojOcena = int.Parse(Console.ReadLine());

        for (int i = 0; i < brojOcena; i++)
        {
            int ocena;
            do
            {
                Console.Write($"Unesi ocenu {i + 1} (1–5): ");
                ocena = int.Parse(Console.ReadLine());

                if (!Validator.ValidnaOcena(ocena))
                {
                    Console.WriteLine("Greška: Ocena mora biti izme?u 1 i 5.");
                }
            } while (!Validator.ValidnaOcena(ocena));

            student.Ocene.Add(ocena);
        }

        
        Console.WriteLine("\n--- Podaci o studentu ---");
        Console.WriteLine($"Ime: {student.Ime}");
        Console.WriteLine($"Prezime: {student.Prezime}");
        Console.WriteLine($"Godina ro?enja: {student.GodinaRodjenja}");
        Console.WriteLine($"Ocene: {string.Join(", ", student.Ocene)}");
        Console.WriteLine($"Prosek: {student.IzracunajProsek():0.00}");
        Console.WriteLine($"Uspeh: {student.OdrediUspeh()}");
    }
}
    