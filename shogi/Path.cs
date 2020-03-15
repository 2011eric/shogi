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
            this.Enabled = true;
            this.Visible = true;
        }
        public void hide() {
            this.Enabled = false;
            this.Visible = false;
        }
    }
}
