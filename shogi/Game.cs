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
        
        private int currentPlayer;
        private ChessPiece[,] board = new ChessPiece[9, 9];
        public Game()
        {
           
            Player[] playerList = new Player[2];
            playerList[0] = new Player("first");
            playerList[1] = new Player("second");
            currentPlayer = 0;
            
        }
        private void SpawnPieces(string player)
        {
            //TODO: Initialize all the chesspieces on the board
            if (player == "first")
            {
                Board.setChessPiece(new Point(5, 9) , new Gyukusho(new Point(5, 9), player));
                Board.setChessPiece(new Point(2, 8) , new Hisha(new Point(2, 8), player));
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
       
    }
       
    
}
