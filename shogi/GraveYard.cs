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
        private static int graveyardwidth = 68*4;
        private static int x_graveyard1 = 967;
        private static int x_graveyard2 = 10;
        private static int y_graveyard1 = 330;
        private static int y_graveyard2 = 10;
        public Player player { get; set; };
        public int playerindex { get; }
        private ChessPieceType type;
        private int numOfCP;
        private int itemIndex;
        private Image image = global::shogi.Properties.Resources.fuhyo;

        public GraveYardItem(int playerindex, ChessPieceType type,int itemIndex,int numOfCP )
        {
            this.playerindex = playerindex;
            this.type = type;
            this.itemIndex = itemIndex;
            this.numOfCP = numOfCP;
            this.initItem();
            this.getCorrespondentImg();
            if (playerindex == 2) this.image.RotateFlip(RotateFlipType.Rotate180FlipNone);
            
        }
        private void initItem()
        {
            
            this.BackgroundImageLayout = ImageLayout.Zoom;

            this.FlatAppearance.BorderColor = Color.Black;
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
        private Point indexToWorld()
        {
            Point world_pos = new Point(0, 0);
            if (playerindex == 1)
            {
                world_pos.X = x_graveyard1 + (68 * itemIndex) % graveyardwidth;
                world_pos.Y = y_graveyard1 + ((int)((68 * itemIndex) / graveyardwidth ))* 68;
            }
            else
            {
                world_pos.X = x_graveyard2 + (68 * itemIndex) % graveyardwidth;
                world_pos.Y = y_graveyard2 + ((68 * itemIndex) / graveyardwidth) * 68;

            }

            return world_pos;

        }
        private void Button_Click(object sender, EventArgs e)
        {
            if(Board.choosed==null|| isSamePlayer(Board.choosed.player))
            {
                Game.DisableOpponentCP();
                Board.choosed=this;
            }
            List<Point> possiblePos= refreshPossibleMoves();
            Game.HighLightPath(possiblePos);
            /*
             
            cp = new ChessPiece() 
            Board.DeployCP();*/
        }
        private  void RefreshPossibleMoves()
        {
            List<Point> possiblePos = new List<Point>();
            switch (this.type)
            {
                case ChessPieceType.Keima:
                    for (int i = 1; i <= 9; i++)
                    {
                        for (int j = 1; j <= 9; j++)
                        {
                            if (this.playerindex == 1 && j < 3) continue;
                            if (this.playerindex == 2 && j > 7) break;
                            if (Board.getChessPiece(new Point(i, j)) == null) possiblePos.Add(new Point(i, j));
                        }
                    }
                    break;
                case ChessPieceType.Kyosha:
                    for (int i = 1; i <= 9; i++)
                    {
                        for (int j = 1; j <= 9; j++)
                        {
                            if (this.playerindex == 1 && j == 1) continue;
                            if (this.playerindex == 2 && j == 9) break;
                            if (Board.getChessPiece(new Point(i, j)) == null) possiblePos.Add(new Point(i, j));
                        }

                    }
                    break;
                case ChessPieceType.Fuhyo:
                    for (int i = 1; i <= 9; i++)
                    {
                        bool secondFu = false;
                        for (int j = 1; j <= 9; j++)
                        {
                            ChessPiece target = Board.getChessPiece(new Point(i, j));
                            if (target != null && target.defaultType == ChessPieceType.Fuhyo)
                            {
                                if ((target.player.role == "first" && this.playerindex == 1) || (target.player.role == "second" && this.playerindex == 2))
                                {
                                    secondFu = true;
                                    break;
                                }
                            }
                        }
                        if (!secondFu)
                        {
                            for (int j = 1; j <= 9; j++)
                            {
                                if (this.playerindex == 1 && j == 1) continue;
                                if (this.playerindex == 2 && j == 9) break;
                                if (Board.getChessPiece(new Point(i, j)) == null) possiblePos.Add(new Point(i, j));//檢查打步詰
                            }
                        }
                    }
                    break;
                default:
                    for (int i = 1; i <= 9; i++)
                    {
                        for (int j = 1; j <= 9; j++)
                        {
                            if (Board.getChessPiece(new Point(i, j)) == null) possiblePos.Add(new Point(i, j));
                        }
                    }
                    break;
            }
            return possiblePos;
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
            this.BackgroundImage = this.image;
        }
        private bool isSamePlayer(Player player)
        {
            return (player.role=="first"&&this.playerindex==1) ||(player.role=="second"&&this.playerindex==2)
        }


    }
}
