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
