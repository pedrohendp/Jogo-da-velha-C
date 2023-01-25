using System;

class TicTacToe
{
    static char[] board = { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
    static int player = 1;
    static int choice;
    static int flag = 0;

    static void Main(string[] args)
    {
        do
        {
            Console.Clear();
            Console.WriteLine("Player 1: X");
            Console.WriteLine("Player 2: O");
            Console.WriteLine("\n");

            if (player % 2 == 0)
            {
                Console.WriteLine("Player 2 turn");
            }
            else
            {
                Console.WriteLine("Player 1 turn");
            }
            Console.WriteLine("\n");
            Board();
            choice = int.Parse(Console.ReadLine());

            if (board[choice - 1] != 'X' && board[choice - 1] != 'O')
            {
                if (player % 2 == 0)
                {
                    board[choice - 1] = 'O';
                    player++;
                }
                else
                {
                    board[choice - 1] = 'X';
                    player++;
                }
            }
            else
            {
                Console.WriteLine("Place already filled. Please try again.");
            }

            flag = CheckWin();
        } while (flag != 1 && flag != -1);

        Console.Clear();
        Board();
        if (flag == 1)
        {
            Console.WriteLine("Player {0} wins!", (player % 2) + 1);
        }
        else
        {
            Console.WriteLine("Draw!");
        }
    }

    static void Board()
    {
        Console.WriteLine("     |     |      ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", board[0], board[1], board[2]);
        Console.WriteLine("_____|_____|____ ");
        Console.WriteLine("     |     |      ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", board[3], board[4], board[5]);
        Console.WriteLine("_____|_____|____ ");
        Console.WriteLine("     |     |      ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", board[6], board[7], board[8]);
        Console.WriteLine("     |     |      ");
    }

    static int CheckWin()
    {
        if (board[0] == board[1] && board[1] == board[2] && board[0] != ' ')
        {
            return 1;
        }
        else if (board[3] == board[4] && board[4] == board[5] && board[3] != ' ')
        {
            return 1;
        }
        else if (board[6] == board[7] && board[7] == board[8] && board[6] != ' ')
        {
            return 1;
        }
        else if (board[0] == board[3] && board[3] == board[6] && board[0] != ' ')
        {
            return 1;
        }
        else if (board[1] == board[4] && board[4] == board[7] && board[1] != ' ')
        {
            return 1;
        }
        else if (board[2] == board[5] && board[5] == board[8] && board[2] != ' ')
        {
            return 1;
        }
        else if (board[0] == board[4] && board[4] == board[8] && board[0] != ' ')
        {
            return 1;
        }
        else if (board[2] == board[4] && board[4] == board[6] && board[2] != ' ')
        {
            return 1;
        }
        else if (board[0] != ' ' && board[1] != ' ' && board[2] != ' ' && board[3] != ' ' && board[4] != ' ' && board[5] != ' ' && board[6] != ' ' && board[7] != ' ' && board[8] != ' ')
        {
            return -1;
        }
        else
        {
            return 0;
        }
    }
}