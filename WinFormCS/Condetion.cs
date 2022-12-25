using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormCS
{
    public class Condetion
    {
       public   int checkWinner(char[,] Board)
        {
            //  2: X winner
            // -2: O winner
            //  0: Tie
            //  1: No winner

            // For rows
            for (int i = 0; i < 3; i++)
            {
                if (Board[i,0] == Board[i,1] && Board[i,1] == Board[i,2] && Board[i,0] != ' ')
                {
                   
                    if (Board[i,0] == 'X')
                    {
                        return 2;
                    }
                    else
                    {
                        return -2;
                    }
                }
            }

            // For colums
            for (int i = 0; i < 3; i++)
            {
                if (Board[0,i] == Board[1,i] && Board[1,i] == Board[2,i] && Board[0,i] != ' ')
                {
                    
                    if (Board[0,i] == 'X')
                    {
                        return 2;
                    }
                    else
                    {
                        return -2;
                    }
                }
            }

            // Diagonal 1
            if (Board[0,0] == Board[1,1] && Board[1,1] == Board[2,2] && Board[0,0] != ' ')
            {
                if (Board[0,0] == 'X')
                {
                    return 2;
                }
                else
                {
                    return -2;
                }
            }

            // Diagonal 2
            if (Board[2,0] == Board[1,1] && Board[1,1] == Board[0,2] && Board[2,0] != ' ')
            {
                if (Board[2,0] == 'X')
                {
                    return 2;
                }
                else
                {
                    return -2;
                }
            }

            // For Tie Case
            bool tie = true;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (Board[i,j] == ' ')
                    {
                        tie = false;
                    }
                }
            }
            if (tie) return 0;

            // Else
            return 1;
        }

       public int minimax(char[,] Board, int depth, bool isMaximizing, bool firstTime = true)
        {
          
            int result = checkWinner(Board);
            if (depth == 0 || result != 1)
            {
                return result;
            }

            if (isMaximizing)
            {
                int finalScore = -10;
                int finalI=0, finalJ=0;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (Board[i,j] == ' ')
                        {
                            Board[i,j] = 'X';
                            int score = minimax(Board, depth - 1, false, false);
                            Board[i,j] = ' ';
                            if (score > finalScore)
                            {
                                finalScore = score;
                                finalI = i;
                                finalJ = j;
                            }
                            
                        }
                    }
                }
                if (firstTime)
                {
                    Board[finalJ,finalI] = 'O';
                 //   button.Text = 'O'.ToString();
                    switch (9)
                    {
                        default:
                            break;
                    }
                }
                return finalScore;
            }
            else
            {
                int finalScore = 10;
                int finalI=0, finalJ=0;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (Board[i,j] == ' ')
                        {
                            Board[i,j] = 'O';
                               
                            int score = minimax(Board, depth - 1, true, false);
                            Board[i,j] = ' ';
                            if (score < finalScore)
                            {
                                finalScore = score;
                                finalI = i;
                                finalJ = j;
                            }
                            
                        }
                    }
                }
                if (firstTime)
                {
                    Board[finalI,finalJ] = 'O';
                   // button.Text='O'.ToString();
                }
                return finalScore;
            }
        }

    }
}
