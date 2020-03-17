using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shogi.ChessPieces
{
    public class Fuhyo : ChessPiece
    {
        public Fuhyo(Point init, Player player) : base(init, player, ChessPieceType.Fuhyo, ChessPieceType.Tokin)
        {

        }
        public override void RefreshPosibleMove(Point point)
        {
            List<Point> result = new List<Point>();
            if (upgraded)
            {

            }
            else
            {
                Point front = new Point(board_point.X, board_point.Y - 1);
                if (player.playerEnum == PlayerEnum.Second)
                    front = new Point(board_point.X, board_point.Y + 1);
                if (Board.moveLegal(front, player) != BoardState.MyCP && Board.moveLegal(front, player) != BoardState.EnemyCheckMate)
                    result.Add(front);

            }
            possibleMove = result;
            
        }
    }
}
