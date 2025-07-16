using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    enum Uspeh {
        [Description("Nedovoljan")]
        Nedovoljan,
        [Description("Dovoljan")]
        Dovoljan,
        [Description("Dobar")]
        Dobar,
        [Description("Vrlo Dobar")]
        VrloDobar, 
        [Description("Odličan")]
        Odlican
    }

}
