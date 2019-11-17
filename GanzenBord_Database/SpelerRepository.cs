using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanzenBord_Database
{
    public class SpelerRepository
    {
        DatabaseForGanzenbordEntities3 entities = new DatabaseForGanzenbordEntities3();
        public List<Spelers> GetSpelers()
        {
            var spelers = new List<Spelers>();

            foreach (var dbSpeler in entities.Spelers)
                spelers.Add(new Spelers
                {
                    Name = dbSpeler.NameOfSpeler,
                    Positie = dbSpeler.Positie
                });

            return spelers;
        }
        public void ModifyPositie(Spelers speler, int? positie)
        {
            var pos = entities.Spelers.Single(x => x.NameOfSpeler == speler.Name);
            pos.Positie = positie;
            entities.SaveChanges();

        }

    }
}
