using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using shogi;
using shogi.ChessPieces;

namespace shogi
{
    public partial class form_board : Form
    {
        Game m_game = new Game();
        public form_board()
        {
            InitializeComponent();

            // Hisha hisha1 = new Hisha(new Point(6, 1), "ih");
            foreach (ChessPiece cp in Board.board)
            {
                if (cp != null)
                    this.Controls.Add(cp);
            }
            foreach (Path path in Board.path){
                if (path != null)
                {
                    this.Controls.Add(path);
                }
            }
           


            
            /*
            test.BackColor = System.Drawing.Color.Transparent;
            test.Image = global::shogi.Properties.Resources.Ginsho;
            test.Location = new System.Drawing.Point(0, 0);
            
            test.Size = new System.Drawing.Size(65, 65);
            Board.setChessPiece(new Point(2, 8), new Hisha(new Point(2, 8), "first"));
            Board.setChessPiece(new Point(2, 2), new Hisha(new Point(2, 2), "second"));
            Board.getChessPiece(new Point(2, 8)).RefreshPosibleMove(new Point(2, 8));
            */




        }

        private void button1_Click(object sender, EventArgs e)
        {
            Game.Restart();
            foreach (ChessPiece cp in Board.board)
            {
                if (cp != null)
                    this.Controls.Add(cp);
            }
            
        }
    }
    
}
