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
       
        public ChessPiece(pos init) { }
        

        public abstract List<pos> possibleMove(pos current);
    }
}
