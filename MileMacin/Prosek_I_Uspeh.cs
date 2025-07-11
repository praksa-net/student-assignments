using System;

public class Prosek_I_Uspeh
{
    public double IzracunajProsek(Student student)
    {
        if (student.Ocene == null || student.Ocene.Count == 0)
            return 0.0;
        double suma = 0;
        foreach (int ocena in student.Ocene)
        {
            suma += ocena;
        }
        return suma / student.Ocene.Count;
    }

    public string OdrediUspeh(Student student)
    {
        double prosek = IzracunajProsek(student);
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
