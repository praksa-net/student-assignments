using System;
using DjordjeGajic;
/// <summary>
/// Summary description for Class1
/// </summary>
public class StudentApp
{


	public StudentApp()
	{
        List<int> ocene = new List<int>();
        int unos = 1;
        do
        {
            Console.WriteLine("Unesite ocenu (ili '0' za kraj unosa).");
            unos = Validator.Validacija();
            int ocena = unos;
            if (ocena != 0)
            {
                ocene.Add(ocena);
            }
        } while (unos != 0);
        Student student = new Student("Djordje", "Gajic", 2007, ocene);
    }
}
