﻿using System;

namespace App4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool condition = true;
            int cont = 0;

            Console.WriteLine("Ingrese el numero de repeticones que desea");
            int limite = int.Parse(Console.ReadLine());

            while (condition)
            {
                if (cont == limite)
                    condition = false;

                Console.WriteLine(cont);
                cont++;
            }
        }
    }
}
