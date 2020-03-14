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
            test.Upgrade();     
            foreach(pos i in test.possibleMove(new pos(5,5)))
            {
                MessageBox.Show(i.ToString());
            }
           
       
            
            this.picture_board.Controls.Add(test);

            test.BackColor = System.Drawing.Color.Transparent;
            test.Image = global::shogi.Properties.Resources.銀;
            test.Location = new System.Drawing.Point(136, 512);
            
            test.Size = new System.Drawing.Size(133, 67);
            test.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
           





        }
       
        
       
        
        
        
      

        private void picture_board_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
    
}
