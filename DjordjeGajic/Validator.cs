using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DjordjeGajic
{
    public class Validator
    {
        public static int Validacija()
        {
            while (true)
            {
                try
                {
                    Console.Write("Unesite ocenu (1 do 5): ");
                    int rezultat = int.Parse(Console.ReadLine());

                    if (rezultat >= 0 && rezultat <= 5)
                    {
                        return rezultat;
                    }
                    else
                    {
                        Console.WriteLine("Molimo Vas unesite validnu ocenu (od 1 do 5).");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Molimo Vas unesite BROJ od 1 do 5.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Uneti broj je prevelik ili premali.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Dogodila se greška: {ex.Message}");
                }
            }
        }
    }
}
