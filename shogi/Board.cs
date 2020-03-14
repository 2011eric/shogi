using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using static shogi.ChessPieces.ChessPiecesName;
namespace shogi
{
    class Board
    {
        private static ChessPiece[,] board = new ChessPiece[10, 10];
        public static bool CheckBorder(Point current)
        {
            //Check if chesspiece out of border
            return (current.X > 0 && current.X < 10) ? ((current.Y > 0 && current.Y < 10) ?true:false): false;
        }
        public static ChessPiece getChessPiece(Point point)
        {
            //Get the chess piece by its position on the board
            return board[point.X, point.Y];
        }
        public static void setChessPiece(Point point,ChessPiece target)
        {
            board[point.X, point.Y] = target;
        }
        public static List<Point> getPossibleMove(Point point)
        {
            //Input the coordinate of the board
            //This is the list which will be returned
            List<Point> possibleMove = new List<Point>();
            //Get the chess piece by its position on the board
            ChessPiece m_ChessPiece = getChessPiece(point);

            //TODO add the possible move below
            
            return possibleMove;
        }
        public static bool checkMate(Point point,ChessPiece target,string player)
        {
            //Input:The chessPiece and point to move at next step
            //TODO: Check if checkmate
            return false;
        }
        public static int moveLegal(Point point,string player)
        {
            ChessPiece target = getChessPiece(point);
            if (target != null )//Check if current player lose the game because of this move.
            {
                if (target.player == player)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
            else if (Board.checkMate(point, getChessPiece(point), player))
            {
                return -1;
            }
            return 1;
        }
    }
}
