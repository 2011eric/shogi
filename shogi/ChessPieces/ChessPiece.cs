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
        public String type { get; }
        public String player { get; }
 
        public ChessPiece(Point init,String player,String type) {
            this.player = player;
            this.type = type;
        }

    }
}
