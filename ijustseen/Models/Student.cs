using System;
class Student
{
  public string Ime { get; set; }
  public string Prezime { get; set; }
  public int GodinaRodjenja { get; set; }
  public int[] Ocene { get; set; }

  public enum Uspeh
  { 
    Odlican,
    VrloDobar,
    Dobar,
    Dovoljan,
    Nedovoljan,
    NemaOcena
  }

  public Student() { }

  public Student(string name, string surname, int godina)
  {
    Ime = name;
    Prezime = surname;
    GodinaRodjenja = godina;
  }

  public void UnosOcena()
  { 
    Console.Write("Unesite broj ocena studenta:");
    int brojOcena = Validator.validateIntLine();
    Ocene = new int[brojOcena];
    for (int i = 0; i < brojOcena; i++)
    {
      Console.Write($"Unesite {i + 1}. ocenu: ");
      int ocena = Validator.validateIntLine();
      while (!Validator.ValidateOcena(ocena))
      {
        Console.WriteLine("Uneta ocena nije validna. Unesite ocenu između 1 i 5.");
        Console.Write($"Unesite {i + 1}. ocenu: ");
        ocena = Validator.validateIntLine();
      }
      Ocene[i] = ocena;
    }
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

  public Uspeh OdrediUspeh()
  {
    double prosek = IzracunajProsek();
    if (prosek == 0.0) return (Uspeh)5;
    else if (prosek >= 4.5) return (Uspeh)0;
    else if (prosek >= 3.5) return (Uspeh)1;
    else if (prosek >= 2.5) return (Uspeh)2;
    else if (prosek >= 1.5) return (Uspeh)3;
    else return (Uspeh)4;
  }
}
