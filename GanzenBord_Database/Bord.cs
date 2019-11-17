using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanzenBord_Database
{
        public class Bord
        {
            public int positie;
            public string Message { get; set; }
            public int PositieChecken(int werp, int huidige_positie)
            {
                if (huidige_positie == 23)
                {
                    Message = $"Je hebt { werp} gegooid, je staat op plaats {huidige_positie}. Het spel is over.";
                    positie = 2000;
                }
                else if (huidige_positie == 25 || huidige_positie == 45)
                {
                    Message = $"Je hebt { werp} gegooid, je staat op plaats {huidige_positie}. Je moet terug naar de start.";
                    positie = 0;
                }
                else if (huidige_positie == 10 || huidige_positie == 20 || huidige_positie == 30 || huidige_positie == 40 || huidige_positie == 50 || huidige_positie == 60)
                {
                    positie = huidige_positie + werp;
                    Message = $"Je hebt { werp} gegooid, je staat op plaats {huidige_positie}. Bonus stapjes! Je staat op plaats {positie}";
                }
                else
                {
                    positie = huidige_positie;
                    Message = $"Je hebt { werp} gegooid, je staat op plaats {huidige_positie}. Gooi je dobbelsteen (g)";
                }
                return positie;
            }
        }
}
