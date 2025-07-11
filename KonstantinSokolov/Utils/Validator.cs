using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonstantinSokolov.Utils
{
    public static class Validator
    {

        public static int UnesiBroj(string poruka)
        {
            while (true)
            {
                Console.WriteLine(poruka);
                try
                {
                    return Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Pogresan uvod!");
                }
            }
        }

        public static bool IsNameValid(string s)
        {
            return !string.IsNullOrWhiteSpace(s);
        }

        public static bool IsGradeCorrect(int grade)
        {
            return grade >= 1 && grade <= 5;
        }

        public static bool IsYearOfBirthCorrect(int year)
        {
            int currentYear = DateTime.Now.Year;
            return year > 1900 && year <= currentYear;
        }
    }
}
