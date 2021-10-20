using System;
using System.Collections.Generic;
using System.Linq;


namespace Vasya___Clerk
{
    class Program
    {
        static void Main(string[] args)
        {
            

        }


        /*
         * The new "Avengers" movie has just been released! There are a lot of people at the cinema box office standing in a huge line. 
         * Each of them has a single 100, 50 or 25 dollar bill. An "Avengers" ticket costs 25 dollars.

           Vasya is currently working as a clerk. He wants to sell a ticket to every single person in this line.

           Can Vasya sell a ticket to every person and give change if he initially has no money and sells the tickets strictly 
           in the order people queue?

           Return YES, if Vasya can sell a ticket to every person and give change with the bills he has at hand at that moment. 
           Otherwise return NO.
         */
        /*public static string Tickets(int[] peopleInLine)
        {
            const int TICKET_VALUE = 25;
            int Vasya = 0;
            foreach (int client in peopleInLine)
            {


                if (Vasya + TICKET_VALUE - client >= 0)
                {
                    int clientAux = client - TICKET_VALUE;
                    Vasya = Vasya + TICKET_VALUE - clientAux;

                }
                else
                {
                    return "NO";
                }
            }
            return "YES";
        }*/

        public static string Tickets(int[] peopleInLine)
        {
            int bancnote25 = 0;
            int bancnote50 = 0;

            foreach (var people in peopleInLine)
            {
                if (people==25)
                {
                    bancnote25++;
                }

                else if (people==50)
                {
                    bancnote25--;
                    bancnote50++;
                }
                else
                {
                    bancnote25--;
                    bancnote50--;
                }

                if (bancnote25<0 || bancnote50<0)
                {
                    return "NO";
                }
            }
            return "YES";
        }
    }
}
