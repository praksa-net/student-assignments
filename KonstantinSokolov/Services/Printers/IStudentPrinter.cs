using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonstantinSokolov.Services.Printers
{
    public interface IStudentPrinter
    {
        void Prikazi(Models.Student student);
        void PrikaziListu(IEnumerable<Models.Student> studenti);
    }
}
