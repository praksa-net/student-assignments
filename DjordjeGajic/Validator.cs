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
                if (int.TryParse(Console.ReadLine(), out int rezultat))
                {
                    if ((rezultat > 0 && rezultat < 6) || rezultat == 0)
                    {
                        return rezultat;
                    }
                    else
                    {
                        Console.WriteLine("Molimo Vas unesite validnu ocenu (od 1 do 5).");
                    }
                }
                else
                {
                    Console.WriteLine("Molimo Vas unesite BROJ od 1 do 5.");
                }
            }
        }
    }
}
