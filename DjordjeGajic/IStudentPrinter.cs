using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DjordjeGajic
{
    internal interface IStudentPrinter
    {
        void PrintName(string name, string lastname);
        void PrintBirthYear(int year);
        void PrintGrades(List<int> grades);

        void PrintProsekUspeh(Student s);
    }
}
