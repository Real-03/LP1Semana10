using System;
using System.Collections.Generic;
using System.IO;
namespace CharSets
{
    public class Program
    {
        private static void Main(string[] args)
        {
            
            HashSet<char> chars = new HashSet<char>();
            foreach(string file in args)
            {
                using StreamReader sr = new StreamReader(file);
                
                while (sr.Peek() >= 0)
                {
                    chars.Add(Convert.ToChar(sr.ReadLine()));
                }
            }

            Console.WriteLine(string.Join("\n",chars));
        }
    }
}
