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

        public static List<Point> getPossibleMove(Point point)
        {
            List<Point> possibleMove;
            String chessPieceType = board[point.X, point.Y].getCurrentType();
            switch (chessPieceType)
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
            return null;
        }
    }
}
