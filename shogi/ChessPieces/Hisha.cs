using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace shogi.ChessPieces
{
    
    class Hisha:ChessPiece
    {
        public string player { get; }
        public bool upgraded { get; set; }
        public Hisha(Point init,string player) : base(init,player,ChessPiecesName.HISHA,"")
        {
            
            this.upgraded = false;
        }
        Point[] upgradedMoves = new Point[8] { new Point(1,-1), new Point(0,-1), new Point(-1,-1),
                                new Point(1, 0), new Point(-1,0), new Point( 1, 1),new Point(0,1) , new Point(-1,1)};
        public override List<Point> PointsibleMove(Point current)
        {
            //TODO:Check if the path is blocked
            List<Point> result = new List<Point>();
            for(int i =current.X+1; i < 10;i++)
            {
               //if()
               
            }
            /* staged
            if(current.X != i)
                {
                    result.Add(new Point(i, current.Y));
                }
                if(current.Y != i)
                {
                    result.Add(new Point(current.X, i));
                }
            */
            if (upgraded)
            {
                foreach (Point i in upgradedMoves)
                {
                    Point _new = new Point(current.X + i.X, current.Y + i.Y);
                    if (_new.X > 0 && _new.X < 10 && _new.Y > 0 && _new.Y < 10)
                    {
                        if (!result.Contains(_new)) result.Add(_new);
                    }
                }
            }
            return result;
        }
        public  void Upgrade()
        {
            this.upgraded = true;
        }
    }
}
