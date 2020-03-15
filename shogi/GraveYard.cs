using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shogi
{
    public class GraveYard
    {
        public Point starting_point;
        public Player player;

        public GraveYard(Point starting_point, Player player)
        {
            this.starting_point = starting_point;
            this.player = player;
        }

        public void toGraveYard(ChessPiece cp)
        {
            ChessPieceType type = cp.defaultType;
            switch (type)
            {

            }
        }
    }
}
