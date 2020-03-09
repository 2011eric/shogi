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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picture_board = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_board)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::shogi.Properties.Resources.銀;
            this.pictureBox1.Location = new System.Drawing.Point(220, 656);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // picture_board
            // 
            this.picture_board.BackColor = System.Drawing.Color.White;
            this.picture_board.Image = global::shogi.Properties.Resources.棋盤1;
            this.picture_board.Location = new System.Drawing.Point(1, 74);
            this.picture_board.Name = "picture_board";
            this.picture_board.Size = new System.Drawing.Size(670, 670);
            this.picture_board.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picture_board.TabIndex = 0;
            this.picture_board.TabStop = false;
            this.picture_board.Click += new System.EventHandler(this.picture_board_Click);
            // 
            // form_board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(771, 815);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picture_board);
            this.Name = "form_board";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.form_board_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_board)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture_board;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}