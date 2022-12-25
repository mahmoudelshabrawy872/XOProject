using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS
{
    public class PrintBoard
    {
        public static void drowBoard(Char[,] Board)
    {
            for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                      Console.Write($"| {Board[i, j]} |");
                    }
                    Console.WriteLine("\n---------------\n");
                }
    }
    }
   
}
