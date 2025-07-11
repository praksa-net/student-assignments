using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SergejMatkovic
{
    static class Validator
    {
        public static bool ValidnaOcena(int ocena)
        {
            return ocena >= 1 && ocena <= 5;
        }
    }
}
