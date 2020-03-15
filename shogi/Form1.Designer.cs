namespace shogi
{
    partial class menu
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Histroy = new System.Windows.Forms.Button();
            this.lable_title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(75, 214);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(154, 40);
            this.btn_Start.TabIndex = 0;
            this.btn_Start.Text = "switch";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_Histroy
            // 
            this.btn_Histroy.Location = new System.Drawing.Point(75, 296);
            this.btn_Histroy.Name = "btn_Histroy";
            this.btn_Histroy.Size = new System.Drawing.Size(154, 40);
            this.btn_Histroy.TabIndex = 1;
            this.btn_Histroy.Text = "button2";
            this.btn_Histroy.UseVisualStyleBackColor = true;
            // 
            // lable_title
            // 
            this.lable_title.AutoSize = true;
            this.lable_title.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable_title.Location = new System.Drawing.Point(53, 104);
            this.lable_title.Name = "lable_title";
            this.lable_title.Size = new System.Drawing.Size(209, 40);
            this.lable_title.TabIndex = 2;
            this.lable_title.Text = "廢到笑的將棋";
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 396);
            this.Controls.Add(this.lable_title);
            this.Controls.Add(this.btn_Histroy);
            this.Controls.Add(this.btn_Start);
            this.Name = "menu";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_Histroy;
        private System.Windows.Forms.Label lable_title;
    }
}

