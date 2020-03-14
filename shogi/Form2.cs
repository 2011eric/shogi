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

        public form_board()
        {
            InitializeComponent();
            Hisha test = new Hisha(new Point(1, 1), "ih");
           
           
       
            
            this.picture_board.Controls.Add(test);

            test.BackColor = System.Drawing.Color.Transparent;
            test.Image = global::shogi.Properties.Resources.銀;
            test.Location = new System.Drawing.Point(136, 512);
            
            test.Size = new System.Drawing.Size(133, 67);
            test.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            Board.setChessPiece(new Point(2, 8), new Hisha(new Point(2, 8), "first"));
            Board.setChessPiece(new Point(2, 2), new Hisha(new Point(2, 2), "second"));
            Board.getChessPiece(new Point(2, 8)).RefreshPosibleMove(new Point(2, 8));
            




        }
       
        
       
        
        
        
      

        private void picture_board_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
    
}
