//If we were to set up a Tic-Tac-Toe game, we would want to know whether the board's current state is solved, wouldn't we? Our goal is to create a function that will check that for us!

//Assume that the board comes in the form of a 3x3 array, where the value is 0 if a spot is empty, 1 if it is an "X", or 2 if it is an "O", like so:

//[[0, 0, 1],
//[0, 1, 2],
//[2, 1, 0]]
//We want our function to return:

//-1 if the board is not yet finished(there are empty spots),
//1 if "X" won,
//2 if "O" won,
//0 if it's a cat's game(i.e.a draw).
//You may assume that the board passed in is valid in the context of a game of Tic-Tac-Toe.

namespace CodeKata
{
    public class TicTacToe
    {
        public static int MySolution(int[,] board)
        {
            if (board[0, 0] == 1 && board[0, 1] == 1 && board[0, 2] == 1 ||
                board[1, 0] == 1 && board[1, 1] == 1 && board[1, 2] == 1 ||
                board[2, 0] == 1 && board[2, 1] == 1 && board[2, 2] == 1 ||
                board[0, 0] == 1 && board[1, 0] == 1 && board[2, 0] == 1 ||
                board[0, 1] == 1 && board[1, 1] == 1 && board[2, 1] == 1 ||
                board[0, 2] == 1 && board[1, 2] == 1 && board[2, 2] == 1 ||
                board[0, 0] == 1 && board[1, 1] == 1 && board[2, 2] == 1 ||
                board[0, 2] == 1 && board[1, 1] == 1 && board[2, 0] == 1)
            {
                return 1;
            }

            if (board[0, 0] == 2 && board[0, 1] == 2 && board[0, 2] == 2 ||
                board[1, 0] == 2 && board[1, 1] == 2 && board[1, 2] == 2 ||
                board[2, 0] == 2 && board[2, 1] == 2 && board[2, 2] == 2 ||
                board[0, 0] == 2 && board[1, 0] == 2 && board[2, 0] == 2 ||
                board[0, 1] == 2 && board[1, 1] == 2 && board[2, 1] == 2 ||
                board[0, 2] == 2 && board[1, 2] == 2 && board[2, 2] == 2 ||
                board[0, 0] == 2 && board[1, 1] == 2 && board[2, 2] == 2 ||
                board[0, 2] == 2 && board[1, 1] == 2 && board[2, 0] == 2)
            {
                return 2;
            }

            if (board[0, 0] == 0 || board[0, 1] == 0 || board[0, 2] == 0 ||
                board[1, 0] == 0 || board[1, 1] == 0 || board[1, 2] == 0 ||
                board[2, 0] == 0 || board[2, 1] == 0 || board[2, 2] == 0 ||
                board[0, 0] == 0 || board[1, 0] == 0 || board[2, 0] == 0 ||
                board[0, 1] == 0 || board[1, 1] == 0 || board[2, 1] == 0 ||
                board[0, 2] == 0 || board[1, 2] == 0 || board[2, 2] == 0 ||
                board[0, 0] == 0 || board[1, 1] == 0 || board[2, 2] == 0 ||
                board[0, 2] == 0 || board[1, 1] == 0 || board[2, 0] == 0)
            {
                return -1;
            }


            return 0;
        }

        public static int MySolution2(int[,] board)
        {
            int k1 = 1;
            int k2 = 1;
            bool empty = false;
            for (int i = 0; i < 3; i++)
            {
                k1 *= board[i, i];
                k2 *= board[2 - i, i];

                int row = 1;
                int col = 1;
                for (int j = 0; j < 3; j++)
                {

                    row *= board[i, j];
                    col *= board[j, i];

                }
                if (row == 1 || col == 1) return 1;
                if (row == 8 || col == 8) return 2;
                if (row == 0 || col == 0) empty = true;
            }
            if (k1 == 1 || k2 == 1) return 1;
            if (k1 == 8 || k2 == 8) return 2;
            if (empty) return -1;

            return 0;
        }
    }
}
