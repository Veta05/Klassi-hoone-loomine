using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassi_hoone_loomine
{
    public class Millest //vmesto enum, ne menjajet znachenija
    {
        //Kivimaja,
        //Puitmaja,
        //Palkmaja,
        //PaneelMaja

        public string Materjal { get; set; }

        public Millest(string materjal = "kivist")
        {
            Materjal = materjal;
        }
        public void NaitaInfo()
        {
            Console.WriteLine($"Mina olen maja, ja olen {Materjal}");
        }
}
}
