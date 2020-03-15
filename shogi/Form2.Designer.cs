using System;
using System.Drawing;

namespace shogi
{
    partial class form_board
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picture_board = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture_board)).BeginInit();
            this.SuspendLayout();
            // 
            // picture_board
            // 
            this.picture_board.BackColor = System.Drawing.Color.White;
            this.picture_board.Image = global::shogi.Properties.Resources.棋盤1;
            this.picture_board.Location = new System.Drawing.Point(0, -1);
            this.picture_board.Margin = new System.Windows.Forms.Padding(6);
            this.picture_board.Name = "picture_board";
            this.picture_board.Size = new System.Drawing.Size(1248, 682);
            this.picture_board.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picture_board.TabIndex = 0;
            this.picture_board.TabStop = false;
            // 
            // form_board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1760, 1399);
            this.Controls.Add(this.picture_board);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "form_board";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.form_board_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_board)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void form_board_Load(object sender, EventArgs e)
        {
            foreach (ChessPiece cp in Board.board)
            {
                if (cp != null) 
                    cp.BringToFront();
            }
        }

        #endregion

        private System.Windows.Forms.PictureBox picture_board;
    }
}