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
        public String defaultType { get; }
        public String upgradeType { get; }
        private String currentType;
        public String player { get; set; }
        public bool canUpgrade = false;
        public bool upgraded = false;

        public List<Point> possibleMove { get; set; }


        public ChessPiece(Point init,String player,String defaultType, String upgradeType) {
            this.player = player;
            this.defaultType = defaultType;
            this.upgradeType = upgradeType;
            currentType = defaultType;
            canUpgrade = false;
            upgraded = false;
        }

        public String getCurrentType()
        {
            return currentType;
        }

        public bool upgrade()
        {
            if (canUpgrade && !upgraded)
            {
                currentType = upgradeType;
                upgraded = true;
            }
            return canUpgrade;
        }

    }
}
