using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shogi
{
    public class Player
    {
        public string role;
        private ChessPiece[] piecesDead;

        public Player(string role)
        {
            this.role = role;
        }
    }
}
