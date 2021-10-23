using System;
using System.Linq;

namespace RGB_To_Hex_Conversion
{
    internal class Program
    {
        /*
         * The rgb function is incomplete.
         * Complete it so that passing in RGB decimal values will result in a hexadecimal representation being returned.
         * Valid decimal values for RGB are 0 - 255.
         * Any values that fall out of that range must be rounded to the closest valid value.
         */

        private static void Main(string[] args)
        {
            /*Console.WriteLine(Rgb(255, 255, 255));
            Console.WriteLine(Rgb(255, 255, 300));
            Console.WriteLine(Rgb(0, 0, 0));
            Console.WriteLine(Rgb(148, 0, 211));
            Console.WriteLine(Rgb(148, -20, 211));
            Console.WriteLine(Rgb(144, 195, 212));
            Console.WriteLine(Rgb(7, 219, 49));*/


            Console.WriteLine($"{2:p0}");


            /*Console.WriteLine(MyMethod(255, 255, 255));
            Console.WriteLine(MyMethod(255, 255, 300));
            Console.WriteLine(MyMethod(0, 0, 0));
            Console.WriteLine(MyMethod(148, 0, 211));
            Console.WriteLine(MyMethod(148, -20, 211));
            Console.WriteLine(MyMethod(144, 195, 212));
            Console.WriteLine(MyMethod(7, 219, 49));*/
        }

        public static string MyMethod(int r, int g, int b)
        {
            return $"{(r > 255 ? 255 : r < 0 ? 0 : r):X2}" +
             $"{(g > 255 ? 255 : g < 0 ? 0 : g):X2}" +
             $"{(b > 255 ? 255 : b < 0 ? 0 : b):X2}";
        }

        public static string Rgb(int r, int g, int b)
        {
            if (new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 }.Contains(r))
                return $"0{toHexNew(r)}" + toHexNew(g) + toHexNew(b);

            if (new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 }.Contains(g))
                return toHexNew(r) + $"0{toHexNew(g)}" + toHexNew(b);

            if (new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 }.Contains(b))
                return toHexNew(r) + toHexNew(g) + $"0{toHexNew(b)}";

            return toHexNew(r) + toHexNew(g) + toHexNew(b);
        }

        public static string toHexNew(int n)
        {
            if (inRange(n) == 0)
            {
                return "00";
            }
            return string.Format("{0:x}", inRange(n)).ToUpper();
        }

        public static int inRange(int n)
        {
            if (n > 255)
            {
                return 255;
            }
            else if (n < 0)
            {
                return 0;
            }
            return n;
        }

    }
}