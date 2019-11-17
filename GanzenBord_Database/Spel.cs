using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GanzenBord_Database
{
    public class Spel
    {
        private SpelerRepository spelerRepo = new SpelerRepository();

        List<Spelers> listVanSpelers = new List<Spelers>();
        Dobbelsteen dobblesteen = new Dobbelsteen();
        Bord spelbord = new Bord();
        public event delegateSendMessage OnSendMessage;

        public void Starten()
        {
            int num;
            foreach (var sp in spelerRepo.GetSpelers())
            {
                while (!sp.Gewonnen.Value)
                {
                Begin:
                    num = dobblesteen.RandomNumber();
                    Console.WriteLine($"{sp.Name}");
                    sp.Positie = sp.Positie + num;
                    sp.Positie = spelbord.PositieChecken(num, sp.Positie.Value);
                    spelerRepo.ModifyPositie(sp, sp.Positie);
                    if (sp.TooMuch.Value)
                    {
                    Tuda:
                        int y = sp.Positie.Value - 63;
                        num = dobblesteen.RandomNumber();
                        if (y < num)
                        {
                            sp.Positie = sp.Positie - num;
                            goto Begin;
                        }
                        else
                            goto Tuda;
                    }
                    OnSendMessage(spelbord.Message);
                }
            }
        }
    }
}