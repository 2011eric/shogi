using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using static shogi.BoardState;
namespace shogi
{
    public class Board
    {
        public static ChessPiece[,] board = new ChessPiece[10, 10];
        public static Path[,] path = new Path[10, 10];
        public static int cpNum = 100;
        public static Size sizeOfCP = new Size(67, 67);
        public static Size sizeOfDeadCP = new Size(30, 30);
        public static ChessPiece choosed = null;
        static Point board_starting_point = new Point(857, 30);
        static double x_unit = 68.6;
        static double y_unit = 69.6;
        public const int x_graveyard1 = 0;
        public const int x_graveyard2 = 500;
        public const int y_graveyard1 = 0;
        public const int y_graveyard2 = 400;
        public const int dy_graveyard1 = 80;
        

        public static Point BoardToWorld(Point board_pos)
        {
            //This methot will turn board position to world position
            //e.g. (1,3) => (200, 400)
            Point world_pos = new Point(0,0);
            

            world_pos.X = (int)(board_starting_point.X - (board_pos.X -1) * x_unit);
            world_pos.Y = (int)(board_starting_point.Y + (board_pos.Y - 1) * y_unit);
            return world_pos;
        }
        public static bool CheckBorder(Point current)
        {
            //Check if chesspiece out of border
            return (current.X > 0 && current.X < 10) ? ((current.Y > 0 && current.Y < 10) ?true:false): false;
        }
        public static ChessPiece getChessPiece(Point point)
        {
            //Get the chess piece by its position on the board
            if(CheckBorder(point))
                return board[point.X, point.Y];
            return null;

        }
        public static void setChessPiece(ChessPiece target)
        {
            Point point = target.board_point;
            board[point.X, point.Y] = target;
        }

        public static Path getPath(Point point)
        {
            if(CheckBorder(point))
                return path[point.X, point.Y];
            return null;
        }


        public static bool CheckMate(Point point,ChessPiece target,Player player)
        {
            //Input:The chessPiece and point to move at next step
            //TODO: Check if checkmate
            return false;
        }
        public static BoardState moveLegal(Point point,Player player)
        {
            ChessPiece target = getChessPiece(point);
            if (target != null )//Check if current player lose the game because of this move.
            {
                if (target.player.Equals(player))            
                    return EnemyCP;                
                else               
                    return EnemyCP;                
            }
            else if (Board.CheckMate(point, getChessPiece(point), player))            
                return EnemyCheckMate;            
            return Null;
        }

        public static void MoveCP(ChessPiece cp, Point to)
        {
            Point from = cp.board_point;
            board[to.X, to.Y] = cp;
            cp.moveTo(to);
            CheckForUpgrade(cp);
            cp.upgrade();
            board[from.X, from.Y] = null;
            choosed = null;
            Game.HideAllPath();
            Game.deHighlightCP();
            Game.switchPlayer();
        }

        public static void KillCP(ChessPiece deadman)
        {
            if (choosed != null)
            {
                Point buffer = deadman.board_point;
                CPToGraveYard(deadman);
                MoveCP(choosed, buffer);
            }
        }

        public static void CheckForUpgrade(ChessPiece cp)
        {
            if (cp.haveUpgrade == false)
            {
                cp.canUpgrade = false;
                return;
            }
            if (cp.player.playerEnum == PlayerEnum.First)
            {
                if (cp.board_point.Y <= 3) cp.canUpgrade = true;
            }
            else
                if (cp.board_point.Y >= 7) cp.canUpgrade = true;
        }


        static Point graveYard_0_starting_point = new Point(0, 0);
        static Point graveYard_1_starting_point = new Point(0, 0);
        static int graveYard_0_num = 0;
        static int graveYard_1_num = 0;
        public static void CPToGraveYard(ChessPiece cp)
        {
            Point from = cp.board_point;       
            board[from.X, from.Y] = null;
            
            cp.kill(choosed.player);
            cp.player.graveyard[(int)cp.defaultType]++;
            System.Windows.Forms.MessageBox.Show(cp.player.playerEnum.ToString()+" "+cp.defaultType.ToString()+":"+cp.player.graveyard[(int)cp.defaultType]);
            //form_board.
        }

        public static void showZoneOfInfluence()
        {
            foreach (Path p in path)
            {
                if (p != null)
                {
                    p.enemyPath = 0;
                    p.myPath = 0;
                }
            }

            foreach (ChessPiece cp in board)
            {
                if(cp != null)
                {
                    cp.RefreshPosibleMove();
                    foreach(Point pt in cp.possibleMove)
                    {
                        if(pt != null)
                        {
                            if (cp.player.playerEnum == PlayerEnum.First) getPath(pt).myPath++;
                            else getPath(pt).enemyPath++;
                        }
                    }
                }
            }

            foreach(Path p in path)
            {
                if (p != null) p.zoneOfInfluence();
            }
        }
       
    }
}
