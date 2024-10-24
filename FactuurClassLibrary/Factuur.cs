using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace FactuurClassLibrary
{
    public class Factuur
    {
        public int FactuurID { get; set; }
        public int KlantID { get; set; }
        public string KlantNaam { get; set; }

        public Factuur(int factuurID, int klantID, string klantNaam)
        {
            FactuurID = factuurID;
            KlantID = klantID;
            KlantNaam = klantNaam;
        }
        public Factuur()
        {

        }

        public override string ToString()
        {
            return $"{FactuurID} - {KlantNaam}";
        }

    }
}
