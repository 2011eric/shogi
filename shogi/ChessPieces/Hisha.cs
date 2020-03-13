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
        public Hisha(Point init,string player) : base(init,player,"Hisha")
        {
            
            this.upgraded = false;
        }
        pos[] upgradedMoves = new pos[8] { new pos(1,-1), new pos(0,-1), new pos(-1,-1),
                                new pos(1, 0), new pos(-1,0), new pos( 1, 1),new pos(0,1) , new pos(-1,1)};
        public override List<pos> possibleMove(pos current)
        {
            //TODO:Check if the path is blocked
            List<pos> result = new List<pos>();
            for(int i =current.X+1; i < 10;i++)
            {
               //if()
               
            }
            /* staged
            if(current.X != i)
                {
                    result.Add(new pos(i, current.Y));
                }
                if(current.Y != i)
                {
                    result.Add(new pos(current.X, i));
                }
            */
            if (upgraded)
            {
                foreach (pos i in upgradedMoves)
                {
                    pos _new = new pos(current.X + i.X, current.Y + i.Y);
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
