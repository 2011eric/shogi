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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(966, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 68);
            this.button1.TabIndex = 0;
            this.button1.Text = "Restart";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // form_board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::shogi.Properties.Resources.棋盤1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1312, 841);
            
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "form_board";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.form_board_Load);
            this.ResumeLayout(false);
            this.Controls.Add(this.button1);

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

        private System.Windows.Forms.Button button1;
    }
}