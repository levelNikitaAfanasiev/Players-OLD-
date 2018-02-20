using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace игроки
{
    public static class Yserdnii_igrok
    {       

        static public void Ygadchisla(out int chisloyserdnogoigroka, ref int hod, out bool rezultat, int rand, int FirstNumber,ref int [] pamiatkayserdnogoigroka, ref int c)
        {
            string Name = "Усердный игрок";
            chisloyserdnogoigroka = FirstNumber + hod;
            pamiatkayserdnogoigroka[c] = chisloyserdnogoigroka;
            c++;
            hod++;
            if (chisloyserdnogoigroka == rand)
            {
            
                Console.WriteLine("выиграл {0}", Name);
                rezultat = true;
            }
            else
            {
                rezultat = false;
            }
        }

    }
}
