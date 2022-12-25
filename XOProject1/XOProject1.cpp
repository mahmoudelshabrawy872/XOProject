//#include<iostream>
//using namespace std;
//
//bool haveTheSameValueAndNotEmpty(char x, char y, char z) {
//    if (x == y && x == z && x != ' ') {
//        return true;
//    }
//    return false;
//}
//
//int checkWinner(char board[3][3]) {
//    //  2: X winner
//    // -2: O winner
//    //  0: Tie
//    //  1: No winner
//
//    // For rows
//    for (int i = 0; i < 3; i++) {
//        if (haveTheSameValueAndNotEmpty(board[i][0], board[i][1], board[i][2])) {
//            return board[i][0] == 'X' ? 2 : -2;
//        }
//    }
//
//    // For cols
//    for (int i = 0; i < 3; i++) {
//        if (haveTheSameValueAndNotEmpty(board[0][i], board[1][i], board[2][i])) {
//            return board[0][i] == 'X' ? 2 : -2;
//        }
//    }
//
//    // Diagonal 1
//    if (haveTheSameValueAndNotEmpty(board[0][0], board[1][1], board[2][2])) {
//        return board[0][0] == 'X' ? 2 : -2;
//    }
//
//    // Diagonal 2
//    if (haveTheSameValueAndNotEmpty(board[2][0], board[1][1], board[0][2])) {
//        return board[2][0] == 'X' ? 2 : -2;
//    }
//
//    // For Tie Case
//    bool tie = true;
//    for (int i = 0; i < 3; i++) {
//        for (int j = 0; j < 3; j++) {
//            if (board[i][j] == ' ') {
//                tie = false;
//            }
//        }
//    }
//    if (tie) return 0;
//
//    // Else
//    return 1;
//}
//
//void drowBoard(char board[3][3]) {
//    for (int i = 0; i < 3; i++) {
//        for (int j = 0; j < 3; j++) {
//            cout << "| " << board[i][j] << " |";
//        }
//        cout << "\n -------------- \n";
//    }
//}
//
//int main() {
//    char board[3][3] = { {' ', ' ', ' '}, {' ', ' ', ' '}, {' ', ' ', ' '} };
//    int x, y;
//    int inPut;
//    bool has_winner = false;
//    char player = 'X';
//    while (!has_winner) {
//        /*cin >> x >> y;*/
//      switch (inPut)
//            {
//            case 1:
//                board[0][0] = player;
//                break;
//            case 2:
//                board[0][1] = player;
//                break;
//            case 3:
//                board[0][2] = player;
//                break;
//            case 4:
//                board[1][0] = player;
//                break;
//            case 5:
//                board[1][1] = player;
//                break;
//            case 6:
//                board[1][2] = player;
//                break;
//            case 7:
//                board[2][0] = player;
//                break;
//            case 8:
//                board[2][1] = player;
//                break;
//            case 9:
//                board[2][2] = player;
//                break;
//
//            default:
//                cout << "enter number in rang(1:9)\n";
//                break;
//            }
//
//        if (board[x][y] == ' ') {
//            /*board[x][y] = player;*/
//          
//
//            player == 'X' ? player = 'O' : player = 'X';
//            drowBoard(board);
//            has_winner = checkWinner(board) != 1;
//        }
//        else {
//            cout << "The field is not empty \n";
//        }
//    }
//    int result = checkWinner(board);
//    if (result == 0) {
//        cout << "Tie \n";
//    }
//    else {
//        cout << ((result == 2) ? "X" : "O") << " player wins \n";
//    }
//    return 0;
//}




























#include <iostream>
using namespace std;

void printBoard(char Board[3][3] ) {
        //PRINT THE BOARD
        for (int l = 0; l < 3; l++)
        {
            
            for (int w = 0; w < 3; w++)
            {
                cout <<" " << Board[l][w] << " | ";
            }
            cout << "\n--------------\n";
        }
       

}


int main()
{
    
        
        char Board[3][3] = { {' ',' ',' '} ,
                             {' ',' ',' '} ,
                             {' ',' ',' '} };
        int inPut;
        bool win = false;
        char player = 'X';
        int  winreturn=0;
        bool tie = true;
        while (win==false)
        {
            cout << "player " << player << " Choose ";
            cin >> inPut;
            switch (inPut)
    {
        case 1:
        Board[0][0] = player;
        break;
        case 2:
        Board[0][1] = player;
        break;       
        case 3:      
        Board[0][2] = player;
        break;        
        case 4:       
        Board[1][0] = player;
        break;        
        case 5:       
        Board[1][1] = player;
        break;       
        case 6:      
        Board[1][2] = player;
        break;       
        case 7:      
        Board[2][0] = player;
        break;        
        case 8:       
        Board[2][1] = player;
        break;
        case 9:
        Board[2][2] = player;
        break;

             default:
                cout << "enter number in rang(1:9)\n";
        break;
    }

            if (player=='X')
            {
                player = 'O';
            }
            else
            {
                player = 'X';
            }


         

            //row
            for (int i = 0; i < 3; i++)
            {
                if (Board[i][0] == Board[i][1] && Board[i][1] == Board[i][2] && Board[i][0] != ' ')
                {
                    if (player == 'X')
                    {
                        player = 'O';
                    }
                    else
                    {
                        player = 'X';
                    }
                   
                    win = true;
                    if (player == 'X')
                        winreturn = 2;
                    if (player == 'O')
                        winreturn = -2;
                    
                }
            }

            //colum
            for (int i = 0; i < 3; i++)
            {
                if (Board[0][i] == Board[1][i] && Board[1][i] == Board[2][i] && Board[0][i] != ' ')
                {
                    if (player == 'X')
                    {
                        player = 'O';
                    }
                    else
                    {
                        player = 'X';
                    }

                    win = true;
                    if (player == 'X')
                        winreturn = 2;
                    if (player == 'O')
                        winreturn = -2;
                }
            }

            if (Board[0][0]==Board[1][1]&& Board[1][1]==Board[2][2]&&Board[0][0]!=' ')
            {
                if (player == 'X')
                {
                    player = 'O';
                }
                else
                {
                    player = 'X';
                }

                win = true;
                if (player == 'X')
                    winreturn = 2;
                if (player == 'O')
                    winreturn = -2;
            }

            if (Board[0][2]==Board[1][1]&& Board[1][1]==Board[2][0] && Board[0][2] != ' ')
            {
                if (player == 'X')
                {
                    player = 'O';
                }
                else
                {
                    player = 'X';
                }

                win = true;
                if (player == 'X')
                    winreturn = 2;
                if (player == 'O')
                    winreturn = -2;
            }
           


            printBoard(Board);
        
}

        cout << "player  " << player << "  win\n";
        cout << winreturn;
    
    
}