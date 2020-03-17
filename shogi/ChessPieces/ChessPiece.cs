using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shogi
{
    public abstract partial class ChessPiece : Button
    {
        public ChessPieceType defaultType { get; }
        public ChessPieceType upgradeType { get; }
        private ChessPieceType currentType;
        public Player player { get; set; }
        public bool haveUpgrade;
        public bool canUpgrade;
        public bool upgraded;
        public bool dead = false;
        public Point board_point;

        public List<Point> possibleMove = new List<Point>();

        protected Image cpImage = global::shogi.Properties.Resources.fuhyo;

        public ChessPiece(Point init,Player player, ChessPieceType defaultType, ChessPieceType upgradeType) {
            this.player = player;
            this.defaultType = defaultType;
            this.upgradeType = upgradeType;
            this.board_point = init;
            currentType = defaultType;
            haveUpgrade = defaultType != upgradeType;
            canUpgrade = false;
            upgraded = false;
            createButton();
        }

        public ChessPiece(Point init, Player player, ChessPieceType defaultType)
        {
            this.player = player;
            this.defaultType = defaultType;
            this.upgradeType = defaultType;
            this.board_point = init;
            currentType = defaultType;
            haveUpgrade = false;
            canUpgrade = false;
            upgraded = false;
            createButton();
        }

        public void createButton()
        {
            this.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            this.BackColor = System.Drawing.Color.Transparent;
            getCorrespondentImg();
            //rotate the image if the player is the enemy
            if (this.player.playerEnum == PlayerEnum.Second) cpImage.RotateFlip(RotateFlipType.Rotate180FlipNone);
            this.BackgroundImage = cpImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.FlatAppearance.BorderSize = 0;
            this.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, Color.White);
            this.FlatStyle =FlatStyle.Flat;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Location = Board.BoardToWorld(this.board_point);
            this.Name = currentType.ToString() + Board.cpNum;
            this.Size = Board.sizeOfCP;
            this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.TabIndex = Board.cpNum;
            Board.cpNum++;
            this.UseVisualStyleBackColor = false;
            this.Click += new System.EventHandler(this.Button_Click);
            /*
            BackColor = System.Drawing.Color.Transparent;
            Image cpImage = global::shogi.Properties.Resources.Ginsho;
            BackgroundImage = cpImage;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            ForeColor = System.Drawing.Color.Transparent;
            Location = new System.Drawing.Point(516, 21);
            Name = "button2";
            Size = new System.Drawing.Size(68, 68);
            TabIndex = 8;
            TextAlign = System.Drawing.ContentAlignment.BottomRight;
            UseVisualStyleBackColor = false;
            Click += new System.EventHandler(this.Button_Click);
            */
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (Board.choosed == null || Board.choosed.player == this.player)
            {
                if (!dead)
                    RefreshPosibleMove(this.board_point);
                else RefreshPossibleMoveDead();
                Board.choosed = this;
                Game.HighLightPath(possibleMove);
            }
            else Board.KillCP(this);
            
            //highlight();
        }

        public ChessPieceType getCurrentType()
        {
            return currentType;
        }

        
        public bool upgrade()
        {
            if (!haveUpgrade) return false;
            //check if the chess piece can upgrade and didn't upgrade before
            if (canUpgrade && !upgraded)
            {
                currentType = upgradeType;
                upgraded = true;
                getCorrespondentImg();
                //rotate the image if the player is the enemy
                if (this.player.playerEnum == PlayerEnum.Second) cpImage.RotateFlip(RotateFlipType.Rotate180FlipNone);
                this.BackgroundImage = cpImage;
            }
            return canUpgrade;
        }

        public void moveTo(Point to)
        {
            board_point = to;
            this.Location = Board.BoardToWorld(this.board_point);
        }

        public void kill(Player by)
        {
            player = by;
            cpImage.RotateFlip(RotateFlipType.Rotate180FlipNone);
            this.BackgroundImage = cpImage;
            this.Size = Board.sizeOfDeadCP;
            this.Enabled = false;
            this.Visible = false;
            canUpgrade = false;
            upgraded = false;
            dead = true;
        }

        public void highlight()
        {
            this.BackColor = Color.FromArgb(70, Color.White) ;
        }
        public void deHighlight()
        {
            BackColor = Color.Transparent;
        }

        public abstract void RefreshPosibleMove(Point point);
        //The above method should only be called once after the cp was moved or every round of the game

        public void RefreshPossibleMoveDead()
        {
            List<Point> result = new List<Point>();
            for (int i = 1; i < 10; i++)
            {
                for(int j = 1; j < 10; j++)
                {
                    if (Board.board[i, j] == null) result.Add(new Point(i, j));
                }
            }
            possibleMove = result;
        }

        private void getCorrespondentImg()
        {
            Image image = Properties.Resources.fuhyo;
            switch (currentType)
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
                //==========
                //upgraded type
                //==========
                case ChessPieceType.Ryuou:      //Fly Car
                    image = Properties.Resources.ryuo;
                    break;
                case ChessPieceType.Ryuuma:     //Angle Walk
                    image = Properties.Resources.ryuma;
                    break;
                case ChessPieceType.Narigin:    //Silver
                    image = Properties.Resources.narigin;
                    break;
                case ChessPieceType.Narikei:    //Expensive horse
                    image = Properties.Resources.narikei;
                    break;
                case ChessPieceType.Narikyou:   //Fragrant car
                    image = Properties.Resources.narikyo;
                    break;
                case ChessPieceType.Tokin:      //Soldier
                    image = Properties.Resources.tokin;
                    break;
                default:
                    
                    break;
                     
            }
            cpImage = image;
        }
    }
}
