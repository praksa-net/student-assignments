using System;
using System.Collections.Generic;

public interface IStudentPrinter
{
    void Prikazi(Student s);
    void PrikaziSve(List<Student> studenti);
}

public class ConsoleStudentPrinter : IStudentPrinter
{
    public void Prikazi(Student s)
    {
        Console.WriteLine($"Ime: {s.Ime}");
        Console.WriteLine($"Prezime: {s.Prezime}");
        Console.WriteLine($"Godina rođenja: {s.GodinaRodjenja}");
        Console.WriteLine($"Prosek ocena: {s.IzracunajProsek()}");
        Console.Write("Uspeh: ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(s.OdrediUspeh());
        Console.ResetColor();
    }

    public void PrikaziSve(List<Student> studenti)
    {
        if (studenti.Count == 0)
        {
            Console.WriteLine("Nema studenata.");
            return;
        }
        for (int i = 0; i < studenti.Count; i++)
        {
            Console.WriteLine($"--- Student #{i + 1} ---");
            Prikazi(studenti[i]);
        }
    }
}