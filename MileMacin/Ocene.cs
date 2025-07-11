using System;

public class Ocene
{
    public void UnosOcena(Student student)
    {
        Console.Write("Unesite broj ocena: ");
        int brojOcena;
        if (!int.TryParse(Console.ReadLine(), out brojOcena) || brojOcena <= 0)
        {
            Console.Write("Molimo unesite ispravan pozitivan broj ocena: ");
        }

        for (int i = 0; i < brojOcena; i++)
        {
            Console.Write($"Unesite ocenu #{i + 1}: ");
            int ocena;
            if (!int.TryParse(Console.ReadLine(), out ocena) || ocena < 1 || ocena > 5)
            {
                Console.Write("Ocena mora biti ceo broj od 1 do 5. Pokusajte ponovo: ");
            }
            else
                student.Ocene.Add(ocena);
        }
    }


    
}
