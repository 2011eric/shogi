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
        public Point board_point;

        public List<Point> possibleMove = new List<Point>();


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
            Image cpImage = global::shogi.Properties.Resources.Ginsho;
            this.BackgroundImage = cpImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.FlatAppearance.BorderSize = 0;
            this.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
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
            RefreshPosibleMove(this.board_point);
            Board.choosed = this;
            Game.HighLightPath(possibleMove);
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
            }
            return canUpgrade;
        }

        public void moveTo(Point to)
        {
            board_point = to;
            this.Location = Board.BoardToWorld(this.board_point);
        }

        public abstract void RefreshPosibleMove(Point point);
        //The above method should only be called once after the cp was moved or every round of the game

    }
}
