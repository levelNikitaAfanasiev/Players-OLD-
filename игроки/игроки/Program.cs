using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace игроки
{
    class Program
    {
        static void Main(string[] args)
        {
            int rand, firstNumber = 0, lastNumber = 1000, hod = 0, chisloyserdnogoigroka, randomplayerchislo, randomymniiplayerchislo = -1, randomcheaterchislo = -1;
            int k = 0, hodcheater = 1, chisloyserdnogoceater = 0;
            Random rnda = new Random();

            bool rezultuserd = false, rezultrandom = false, rezultlearnrandom, rezultYScheater = false, rezultats;
            int[] pamiatkaymnogoigroka = new int[lastNumber];
            int[] pamiatkayserdnogoigroka = new int[lastNumber];
            int[] pamiatkarandomPLAYER = new int[lastNumber];
            int[] pamiatkayserdnogoceatera = new int[lastNumber];
            int[] pamiatkarandomcheatera = new int[lastNumber];
            rand = 500;
            
            if (rand >= firstNumber && rand <= lastNumber)
            {



                int z = 0, v = 0, c = 0, n = 0;

                Console.WriteLine("загаданное число {0}",rand);
                do
                {

                    Yserdnii_igrok.Ygadchisla(out chisloyserdnogoigroka, ref hod, out rezultuserd, rand, firstNumber, ref pamiatkayserdnogoigroka, ref c);

                    RandomPlayer.Ygadchisla(ref z, rnda, out rezultrandom, out randomplayerchislo, rand, firstNumber, lastNumber, ref pamiatkarandomPLAYER);

                    Randomymniiigrok.Ygadchisla(rnda, out rezultlearnrandom, rand, firstNumber, lastNumber, ref randomymniiplayerchislo, ref pamiatkaymnogoigroka, ref k);

                    YserdniiCheater.Ygadchisla(ref pamiatkayserdnogoceatera, pamiatkarandomPLAYER, pamiatkaymnogoigroka, ref hodcheater, ref chisloyserdnogoceater, ref rezultYScheater, rand, firstNumber, ref v, k);

                    RandomCheater.Ygadchisla(rnda, out rezultats, rand, firstNumber, lastNumber, ref randomcheaterchislo, pamiatkaymnogoigroka, pamiatkayserdnogoigroka, pamiatkarandomPLAYER, pamiatkayserdnogoceatera, ref pamiatkarandomcheatera, ref n);


                    if (rezultuserd == true || rezultrandom == true || rezultlearnrandom == true || rezultYScheater == true || rezultats == true)
                        break;

                }
                while ( true);



            }
            else
            {
                Console.WriteLine("число введено неправильно");
            }
        }
    }
}
