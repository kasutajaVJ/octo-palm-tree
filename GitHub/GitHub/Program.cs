﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHub
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            Console.WriteLine("Hello from the other side");
            Console.WriteLine("Hello from visual studio");
            Tervitaja.Tervita("Siim");
            Tervitaja.Tervita(new String[] { "Kalle", "Malle", "Salle", "Valle"});
            Console.ReadKey();

            
        }
    }
}
