﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Обяснете предимствата от използването на изключения.

namespace ConsoleAppGlava12Exercises6
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (StreamReader sr = new StreamReader("TestFile.txt"))
                {
                    String line = sr.ReadToEnd();
                    Console.WriteLine(line);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
    }
}