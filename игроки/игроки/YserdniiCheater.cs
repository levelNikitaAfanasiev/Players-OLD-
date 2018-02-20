using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace игроки
{
    public static class YserdniiCheater
    {
        public static void Ygadchisla(ref int[] pamiatkayserdnogoceatera, int[] pamiatkarandomPLAYER, int[] pamiatkaymnogoigroka,ref int hodcheater, ref int chisloyserdnogoceater,ref bool rezultYScheater, int rand , int Firstnumber,ref int v, int k)
        {
            string Name = "Усердный читер";
            
            bool b;
            chisloyserdnogoceater = Firstnumber + hodcheater;
           
            do
            {
                b = true;
               
               
                for (int i = 0; i <= k; i++)
                {
                    if (pamiatkaymnogoigroka[i] == chisloyserdnogoceater || pamiatkarandomPLAYER[i] == chisloyserdnogoceater)
                    {
                        
                        b = false;
                       
                    }
                    if (b == false)
                    {
                        hodcheater++;
                        chisloyserdnogoceater = Firstnumber + hodcheater;
                        break;
                    }


                }

            } while (b == false);


            pamiatkayserdnogoceatera[v] = chisloyserdnogoceater;
            



            if (chisloyserdnogoceater == rand)
            {
                
                Console.WriteLine("выиграл {0}", Name);
                rezultYScheater = true;
            }
            else
            {
               rezultYScheater = false;
            }
            hodcheater++;
            v++;


        }





    }
}



