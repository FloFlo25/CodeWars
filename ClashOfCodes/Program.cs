using System;
using System.Linq;

namespace ClashOfCodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string sep = "->";
            for (int i = 0; i < N; i++)
            {
                string shift = Console.ReadLine();
                string[] hours = shift.Split(sep);
                if (24 - int.Parse(hours[1]) > int.Parse(hours[1]) - int.Parse(hours[0]))
                {
                    Console.Write(hours[0] + sep + hours[1]);
                }
                else
                {
                    Console.Write(hours[1] + sep + "24");
                }
                if (i < N)
                {
                    Console.Write(" ");

                }
            }
        }
        public static void pr6()
        {
            string[] inputs = Console.ReadLine().Split(' ');
            string hair = inputs[0];
            string cheek = inputs[1];
            string eye = inputs[2];
            string nose = inputs[3];
            string mouth = inputs[4];
            string chin = inputs[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write(hair);
            }
            Console.WriteLine($"\n{cheek}{eye} {eye}{cheek}");
            Console.WriteLine($"{cheek} {nose} {cheek}");
            Console.WriteLine($"{cheek} {mouth} {cheek}");

            if (chin.Length == 1)
            {
                Console.WriteLine($"  {chin}");
            }
            else if (chin.Length == 3)
            {
                Console.WriteLine($" {chin}");
            }
            else if (chin.Length == 5)
            {
                Console.WriteLine($"{chin}");
            }
        }
        public static void pr5()
        {
            int N = int.Parse(Console.ReadLine());

            // Write an answer using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");

            Console.WriteLine(N % 10);
        }
        public static void pr4()
        {
            string message = Console.ReadLine();

            char[] litere = message.ToCharArray();

            if (Char.IsUpper(litere[0]))
            {
                Console.WriteLine("PascalCase");
            }
            else if (litere.Any(c => c == '_'))
            {
                Console.WriteLine("snake_case");
            }
            else
            {
                Console.WriteLine("camelCase");
            }
        }
        public static void pr3()
        {
            string s = Console.ReadLine();

            char[] splited = s.ToCharArray();
            int sum = 0;


            for (int i = 0; i < splited.Length; i++)
            {
                /*    numere[i] = int.Parse(splited[i]);*/
                if (splited[i] == '6' || splited[i] == '0' || splited[i] == '9')
                {
                    sum += 1;
                }
                else if (splited[i] == '8')
                {
                    sum += 2;
                }
            }




            Console.WriteLine(sum);
        }
        public static void pr2()
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int x = int.Parse(inputs[0]);
            int h = int.Parse(inputs[1]);

            Console.WriteLine();
        }
        public static void pr1()
        {
            string t = Console.ReadLine();
            string t2 = Console.ReadLine();

            if (t2.CompareTo(t) < 0)
            {
                Console.WriteLine("EARLY");
            }
            else if (t2.CompareTo(t) > 0)
            {
                Console.WriteLine("DELAYED");
            }
            else
            {
                Console.WriteLine("ON TIME");
            }
        }
    }

}
