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
        private Point[] move;
        public Gyukusho(Point init, string player) : base(init, player, ChessPieceType.Gyukusho)
        {
            
        }
        

        public override void RefreshPosibleMove(Point point)
        {
            List<Point> result = new List<Point>();
            foreach (Point i in move)
            {
                Point _new = new Point(point.X + i.X, point.Y + i.Y);
                if (_new.X > 0 && _new.X < 10 && _new.Y > 0 && _new.Y < 10)
                {
                    result.Add(_new);
                }
            }
            possibleMove = result;
        }
    }
}
