using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shogi
{
    public struct pos
    {
        public int x;
        public int y;
    };

    public class Game
    {
        
        private int currentPlayer;
        public Game()
        {
            Player[] playerList = new Player[2];
            playerList[0] = new Player("first");
            playerList[1] = new Player("second");
            currentPlayer = 0;
        }
        public void Start() {
            while (true)
            {
                this.Operate();
            }

        }
        private void Operate()
        {
            bool finished = false;
            while (!finished)
            {
                pos Pos = calcInputPos();
                if(Pos.x > 0 && Pos.x <10 && Pos.y >0 && Pos.y <10)
                {
                 
                }
                
            }
            return;
        } 
        private pos calcInputPos()
        {
            pos clickPos = new pos();
            //TODO: Convert mouse pos to board pos when board is clicked.
            return clickPos;
        }
        private void showPosibleMove(pos[] positions)
        {
            //TODO: Show all positions
            return;
        }
    }
}
