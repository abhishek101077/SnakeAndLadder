using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_and_Ladder
{
    internal class DiceUC2
    {
        public static void solution()
        {
            Random random = new Random();
            int diceOutput = random.Next(7);
            int position = 0;
            Console.WriteLine("The outcome of number :" +diceOutput);
            Console.ReadLine();
        }


        }
    }
