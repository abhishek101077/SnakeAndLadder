﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_and_Ladder
{
    internal class OptionUC3
    {
        public static void solution()
        { Random rnd = new Random();
            int diceroll = rnd.Next(3);

            switch (diceroll)
            {
                case 1:
                    Console.WriteLine("Ladder");
                    break;
                case 2:
                    Console.WriteLine("Snake");
                    break;
                case 0:
                    Console.WriteLine("No Play");
                    break;
            }
             
            }

        }
    }
