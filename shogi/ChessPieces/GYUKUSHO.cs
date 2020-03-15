using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace shogi.ChessPieces
{
    class Gyukusho : ChessPiece
    {
        public Gyukusho(Point init, Player player) : base(init, player, ChessPieceType.Gyukusho)
        {
            
        }
        

        public override void RefreshPosibleMove(Point point)
        {
            List<Point> result = new List<Point>();
            for(int i = -1; i <= 1; i++)
            {
                for(int j = -1; j <= 1; j++)
                {
                    if (i != 0 || j != 0)
                    {
                        Point nextPoint = new Point(board_point.X + i, board_point.Y + j);
                        if (!Board.CheckBorder(nextPoint));
                        else if (Board.moveLegal(nextPoint, this.player) != BoardState.MyCP || Board.moveLegal(nextPoint, this.player) == BoardState.EnemyCP)
                        {
                            result.Add(nextPoint);
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            possibleMove = result;
        }
    }
}
