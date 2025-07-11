using System;

public class StudentApp
{
   

    public void UnosStudenta()
    {
        Console.Write("Unesite ime studenta: ");
        string ime = Console.ReadLine();
        Console.Write("Unesite prezime studenta: ");
        string prezime = Console.ReadLine();
        Console.Write("Unesite godinu rodjenja studenta: ");
        int godinaRodjenja;
        while (!int.TryParse(Console.ReadLine(), out godinaRodjenja) || godinaRodjenja <= 0)
        {
            Console.Write("Molimo unesite ispravnu godinu rodjenja: ");
        }
        Student student = new Student(ime, prezime, godinaRodjenja);
       
    }

 














    /*Console.Write("Unesite broj ocena: ");
        int brojOcena;
        while (!int.TryParse(Console.ReadLine(), out brojOcena) || brojOcena <= 0)
        {
            Console.Write("Molimo unesite ispravan pozitivan broj ocena: ");
        }
    */

    /*for (int i = 0; i < brojOcena; i++)
    {
        Console.Write($"Unesite ocenu #{i + 1}: ");
        int ocena;
        while (!int.TryParse(Console.ReadLine(), out ocena) || ocena < 1 || ocena > 5)
        {
            Console.Write("Ocena mora biti ceo broj od 1 do 5. Pokusajte ponovo: ");
        }
        student.Ocene.Add(ocena);
    }
    */
}
