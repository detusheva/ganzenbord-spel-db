using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanzenBord_Database
{
        public class Dobbelsteen
        {
            public int RandomNumber()
            {
                Random rdn = new Random();
                return rdn.Next(0, 6);
            }
        }
}
