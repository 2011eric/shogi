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
        public static ChessPiece[,] board = new ChessPiece[9, 9];
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
        public static List<Point> getPossibleMove(Point point)
        {
            //Input the coordinate of the board
            //This is the list which will be returned
            List<Point> possibleMove = new List<Point>();
            //Get the chess piece by its position on the board
            ChessPiece m_ChessPiece = getChessPiece(point);

            //TODO add the possible move below
            switch (m_ChessPiece.getCurrentType())
            {
                case GYUKUSHO:
                    break;
                case HISHA:
                    break;
                case RYUOU:
                    break;
                case KAKUGYO:
                    break;
                case RYUUMA:
                    break;
                case KINSHO:
                    break;
                case GINSHO:
                    break;
                case KEIMA:
                    break;
                case KYOSHA:
                    break;
                case HUHYO:
                    break;
            }
            return possibleMove;
        }
    }
}
