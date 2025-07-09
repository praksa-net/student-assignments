using System;
class Student
{
  public string Ime { get; set; }
  public string Prezime { get; set; }
  public int GodinaRodjenja { get; set; }
  public int[] Ocene { get; set; }

  public Student() { }

  public Student(string name, string surname, int godina)
  {
    Ime = name;
    Prezime = surname;
    GodinaRodjenja = godina;
  }

  public double IzracunajProsek()
  {
    if (Ocene == null || Ocene.Length == 0)
    {
      return 0.0;
    }

    double prosek = Ocene.Average();
    return prosek;
  }

  public String OdrediUspeh()
  {
    double prosek = IzracunajProsek();
    if (prosek == 0.0) return "Nema ocena";
    else if (prosek >= 4.5) return "Odličan";
    else if (prosek >= 3.5) return "Vrlo dobar";
    else if (prosek >= 2.5) return "Dobar";
    else if (prosek >= 1.5) return "Dovoljan";
    else return "Nedovoljan";
  }
}
