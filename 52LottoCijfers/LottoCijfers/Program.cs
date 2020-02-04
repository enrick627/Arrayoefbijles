//Enrick De Munter 5ITN nr3
/* OPGAVE
 * ======
 * Geef 6 random lottocijfers met maximum 43 getallen
 *
 * ANALYSE
 * =======
 * GEEF     6 random getalle
 *
 * BEREKEN  geef 6 random getallen met maximum 43 en mag maar 1 keer gebruikt worden
 *
 * TOON     6 random getallen
 *
 *
 *
 */
using System;

namespace LottoCijfers
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Random randomMaker = new Random();
            int[] getallen = new int[6];
            bool klaar = false;
            int index = 0;

            while (klaar==false)
            {
                int getal = (randomMaker.Next() % 43) + 1;
                if(!vindGetal(getallen, getal))
                {
                    getallen[index] = getal;
                    index++;
                }

                if (index == 6)
                {
                    klaar = true;
                }
            }

            foreach (int getal in getallen)
            {
                Console.WriteLine(getal);
            }
        }

        public static bool vindGetal(int[] getallen, int gezochtGetal)
        {
            bool gevonden = false;

            foreach (int getal in getallen)
            {
                if (getal == gezochtGetal)
                {
                    gevonden = true;
                }
            }

            return gevonden;
        }
    }
}
