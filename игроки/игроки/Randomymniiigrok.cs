using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace игроки
{
    public static class Randomymniiigrok
    {
     

        public static void Ygadchisla(Random rnd, out bool rezultat,int rand, int firstNumber, int lastNumber, ref int randomymniiplayerchislo,ref int[] pamiatkaymnogoigroka, ref int k)
        {
            string Name = "Рандом умный игрок";

            bool b;

        

            randomymniiplayerchislo = rnd.Next(firstNumber, lastNumber);
          
           
            do
            {
                b = true;

                for (int i = 0; i <= k; i++)
                {
                    if (pamiatkaymnogoigroka[i] == randomymniiplayerchislo)
                    {
                       
                        b = false;
                    }
                    if(b == false)
                    {
                        randomymniiplayerchislo = rnd.Next(firstNumber, lastNumber);
                       
                    }
                   

                }






            } while (b == false);

            pamiatkaymnogoigroka[k] = randomymniiplayerchislo;
         

            if (randomymniiplayerchislo == rand)
            {
               
                Console.WriteLine("выиграл {0}", Name);
                rezultat = true;
            }
            else
            {
                rezultat = false;
            }
            k++;


        }


    }
}
