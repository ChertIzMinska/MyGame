﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            while(!player.winner())
            {
                player.action();
            }
            Console.WriteLine("Ebal v rot ");
        }
    }
    
}
