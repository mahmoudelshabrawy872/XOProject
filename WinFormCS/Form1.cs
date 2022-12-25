using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFormCS
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        Char[,] Board = { { ' ', ' ', ' ' }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' } };
        char player = 'X';
        Condetion condetion1 =new Condetion();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            simpleButton1.Text=player.ToString();
            Board[0,0] = player;
            //if (player == 'X')
            //{
            //    player = 'O';
            //}
            //else
            //{
            //    player = 'X';
            //}
            int result1 = condetion1.minimax(Board, 100, false);
            simpleButton1.Text = Board[0, 0].ToString();
            simpleButton2.Text = Board[0, 1].ToString();
            simpleButton3.Text = Board[0, 2].ToString();
            simpleButton4.Text = Board[1, 2].ToString();
            simpleButton5.Text = Board[1, 1].ToString();
            simpleButton6.Text = Board[1, 0].ToString();
            simpleButton7.Text = Board[2, 2].ToString();
            simpleButton8.Text = Board[2, 1].ToString();
            simpleButton9.Text = Board[2, 0].ToString();
            int result = condetion1.checkWinner(Board);
            if (result == 0)
            {
                MessageBox.Show("tie");
            }
            if (result == 2)
            {
                MessageBox.Show("player x win");
            }
            if (result == -2)
            {
                MessageBox.Show("player o win");
            }

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            simpleButton2.Text = player.ToString();
            Board[0, 1] = player;
            int result1 = condetion1.minimax(Board, 100, false);
            simpleButton2.Text = Board[0, 1].ToString();
            //if (player == 'X')
            //{
            //    player = 'O';
            //}
            //else
            //{
            //    player = 'X';
            //}
            simpleButton1.Text = Board[0, 0].ToString();
            simpleButton2.Text = Board[0, 1].ToString();
            simpleButton3.Text = Board[0, 2].ToString();
            simpleButton4.Text = Board[1, 2].ToString();
            simpleButton5.Text = Board[1, 1].ToString();
            simpleButton6.Text = Board[1, 0].ToString();
            simpleButton7.Text = Board[2, 2].ToString();
            simpleButton8.Text = Board[2, 1].ToString();
            simpleButton9.Text = Board[2, 0].ToString();
            int result = condetion1.checkWinner(Board);
            if (result == 0)
            {
                MessageBox.Show("tie");
            }
            if (result == 2)
            {
                MessageBox.Show("player x win");
            }
            if (result == -2)
            {
                MessageBox.Show("player o win");
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            simpleButton3.Text = player.ToString();
            Board[0, 2] = player;
            int result1 = condetion1.minimax(Board, 100, false);
            int result = condetion1.checkWinner(Board);
            //if (player == 'X')
            //{
            //    player = 'O';
            //}
            //else
            //{
            //    player = 'X';
            //}
            simpleButton3.Text = Board[0, 2].ToString();
            simpleButton1.Text = Board[0, 0].ToString();
            simpleButton2.Text = Board[0, 1].ToString();
            simpleButton3.Text = Board[0, 2].ToString();
            simpleButton4.Text = Board[1, 2].ToString();
            simpleButton5.Text = Board[1, 1].ToString();
            simpleButton6.Text = Board[1, 0].ToString();
            simpleButton7.Text = Board[2, 2].ToString();
            simpleButton8.Text = Board[2, 1].ToString();
            simpleButton9.Text = Board[2, 0].ToString();
            if (result == 0)
            {
                MessageBox.Show("tie");
            }
            if (result == 2)
            {
                MessageBox.Show("player x win");
            }
            if (result == -2)
            {
                MessageBox.Show("player o win");
            }
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            simpleButton6.Text = player.ToString();
            Board[1, 0] = player;
            int result1 = condetion1.minimax(Board, 100, false);
            int result = condetion1.checkWinner(Board);
            //if (player == 'X')
            //{
            //    player = 'O';
            //}
            //else
            //{
            //    player = 'X';
            //}
            simpleButton6.Text = Board[1, 0].ToString();
            simpleButton1.Text = Board[0, 0].ToString();
            simpleButton2.Text = Board[0, 1].ToString();
            simpleButton3.Text = Board[0, 2].ToString();
            simpleButton4.Text = Board[1, 2].ToString();
            simpleButton5.Text = Board[1, 1].ToString();
            simpleButton6.Text = Board[1, 0].ToString();
            simpleButton7.Text = Board[2, 2].ToString();
            simpleButton8.Text = Board[2, 1].ToString();
            simpleButton9.Text = Board[2, 0].ToString();
            if (result == 0)
            {
                MessageBox.Show("tie");
            }
            if (result == 2)
            {
                MessageBox.Show("player x win");
            }
            if (result == -2)
            {
                MessageBox.Show("player o win");
            }
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            simpleButton5.Text = player.ToString();
            Board[1, 1] = player;
            int result1 = condetion1.minimax(Board, 100, false);
            int result = condetion1.checkWinner(Board);
            //if (player == 'X')
            //{
            //    player = 'O';
            //}
            //else
            //{
            //    player = 'X';
            //}
            simpleButton5.Text = Board[1, 1].ToString();
            simpleButton1.Text = Board[0, 0].ToString();
            simpleButton2.Text = Board[0, 1].ToString();
            simpleButton3.Text = Board[0, 2].ToString();
            simpleButton4.Text = Board[1, 2].ToString();
            simpleButton5.Text = Board[1, 1].ToString();
            simpleButton6.Text = Board[1, 0].ToString();
            simpleButton7.Text = Board[2, 2].ToString();
            simpleButton8.Text = Board[2, 1].ToString();
            simpleButton9.Text = Board[2, 0].ToString();
            if (result == 0)
            {
                MessageBox.Show("tie");
            }
            if (result == 2)
            {
                MessageBox.Show("player x win");
            }
            if (result == -2)
            {
                MessageBox.Show("player o win");
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            simpleButton4.Text = player.ToString();
            Board[1, 2] = player;
            int result1 = condetion1.minimax(Board, 100, false);
            int result = condetion1.checkWinner(Board);
            //if (player == 'X')
            //{
            //    player = 'O';
            //}
            //else
            //{
            //    player = 'X';
            //}
            simpleButton4.Text = Board[1, 2].ToString();
            simpleButton1.Text = Board[0, 0].ToString();
            simpleButton2.Text = Board[0, 1].ToString();
            simpleButton3.Text = Board[0, 2].ToString();
            simpleButton4.Text = Board[1, 2].ToString();
            simpleButton5.Text = Board[1, 1].ToString();
            simpleButton6.Text = Board[1, 0].ToString();
            simpleButton7.Text = Board[2, 2].ToString();
            simpleButton8.Text = Board[2, 1].ToString();
            simpleButton9.Text = Board[2, 0].ToString();
            if (result == 0)
            {
                MessageBox.Show("tie");
            }
            if (result == 2)
            {
                MessageBox.Show("player x win");
            }
            if (result == -2)
            {
                MessageBox.Show("player o win");
            }
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            simpleButton9.Text = player.ToString();
            Board[2, 0] = player;
            int result1 = condetion1.minimax(Board, 100, false);
            int result = condetion1.checkWinner(Board);
            //if (player == 'X')
            //{
            //    player = 'O';
            //}
            //else
            //{
            //    player = 'X';
            //}
            simpleButton9.Text = Board[2, 0].ToString();
            simpleButton1.Text = Board[0, 0].ToString();
            simpleButton2.Text = Board[0, 1].ToString();
            simpleButton3.Text = Board[0, 2].ToString();
            simpleButton4.Text = Board[1, 2].ToString();
            simpleButton5.Text = Board[1, 1].ToString();
            simpleButton6.Text = Board[1, 0].ToString();
            simpleButton7.Text = Board[2, 2].ToString();
            simpleButton8.Text = Board[2, 1].ToString();
            simpleButton9.Text = Board[2, 0].ToString();
            if (result == 0)
            {
                MessageBox.Show("tie");
            }
            if (result == 2)
            {
                MessageBox.Show("player x win");
            }
            if (result == -2)
            {
                MessageBox.Show("player o win");
            }

        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            simpleButton8.Text = player.ToString();
            Board[2, 1] = player;
            int result1 = condetion1.minimax(Board, 100, false);
            int result = condetion1.checkWinner(Board);
            //if (player == 'X')
            //{
            //    player = 'O';
            //}
            //else
            //{
            //    player = 'X';
            //}
            simpleButton8.Text = Board[2, 1].ToString();
            simpleButton1.Text = Board[0, 0].ToString();
            simpleButton2.Text = Board[0, 1].ToString();
            simpleButton3.Text = Board[0, 2].ToString();
            simpleButton4.Text = Board[1, 2].ToString();
            simpleButton5.Text = Board[1, 1].ToString();
            simpleButton6.Text = Board[1, 0].ToString();
            simpleButton7.Text = Board[2, 2].ToString();
            simpleButton8.Text = Board[2, 1].ToString();
            simpleButton9.Text = Board[2, 0].ToString();
          
            if (result == 0)
            {
                MessageBox.Show("tie");
            }
            if (result == 2)
            {
                MessageBox.Show("player x win");
            }
            if (result == -2)
            {
                MessageBox.Show("player o win");
            }


        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            simpleButton7.Text = player.ToString();
            Board[2, 2] = player;
            int result1 = condetion1.minimax(Board, 100, false);
            //if (player == 'X')
            //{
            //    player = 'O';
            //}
            //else
            //{
            //    player = 'X';
            //}
            int result = condetion1.checkWinner(Board);
            simpleButton7.Text = Board[2, 2].ToString();
            simpleButton1.Text = Board[0, 0].ToString();
            simpleButton2.Text = Board[0, 1].ToString();
            simpleButton3.Text = Board[0, 2].ToString();
            simpleButton4.Text = Board[1, 2].ToString();
            simpleButton5.Text = Board[1, 1].ToString();
            simpleButton6.Text = Board[1, 0].ToString();
            simpleButton7.Text = Board[2, 2].ToString();
            simpleButton8.Text = Board[2, 1].ToString();
            simpleButton9.Text = Board[2, 0].ToString();
            
            if (result == 0)
            {
                MessageBox.Show("tie");
            }
            if (result == 2)
            {
                MessageBox.Show("player x win");
            }
            if (result == -2)
            {
                MessageBox.Show("player o win");
            }


        }
    }
}
