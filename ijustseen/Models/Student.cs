class Student
{
  public string Ime { get; set; }
  public string Prezime { get; set; }
  public int GodinaRodjenja { get; set; }
  public int[] Ocene { get; set; }

  // public enum Uspeh
  // { 
  //   Odlican,
  //   VrloDobar,
  //   Dobar,
  //   Dovoljan,
  //   Nedovoljan,
  //   NemaOcena
  // }

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
    int brojOcena = Validator.getValidatedIntString();
    Ocene = new int[brojOcena];
    for (int i = 0; i < brojOcena; i++)
    {
      Console.Write($"Unesite {i + 1}. ocenu: ");
      int ocena = Validator.getValidatedIntString();
      while (!Validator.ValidateOcena(ocena))
      {
        Console.WriteLine("Uneta ocena nije validna. Unesite ocenu između 1 i 5.");
        Console.Write($"Unesite {i + 1}. ocenu: ");
        ocena = Validator.getValidatedIntString();
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
    if (prosek == 0.0) return Uspeh.NemaOcena;
    else if (prosek >= 4.5) return Uspeh.Odlican;
    else if (prosek >= 3.5) return Uspeh.VrloDobar;
    else if (prosek >= 2.5) return Uspeh.Dobar;
    else if (prosek >= 1.5) return Uspeh.Dovoljan;
    else return Uspeh.Nedovoljan;
  }
}
