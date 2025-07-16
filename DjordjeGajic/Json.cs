using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DjordjeGajic
{
    internal class Json
    {
        internal static void Save(List<Student> students)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            string json = JsonSerializer.Serialize(students, options);
            File.WriteAllText("C:\\Users\\Administrator\\source\\repos\\student-assignments\\DjordjeGajic\\students.json", json);
        }

        public static List<Student> Get()
        {
            string jsonString = File.ReadAllText("C:\\Users\\Administrator\\source\\repos\\student-assignments\\DjordjeGajic\\students.json");
            return JsonSerializer.Deserialize<List<Student>>(jsonString);
        }
    }
}
