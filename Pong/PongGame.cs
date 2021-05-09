using System;
using System.Windows.Forms;
using Microsoft.Xna.Framework;

    // This program executes the digital Ping Pong game

    namespace Pong
    {
        enum PaddleState
        {
            Up,
            Down,
            None
        }

        public partial class frmPongGame : Form
        {
            //global variables
            PaddleState LeftPaddle = PaddleState.None;
            PaddleState RightPaddle = PaddleState.None;
            float Speed;
            Vector2 Velocity, Position;
            int Player1 = 0, Player2 = 0;

            public frmPongGame()
            {
                InitializeComponent();
            }

            private void frmPongGame_KeyDown(object sender, KeyEventArgs e)
            {
                //check if paddles should move
                if (e.KeyCode == Keys.W)
                {
                    LeftPaddle = PaddleState.Up;
                }
                else if (e.KeyCode == Keys.S)
                {
                    LeftPaddle = PaddleState.Down;
                }
                else if (e.KeyCode == Keys.Up)
                {
                    RightPaddle = PaddleState.Up;
                }
                else if (e.KeyCode == Keys.Down)
                {
                    RightPaddle = PaddleState.Down;
                }
            }

            private void frmPongGame_KeyUp(object sender, KeyEventArgs e)
            {
                //reset paddle movement
                if (e.KeyCode == Keys.W || e.KeyCode == Keys.S)
                {
                    LeftPaddle = PaddleState.None;
                }
                else if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
                {
                    RightPaddle = PaddleState.None;
                }
                else if (e.KeyCode == Keys.Return)
                {
                    //reset game
                    Reset();
                    lblStart.Visible = false;
                    tmrGame.Enabled = true;
                }
            }

            private void tmrGame_Tick(object sender, EventArgs e)
            {
                //detect if ball hits paddle
                if (picLeftPaddle.Bounds.IntersectsWith(picBall.Bounds) || picRightPaddle.Bounds.IntersectsWith(picBall.Bounds))
                {
                    //set max speed to 11
                    if (Speed < 11)
                    {
                        Velocity.X *= -1.1f;
                    }
                    else
                    {
                        Velocity.X *= -1;
                    }
                }

                //detect if ball hits top or bottom boundary
                if (picBall.Top <= 0 || picBall.Bottom >= ClientSize.Height)
                {
                    Velocity.Y *= -1;
                }

                //check if ball scores
                if (picBall.Left <= 0)
                {
                    Player2++;
                    lblPlayer2.Text = Player2.ToString();
                    Reset();
                }
                else if (picBall.Right >= ClientSize.Width)
                {
                    Player1++;
                    lblPlayer1.Text = Player1.ToString();
                    Reset();
                }

                //move ball
                Position += Velocity;
                picBall.Left = (int)Position.X;
                picBall.Top = (int)Position.Y;

                //move paddles
                if (LeftPaddle == PaddleState.Up)
                {
                    picLeftPaddle.Top -= 5;
                }
                else if (LeftPaddle == PaddleState.Down)
                {
                    picLeftPaddle.Top += 5;
                }
                if (RightPaddle == PaddleState.Up)
                {
                    picRightPaddle.Top -= 5;
                }
                else if (RightPaddle == PaddleState.Down)
                {
                    picRightPaddle.Top += 5;
                }
            }

            private float FindRandomAngle() 
            {
                //generate random angle for ball
                Random RandomAngle = new Random();
                int r = 0;
                while (r % 2 == 0)
                {
                    r = RandomAngle.Next(1, 8);
                }
                float Angle = MathHelper.ToRadians(r * 45);

                return Angle;
            }

            private void Reset()
            {
                float Width = (ClientSize.Width + picBall.Width)/2;
                float Height = (ClientSize.Height + picBall.Height)/2;
                Position = new Vector2(Width,Height);

                //set velocity of ball
                Speed = 5;
                float Angle = FindRandomAngle();
                float Vx = (float)(Speed * Math.Cos(Angle));
                float Vy = (float)(Speed * Math.Sin(Angle));
                Velocity = new Vector2(Vx, Vy);
            }
        }
    }