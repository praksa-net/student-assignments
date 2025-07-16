using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DjordjeGajic
{
    internal class StudentFactory
    {
        public static Student CreateMockStudent()
        {
            return new Student("Name", "Lastname", 18, new List<int> { 1, 2, 3, 4, 5 });
        }
    }
}
