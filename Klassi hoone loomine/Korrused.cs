using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassi_hoone_loomine
{
    public class Korrused
    {
        public int Korrus { get; set; }

        public Korrused(int korrus = 5)
        {
            Korrus = korrus;
        }

        public void NaitaInfo()
        {
            Console.WriteLine($"Mina olen maja ja olen {Korrus} korruseline.");
        }
        


    }
}
