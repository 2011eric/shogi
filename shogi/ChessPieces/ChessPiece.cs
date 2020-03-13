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
        public String currentType { get; }
        public String player { get; }

        public List<Point> possibleMove { get; set; }


        public ChessPiece(Point init,String player,String defaultType, String upgradeType) {
            this.player = player;
            this.defaultType = defaultType;
            this.upgradeType = upgradeType;
            currentType = defaultType;
        }

    }
}
