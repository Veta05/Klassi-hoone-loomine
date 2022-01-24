using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassi_hoone_loomine
{
    public class KorterMaja : Hoone
    {
        private object korterid;

        public KorterMaja(int korterid = 100): base(korterid)
        {

        }
        public override void NaitaInfo()
        {
            Console.WriteLine($"Olen {korterid} korruseline maja!");
        }
    }
}
