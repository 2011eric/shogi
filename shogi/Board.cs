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
        public static Size sizeOfCP = new Size(68, 68);
        public static ChessPiece choosed = null;

        public static Point BoardToWorld(Point board_pos)
        {
            //This methot will turn board position to world position
            //e.g. (1,3) => (200, 400)
            Point world_pos = new Point(0,0);
            Point starting_point = new Point(571,24);
            double x_unit = 68.6;
            double y_unit = 69.6;

            world_pos.X = (int)(starting_point.X - (board_pos.X -1) * x_unit);
            world_pos.Y = (int)(starting_point.Y + (board_pos.Y - 1) * y_unit);
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
            return board[point.X, point.Y];
        }
        public static void setChessPiece(ChessPiece target)
        {
            Point point = target.board_point;
            board[point.X, point.Y] = target;
        }

        public static Path getPath(Point point)
        {
            return path[point.X, point.Y];
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
                {
                    return MyCP;
                }
                else
                {
                    return Null;
                }
            }
            else if (Board.CheckMate(point, getChessPiece(point), player))
            {
                return EnemyCheckMate;
            }
            return Null;
        }

        public static void MoveCP(ChessPiece cp, Point to)
        {
            Point from = cp.board_point;
            board[to.X, to.Y] = cp;
            cp.moveTo(to);
            board[from.X, from.Y] = null;
            choosed = null;
            Game.switchPlayer();
            Game.HideAllPath();
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

        public static void CPToGraveYard(ChessPiece cp)
        {
            Point to = new Point(1, 1);
            Point from = cp.board_point;
            board[to.X, to.Y] = cp;
            cp.moveTo(to);
            board[from.X, from.Y] = null;
            cp.kill(choosed.player);
        }
              
    }
}
