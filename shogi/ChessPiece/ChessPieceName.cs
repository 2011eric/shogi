using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shogi
{
    public abstract class ChessPiece : PictureBox
    {
        public ChessPiece(pos init)
        {

        }

        public bool moveTo(pos to)
        {
            return false;
        }

        public bool upgrade()
        {
            return false;
        }
    }
}
