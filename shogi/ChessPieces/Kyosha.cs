using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shogi.ChessPieces
{
    public class Kyosha : ChessPiece
    {
        public Kyosha(Point init, Player player) : base(init, player, ChessPieceType.Kyosha, ChessPieceType.Narikyou)
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
                    for (int i = point.Y - 1; i > 0; i--)
                    {
                        Point nextPoint = new Point(point.X, i);
                        if (Board.moveLegal(nextPoint, this.player) != BoardState.MyCP)
                        {
                            buffer.Add(nextPoint);
                            if (Board.moveLegal(nextPoint, this.player) == BoardState.EnemyCP) break;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else 
                {
                    for (int i = point.Y + 1; i < 10; i++)
                    {
                        Point nextPoint = new Point(point.X, i);
                        if (Board.moveLegal(nextPoint, this.player) != BoardState.MyCP)
                        {
                            buffer.Add(nextPoint);
                            if (Board.moveLegal(nextPoint, this.player) == BoardState.EnemyCP) break;
                        }
                        else
                        {
                            break;
                        }
                    }
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
