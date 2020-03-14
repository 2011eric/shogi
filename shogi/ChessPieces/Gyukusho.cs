﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace shogi.ChessPieces
{
    class Gyukusho : ChessPiece
    {
        private Point[] move;
        public Gyukusho(Point init, string player) : base(init, player, ChessPieceType.Gyukusho)
        {
            
        }
        
        
        public override List<Point> PointsibleMove(Point current)
        {
            List<Point> result = new List<Point>();
            foreach(Point i in moves)
            {
                Point _new = new Point(current.X+i.X, current.Y+i.Y);
                if (_new.X > 0 && _new.X < 10 && _new.Y > 0 && _new.Y < 10)
                {
                    result.Add(_new);
                }
            }
            return result;
        }

        public override void RefreshPosibleMove()
        {
            
        }
    }
}