using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shogi
{
    public struct pos
    {
        public int X { get; }
        public int Y { get; }

        public pos(int x, int y)
        {
            X = x;
            Y = y;
        }
        public override bool Equals(Object obj)
        {
            //Check for null and compare run-time types.
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                pos p = (pos)obj;
                return (X == p.X) && (Y == p.Y);
            }
        }

        public override string ToString() => $"({X}, {Y})";
    }

    public class Game
    {
        
        private int currentPlayer;
        private ChessPiece[,] board;
        public Game()
        {
            board = new ChessPiece[9, 9];
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
                if(Pos.X > 0 && Pos.X <10 && Pos.Y >0 && Pos.Y <10)
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
        public ChessPiece GetChessPiece(pos index)
        {
            return board[index.X, index.Y];
        } 
    }
       
    }
}
