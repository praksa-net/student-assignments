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
            Console.WriteLine();
        }
    }

    public void PrikaziNajvisiProsek(List<Student> studenti)
    {
        if (studenti.Count == 0)
        {
            Console.WriteLine("Nema studenata za prikaz.");
            return;
        }

        Student najboljiStudent = studenti[0];
        foreach (var student in studenti)
        {
            if (student.IzracunajProsek() > najboljiStudent.IzracunajProsek())
            {
                najboljiStudent = student;
            }
        }

        Console.WriteLine("Student sa najvišim prosekom:");
        Prikazi(najboljiStudent);
        Console.WriteLine();
    }

    public void PrikaziNajmanjiProsek(List<Student> studenti)
    {
        if (studenti.Count == 0)
        {
            Console.WriteLine("Nema studenata za prikaz.");
            return;
        }

        Student najmanjiStudent = studenti[0];
        foreach (var student in studenti)
        {
            if (student.IzracunajProsek() < najmanjiStudent.IzracunajProsek())
            {
                najmanjiStudent = student;
            }
        }

        Console.WriteLine("Student sa najnižim prosekom:");
        Prikazi(najmanjiStudent);
        Console.WriteLine();
    }

    public void PrikaziBrojOdlicnihStudenata(List<Student> studenti)
    {
        int brojOdlicnih = 0;
        foreach (var student in studenti)
        {
            if (student.OdrediUspeh() == Uspeh.Odlican)
            {
                brojOdlicnih++;
            }
        }
        Console.WriteLine($"Broj odličnih studenata: {brojOdlicnih}");
        Console.WriteLine();
    }
}