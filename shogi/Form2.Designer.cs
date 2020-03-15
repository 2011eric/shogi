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
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture_board)).BeginInit();
            this.SuspendLayout();
            // 
            // picture_board
            // 
            this.picture_board.BackColor = System.Drawing.Color.White;
            this.picture_board.Image = global::shogi.Properties.Resources.棋盤1;
            this.picture_board.Location = new System.Drawing.Point(45, -3);
            this.picture_board.Name = "picture_board";
            this.picture_board.Size = new System.Drawing.Size(670, 670);
            this.picture_board.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picture_board.TabIndex = 0;
            this.picture_board.TabStop = false;
            this.picture_board.Click += new System.EventHandler(this.picture_board_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current Player";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // form_board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(880, 673);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picture_board);
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
        private System.Windows.Forms.Label label1;
    }
}