using System;
using System.Collections.Generic;

class Student
{
    public string Ime { get; set; }
    public string Prezime { get; set; }
    public int GodinaRodjenja { get; set; }
    public List<int> Ocene { get; set; }

    public Student(string ime, string prezime, int godinaRodjenja)
    {
        Ime = ime;
        Prezime = prezime;
        GodinaRodjenja = godinaRodjenja;
        Ocene = new List<int>();
    }

   
    public double IzracunajProsek()
    {
        if (Ocene == null || Ocene.Count == 0)
            return 0.0;

        double suma = 0;
        foreach (int ocena in Ocene)
        {
            suma += ocena;
        }
        return suma / Ocene.Count;
    }

    public string OdrediUspeh()
    {
        double prosek = IzracunajProsek();

        if (prosek >= 4.5)
            return "Odlican";
        else if (prosek >= 3.5)
            return "Vrlo dobar";
        else if (prosek >= 2.5)
            return "Dobar";
        else if (prosek >= 1.5)
            return "Dovoljan";
        else
            return "Nedovoljan";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student("Mile", "Macin", 2000);

        Console.Write("Unesite broj ocena: ");
        int brojOcena;
        while (!int.TryParse(Console.ReadLine(), out brojOcena) || brojOcena <= 0)
        {
            Console.Write("Molimo unesite ispravan pozitivan broj ocena: ");
        }

        for (int i = 0; i < brojOcena; i++)
        {
            Console.Write($"Unesite ocenu #{i + 1}: ");
            int ocena;
            while (!int.TryParse(Console.ReadLine(), out ocena) || ocena < 1 || ocena > 5)
            {
                Console.Write("Ocena mora biti ceo broj od 1 do 5. Pokusajte ponovo: ");
            }
            student.Ocene.Add(ocena);
        }

        double prosek = student.IzracunajProsek();
        Console.WriteLine($"Prosek ocena za {student.Ime} {student.Prezime} je: {prosek:F2}");

        Console.WriteLine($"Uspeh za {student.Ime} {student.Prezime} je: {student.OdrediUspeh()}");

        Console.WriteLine("Zdravo, MileMacin!");        
    }
}