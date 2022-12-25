using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintBoard printBoard = new PrintBoard();
            Condetion condetion1=new Condetion();
            Char[,] Board = { { ' ', ' ', ' ' }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' } };
            int inPut;
            bool has_winner = false;
            char player = 'X';
            while (!has_winner)
            {
                Console.WriteLine($"Player: {player} Choose:");
               inPut=Convert.ToInt32( Console.ReadLine());
             


                switch (inPut)
                {
                    case 1:
                        Board[0,0] = player;
                        break;
                    case 2:
                        Board[0,1] = player;
                        break;
                    case 3:
                        Board[0,2] = player;
                        break;
                    case 4:
                        Board[1,0] = player;
                        break;
                    case 5:
                        Board[1,1] = player;
                        break;
                    case 6:
                        Board[1,2] = player;
                        break;
                    case 7:
                        Board[2,0] = player;
                        break;
                    case 8:
                        Board[2,1] = player;
                        break;
                    case 9:
                        Board[2,2] = player;
                        break;

                    default:
                        //  cout << "enter number in rang(1:9)\n";
                        Console.WriteLine("enter number in rang(1:9)\n");
                        break;
                }
                //if (player == 'X')
                //{
                //    player = 'O';
                //}
                //else
                //    player = 'X';
                int result1 = condetion1.minimax(Board, 100, false);
                PrintBoard. drowBoard(Board);
                Console.WriteLine($"result{result1}");
                has_winner = condetion1.checkWinner(Board) != 1;

               
                

            }


            int result =condetion1.checkWinner(Board);
            if (result == 0)
            {
                Console.WriteLine("Tie \n");
            }
            else
            {
                Console.WriteLine(((result == 2) ? "X" : "O") + " player wins \n");
              
            }



            Console.ReadKey();




        }

        

    }
}

