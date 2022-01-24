using System;

namespace Klassi_hoone_loomine
{
    class Program
    {
        static void Main(string[] args)
        {
            Eramaja majake = new Eramaja();
            majake.NaitaInfo();
            KorterMaja majake2 = new KorterMaja();
            Inimene mees = new Inimene("Juku");
            majake.uks = new Uks("must");
            majake.korrused = new Korrused(10);
            majake.millest = new Millest("Paberist");
            mees.hoone = majake;
            mees.NaitaInfo();
        }
    }
}
