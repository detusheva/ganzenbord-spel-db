using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanzenBord_Database
{
        public class Spelers
        {
            public string Name { get; set; }
            public int? Positie { get; set; }
            public bool? Gewonnen { get { return Positie == 63; } }
            public bool? TooMuch { get { return Positie > 63; } }

        }
}
