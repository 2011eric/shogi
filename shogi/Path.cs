using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace shogi
{
    public class Path : Button
    {
        public Point pos;
        private Color color = Color.White;
        public int enemyPath = 0;
        public int myPath = 0;
        public Path(Point pos)
        {
            this.pos = pos;
            this.BackColor = Color.FromArgb(70, color);
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Location = Board.BoardToWorld(pos);
            this.Name = "Path" + Board.cpNum;
            this.Size = Board.sizeOfCP;
            this.TabIndex = Board.cpNum;
            Board.cpNum++;
            this.TabStop = false;
            this.Click += new System.EventHandler(this.Button_Click);
            hide();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Board.MoveCP(Board.choosed, pos);
        }

        public void show() {
            this.BackColor = Color.FromArgb(70, color);
            this.Enabled = true;
            this.Visible = true;
        }
        public void hide() {
            this.Enabled = false;
            this.Visible = false;
        }

        public void zoneOfInfluence()
        {
            ChessPiece cp = Board.getChessPiece(this.pos);
            Color color = Color.FromArgb(70, Color.Gray);
            if (enemyPath == 0 && myPath == 0) ;
            else if (enemyPath == myPath) color = Color.FromArgb(130, 149,0,255);
            else if (enemyPath < myPath) color = Color.FromArgb(100, Color.Blue);
            else color = Color.FromArgb(70, Color.Red);
            if (cp == null)
            {
                this.BackColor = color;
                this.Visible = true;
            }
            else
            {
                cp.BackColor = Color.FromArgb(45, color);
            }
        }

        
    }
}
