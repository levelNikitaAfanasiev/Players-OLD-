using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace игроки
{
    public static class RandomPlayer
    {


        static public void Ygadchisla(ref int  z, Random rnda,out bool rezultat, out int chislorandomigroka,int rand,int firstNumber,int lastNumber, ref int [] pamiatkarandomPLAYER)
        {
            string Name = "рандом игрок";
           
            chislorandomigroka = rnda.Next(firstNumber, lastNumber);
            pamiatkarandomPLAYER[z] = chislorandomigroka;
            z++;
            if (chislorandomigroka == rand)
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
