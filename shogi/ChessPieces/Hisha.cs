using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Collections.Generic;

namespace shogi.ChessPieces
{
    
    class Hisha:ChessPiece
    {
        List<Point> upgradedMoves = new List<Point>();

        public Hisha(Point init, Player player) : base(init, player, ChessPieceType.Hisha)
        {
            
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    if (!(i == 0 && j == 0))
                    {
                        upgradedMoves.Add(new Point(i, j));
                        
                    }
                }

            }
        }
        
        
       
       
        public override void RefreshPosibleMove(Point point)
        {
            //TODO:Check if the path is blocked
            List<Point> result = new List<Point>();
            for (int i = point.X + 1; i < 10; i++)
            {
                Point nextPoint = new Point(i, point.Y);
                if (Board.moveLegal(nextPoint, this.player) != BoardState.MyCP)
                {
                    result.Add(nextPoint);
                    if (Board.moveLegal(nextPoint, this.player) == BoardState.EnemyCP) break;
                }
                else
                {
                    break;
                }
            }
            for (int i = point.X - 1; i > 0 ; i--)
            {
                Point nextPoint = new Point(i, point.Y);
                if (Board.moveLegal(nextPoint, this.player) != BoardState.MyCP)
                {
                    result.Add(nextPoint);
                    if (Board.moveLegal(nextPoint, this.player) == BoardState.EnemyCP) break;
                }
                else
                {
                    break;
                }
            }
            for (int i = point.Y + 1; i < 10; i++)
            {
                Point nextPoint = new Point(point.X,i );
                if (Board.moveLegal(nextPoint, this.player) != BoardState.MyCP)
                {
                    result.Add(nextPoint);
                    if (Board.moveLegal(nextPoint, this.player) == BoardState.EnemyCP) break;
                }
                else
                {
                    break;
                }
            }
            for (int i = point.Y - 1; i > 0 ; i--)
            {
                Point nextPoint = new Point(point.X, i);
                if (Board.moveLegal(nextPoint, this.player) != BoardState.MyCP)
                {
                    result.Add(nextPoint);
                    if (Board.moveLegal(nextPoint, this.player) == BoardState.EnemyCP) break;
                }
                else
                {
                    break;
                }
            }
            if (upgraded)
            {
                foreach (Point i in upgradedMoves)
                {
                    Point nextPoint = new Point(point.X + i.X, point.Y + i.Y);

                    if (Board.CheckBorder(nextPoint))
                    {
                        if (!result.Contains(nextPoint)) result.Add(nextPoint);
                    }
                }

            }
            foreach(Point i in result)
            {
                //System.Windows.Forms.MessageBox.Show("next:" + i.ToString());
            }
            possibleMove = result;
        }
    }
}
