using DjordjeGajic;
using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Student
{

    public string Ime;
    public string Prezime;
    public int GodinaRodjenja;
    public List<int> Ocene;

    public double IzracunajProsek()
    {
        double suma = 0;
        foreach (int ocena in Ocene)
        {
            suma += ocena;
        }
        return suma / Ocene.Count;
    }

    public string OdrediUspeh()
    {
        string prosek;
        double ocena = IzracunajProsek();
        if (ocena >= 4.5)
        {
            prosek = "Odlican.";
        }
        else if (ocena >= 3.5)
        {
            prosek = "Vrlo dobar.";
        }
        else if (ocena >= 2.5)
        {
            prosek = "Dobar.";
        }
        else if (ocena >= 1.5)
        {
            prosek = "Dovoljan.";
        }
        else
        {
            prosek = "Nedovoljan.";
        }
        return prosek;
    }

    /*void PrikazInformacija()
    {
        Console.WriteLine("Informacije o studentu:");
        Console.WriteLine($"Ime i prezime: {Ime} {Prezime}");
        Console.WriteLine($"Godina rodjenja: {GodinaRodjenja}");
        Console.WriteLine("Ocene studenta");
        foreach (int ocena in Ocene)
        {
            Console.Write(ocena + " ");
        }
        Console.WriteLine();
        Console.WriteLine($"Prosek i uspeh: {IzracunajProsek()} - {OdrediUspeh()}");
    }*/

    public Student(string ime, string prezime, int godina, List<int> ocene)
	{
        Ime = ime;
        Prezime = prezime;
        GodinaRodjenja = godina;
        Ocene = ocene;
        StudentInfo.PrikazInformacija(this);
	}
}