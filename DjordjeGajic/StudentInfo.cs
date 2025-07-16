using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DjordjeGajic
{
    internal class StudentInfo
    {
        public static void PrikazInformacija(Student s)
        {
            Console.WriteLine("Informacije o studentu:");
            Console.WriteLine($"Ime i prezime: {s.Ime} {s.Prezime}");
            Console.WriteLine($"Godina rodjenja: {s.GodinaRodjenja}");
            Console.WriteLine("Ocene studenta");
            foreach (int ocena in s.Ocene)
            {
                Console.Write(ocena + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"Prosek i uspeh: {s.IzracunajProsek()} - {s.OdrediUspeh()}");
        }
    }
}
