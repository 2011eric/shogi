using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shogi
{
    public enum PlayerEnum
    {
        First,
        Second
    }
    public class Player
    {
        
        public string role;
        public PlayerEnum playerEnum;
        public static int playerNum = 0;
        private ChessPiece[] piecesDead;

        public Player(string role)
        {
            this.role = role;
            this.playerEnum = (PlayerEnum)(playerNum % 2);
            playerNum++;
        }

        public override string ToString()
        {
            return playerEnum.ToString();
        }
    }
}
