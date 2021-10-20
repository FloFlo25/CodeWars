using System;
using System.Text.RegularExpressions;

namespace Disemvowel_Trolls
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Disemvowel("This website is for losers LOL!")); 
        }

        /// <summary>
        /// 
        /// Trolls are attacking your comment section!
        /// A common way to deal with this situation is to remove all of the vowels from the trolls' comments, neutralizing the threat.
        /// For example, the string "This website is for losers LOL!" would become "Ths wbst s fr lsrs LL!".
        /// Note: for this kata y isn't considered a vowel.
        /// </summary>
        /// <param name="str"></param>
        public static string Disemvowel(string str)
        {
            var pattern = @"[aeiou]";
            var noVowels = Regex.Replace(str, pattern, "", RegexOptions.IgnoreCase);

            return noVowels.ToString();
        }

        public static string Disemvowel_Kata(string str)
        {
            return Regex.Replace(str, "[aeiou]", "", RegexOptions.IgnoreCase);
        }
    }
}
