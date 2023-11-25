using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caro2
{
    class Board
    {
        public int BOARD_SIZE = 3;
        public Cell[,] board;

        public Board() 
        {
            board = new Cell[BOARD_SIZE, BOARD_SIZE];
            for (int i = 0; i < BOARD_SIZE; i++)
            {
                for(int j = 0; j < BOARD_SIZE; j++)
                {
                    board[i, j] = new Cell();
                }
            }
        }
        public void PrintBoard()
        {
            int count = 1;
            for (int i = 0; i < BOARD_SIZE; i++)
            {
                Console.Write('-');
                for (int j = 0; j < BOARD_SIZE; j++)
                {
                    if (board[i, j].IsEmpty()) 
                        Console.Write(count);
                    else
                    {
                        char c = (char)board[i, j].fieldStatus;
                        if (c == 'X')   Console.ForegroundColor = ConsoleColor.Red;
                        else Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(c);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.Write('-');
                    count ++;
                }
                Console.WriteLine();
            }
        }
        public bool Choice(char choice, int choiceNumber)
        {
            int x = (choiceNumber - 1) / BOARD_SIZE;
            int y = (choiceNumber - 1) % BOARD_SIZE;
            if (board[x, y].IsEmpty())
            {
                board[x, y].PutCell(choice);
                return true;
            }
            else
            {
                int temp = 2;
                do
                {
                    if (temp  < 0)  return false;
                    PrintBoard();
                    Console.WriteLine("Error. Ban da nhap vao o co gia tri!");
                    Console.Write("Moi nhap lai gia tri: ");
                    choiceNumber = int.Parse(Console.ReadLine());
                    x = (choiceNumber - 1) / BOARD_SIZE;
                    y = (choiceNumber - 1) % BOARD_SIZE;
                    temp--;
                }while (!board[x, y].IsEmpty());

                board[x, y].PutCell(choice);
                return true;
            }
        }
        public void ClearBoard() { Console.Clear(); }
    }
}
