namespace PinPonOyunum
{
    partial class gameForm
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
            this.playGround = new System.Windows.Forms.Panel();
            this.gameover_Lbl = new System.Windows.Forms.Label();
            this.points_Lbl = new System.Windows.Forms.Label();
            this.score_Lbl = new System.Windows.Forms.Label();
            this.ball = new System.Windows.Forms.PictureBox();
            this.racket = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.joker_lbl = new System.Windows.Forms.Label();
            this.point_joker = new System.Windows.Forms.Label();
            this.playGround.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).BeginInit();
            this.SuspendLayout();
            // 
            // playGround
            // 
            this.playGround.Controls.Add(this.gameover_Lbl);
            this.playGround.Controls.Add(this.point_joker);
            this.playGround.Controls.Add(this.points_Lbl);
            this.playGround.Controls.Add(this.joker_lbl);
            this.playGround.Controls.Add(this.score_Lbl);
            this.playGround.Controls.Add(this.ball);
            this.playGround.Controls.Add(this.racket);
            this.playGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playGround.Location = new System.Drawing.Point(0, 0);
            this.playGround.Name = "playGround";
            this.playGround.Size = new System.Drawing.Size(800, 450);
            this.playGround.TabIndex = 0;
            // 
            // gameover_Lbl
            // 
            this.gameover_Lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gameover_Lbl.Font = new System.Drawing.Font("MV Boli", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameover_Lbl.Location = new System.Drawing.Point(207, 20);
            this.gameover_Lbl.Name = "gameover_Lbl";
            this.gameover_Lbl.Size = new System.Drawing.Size(368, 373);
            this.gameover_Lbl.TabIndex = 4;
            this.gameover_Lbl.Text = "Game Over!\r\n\r\nR-Restart Game\r\n\r\nC-Continue\r\n\r\nEsc-Exit\r\n";
            this.gameover_Lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // points_Lbl
            // 
            this.points_Lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.points_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.points_Lbl.Location = new System.Drawing.Point(125, 32);
            this.points_Lbl.Name = "points_Lbl";
            this.points_Lbl.Size = new System.Drawing.Size(76, 37);
            this.points_Lbl.TabIndex = 3;
            this.points_Lbl.Text = "0";
            this.points_Lbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // score_Lbl
            // 
            this.score_Lbl.AutoSize = true;
            this.score_Lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.score_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.score_Lbl.Location = new System.Drawing.Point(19, 32);
            this.score_Lbl.Name = "score_Lbl";
            this.score_Lbl.Size = new System.Drawing.Size(109, 37);
            this.score_Lbl.TabIndex = 2;
            this.score_Lbl.Text = "Score:";
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Red;
            this.ball.Location = new System.Drawing.Point(369, 363);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(30, 30);
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            // 
            // racket
            // 
            this.racket.BackColor = System.Drawing.Color.Navy;
            this.racket.Location = new System.Drawing.Point(281, 418);
            this.racket.Name = "racket";
            this.racket.Size = new System.Drawing.Size(200, 20);
            this.racket.TabIndex = 0;
            this.racket.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // joker_lbl
            // 
            this.joker_lbl.AutoSize = true;
            this.joker_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.joker_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.joker_lbl.Location = new System.Drawing.Point(19, 84);
            this.joker_lbl.Name = "joker_lbl";
            this.joker_lbl.Size = new System.Drawing.Size(104, 37);
            this.joker_lbl.TabIndex = 2;
            this.joker_lbl.Text = "Joker:";
            // 
            // point_joker
            // 
            this.point_joker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.point_joker.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.point_joker.Location = new System.Drawing.Point(115, 84);
            this.point_joker.Name = "point_joker";
            this.point_joker.Size = new System.Drawing.Size(76, 37);
            this.point_joker.TabIndex = 3;
            this.point_joker.Text = "0";
            this.point_joker.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // gameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.playGround);
            this.Name = "gameForm";
            this.Text = "Ping Pong Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameForm_KeyDown);
            this.playGround.ResumeLayout(false);
            this.playGround.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel playGround;
        private System.Windows.Forms.Label gameover_Lbl;
        private System.Windows.Forms.Label points_Lbl;
        private System.Windows.Forms.Label score_Lbl;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox racket;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label point_joker;
        private System.Windows.Forms.Label joker_lbl;
    }
}

