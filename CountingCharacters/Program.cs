using System;
using System.Collections.Generic;
using System.IO;

namespace CountingCharacters
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("../../passageToIndia.txt");
            string data = sr.ReadToEnd();
            Dictionary<char, int> letters = new Dictionary<char, int>();

            foreach (char a in data) // Count the letters
            {
                if (letters.ContainsKey(a))
                {
                    letters[a]++;
                }
                else
                {
                    letters.Add(a, 1);
                }
            }
            foreach (KeyValuePair<char, int> letter in letters)// print the letters to the console.
            {
                Console.WriteLine(letter.Key + " ; " + letter.Value);
            }

            Console.ReadLine();
        }
    }
}