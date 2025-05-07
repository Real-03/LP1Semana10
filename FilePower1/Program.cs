using System;
using System.Collections.Generic;
using System.IO;
namespace FilePower1
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string text = "";
            Queue<string> allText = new Queue<string>();
            do
            {
                text = Console.ReadLine();
                allText.Enqueue(text);
            }while(text != "");
            File.WriteAllLines(args[0], allText);

        }
    }
}
