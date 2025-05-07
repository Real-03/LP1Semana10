using System;
using System.Collections.Generic;
using System.IO;
namespace FilePower2
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string text = "";
            using StreamWriter sw = new StreamWriter (args[0])  ;
            do
            {
                
                text = Console.ReadLine();
                if(text!="")
                    sw.WriteLine(text);

            }while(text != "");


        }
    }
}
