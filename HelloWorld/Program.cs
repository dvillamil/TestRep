﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(createMessage());
            Console.WriteLine("Hello Diana Maria");            
        }
        public static string createMessage()
        {
            return "Hello World Diana";
        }
    }
}
