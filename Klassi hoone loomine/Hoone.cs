using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassi_hoone_loomine
{
    public abstract class Hoone
    {
        public int Pindala { get; set; }
        public int Korterid { get; set; }
        public Uks uks;
        public Millest millest;
        public Millest Millest { get; }
        public Korrused korrused;

        public Hoone(int pindala = 200, int korterid = 100)
        {
            Pindala = pindala;
            Korterid = korterid;
        }
        //public Hoone(Millest millest)
        //{
        //    Millest = Millest.PaneelMaja;
        //}

        public abstract void NaitaInfo();

        public Uks GetUks()
        {
            return uks;
        }
        public Millest GetMaterjal()
        {
            return millest;
        }
        public Korrused GetKorrused()
        {
            return korrused;
        }
    }
}
