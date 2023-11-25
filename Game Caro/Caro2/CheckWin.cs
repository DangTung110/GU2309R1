using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caro2
{
    class CheckWin
    {
        public CheckWin() { }
        private bool WinColum(Board gameBoard)
        {
            for (int i = 0;i < gameBoard.BOARD_SIZE; i++)
            {
                if (gameBoard.board[i, 0].fieldStatus == gameBoard.board[i, 1].fieldStatus && gameBoard.board[i, 1].fieldStatus == gameBoard.board[i, 2].fieldStatus && !gameBoard.board[i, 0].IsEmpty())
                    return true;
            }
            return false;
        }
        private bool WinRow(Board gameBoard)
        {
            for (int i = 0; i < gameBoard.BOARD_SIZE; i++)
            {
                if (gameBoard.board[0, i].fieldStatus == gameBoard.board[1, i].fieldStatus && gameBoard.board[1, i].fieldStatus == gameBoard.board[2, i].fieldStatus && !gameBoard.board[0, i].IsEmpty())
                    return true;
            }
            return false;
        }
        private bool WinDiagonal(Board gameBoard)
        {
            if (gameBoard.board[0, 0].fieldStatus == gameBoard.board[1, 1].fieldStatus && gameBoard.board[1, 1].fieldStatus == gameBoard.board[2, 2].fieldStatus && !gameBoard.board[0, 0].IsEmpty())
                return true;
            
            else if (gameBoard.board[2, 0].fieldStatus == gameBoard.board[1, 1].fieldStatus && gameBoard.board[1, 1].fieldStatus == gameBoard.board[0, 2].fieldStatus && !gameBoard.board[0, 2].IsEmpty())
                return true;

            return false;
        }
        public bool Win(Board gameBoard)
        {
            return (WinColum(gameBoard) || WinRow(gameBoard) || WinDiagonal(gameBoard));
        }
    }
}
