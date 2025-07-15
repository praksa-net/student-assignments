using System;
using System.Collections.Generic;

public static class StudentApp
{
    public static void Pokreni()
    {
        var studentFactory = new StudentFactory();
        var printer = new ConsoleStudentPrinter();

        Console.WriteLine("--- Dobrodošli u aplikaciju za unos studenata ---");
        Console.WriteLine("Unesite podatke za studente. Za kraj unosa unesite 'kraj' u ime ili prezime.");
        Console.WriteLine();

        studentFactory.inputStudents();

        Console.WriteLine("\n--- Svi uneti studenti ---");
        printer.PrikaziSve(studentFactory.GetAllStudents());

        studentFactory.SaveToJsonFile();
    }
} 