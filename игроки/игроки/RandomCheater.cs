using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace игроки
{
    static public class RandomCheater
    {
        
        public static void Ygadchisla(Random rnd, out bool rezultats, int rand, int firstNumber, int lastNumber, ref int randomcheaterchislo, int[] pamiatkaymnogoigroka, int[] pamiatkayserdnogoigroka, int[] pamiatkarandomPLAYER, int[] pamiatkayserdnogoceatera, ref int[] pamiatkarandomcheatera, ref int n)
        {

            string Name = "Рандом читер";
            bool b;



            randomcheaterchislo = rnd.Next(firstNumber, lastNumber);


            do
            {
                b = true;

                for (int i = 0; i <= n; i++)
                {
                    if (pamiatkaymnogoigroka[i] == randomcheaterchislo || pamiatkarandomcheatera[i] == randomcheaterchislo || pamiatkarandomPLAYER[i] == randomcheaterchislo || pamiatkayserdnogoceatera[i] == randomcheaterchislo || pamiatkayserdnogoigroka[i] == randomcheaterchislo)
                    {
                       
                        b = false;
                    }
                    if (b == false)
                    {
                        randomcheaterchislo = rnd.Next(firstNumber, lastNumber);

                    }


                }






            } while (b == false);

            pamiatkaymnogoigroka[n] = randomcheaterchislo;
           

            if (randomcheaterchislo == rand)
            {
                
                Console.WriteLine("выиграл {0}", Name);
                rezultats = true;
            }
            else
            {
                rezultats = false;
            }
            n++;


        }


    }
}