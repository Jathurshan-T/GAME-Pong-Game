namespace Pong
{
    partial class frmPongGame
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
            this.components = new System.ComponentModel.Container();
            this.picLeftPaddle = new System.Windows.Forms.PictureBox();
            this.picBall = new System.Windows.Forms.PictureBox();
            this.picRightPaddle = new System.Windows.Forms.PictureBox();
            this.tmrGame = new System.Windows.Forms.Timer(this.components);
            this.lblStart = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLeftPaddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRightPaddle)).BeginInit();
            this.SuspendLayout();
            // 
            // picLeftPaddle
            // 
            this.picLeftPaddle.BackColor = System.Drawing.Color.White;
            this.picLeftPaddle.Location = new System.Drawing.Point(20, 190);
            this.picLeftPaddle.Name = "picLeftPaddle";
            this.picLeftPaddle.Size = new System.Drawing.Size(20, 150);
            this.picLeftPaddle.TabIndex = 0;
            this.picLeftPaddle.TabStop = false;
            // 
            // picBall
            // 
            this.picBall.BackColor = System.Drawing.Color.White;
            this.picBall.Location = new System.Drawing.Point(514, 359);
            this.picBall.Name = "picBall";
            this.picBall.Size = new System.Drawing.Size(20, 20);
            this.picBall.TabIndex = 1;
            this.picBall.TabStop = false;
            // 
            // picRightPaddle
            // 
            this.picRightPaddle.BackColor = System.Drawing.Color.White;
            this.picRightPaddle.Location = new System.Drawing.Point(968, 280);
            this.picRightPaddle.Name = "picRightPaddle";
            this.picRightPaddle.Size = new System.Drawing.Size(20, 150);
            this.picRightPaddle.TabIndex = 2;
            this.picRightPaddle.TabStop = false;
            // 
            // tmrGame
            // 
            this.tmrGame.Interval = 10;
            this.tmrGame.Tick += new System.EventHandler(this.tmrGame_Tick);
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.ForeColor = System.Drawing.Color.White;
            this.lblStart.Location = new System.Drawing.Point(366, 383);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(292, 35);
            this.lblStart.TabIndex = 3;
            this.lblStart.Text = "Press ENTER to Begin";
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer2.Font = new System.Drawing.Font("Microsoft YaHei UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2.ForeColor = System.Drawing.Color.White;
            this.lblPlayer2.Location = new System.Drawing.Point(951, 9);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(45, 50);
            this.lblPlayer2.TabIndex = 4;
            this.lblPlayer2.Text = "0";
            this.lblPlayer2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer1.Font = new System.Drawing.Font("Microsoft YaHei UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1.ForeColor = System.Drawing.Color.White;
            this.lblPlayer1.Location = new System.Drawing.Point(12, 9);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(45, 50);
            this.lblPlayer1.TabIndex = 4;
            this.lblPlayer1.Text = "0";
            this.lblPlayer1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmPongGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1008, 762);
            this.Controls.Add(this.picBall);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.picRightPaddle);
            this.Controls.Add(this.picLeftPaddle);
            this.Name = "frmPongGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pong Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPongGame_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmPongGame_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picLeftPaddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRightPaddle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLeftPaddle;
        private System.Windows.Forms.PictureBox picBall;
        private System.Windows.Forms.PictureBox picRightPaddle;
        private System.Windows.Forms.Timer tmrGame;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.Label lblPlayer1;
    }
}

