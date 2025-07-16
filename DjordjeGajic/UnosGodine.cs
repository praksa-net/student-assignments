using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DjordjeGajic
{
    internal class UnosGodine
    {
        internal static int Unos()
        {
            Console.WriteLine("Unesite godinu rodjenja:");
            int godina = Validator.YearValidation();
            return godina;
        }
    }
}
