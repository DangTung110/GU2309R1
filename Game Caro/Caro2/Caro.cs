using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Caro2
{
    class Caro
    {
        public Caro() { }
        public void Play()
        {
            int choice = 0, count = 0, temp = 2;
            char c = ' ';
            int mode;

            Console.WriteLine("Ban muon chon che do nao: ");
            Console.WriteLine("1.Nguoi VS Nguoi.");
            Console.WriteLine("2.Nguoi VS Robot.");
            Console.WriteLine("3.Robot VS Robot.");
            while (!int.TryParse(Console.ReadLine(), out mode) || mode > 3 || mode < 0)
            {
                if (temp > 0)
                {
                    Console.WriteLine("Error. Vui long chon lai che do.");
                    temp--;
                }
                else
                {
                    Console.WriteLine("Ban da het luot chon.");
                }
            }
            Console.Clear();

            CheckWin checkWin = new CheckWin();
            Board board = new Board();

            if (mode == 1)
            {
                do
                {
                    board.PrintBoard();
                    if (count % 2 == 0)
                        c = 'X';
                    else
                        c = 'O';
                    Console.WriteLine("Player {0}: ", c);
                    while (!int.TryParse(Console.ReadLine(), out choice) || choice > 9 || choice < 1)
                    {
                        if (temp > 0)
                        {
                            Console.WriteLine("Error. Player {0}: ", c);
                            temp--;
                        }
                        else
                        {
                            Console.WriteLine("Player {0} lose.", c);
                            return;
                        }
                    }
                    board.ClearBoard();
                    count++;
                } while (board.Choice(c, choice) && !checkWin.Win(board) && count < 9);
            }
            else if (mode == 2)
            {
                Robot robot = new Robot();
                List<int> lst = new List<int>();
                do
                {
                    board.PrintBoard();
                    if (count % 2 == 0)
                    {
                        c = 'X';
                        Console.WriteLine("Player {0}: ", c);
                        choice = robot.Person_Robot();                        
                        while (lst.Contains(choice))
                        {
                            choice = robot.Person_Robot();
                        }
                    }
                    else
                    {
                        c = 'O';
                        Console.WriteLine("Player {0}: ", c);
                        while (!int.TryParse(Console.ReadLine(), out choice) || choice > 9 || choice < 1)
                        {
                            if (temp > 0)
                            {
                                Console.WriteLine("Error. Player {0}: ", c);
                                temp--;
                            }
                            else
                            {
                                Console.WriteLine("Player {0} lose.", c);
                                return;
                            }
                        }
                    }
                    
                    board.ClearBoard();
                    lst.Add(choice);
                    count++;
                } while (board.Choice(c, choice) && !checkWin.Win(board) && count < 9);
            }
            else
            {
                Robot robot = new Robot();
                List<int> lst = new List<int>();
                do
                {
                    board.PrintBoard();                    
                    if (count % 2 == 0)
                    {
                        c = 'X';
                        Console.WriteLine("Player {0}: ", c);
                    }
                    else
                    {
                        c = 'O';
                        Console.WriteLine("Player {0}: ", c);
                    }

                    choice = robot.Person_Robot();
                    while (lst.Contains(choice))
                    {
                        choice = robot.Person_Robot();
                    }
                    board.ClearBoard();
                    lst.Add(choice);
                    count++;
                } while (board.Choice(c, choice) && !checkWin.Win(board) && count < 9);
            }

            board.PrintBoard();
            if (checkWin.Win(board))
                Console.WriteLine("Player {0} Won!!!!", c);
            else
                Console.WriteLine("Hoa");
        }
    }
}
