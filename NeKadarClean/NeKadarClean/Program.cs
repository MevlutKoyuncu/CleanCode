﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace NeKadarClean
{
    internal class Program
    {
        static void Main(string[] args)
        {

            BeyazEsya[] esyalar = new BeyazEsya[3];
            esyalar[0] = new BeyazEsya("Regal", "A200", 5000);
            esyalar[1] = new BeyazEsya("Ariston", "X1200", 7000);
            esyalar[2] = new CamasirMakinesi("Arçelik", "AR5", 3000, "7 LT", true);
            

            for (int i = 0; i < esyalar.Length; i++)
            {
                Console.WriteLine(esyalar[i]);
            }

        }
    }
}
