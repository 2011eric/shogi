using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using shogi.ChessPieces;
using System.Media;
namespace shogi
{
    public class Game
    {
        static Player[] playerList = new Player[2];
        public static Player currentPlayer;
        public static int round = 0;
        public static bool game_over = false;
        public static SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.sound_move);

        public Game()
        {


            playerList[0] = new Player("first");
            playerList[1] = new Player("second");
            SpawnAllPieces();
            SpawnGraveYard();
            currentPlayer = playerList[0];
            SpawnPaths();
            
            soundPlayer.LoadAsync();
            
            DisableOpponentCP();
            
        }

        private void SpawnPaths()
        {
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Board.path[i, j] = new Path(new Point(i, j));
                }
            }
        }
        private static void SpawnAllPieces()
        {
            //TODO: Initialize all the chesspieces on the board
            //==============================
            //First Player
            //==============================
            Board.setChessPiece(new Gyukusho(new Point(5, 9), playerList[0]));
            Board.setChessPiece(new Hisha(new Point(2, 8), playerList[0]));
            Board.setChessPiece(new Kakugyo(new Point(8, 8), playerList[0]));
            Board.setChessPiece(new Kinsho(new Point(4, 9), playerList[0]));
            Board.setChessPiece(new Kinsho(new Point(6, 9), playerList[0]));
            Board.setChessPiece(new Ginsho(new Point(3, 9), playerList[0]));
            Board.setChessPiece(new Ginsho(new Point(7, 9), playerList[0]));
            Board.setChessPiece(new Keima(new Point(2, 9), playerList[0]));
            Board.setChessPiece(new Keima(new Point(8, 9), playerList[0]));
            Board.setChessPiece(new Kyosha(new Point(1, 9), playerList[0]));
            Board.setChessPiece(new Kyosha(new Point(9, 9), playerList[0]));
            for (int i = 1; i <= 9; i++) Board.setChessPiece(new Fuhyo(new Point(i, 7), playerList[0]));
            //==============================
            //Second Player
            //==============================
            Board.setChessPiece(new Gyukusho(new Point(5,1), playerList[1]));
            Board.setChessPiece(new Hisha(new Point(8, 2), playerList[1]));
            Board.setChessPiece(new Kakugyo(new Point(2, 2), playerList[1]));
            Board.setChessPiece(new Kinsho(new Point(4, 1), playerList[1]));
            Board.setChessPiece(new Kinsho(new Point(6, 1), playerList[1]));
            Board.setChessPiece(new Ginsho(new Point(3, 1), playerList[1]));
            Board.setChessPiece(new Ginsho(new Point(7, 1), playerList[1]));
            Board.setChessPiece(new Keima(new Point(2, 1), playerList[1]));
            Board.setChessPiece(new Keima(new Point(8, 1), playerList[1]));
            Board.setChessPiece(new Kyosha(new Point(1, 1), playerList[1]));
            Board.setChessPiece(new Kyosha(new Point(9, 1), playerList[1]));
            for (int i = 1; i <= 9; i++) Board.setChessPiece(new Fuhyo(new Point(i, 3), playerList[1]));
        }
        private void SpawnGraveYard()
        {
            for (int i = 1; i <= 2; i++)
            {
                Board.addGraveYard(new GraveYardItem(i, ChessPieceType.Hisha, 0, 0));
                Board.addGraveYard(new GraveYardItem(i, ChessPieceType.Kakugyo, 1, 0));
                Board.addGraveYard(new GraveYardItem(i, ChessPieceType.Kinsho, 2, 0));
                Board.addGraveYard(new GraveYardItem(i, ChessPieceType.Ginsho, 3, 0));
                Board.addGraveYard(new GraveYardItem(i, ChessPieceType.Keima, 4, 0));
                Board.addGraveYard(new GraveYardItem(i, ChessPieceType.Kyosha, 5, 0));
                Board.addGraveYard(new GraveYardItem(i, ChessPieceType.Fuhyo, 6, 0));
            }
        }
           
        
        public void Start()
        {
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
                if (Point.X > 0 && Point.X < 10 && Point.Y > 0 && Point.Y < 10)
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

        public static void switchPlayer()
        {
            round++;
            currentPlayer = playerList[round % 2];
            DisableOpponentCP();
            
        }

        public static void HighLightPath(List<Point> point)
        {
            if (point == null) return;
            deHighlightCP();
            HideAllPath();

            foreach (Point element in point)
            {
                if (point != null)
                {
                    if (Board.getChessPiece(element) == null)
                        Board.getPath(element).show();
                    else
                    {
                        ChessPiece cp = Board.getChessPiece(element);
                        if (cp.player.playerEnum != currentPlayer.playerEnum) { 
                        Board.getChessPiece(element).Enabled = true;
                        Board.getChessPiece(element).highlight();
                        }
                    }
                }
            }


        }

        public static void HideAllPath()
        {
            foreach (Path path in Board.path)
            {
                if (path != null) path.hide();
            }
        }

        public static void deHighlightCP()
        {
            foreach (ChessPiece cp in Board.board)
            {
                if (cp != null) cp.deHighlight();
            }
        }

        public static void DisableOpponentCP()
        {
            foreach (ChessPiece cp in Board.board)
            {
                if (cp != null)
                {
                    if (cp.player == currentPlayer) cp.Enabled = true;
                    else cp.Enabled = false;
                }
            }
            if (currentPlayer.role == "first")
            {
                foreach (GraveYardItem item in Board.graveYard2)
                {
                    item.Enabled = false;
                }
            }
            else
            {
                foreach(GraveYardItem item in Board.graveYard1)
                {
                    item.Enabled = false;
                }
            }
            
            


        }

        public static void Restart()
        {
            game_over = false;
            ClearBoard();
            playerList[0] = new Player("first");
            playerList[1] = new Player("second");
            SpawnAllPieces();
            round = 0;
            currentPlayer = playerList[0];
            DisableOpponentCP();
            HideAllPath();
            
        }

        public static void GameOver()
        {
            game_over = true;
            System.Windows.Forms.MessageBox.Show("Game Over, The Winner is " + currentPlayer.role);
            Restart();
            
        }



        public static void ClearBoard()
        {
            foreach (ChessPiece cp in Board.board)
            {
                if(cp != null)
                {
                    cp.Enabled = false;
                    cp.Visible = false;
                }
            }
            Board.board = new ChessPiece[10, 10];
        }


    }
}
