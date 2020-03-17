using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shogi.ChessPieces
{
    public class Keima : ChessPiece
    {
        public Keima(Point init, Player player) : base(init, player, ChessPieceType.Keima, ChessPieceType.Narikei)
        {

        }
        public override void RefreshPosibleMove(Point point)
        {
            List<Point> result = new List<Point>();
            List<Point> buffer = new List<Point>();
            if (upgraded)
            {
                buffer.Add(new Point(board_point.X + 1, board_point.Y));
                buffer.Add(new Point(board_point.X - 1, board_point.Y));
                buffer.Add(new Point(board_point.X, board_point.Y + 1));
                buffer.Add(new Point(board_point.X, board_point.Y - 1));


                if (player.playerEnum == PlayerEnum.First)
                {
                    buffer.Add(new Point(board_point.X - 1, board_point.Y - 1));
                    buffer.Add(new Point(board_point.X + 1, board_point.Y - 1));
                }
                else
                {
                    buffer.Add(new Point(board_point.X - 1, board_point.Y + 1));
                    buffer.Add(new Point(board_point.X + 1, board_point.Y + 1));
                }
            }
            else
            {
                if (player.playerEnum == PlayerEnum.First)
                {
                    buffer.Add(new Point(board_point.X - 1, board_point.Y - 2));
                    buffer.Add(new Point(board_point.X + 1, board_point.Y - 2));
                }
                else
                {
                    buffer.Add(new Point(board_point.X - 1, board_point.Y + 2));
                    buffer.Add(new Point(board_point.X + 1, board_point.Y + 2));
                }
            }

            foreach (Point p in buffer)
                if(Board.CheckBorder(p))
                    if (Board.moveLegal(p, player) != BoardState.MyCP && Board.moveLegal(p, player) != BoardState.EnemyCheckMate)
                        result.Add(p);

            possibleMove = result;
            
        }
    }
}
