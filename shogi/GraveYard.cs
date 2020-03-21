using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shogi
{
    public class GraveYardItem:Button
    {
        private static int x_graveyard1 = 500;
        private static int x_graveyard2 = 0;
        private static int y_graveyard1 = 400;
        private static int y_graveyard2 = 0;
        private int playerindex;
        private ChessPieceType type;
        private int numOfCP;
        private Image image = global::shogi.Properties.Resources.fuhyo;

        public GraveYardItem(int playerindex, ChessPieceType type,int numOfCP )
        {
            this.playerindex = playerindex;
            this.type = type;
            this.numOfCP = numOfCP;
            this.initItem();
            this.getCorrespondentImg();
        }
        private void initItem()
        {
            if (playerindex == 2) this.image.RotateFlip(RotateFlipType.Rotate180FlipNone);
            this.BackgroundImage = this.image;
            this.BackgroundImageLayout = ImageLayout.Zoom;

            this.FlatAppearance.BorderColor = Color.Transparent;
            this.FlatAppearance.BorderSize = 0;
            this.FlatAppearance.MouseDownBackColor = Color.Transparent;
            this.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, Color.LightGray);
            this.FlatStyle = FlatStyle.Flat;
            this.ForeColor = Color.Black;

            this.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            this.BackColor = Color.Transparent;
            
            this.FlatAppearance.BorderSize = 0;
            this.Location = this.indexToWorld();
            this.Name = "GraveYardItem" + '_' +playerindex +'_'+type.ToString();
            this.Size = new Size(68, 68);
            this.TabStop = false;
            this.UseVisualStyleBackColor = false;
            this.Click += new System.EventHandler(this.Button_Click);
            
        }
        //private getCOr
        private Point indexToWorld()
        {
            Point world_pos = new Point(0, 0);
            if (playerindex == 1)
            {
                world_pos.X = x_graveyard1;
            }

            return world_pos;

        }
        private void Button_Click(object sender, EventArgs e)
        {

        }
        private void getCorrespondentImg()
        {
            Image image = Properties.Resources.fuhyo;
            switch (type)
            {

                case ChessPieceType.Gyukusho:   //Ding
                    image = Properties.Resources.gyokusho;
                    break;
                case ChessPieceType.Hisha:      //Fly Car
                    image = Properties.Resources.hisha;
                    break;
                case ChessPieceType.Kakugyo:    //Angle Walk
                    image = Properties.Resources.kakugyo;
                    break;
                case ChessPieceType.Kinsho:     //Gold
                    image = Properties.Resources.kinsho;
                    break;
                case ChessPieceType.Ginsho:     //Silver
                    image = Properties.Resources.ginsho;
                    break;
                case ChessPieceType.Keima:      //Expensive horse
                    image = Properties.Resources.keima;
                    break;
                case ChessPieceType.Kyosha:     //Fragrant car
                    image = Properties.Resources.kyosha;
                    break;
                case ChessPieceType.Fuhyo:      //Soldier
                    image = Properties.Resources.fuhyo;
                    break;
                default:
                    break;

            }
            this.image = image;
        }



    }
}
