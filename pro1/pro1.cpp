#include<iostream>
using namespace std;


int checkWinner(char Board[3][3]) {
    //  2: X winner
    // -2: O winner
    //  0: Tie
    //  1: No winner

    // For rows
    for (int i = 0; i < 3; i++) {
        if (Board[i][0]== Board[i][1]&& Board[i][1]== Board[i][2]&&Board[i][0]!=' ') {
           /* return Board[i][0] == 'X' ? 2 : -2;*/
            if (Board[i][0] == 'X')
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
    for (int i = 0; i < 3; i++) {
        if (Board[0][i]== Board[1][i]&& Board[1][i]== Board[2][i]&&Board[0][i]!=' ') {
          /*  return Board[0][i] == 'X' ? 2 : -2;*/
            if (Board[0][i] == 'X')
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
    if (Board[0][0]== Board[1][1]&& Board[1][1]== Board[2][2]&&Board[0][0]!=' ') {
        if (Board[0][0] == 'X')
        {
            return 2;
        }
        else
        {
            return -2;
        }
    }

    // Diagonal 2
    if (Board[2][0]== Board[1][1]&& Board[1][1]== Board[0][2]&&Board[2][0]!=' ') {
        if (Board[2][0] == 'X')
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
    for (int i = 0; i < 3; i++) {
        for (int j = 0; j < 3; j++) {
            if (Board[i][j] == ' ') {
                tie = false;
            }
        }
    }
    if (tie) return 0;

    // Else
    return 1;
}

void drowBoard(char Board[3][3]) {
    for (int i = 0; i < 3; i++) {
        for (int j = 0; j < 3; j++) {
            cout << "| " << Board[i][j] << " |";
        }
        cout << "\n -------------- \n";
    }
}


int minimax(char Board[3][3], int depth, bool isMaximizing, bool firstTime = true) {
    int result = checkWinner(Board);
    if (depth == 0 || result != 1) {
        return result;
    }

    if (isMaximizing) {
        int finalScore = -10;
        int finalI, finalJ;
        for (int i = 0; i < 3; i++) {
            for (int j = 0; j < 3; j++) {
                if (Board[i][j] == ' ') {
                    Board[i][j] = 'X';
                    int score = minimax(Board, depth - 1, false, false);
                    Board[i][j] = ' ';
                    if (score > finalScore) {
                        finalScore = score;
                        finalI = i;
                        finalJ = j;
                    }
                    if (firstTime) {
                        cout << "score," << i << "," << j << ": " << score << "\n";
                    }
                }
            }
        }
        if (firstTime) {
            Board[finalI][finalJ] = 'O';
        }
        return finalScore;
    }
    else {
        int finalScore = 10;
        int finalI, finalJ;
        for (int i = 0; i < 3; i++) {
            for (int j = 0; j < 3; j++) {
                if (Board[i][j] == ' ') {
                    Board[i][j] = 'O';
                    int score = minimax(Board, depth - 1, true, false);
                    Board[i][j] = ' ';
                    if (score < finalScore) {
                        finalScore = score;
                        finalI = i;
                        finalJ = j;
                    }
                    if (firstTime) {
                        cout << "score," << i << "," << j << ": " << score << "\n";
                    }
                }
            }
        }
        if (firstTime) {
            Board[finalI][finalJ] = 'O';
        }
        return finalScore;
    }
}


int main() {
    char Board[3][3] = { {' ', ' ', ' '},
                         {' ', ' ', ' '},
                         {' ', ' ', ' '} };
   
    int inPut;
    bool has_winner = false;
    char player = 'X';
    while (!has_winner) {
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

            //player == 'X' ? player = 'O' : player = 'X';
          
            int result =minimax(Board, 100, false);
            drowBoard(Board);
            cout <<"result "<< result  << " \n";
            has_winner = checkWinner(Board) != 1;
        
    }
    int result = checkWinner(Board);
    if (result == 0) {
        cout << "Tie \n";
    }
    else {
        cout << ((result == 2) ? "X" : "O") << " player wins \n";
    }
    return 0;
}