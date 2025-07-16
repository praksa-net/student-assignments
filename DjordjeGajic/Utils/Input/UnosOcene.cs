using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DjordjeGajic
{
    internal class UnosOcene
    {
        internal static int Unos(List<int> ocene)
        {
            Console.WriteLine("Unesite ocenu (ili '0' za kraj unosa).");
            int unos = Validator.Validacija();
            int ocena = unos;
            if (ocena != 0)
            {
                ocene.Add(ocena);
            }
            return ocena;
        }
    }
}
