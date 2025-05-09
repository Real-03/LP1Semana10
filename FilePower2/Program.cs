using System;
using System.Collections.Generic;
using System.IO;
namespace FilePower2
{
    public class Program
    {
        private static void Main(string[] args)
        {
            using StreamWriter sw = new StreamWriter(args[0]);
            string text;
            while (!string.IsNullOrEmpty(text = Console.ReadLine()))
            {
                sw.WriteLine(text);
            }


        }
    }
}
