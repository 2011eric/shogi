using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using shogi.ChessPieces;

namespace shogi
{
    public class Game
    {
        Player[] playerList = new Player[2];
        private int currentPlayer;
        public Game()
        {

         
            playerList[0] = new Player("first");
            playerList[1] = new Player("second");
            SpawnPieces(playerList[0]);
            SpawnPieces(playerList[1]);
            currentPlayer = 0;
            SpawnPaths();
        }

        private void SpawnPaths()
        {
            for(int i = 1; i < 10; i++)
            {
                for(int j = 1; j < 10; j++)
                {
                    Board.path[i, j] = new Path(new Point(i, j));
                }
            }
        }
        private void SpawnPieces(Player player)
        {
            //TODO: Initialize all the chesspieces on the board
            if (player.Equals(playerList[0]))
            {
                //Board.setChessPiece(new Point(5, 9) , new Gyukusho(new Point(1, 1), player));
                 Board.setChessPiece(new Hisha(new Point(4, 2), player));
                 Board.setChessPiece(new Hisha(new Point(4, 7), player));

            }
            else
            {
                //Board.board[1, 9] = new Gyukusho(new Point(5, 9), player);
            }
            

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
                Point Point = calcInputPoint();
                if(Point.X > 0 && Point.X <10 && Point.Y >0 && Point.Y <10)
                {
                 
                }
                
            }
            return;
        } 
        private Point calcInputPoint()
        {
            Point clickPoint = new Point();
            //TODO: Convert mouse Point to board Point when board is clicked.
            return clickPoint;
        }

        public static void HighLightPath(List<Point> point)
        {
            if (point == null) return;

            HideAllPath();

            foreach(Point element in point)
            {
                if(point != null) Board.getPath(element).show();
            }

           
        }

        public static void HideAllPath()
        {
            foreach (Path path in Board.path)
            {
                if (path != null) path.hide();
            }
        }

       
    }
       
    
}
