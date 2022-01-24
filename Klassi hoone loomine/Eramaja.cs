using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassi_hoone_loomine
{
    public class Eramaja : Hoone
    {
        int suurus;
        string status;
        public Eramaja(int pindala = 50) :base(pindala)
        {
        }

        public string Status
        {
            get { return status; }
        }

        public override void NaitaInfo()
        {
            Console.WriteLine($"Mina olen{status}, minu pindala on {Pindala} m2");
            if (suurus <= 40)
            {
                Console.WriteLine("Väike maja.");
            }
            else if (suurus >= 41 && suurus <= 100)
            {
                Console.WriteLine("Keskmine maja.");
            }
            else
            {
                Console.WriteLine("Suur maja.");
            }
        }
    }
}
