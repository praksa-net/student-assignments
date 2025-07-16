using DjordjeGajic;
using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Student
{

    public string Ime { get; set; }
    public string Prezime { get; set; }
    public int GodinaRodjenja {  get; set; }
    public List<int> Ocene {  get; set; }

    public double IzracunajProsek()
    {
        double suma = 0;
        foreach (int ocena in Ocene)
        {
            suma += ocena;
        }
        return suma / Ocene.Count;
    }

    public Prosek OdrediUspeh()
    {
        Prosek prosek;
        double ocena = IzracunajProsek();
        if (ocena >= 4.5)
        {
            prosek = Prosek.Odlican;
        }
        else if (ocena >= 3.5)
        {
            prosek = Prosek.Vrlodobar;
        }
        else if (ocena >= 2.5)
        {
            prosek = Prosek.Dobar;
        }
        else if (ocena >= 1.5)
        {
            prosek = Prosek.Dovoljan;
        }
        else
        {
            prosek = Prosek.Nevodoljan;
        }
        return prosek;
    }

    public Student(string ime, string prezime, int godinaRodjenja, List<int> ocene)
	{
        Ime = ime;
        Prezime = prezime;
        GodinaRodjenja = godinaRodjenja;
        Ocene = ocene;
        StudentInfo.PrikazInformacija(this);
	}
}