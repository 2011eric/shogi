using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shogi
{
    public abstract partial class ChessPiece : PictureBox
    {
        public ChessPieceType defaultType { get; }
        public ChessPieceType upgradeType { get; }
        private ChessPieceType currentType;
        public String player { get; set; }
        public bool haveUpgrade;
        public bool canUpgrade;
        public bool upgraded;

        public List<Point> possibleMove { get; set; }


        public ChessPiece(Point init,String player, ChessPieceType defaultType, ChessPieceType upgradeType) {
            this.player = player;
            this.defaultType = defaultType;
            this.upgradeType = upgradeType;
            currentType = defaultType;
            haveUpgrade = defaultType != upgradeType;
            canUpgrade = false;
            upgraded = false;
        }
        public ChessPiece(Point init, String player, ChessPieceType defaultType)
        {
            this.player = player;
            this.defaultType = defaultType;
            this.upgradeType = defaultType;
            currentType = defaultType;
            haveUpgrade = false;
            canUpgrade = false;
            upgraded = false;
        }

        public ChessPieceType getCurrentType()
        {
            return currentType;
        }

        public bool upgrade()
        {
            if (!haveUpgrade) return false;
            //check if the chess piece can upgrade and didn't upgrade before
            if (canUpgrade && !upgraded)
            {
                currentType = upgradeType;
                upgraded = true;
            }
            return canUpgrade;
        }

        public abstract void RefreshPosibleMove(Point point);
        //The above method should only be called once after the cp was moved or every round of the game

    }
}
