﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineApp
{
    class Program
    {
        static void Main(string[] args)
        {

            GeneratorVet generator = new GeneratorVet();

            // Zde dokonči úlohu svým kódem...
            for(int i=0;i<10;i++)
                Console.WriteLine(generator.VygenerujVetu());
            Console.ReadKey();
        }
    }
}
