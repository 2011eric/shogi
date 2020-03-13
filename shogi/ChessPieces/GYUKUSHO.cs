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
        public Gyukusho(Point init, string player) : base(init, player, "Gyukusho")
        {

        }
        pos[] moves = new pos[8] { new pos(1,-1), new pos(0,-1), new pos(-1,-1),
                                new pos(1, 0), new pos(-1,0), new pos( 1, 1),new pos(0,1) , new pos(-1,1)};
        
        public override List<pos> possibleMove(pos current)
        {
            List<pos> result = new List<pos>();
            foreach(pos i in moves)
            {
                pos _new = new pos(current.X+i.X, current.Y+i.Y);
                if (_new.X > 0 && _new.X < 10 && _new.Y > 0 && _new.Y < 10)
                {
                    result.Add(_new);
                }
            }
            return result;
        }
    }
}
