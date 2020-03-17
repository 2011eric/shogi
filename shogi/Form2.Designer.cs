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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picture_board)).BeginInit();
            this.picture_board.SuspendLayout();
            this.SuspendLayout();
            // 
            // picture_board
            // 
            this.picture_board.BackColor = System.Drawing.Color.White;
            this.picture_board.Image = global::shogi.Properties.Resources.棋盤;
            this.picture_board.Location = new System.Drawing.Point(1, -2);
            this.picture_board.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picture_board.Name = "picture_board";
            this.picture_board.Size = new System.Drawing.Size(1248, 682);
            this.picture_board.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picture_board.TabIndex = 0;
            this.picture_board.TabStop = false;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = global::shogi.Properties.Resources.gyokusho;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(975, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 100);
            this.button1.TabIndex = 1;
            this.button1.Text = "3";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = global::shogi.Properties.Resources.fuhyo;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(1045, 338);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 100);
            this.button2.TabIndex = 2;
            this.button2.Text = "3";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // form_board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1250, 683);
            this.Controls.Add(this.picture_board);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "form_board";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.form_board_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_board)).EndInit();
            this.picture_board.ResumeLayout(false);
            this.picture_board.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

            this.picture_board.Controls.Add(this.button1);
            this.picture_board.Controls.Add(this.button2);

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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}