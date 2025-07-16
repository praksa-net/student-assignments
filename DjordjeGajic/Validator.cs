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

        public static bool IsNameValid(string input)
        {
            return !string.IsNullOrWhiteSpace(input);
        }

        public static int YearValidation()
        {
            while (true)
            {
                try
                {
                    int rezultat = int.Parse(Console.ReadLine());

                    if(rezultat >= 2000 && rezultat <= 2006)
                    {
                        return rezultat;
                    }
                    else
                    {
                        Console.WriteLine("Molimo Vas unesite validnu godinu rodjenja.");
                    }
                }
                catch(FormatException)
                {
                    Console.WriteLine("Molimo Vas unesite BROJ od 2000 do 2006.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Uneti broj je preveliki ili premali.");
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"Dogodila se greska: {ex.Message}");
                }
            }
        }
    }
}