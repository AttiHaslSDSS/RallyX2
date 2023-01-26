using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace RallyX
{
    public partial class RallyX : Form
    {
        //Paint
        SolidBrush greenBrush = new SolidBrush(Color.Green);
        SolidBrush redBrush = new SolidBrush(Color.Red);
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        SoundPlayer soundplayer = new SoundPlayer();

        //Movement established
        bool leftDown = false;
        bool rightDown = false;
        bool downDown = false;
        bool upDown = false;
        bool aDown = false;
        bool dDown = false;
        bool sDown = false;
        bool wDown = false;

        // Establish the point system
        int car1points = 0;
        int car2points = 0;

        //Create the automobiles
        Rectangle car1b1 = new Rectangle(3, 15, 5, 5);
        Rectangle car1s1 = new Rectangle(3, 20, 5, 5);
        Rectangle car1b2 = new Rectangle(3, 10, 5, 5);
        Rectangle car1s2 = new Rectangle(3, 25, 5, 5);
        Rectangle car2b1 = new Rectangle(3, 60, 5, 5);
        Rectangle car2s1 = new Rectangle(3, 65, 5, 5);
        Rectangle car2b2 = new Rectangle(3, 55, 5, 5);
        Rectangle car2s2 = new Rectangle(3, 70, 5, 5);

        //Establish car speed
        int car1b1speed = 5;
        int car2b1speed = 5;
        int car1b2speed = 5;
        int car2b2speed = 5;
        int car1s1speed = 5;
        int car2s1speed = 5;
        int car1s2speed = 5;
        int car2s2speed = 5;

        public RallyX()
        {
        }

        public RallyX(IContainer components)
        {
            this.components = components;
        }

        private void InitializeComponent(object sender, EventArgs e)
        {
            this.components = new System.ComponentModel.Container();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            // 
            // RallyX
            // 
            this.ClientSize = new System.Drawing.Size(596, 395);
            this.Name = "RallyX";
            this.ResumeLayout(false);

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //Enable movement when key is down
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftDown = true;
                    break;
                case Keys.Right:
                    rightDown = true;
                    break;
                case Keys.Down:
                    downDown = true;
                    break;
                case Keys.Up:
                    upDown = true;
                    break;

                case Keys.A:
                    aDown = true;
                    break;
                case Keys.D:
                    dDown = true;
                    break;
                case Keys.S:
                    sDown = true;
                    break;
                case Keys.W:
                    wDown = true;
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            //Establish movement, set to false
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftDown = false;
                    break;
                case Keys.Right:
                    rightDown = false;
                    break;
                case Keys.Down:
                    downDown = false;
                    break;
                case Keys.Up:
                    upDown = false;
                    break;

                case Keys.A:
                    aDown = false;
                    break;
                case Keys.D:
                    dDown = false;
                    break;
                case Keys.S:
                    sDown = false;
                    break;
                case Keys.W:
                    wDown = false;
                    break;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //Paint the automobiles
            e.Graphics.FillRectangle(redBrush, car2b1);
            e.Graphics.FillRectangle(redBrush, car2b2);
            e.Graphics.FillRectangle(redBrush, car2s2);
            e.Graphics.FillRectangle(redBrush, car2s1);
            e.Graphics.FillRectangle(greenBrush, car1b1);
            e.Graphics.FillRectangle(greenBrush, car1b2);
            e.Graphics.FillRectangle(greenBrush, car1s1);
            e.Graphics.FillRectangle(greenBrush, car1s2);

        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //left for  car1 
            if (leftDown == true && car1b1.X > 5)
            {
                car1b1.X -= car1b1speed;
            }
            if (leftDown == true && car1s1.X > 5)
            {
                car1s1.X -= car1s1speed;
            }
            if (leftDown == true && car1b2.X > 5)
            {
                car1b2.X -= car1b2speed;
            }
            if (leftDown == true && car1s1.X > 5)
            {
                car1s2.X -= car1s2speed;
            }
            //right for car1
            if (rightDown == true && car1b1.X < this.Width - car1b1.Width)
            {
                car1b1.X += car1b1speed;
            }
            if (rightDown == true && car1s1.X < this.Width - car1s1.Width)
            {
                car1s1.X += car1s1speed;
            }
            if (rightDown == true && car1b2.X < this.Width - car1b2.Width)
            {
                car1b2.X += car1b2speed;
            }
            if (rightDown == true && car1s1.X < this.Width - car1s1.Width)
            {
                car1s1.X += car1s1speed;
            }
            //down for car1
            if (downDown == true && car1b1.Y > 5)
            {
                car1b1.Y += car1b1speed;
            }
            if (downDown == true && car1b1.Y > 5)
            {
                car1s1.X += car1s1speed;
            }
            if (downDown == true && car1b1.Y > 5)
            {
                car1b2.X += car1b2speed;
            }
            if (downDown == true && car1b1.Y > 5)
            {
                car1s2.X += car1s2speed;
            }
            //up for car1
            if (upDown == true && car1b1.Y > 5)
            {
                car1b1.Y -= car1b1speed;
            }
            if (upDown == true && car1s1.Y > 5)
            {
                car1s1.Y -= car1s1speed;
            }
            if (upDown == true && car1b2.Y > 5)
            {
                car1b2.Y -= car1b2speed;
            }
            if (upDown == true && car1s2.Y > 5)
            {
                car1s2.Y -= car1s2speed;
            }

            //a for  car2
            if (aDown == true && car2b1.X > 5)
            {
                car2b1.X -= car2b1speed;
            }
            if (aDown == true && car2b2.X > 5)
            {
                car2b2.X -= car2b2speed;
            }
            if (aDown == true && car2s1.X > 5)
            {
                car2s1.X -= car1s1speed;
            }
            if (aDown == true && car2s2.X > 5)
            {
                car2s2.X -= car2s2speed;
            }
            //d for car2
            if (dDown == true && car2b1.X < this.Width - car2b2.Width)
            {
                car2b1.X += car2b1speed;
            }
            if (dDown == true && car2b2.X < this.Width - car2b2.Width)
            {
                car2b2.X += car2b2speed;
            }
            if (dDown == true && car2s1.X < this.Width - car2b2.Width)
            {
                car2s1.X += car2s1speed;
            }
            if (dDown == true && car2s2.X < this.Width - car2b2.Width)
            {
                car2s2.X += car2s2speed;
            }
            //s for car2
            if (sDown == true && car2b1.Y > 5)
            {
                car2b1.Y -= car2b1speed;
            }
            if (sDown == true && car2b2.Y > 5)
            {
                car2b2.Y -= car2b2speed;
            }
            if (sDown == true && car2s1.Y > 5)
            {
                car2s1.Y -= car1s1speed;
            }
            if (sDown == true && car2s2.Y > 5)
            {
                car2s2.Y -= car2s2speed;
            }
            //w for car2
            if (wDown == true && car2b1.Y < this.Width - car2b2.Width)
            {
                car2b1.Y += car2b1speed;
            }
            if (wDown == true && car2b2.Y < this.Width - car2b2.Width)
            {
                car2b2.Y += car2b2speed;
            }
            if (wDown == true && car2s1.Y < this.Width - car2b2.Width)
            {
                car2s1.Y += car2s1speed;
            }
            if (wDown == true && car2s2.Y < this.Width - car2b2.Width)
            {
                car2s2.Y += car2s2speed;
            }



            //Car1 Crashes (Victor)

            // If car1 crashes into car2 bumper 2
            if (car1b1.IntersectsWith(car2b2))
            {
                car1points++;
                //reverse a for  car2
                if (aDown == true && car2b1.X > 5)
                {
                    car2b1.X += car2b1speed;
                }
                if (aDown == true && car2b2.X > 5)
                {
                    car2b2.X += car2b2speed;
                }
                if (aDown == true && car2s1.X > 5)
                {
                    car2s1.X += car1s1speed;
                }
                if (aDown == true && car2s2.X > 5)
                {
                    car2s2.X += car2s2speed;
                }
                //reverse d for car2
                if (dDown == true && car2b1.X < this.Width - car2b2.Width)
                {
                    car2b1.X -= car2b1speed;
                }
                if (dDown == true && car2b2.X < this.Width - car2b2.Width)
                {
                    car2b2.X -= car2b2speed;
                }
                if (dDown == true && car2s1.X < this.Width - car2b2.Width)
                {
                    car2s1.X -= car2s1speed;
                }
                if (dDown == true && car2s2.X < this.Width - car2b2.Width)
                {
                    car2s2.X -= car2s2speed;
                }
                //reverse s for car2
                if (sDown == true && car2b1.Y > 5)
                {
                    car2b1.Y += car2b1speed;
                }
                if (sDown == true && car2b2.Y > 5)
                {
                    car2b2.Y += car2b2speed;
                }
                if (sDown == true && car2s1.Y > 5)
                {
                    car2s1.Y += car1s1speed;
                }
                if (sDown == true && car2s2.Y > 5)
                {
                    car2s2.Y += car2s2speed;
                }
                //reverse w for car2
                if (wDown == true && car2b1.Y < this.Width - car2b2.Width)
                {
                    car2b1.Y -= car2b1speed;
                }
                if (wDown == true && car2b2.Y < this.Width - car2b2.Width)
                {
                    car2b2.Y -= car2b2speed;
                }
                if (wDown == true && car2s1.Y < this.Width - car2b2.Width)
                {
                    car2s1.Y -= car2s1speed;
                }
                if (wDown == true && car2s2.Y < this.Width - car2b2.Width)
                {
                    car2s2.Y -= car2s2speed;
                }
            }
            // If car1 crashes into car1 side 1
            if (car1b1.IntersectsWith(car2s1))
            {
                car1points++;
                //reverse a for  car2
                if (aDown == true && car2b1.X > 5)
                {
                    car2b1.X += car2b1speed;
                }
                if (aDown == true && car2b2.X > 5)
                {
                    car2b2.X += car2b2speed;
                }
                if (aDown == true && car2s1.X > 5)
                {
                    car2s1.X += car1s1speed;
                }
                if (aDown == true && car2s2.X > 5)
                {
                    car2s2.X += car2s2speed;
                }
                //reverse d for car2
                if (dDown == true && car2b1.X < this.Width - car2b2.Width)
                {
                    car2b1.X -= car2b1speed;
                }
                if (dDown == true && car2b2.X < this.Width - car2b2.Width)
                {
                    car2b2.X -= car2b2speed;
                }
                if (dDown == true && car2s1.X < this.Width - car2b2.Width)
                {
                    car2s1.X -= car2s1speed;
                }
                if (dDown == true && car2s2.X < this.Width - car2b2.Width)
                {
                    car2s2.X -= car2s2speed;
                }
                //reverse s for car2
                if (sDown == true && car2b1.Y > 5)
                {
                    car2b1.Y += car2b1speed;
                }
                if (sDown == true && car2b2.Y > 5)
                {
                    car2b2.Y += car2b2speed;
                }
                if (sDown == true && car2s1.Y > 5)
                {
                    car2s1.Y += car1s1speed;
                }
                if (sDown == true && car2s2.Y > 5)
                {
                    car2s2.Y += car2s2speed;
                }
                //reverse w for car2
                if (wDown == true && car2b1.Y < this.Width - car2b2.Width)
                {
                    car2b1.Y -= car2b1speed;
                }
                if (wDown == true && car2b2.Y < this.Width - car2b2.Width)
                {
                    car2b2.Y -= car2b2speed;
                }
                if (wDown == true && car2s1.Y < this.Width - car2b2.Width)
                {
                    car2s1.Y -= car2s1speed;
                }
                if (wDown == true && car2s2.Y < this.Width - car2b2.Width)
                {
                    car2s2.Y -= car2s2speed;
                }
            }
            // If car1 crashes into car2 side 2
            if (car1b1.IntersectsWith(car2s2))
            {
                car1points++;
                //reverse a for  car2
                if (aDown == true && car2b1.X > 5)
                {
                    car2b1.X += car2b1speed;
                }
                if (aDown == true && car2b2.X > 5)
                {
                    car2b2.X += car2b2speed;
                }
                if (aDown == true && car2s1.X > 5)
                {
                    car2s1.X += car1s1speed;
                }
                if (aDown == true && car2s2.X > 5)
                {
                    car2s2.X += car2s2speed;
                }
                //reverse d for car2
                if (dDown == true && car2b1.X < this.Width - car2b2.Width)
                {
                    car2b1.X -= car2b1speed;
                }
                if (dDown == true && car2b2.X < this.Width - car2b2.Width)
                {
                    car2b2.X -= car2b2speed;
                }
                if (dDown == true && car2s1.X < this.Width - car2b2.Width)
                {
                    car2s1.X -= car2s1speed;
                }
                if (dDown == true && car2s2.X < this.Width - car2b2.Width)
                {
                    car2s2.X -= car2s2speed;
                }
                //reverse s for car2
                if (sDown == true && car2b1.Y > 5)
                {
                    car2b1.Y += car2b1speed;
                }
                if (sDown == true && car2b2.Y > 5)
                {
                    car2b2.Y += car2b2speed;
                }
                if (sDown == true && car2s1.Y > 5)
                {
                    car2s1.Y += car1s1speed;
                }
                if (sDown == true && car2s2.Y > 5)
                {
                    car2s2.Y += car2s2speed;
                }
                //reverse w for car2
                if (wDown == true && car2b1.Y < this.Width - car2b2.Width)
                {
                    car2b1.Y -= car2b1speed;
                }
                if (wDown == true && car2b2.Y < this.Width - car2b2.Width)
                {
                    car2b2.Y -= car2b2speed;
                }
                if (wDown == true && car2s1.Y < this.Width - car2b2.Width)
                {
                    car2s1.Y -= car2s1speed;
                }
                if (wDown == true && car2s2.Y < this.Width - car2b2.Width)
                {
                    car2s2.Y -= car2s2speed;
                }
            }

            //Car2 Crashes (Victor)

            // If car2 crashes into car1 bumper2
            if (car2b1.IntersectsWith(car1b2))
            {
                car2points++;
                //reverse left for car1
                if (leftDown == true && car1b1.X > 5)
                {
                    car1b1.X += car1b1speed;
                }
                if (leftDown == true && car1s1.X > 5)
                {
                    car1s1.X += car1s1speed;
                }
                if (leftDown == true && car1b2.X > 5)
                {
                    car1b2.X += car1b2speed;
                }
                if (leftDown == true && car1s1.X > 5)
                {
                    car1s2.X += car1s2speed;
                }
                //reverse right for car1
                if (rightDown == true && car1b1.X < this.Width - car1b1.Width)
                {
                    car1b1.X -= car1b1speed;
                }
                if (rightDown == true && car1s1.X < this.Width - car1s1.Width)
                {
                    car1s1.X -= car1s1speed;
                }
                if (rightDown == true && car1b2.X < this.Width - car1b2.Width)
                {
                    car1b2.X -= car1b2speed;
                }
                if (rightDown == true && car1s1.X < this.Width - car1s1.Width)
                {
                    car1s1.X -= car1s1speed;
                }
                //reverse down for car1
                if (downDown == true && car1b1.Y > 5)
                {
                    car1b1.Y += car1b1speed;
                }
                if (downDown == true && car1b1.Y > 5)
                {
                    car1s1.X += car1s1speed;
                }
                if (downDown == true && car1b1.Y > 5)
                {
                    car1b2.X += car1b2speed;
                }
                if (downDown == true && car1b1.Y > 5)
                {
                    car1s2.X += car1s2speed;
                }
                //reverse up for car1
                if (upDown == true && car1b1.Y > 5)
                {
                    car1b1.Y -= car1b1speed;
                }
                if (upDown == true && car1s1.Y > 5)
                {
                    car1s1.Y -= car1s1speed;
                }
                if (upDown == true && car1b2.Y > 5)
                {
                    car1b2.Y -= car1b2speed;
                }
                if (upDown == true && car1s2.Y > 5)
                {
                    car1s2.Y -= car1s2speed;
                }
            }
            // If car2 crashes into car1 side1 
            if (car2b1.IntersectsWith(car1s1))
            {
                car2points++;
                //reverse left for car1
                if (leftDown == true && car1b1.X > 5)
                {
                    car1b1.X += car1b1speed;
                }
                if (leftDown == true && car1s1.X > 5)
                {
                    car1s1.X += car1s1speed;
                }
                if (leftDown == true && car1b2.X > 5)
                {
                    car1b2.X += car1b2speed;
                }
                if (leftDown == true && car1s1.X > 5)
                {
                    car1s2.X += car1s2speed;
                }
                //reverse right for car1
                if (rightDown == true && car1b1.X < this.Width - car1b1.Width)
                {
                    car1b1.X -= car1b1speed;
                }
                if (rightDown == true && car1s1.X < this.Width - car1s1.Width)
                {
                    car1s1.X -= car1s1speed;
                }
                if (rightDown == true && car1b2.X < this.Width - car1b2.Width)
                {
                    car1b2.X -= car1b2speed;
                }
                if (rightDown == true && car1s1.X < this.Width - car1s1.Width)
                {
                    car1s1.X -= car1s1speed;
                }
                //reverse down for car1
                if (downDown == true && car1b1.Y > 5)
                {
                    car1b1.Y += car1b1speed;
                }
                if (downDown == true && car1b1.Y > 5)
                {
                    car1s1.X += car1s1speed;
                }
                if (downDown == true && car1b1.Y > 5)
                {
                    car1b2.X += car1b2speed;
                }
                if (downDown == true && car1b1.Y > 5)
                {
                    car1s2.X += car1s2speed;
                }
                //reverse up for car1
                if (upDown == true && car1b1.Y > 5)
                {
                    car1b1.Y -= car1b1speed;
                }
                if (upDown == true && car1s1.Y > 5)
                {
                    car1s1.Y -= car1s1speed;
                }
                if (upDown == true && car1b2.Y > 5)
                {
                    car1b2.Y -= car1b2speed;
                }
                if (upDown == true && car1s2.Y > 5)
                {
                    car1s2.Y -= car1s2speed;
                }
            }
            // If car2 crashes into car1 side2
            if (car2b1.IntersectsWith(car1s2))
            {
                car2points++;
                //reverse left for car1
                if (leftDown == true && car1b1.X > 5)
                {
                    car1b1.X += car1b1speed;
                }
                if (leftDown == true && car1s1.X > 5)
                {
                    car1s1.X += car1s1speed;
                }
                if (leftDown == true && car1b2.X > 5)
                {
                    car1b2.X += car1b2speed;
                }
                if (leftDown == true && car1s1.X > 5)
                {
                    car1s2.X += car1s2speed;
                }
                //reverse right for car1
                if (rightDown == true && car1b1.X < this.Width - car1b1.Width)
                {
                    car1b1.X -= car1b1speed;
                }
                if (rightDown == true && car1s1.X < this.Width - car1s1.Width)
                {
                    car1s1.X -= car1s1speed;
                }
                if (rightDown == true && car1b2.X < this.Width - car1b2.Width)
                {
                    car1b2.X -= car1b2speed;
                }
                if (rightDown == true && car1s1.X < this.Width - car1s1.Width)
                {
                    car1s1.X -= car1s1speed;
                }
                //reverse down for car1
                if (downDown == true && car1b1.Y > 5)
                {
                    car1b1.Y += car1b1speed;
                }
                if (downDown == true && car1b1.Y > 5)
                {
                    car1s1.X += car1s1speed;
                }
                if (downDown == true && car1b1.Y > 5)
                {
                    car1b2.X += car1b2speed;
                }
                if (downDown == true && car1b1.Y > 5)
                {
                    car1s2.X += car1s2speed;
                }
                //reverse up for car1
                if (upDown == true && car1b1.Y > 5)
                {
                    car1b1.Y -= car1b1speed;
                }
                if (upDown == true && car1s1.Y > 5)
                {
                    car1s1.Y -= car1s1speed;
                }
                if (upDown == true && car1b2.Y > 5)
                {
                    car1b2.Y -= car1b2speed;
                }
                if (upDown == true && car1s2.Y > 5)
                {
                    car1s2.Y -= car1s2speed;
                }
            }

            //Side Collisions

            // If car2 side1 crashes into car1 side1 
            if (car2s1.IntersectsWith(car1s1))
            {
                //reverse left for car1
                if (leftDown == true && car1b1.X > 5)
                {
                    car1b1.X += car1b1speed;
                }
                if (leftDown == true && car1s1.X > 5)
                {
                    car1s1.X += car1s1speed;
                }
                if (leftDown == true && car1b2.X > 5)
                {
                    car1b2.X += car1b2speed;
                }
                if (leftDown == true && car1s1.X > 5)
                {
                    car1s2.X += car1s2speed;
                }
                //reverse right for car1
                if (rightDown == true && car1b1.X < this.Width - car1b1.Width)
                {
                    car1b1.X -= car1b1speed;
                }
                if (rightDown == true && car1s1.X < this.Width - car1s1.Width)
                {
                    car1s1.X -= car1s1speed;
                }
                if (rightDown == true && car1b2.X < this.Width - car1b2.Width)
                {
                    car1b2.X -= car1b2speed;
                }
                if (rightDown == true && car1s1.X < this.Width - car1s1.Width)
                {
                    car1s1.X -= car1s1speed;
                }
                //reverse down for car1
                if (downDown == true && car1b1.Y > 5)
                {
                    car1b1.Y += car1b1speed;
                }
                if (downDown == true && car1b1.Y > 5)
                {
                    car1s1.X += car1s1speed;
                }
                if (downDown == true && car1b1.Y > 5)
                {
                    car1b2.X += car1b2speed;
                }
                if (downDown == true && car1b1.Y > 5)
                {
                    car1s2.X += car1s2speed;
                }
                //reverse up for car1
                if (upDown == true && car1b1.Y > 5)
                {
                    car1b1.Y -= car1b1speed;
                }
                if (upDown == true && car1s1.Y > 5)
                {
                    car1s1.Y -= car1s1speed;
                }
                if (upDown == true && car1b2.Y > 5)
                {
                    car1b2.Y -= car1b2speed;
                }
                if (upDown == true && car1s2.Y > 5)
                {
                    car1s2.Y -= car1s2speed;
                }
            }
            // If car2 side2 crashes into car1 side2
            if (car2s2.IntersectsWith(car1s2))
            {

                {
                    //reverse left for  car1 
                    if (leftDown == true && car1b1.X > 5)
                    {
                        car1b1.X += car1b1speed;
                    }
                    if (leftDown == true && car1s1.X > 5)
                    {
                        car1s1.X += car1s1speed;
                    }
                    if (leftDown == true && car1b2.X > 5)
                    {
                        car1b2.X += car1b2speed;
                    }
                    if (leftDown == true && car1s1.X > 5)
                    {
                        car1s2.X += car1s2speed;
                    }
                    //reverse right for car1
                    if (rightDown == true && car1b1.X < this.Width - car1b1.Width)
                    {
                        car1b1.X -= car1b1speed;
                    }
                    if (rightDown == true && car1s1.X < this.Width - car1s1.Width)
                    {
                        car1s1.X -= car1s1speed;
                    }
                    if (rightDown == true && car1b2.X < this.Width - car1b2.Width)
                    {
                        car1b2.X -= car1b2speed;
                    }
                    if (rightDown == true && car1s1.X < this.Width - car1s1.Width)
                    {
                        car1s1.X -= car1s1speed;
                    }
                    //reverse down for car1
                    if (downDown == true && car1b1.Y > 5)
                    {
                        car1b1.Y += car1b1speed;
                    }
                    if (downDown == true && car1b1.Y > 5)
                    {
                        car1s1.X += car1s1speed;
                    }
                    if (downDown == true && car1b1.Y > 5)
                    {
                        car1b2.X += car1b2speed;
                    }
                    if (downDown == true && car1b1.Y > 5)
                    {
                        car1s2.X += car1s2speed;
                    }
                    //reverse up for car1
                    if (upDown == true && car1b1.Y > 5)
                    {
                        car1b1.Y -= car1b1speed;
                    }
                    if (upDown == true && car1s1.Y > 5)
                    {
                        car1s1.Y -= car1s1speed;
                    }
                    if (upDown == true && car1b2.Y > 5)
                    {
                        car1b2.Y -= car1b2speed;
                    }
                    if (upDown == true && car1s2.Y > 5)
                    {
                        car1s2.Y -= car1s2speed;
                    }

                    //reverse a for  car2
                    if (aDown == true && car2b1.X > 5)
                    {
                        car2b1.X += car2b1speed;
                    }
                    if (aDown == true && car2b2.X > 5)
                    {
                        car2b2.X += car2b2speed;
                    }
                    if (aDown == true && car2s1.X > 5)
                    {
                        car2s1.X += car1s1speed;
                    }
                    if (aDown == true && car2s2.X > 5)
                    {
                        car2s2.X += car2s2speed;
                    }
                    //reverse d for car2
                    if (dDown == true && car2b1.X < this.Width - car2b2.Width)
                    {
                        car2b1.X -= car2b1speed;
                    }
                    if (dDown == true && car2b2.X < this.Width - car2b2.Width)
                    {
                        car2b2.X -= car2b2speed;
                    }
                    if (dDown == true && car2s1.X < this.Width - car2b2.Width)
                    {
                        car2s1.X -= car2s1speed;
                    }
                    if (dDown == true && car2s2.X < this.Width - car2b2.Width)
                    {
                        car2s2.X -= car2s2speed;
                    }
                    //reverse s for car2
                    if (sDown == true && car2b1.Y > 5)
                    {
                        car2b1.Y += car2b1speed;
                    }
                    if (sDown == true && car2b2.Y > 5)
                    {
                        car2b2.Y += car2b2speed;
                    }
                    if (sDown == true && car2s1.Y > 5)
                    {
                        car2s1.Y += car1s1speed;
                    }
                    if (sDown == true && car2s2.Y > 5)
                    {
                        car2s2.Y += car2s2speed;
                    }
                    //reverse w for car2
                    if (wDown == true && car2b1.Y < this.Width - car2b2.Width)
                    {
                        car2b1.Y -= car2b1speed;
                    }
                    if (wDown == true && car2b2.Y < this.Width - car2b2.Width)
                    {
                        car2b2.Y -= car2b2speed;
                    }
                    if (wDown == true && car2s1.Y < this.Width - car2b2.Width)
                    {
                        car2s1.Y -= car2s1speed;
                    }
                    if (wDown == true && car2s2.Y < this.Width - car2b2.Width)
                    {
                        car2s2.Y -= car2s2speed;
                    }
                }
            }
            // If car2 side1 crashes into car1 side2
            if (car2s1.IntersectsWith(car1s2))

            {

                {
                    //reverse left for  car1 
                    if (leftDown == true && car1b1.X > 5)
                    {
                        car1b1.X += car1b1speed;
                    }
                    if (leftDown == true && car1s1.X > 5)
                    {
                        car1s1.X += car1s1speed;
                    }
                    if (leftDown == true && car1b2.X > 5)
                    {
                        car1b2.X += car1b2speed;
                    }
                    if (leftDown == true && car1s1.X > 5)
                    {
                        car1s2.X += car1s2speed;
                    }
                    //reverse right for car1
                    if (rightDown == true && car1b1.X < this.Width - car1b1.Width)
                    {
                        car1b1.X -= car1b1speed;
                    }
                    if (rightDown == true && car1s1.X < this.Width - car1s1.Width)
                    {
                        car1s1.X -= car1s1speed;
                    }
                    if (rightDown == true && car1b2.X < this.Width - car1b2.Width)
                    {
                        car1b2.X -= car1b2speed;
                    }
                    if (rightDown == true && car1s1.X < this.Width - car1s1.Width)
                    {
                        car1s1.X -= car1s1speed;
                    }
                    //reverse down for car1
                    if (downDown == true && car1b1.Y > 5)
                    {
                        car1b1.Y += car1b1speed;
                    }
                    if (downDown == true && car1b1.Y > 5)
                    {
                        car1s1.X += car1s1speed;
                    }
                    if (downDown == true && car1b1.Y > 5)
                    {
                        car1b2.X += car1b2speed;
                    }
                    if (downDown == true && car1b1.Y > 5)
                    {
                        car1s2.X += car1s2speed;
                    }
                    //reverse up for car1
                    if (upDown == true && car1b1.Y > 5)
                    {
                        car1b1.Y -= car1b1speed;
                    }
                    if (upDown == true && car1s1.Y > 5)
                    {
                        car1s1.Y -= car1s1speed;
                    }
                    if (upDown == true && car1b2.Y > 5)
                    {
                        car1b2.Y -= car1b2speed;
                    }
                    if (upDown == true && car1s2.Y > 5)
                    {
                        car1s2.Y -= car1s2speed;
                    }

                    //reverse a for  car2
                    if (aDown == true && car2b1.X > 5)
                    {
                        car2b1.X += car2b1speed;
                    }
                    if (aDown == true && car2b2.X > 5)
                    {
                        car2b2.X += car2b2speed;
                    }
                    if (aDown == true && car2s1.X > 5)
                    {
                        car2s1.X += car1s1speed;
                    }
                    if (aDown == true && car2s2.X > 5)
                    {
                        car2s2.X += car2s2speed;
                    }
                    //reverse d for car2
                    if (dDown == true && car2b1.X < this.Width - car2b2.Width)
                    {
                        car2b1.X -= car2b1speed;
                    }
                    if (dDown == true && car2b2.X < this.Width - car2b2.Width)
                    {
                        car2b2.X -= car2b2speed;
                    }
                    if (dDown == true && car2s1.X < this.Width - car2b2.Width)
                    {
                        car2s1.X -= car2s1speed;
                    }
                    if (dDown == true && car2s2.X < this.Width - car2b2.Width)
                    {
                        car2s2.X -= car2s2speed;
                    }
                    //reverse s for car2
                    if (sDown == true && car2b1.Y > 5)
                    {
                        car2b1.Y += car2b1speed;
                    }
                    if (sDown == true && car2b2.Y > 5)
                    {
                        car2b2.Y += car2b2speed;
                    }
                    if (sDown == true && car2s1.Y > 5)
                    {
                        car2s1.Y += car1s1speed;
                    }
                    if (sDown == true && car2s2.Y > 5)
                    {
                        car2s2.Y += car2s2speed;
                    }
                    //reverse w for car2
                    if (wDown == true && car2b1.Y < this.Width - car2b2.Width)
                    {
                        car2b1.Y -= car2b1speed;
                    }
                    if (wDown == true && car2b2.Y < this.Width - car2b2.Width)
                    {
                        car2b2.Y -= car2b2speed;
                    }
                    if (wDown == true && car2s1.Y < this.Width - car2b2.Width)
                    {
                        car2s1.Y -= car2s1speed;
                    }
                    if (wDown == true && car2s2.Y < this.Width - car2b2.Width)
                    {
                        car2s2.Y -= car2s2speed;
                    }
                }
            }
            // If car2 side2 crashes into car1 side1
            if (car2s1.IntersectsWith(car1s1))
            {

                {
                    //reverse left for  car1 
                    if (leftDown == true && car1b1.X > 5)
                    {
                        car1b1.X += car1b1speed;
                    }
                    if (leftDown == true && car1s1.X > 5)
                    {
                        car1s1.X += car1s1speed;
                    }
                    if (leftDown == true && car1b2.X > 5)
                    {
                        car1b2.X += car1b2speed;
                    }
                    if (leftDown == true && car1s1.X > 5)
                    {
                        car1s2.X += car1s2speed;
                    }
                    //reverse right for car1
                    if (rightDown == true && car1b1.X < this.Width - car1b1.Width)
                    {
                        car1b1.X -= car1b1speed;
                    }
                    if (rightDown == true && car1s1.X < this.Width - car1s1.Width)
                    {
                        car1s1.X -= car1s1speed;
                    }
                    if (rightDown == true && car1b2.X < this.Width - car1b2.Width)
                    {
                        car1b2.X -= car1b2speed;
                    }
                    if (rightDown == true && car1s1.X < this.Width - car1s1.Width)
                    {
                        car1s1.X -= car1s1speed;
                    }
                    //reverse down for car1
                    if (downDown == true && car1b1.Y > 5)
                    {
                        car1b1.Y += car1b1speed;
                    }
                    if (downDown == true && car1b1.Y > 5)
                    {
                        car1s1.X += car1s1speed;
                    }
                    if (downDown == true && car1b1.Y > 5)
                    {
                        car1b2.X += car1b2speed;
                    }
                    if (downDown == true && car1b1.Y > 5)
                    {
                        car1s2.X += car1s2speed;
                    }
                    //reverse up for car1
                    if (upDown == true && car1b1.Y > 5)
                    {
                        car1b1.Y -= car1b1speed;
                    }
                    if (upDown == true && car1s1.Y > 5)
                    {
                        car1s1.Y -= car1s1speed;
                    }
                    if (upDown == true && car1b2.Y > 5)
                    {
                        car1b2.Y -= car1b2speed;
                    }
                    if (upDown == true && car1s2.Y > 5)
                    {
                        car1s2.Y -= car1s2speed;
                    }

                    //reverse a for  car2
                    if (aDown == true && car2b1.X > 5)
                    {
                        car2b1.X += car2b1speed;
                    }
                    if (aDown == true && car2b2.X > 5)
                    {
                        car2b2.X += car2b2speed;
                    }
                    if (aDown == true && car2s1.X > 5)
                    {
                        car2s1.X += car1s1speed;
                    }
                    if (aDown == true && car2s2.X > 5)
                    {
                        car2s2.X += car2s2speed;
                    }
                    //reverse d for car2
                    if (dDown == true && car2b1.X < this.Width - car2b2.Width)
                    {
                        car2b1.X -= car2b1speed;
                    }
                    if (dDown == true && car2b2.X < this.Width - car2b2.Width)
                    {
                        car2b2.X -= car2b2speed;
                    }
                    if (dDown == true && car2s1.X < this.Width - car2b2.Width)
                    {
                        car2s1.X -= car2s1speed;
                    }
                    if (dDown == true && car2s2.X < this.Width - car2b2.Width)
                    {
                        car2s2.X -= car2s2speed;
                    }
                    //reverse s for car2
                    if (sDown == true && car2b1.Y > 5)
                    {
                        car2b1.Y += car2b1speed;
                    }
                    if (sDown == true && car2b2.Y > 5)
                    {
                        car2b2.Y += car2b2speed;
                    }
                    if (sDown == true && car2s1.Y > 5)
                    {
                        car2s1.Y += car1s1speed;
                    }
                    if (sDown == true && car2s2.Y > 5)
                    {
                        car2s2.Y += car2s2speed;
                    }
                    //reverse w for car2
                    if (wDown == true && car2b1.Y < this.Width - car2b2.Width)
                    {
                        car2b1.Y -= car2b1speed;
                    }
                    if (wDown == true && car2b2.Y < this.Width - car2b2.Width)
                    {
                        car2b2.Y -= car2b2speed;
                    }
                    if (wDown == true && car2s1.Y < this.Width - car2b2.Width)
                    {
                        car2s1.Y -= car2s1speed;
                    }
                    if (wDown == true && car2s2.Y < this.Width - car2b2.Width)
                    {
                        car2s2.Y -= car2s2speed;
                    }
                }
            }

            //Bumper Collisions

            // If car1 side1 crashes into car2 bumper2
            if (car1b2.IntersectsWith(car2s2))

            {

                {
                    //reverse left for  car1 
                    if (leftDown == true && car1b1.X > 5)
                    {
                        car1b1.X += car1b1speed;
                    }
                    if (leftDown == true && car1s1.X > 5)
                    {
                        car1s1.X += car1s1speed;
                    }
                    if (leftDown == true && car1b2.X > 5)
                    {
                        car1b2.X += car1b2speed;
                    }
                    if (leftDown == true && car1s1.X > 5)
                    {
                        car1s2.X += car1s2speed;
                    }
                    //reverse right for car1
                    if (rightDown == true && car1b1.X < this.Width - car1b1.Width)
                    {
                        car1b1.X -= car1b1speed;
                    }
                    if (rightDown == true && car1s1.X < this.Width - car1s1.Width)
                    {
                        car1s1.X -= car1s1speed;
                    }
                    if (rightDown == true && car1b2.X < this.Width - car1b2.Width)
                    {
                        car1b2.X -= car1b2speed;
                    }
                    if (rightDown == true && car1s1.X < this.Width - car1s1.Width)
                    {
                        car1s1.X -= car1s1speed;
                    }
                    //reverse down for car1
                    if (downDown == true && car1b1.Y > 5)
                    {
                        car1b1.Y += car1b1speed;
                    }
                    if (downDown == true && car1b1.Y > 5)
                    {
                        car1s1.X += car1s1speed;
                    }
                    if (downDown == true && car1b1.Y > 5)
                    {
                        car1b2.X += car1b2speed;
                    }
                    if (downDown == true && car1b1.Y > 5)
                    {
                        car1s2.X += car1s2speed;
                    }
                    //reverse up for car1
                    if (upDown == true && car1b1.Y > 5)
                    {
                        car1b1.Y -= car1b1speed;
                    }
                    if (upDown == true && car1s1.Y > 5)
                    {
                        car1s1.Y -= car1s1speed;
                    }
                    if (upDown == true && car1b2.Y > 5)
                    {
                        car1b2.Y -= car1b2speed;
                    }
                    if (upDown == true && car1s2.Y > 5)
                    {
                        car1s2.Y -= car1s2speed;
                    }

                    //reverse a for  car2
                    if (aDown == true && car2b1.X > 5)
                    {
                        car2b1.X += car2b1speed;
                    }
                    if (aDown == true && car2b2.X > 5)
                    {
                        car2b2.X += car2b2speed;
                    }
                    if (aDown == true && car2s1.X > 5)
                    {
                        car2s1.X += car1s1speed;
                    }
                    if (aDown == true && car2s2.X > 5)
                    {
                        car2s2.X += car2s2speed;
                    }
                    //reverse d for car2
                    if (dDown == true && car2b1.X < this.Width - car2b2.Width)
                    {
                        car2b1.X -= car2b1speed;
                    }
                    if (dDown == true && car2b2.X < this.Width - car2b2.Width)
                    {
                        car2b2.X -= car2b2speed;
                    }
                    if (dDown == true && car2s1.X < this.Width - car2b2.Width)
                    {
                        car2s1.X -= car2s1speed;
                    }
                    if (dDown == true && car2s2.X < this.Width - car2b2.Width)
                    {
                        car2s2.X -= car2s2speed;
                    }
                    //reverse s for car2
                    if (sDown == true && car2b1.Y > 5)
                    {
                        car2b1.Y += car2b1speed;
                    }
                    if (sDown == true && car2b2.Y > 5)
                    {
                        car2b2.Y += car2b2speed;
                    }
                    if (sDown == true && car2s1.Y > 5)
                    {
                        car2s1.Y += car1s1speed;
                    }
                    if (sDown == true && car2s2.Y > 5)
                    {
                        car2s2.Y += car2s2speed;
                    }
                    //reverse w for car2
                    if (wDown == true && car2b1.Y < this.Width - car2b2.Width)
                    {
                        car2b1.Y -= car2b1speed;
                    }
                    if (wDown == true && car2b2.Y < this.Width - car2b2.Width)
                    {
                        car2b2.Y -= car2b2speed;
                    }
                    if (wDown == true && car2s1.Y < this.Width - car2b2.Width)
                    {
                        car2s1.Y -= car2s1speed;
                    }
                    if (wDown == true && car2s2.Y < this.Width - car2b2.Width)
                    {
                        car2s2.Y -= car2s2speed;
                    }
                }
            }
            // If car1 side2 crashes into car2 bumper2
            if (car1b2.IntersectsWith(car2s1))
            {

                {
                    //reverse left for  car1 
                    if (leftDown == true && car1b1.X > 5)
                    {
                        car1b1.X += car1b1speed;
                    }
                    if (leftDown == true && car1s1.X > 5)
                    {
                        car1s1.X += car1s1speed;
                    }
                    if (leftDown == true && car1b2.X > 5)
                    {
                        car1b2.X += car1b2speed;
                    }
                    if (leftDown == true && car1s1.X > 5)
                    {
                        car1s2.X += car1s2speed;
                    }
                    //reverse right for car1
                    if (rightDown == true && car1b1.X < this.Width - car1b1.Width)
                    {
                        car1b1.X -= car1b1speed;
                    }
                    if (rightDown == true && car1s1.X < this.Width - car1s1.Width)
                    {
                        car1s1.X -= car1s1speed;
                    }
                    if (rightDown == true && car1b2.X < this.Width - car1b2.Width)
                    {
                        car1b2.X -= car1b2speed;
                    }
                    if (rightDown == true && car1s1.X < this.Width - car1s1.Width)
                    {
                        car1s1.X -= car1s1speed;
                    }
                    //reverse down for car1
                    if (downDown == true && car1b1.Y > 5)
                    {
                        car1b1.Y += car1b1speed;
                    }
                    if (downDown == true && car1b1.Y > 5)
                    {
                        car1s1.X += car1s1speed;
                    }
                    if (downDown == true && car1b1.Y > 5)
                    {
                        car1b2.X += car1b2speed;
                    }
                    if (downDown == true && car1b1.Y > 5)
                    {
                        car1s2.X += car1s2speed;
                    }
                    //reverse up for car1
                    if (upDown == true && car1b1.Y > 5)
                    {
                        car1b1.Y -= car1b1speed;
                    }
                    if (upDown == true && car1s1.Y > 5)
                    {
                        car1s1.Y -= car1s1speed;
                    }
                    if (upDown == true && car1b2.Y > 5)
                    {
                        car1b2.Y -= car1b2speed;
                    }
                    if (upDown == true && car1s2.Y > 5)
                    {
                        car1s2.Y -= car1s2speed;
                    }

                    //reverse a for  car2
                    if (aDown == true && car2b1.X > 5)
                    {
                        car2b1.X += car2b1speed;
                    }
                    if (aDown == true && car2b2.X > 5)
                    {
                        car2b2.X += car2b2speed;
                    }
                    if (aDown == true && car2s1.X > 5)
                    {
                        car2s1.X += car1s1speed;
                    }
                    if (aDown == true && car2s2.X > 5)
                    {
                        car2s2.X += car2s2speed;
                    }
                    //reverse d for car2
                    if (dDown == true && car2b1.X < this.Width - car2b2.Width)
                    {
                        car2b1.X -= car2b1speed;
                    }
                    if (dDown == true && car2b2.X < this.Width - car2b2.Width)
                    {
                        car2b2.X -= car2b2speed;
                    }
                    if (dDown == true && car2s1.X < this.Width - car2b2.Width)
                    {
                        car2s1.X -= car2s1speed;
                    }
                    if (dDown == true && car2s2.X < this.Width - car2b2.Width)
                    {
                        car2s2.X -= car2s2speed;
                    }
                    //reverse s for car2
                    if (sDown == true && car2b1.Y > 5)
                    {
                        car2b1.Y += car2b1speed;
                    }
                    if (sDown == true && car2b2.Y > 5)
                    {
                        car2b2.Y += car2b2speed;
                    }
                    if (sDown == true && car2s1.Y > 5)
                    {
                        car2s1.Y += car1s1speed;
                    }
                    if (sDown == true && car2s2.Y > 5)
                    {
                        car2s2.Y += car2s2speed;
                    }
                    //reverse w for car2
                    if (wDown == true && car2b1.Y < this.Width - car2b2.Width)
                    {
                        car2b1.Y -= car2b1speed;
                    }
                    if (wDown == true && car2b2.Y < this.Width - car2b2.Width)
                    {
                        car2b2.Y -= car2b2speed;
                    }
                    if (wDown == true && car2s1.Y < this.Width - car2b2.Width)
                    {
                        car2s1.Y -= car2s1speed;
                    }
                    if (wDown == true && car2s2.Y < this.Width - car2b2.Width)
                    {
                        car2s2.Y -= car2s2speed;
                    }
                }
            }
            // If car1 bumper2 crashes into car2 bumper2
            if (car1b2.IntersectsWith(car2b2))
            {

                {
                    //reverse left for  car1 
                    if (leftDown == true && car1b1.X > 5)
                    {
                        car1b1.X += car1b1speed;
                    }
                    if (leftDown == true && car1s1.X > 5)
                    {
                        car1s1.X += car1s1speed;
                    }
                    if (leftDown == true && car1b2.X > 5)
                    {
                        car1b2.X += car1b2speed;
                    }
                    if (leftDown == true && car1s1.X > 5)
                    {
                        car1s2.X += car1s2speed;
                    }
                    //reverse right for car1
                    if (rightDown == true && car1b1.X < this.Width - car1b1.Width)
                    {
                        car1b1.X -= car1b1speed;
                    }
                    if (rightDown == true && car1s1.X < this.Width - car1s1.Width)
                    {
                        car1s1.X -= car1s1speed;
                    }
                    if (rightDown == true && car1b2.X < this.Width - car1b2.Width)
                    {
                        car1b2.X -= car1b2speed;
                    }
                    if (rightDown == true && car1s1.X < this.Width - car1s1.Width)
                    {
                        car1s1.X -= car1s1speed;
                    }
                    //reverse down for car1
                    if (downDown == true && car1b1.Y > 5)
                    {
                        car1b1.Y += car1b1speed;
                    }
                    if (downDown == true && car1b1.Y > 5)
                    {
                        car1s1.X += car1s1speed;
                    }
                    if (downDown == true && car1b1.Y > 5)
                    {
                        car1b2.X += car1b2speed;
                    }
                    if (downDown == true && car1b1.Y > 5)
                    {
                        car1s2.X += car1s2speed;
                    }
                    //reverse up for car1
                    if (upDown == true && car1b1.Y > 5)
                    {
                        car1b1.Y -= car1b1speed;
                    }
                    if (upDown == true && car1s1.Y > 5)
                    {
                        car1s1.Y -= car1s1speed;
                    }
                    if (upDown == true && car1b2.Y > 5)
                    {
                        car1b2.Y -= car1b2speed;
                    }
                    if (upDown == true && car1s2.Y > 5)
                    {
                        car1s2.Y -= car1s2speed;
                    }

                    //reverse a for  car2
                    if (aDown == true && car2b1.X > 5)
                    {
                        car2b1.X += car2b1speed;
                    }
                    if (aDown == true && car2b2.X > 5)
                    {
                        car2b2.X += car2b2speed;
                    }
                    if (aDown == true && car2s1.X > 5)
                    {
                        car2s1.X += car1s1speed;
                    }
                    if (aDown == true && car2s2.X > 5)
                    {
                        car2s2.X += car2s2speed;
                    }
                    //reverse d for car2
                    if (dDown == true && car2b1.X < this.Width - car2b2.Width)
                    {
                        car2b1.X -= car2b1speed;
                    }
                    if (dDown == true && car2b2.X < this.Width - car2b2.Width)
                    {
                        car2b2.X -= car2b2speed;
                    }
                    if (dDown == true && car2s1.X < this.Width - car2b2.Width)
                    {
                        car2s1.X -= car2s1speed;
                    }
                    if (dDown == true && car2s2.X < this.Width - car2b2.Width)
                    {
                        car2s2.X -= car2s2speed;
                    }
                    //reverse s for car2
                    if (sDown == true && car2b1.Y > 5)
                    {
                        car2b1.Y += car2b1speed;
                    }
                    if (sDown == true && car2b2.Y > 5)
                    {
                        car2b2.Y += car2b2speed;
                    }
                    if (sDown == true && car2s1.Y > 5)
                    {
                        car2s1.Y += car1s1speed;
                    }
                    if (sDown == true && car2s2.Y > 5)
                    {
                        car2s2.Y += car2s2speed;
                    }
                    //reverse w for car2
                    if (wDown == true && car2b1.Y < this.Width - car2b2.Width)
                    {
                        car2b1.Y -= car2b1speed;
                    }
                    if (wDown == true && car2b2.Y < this.Width - car2b2.Width)
                    {
                        car2b2.Y -= car2b2speed;
                    }
                    if (wDown == true && car2s1.Y < this.Width - car2b2.Width)
                    {
                        car2s1.Y -= car2s1speed;
                    }
                    if (wDown == true && car2s2.Y < this.Width - car2b2.Width)
                    {
                        car2s2.Y -= car2s2speed;
                    }
                }
            }
            // If car1 side1 crashes into car2 bumper2
            if (car2b2.IntersectsWith(car1s2))

            {

                {
                    //reverse left for  car1 
                    if (leftDown == true && car1b1.X > 5)
                    {
                        car1b1.X += car1b1speed;
                    }
                    if (leftDown == true && car1s1.X > 5)
                    {
                        car1s1.X += car1s1speed;
                    }
                    if (leftDown == true && car1b2.X > 5)
                    {
                        car1b2.X += car1b2speed;
                    }
                    if (leftDown == true && car1s1.X > 5)
                    {
                        car1s2.X += car1s2speed;
                    }
                    //reverse right for car1
                    if (rightDown == true && car1b1.X < this.Width - car1b1.Width)
                    {
                        car1b1.X -= car1b1speed;
                    }
                    if (rightDown == true && car1s1.X < this.Width - car1s1.Width)
                    {
                        car1s1.X -= car1s1speed;
                    }
                    if (rightDown == true && car1b2.X < this.Width - car1b2.Width)
                    {
                        car1b2.X -= car1b2speed;
                    }
                    if (rightDown == true && car1s1.X < this.Width - car1s1.Width)
                    {
                        car1s1.X -= car1s1speed;
                    }
                    //reverse down for car1
                    if (downDown == true && car1b1.Y > 5)
                    {
                        car1b1.Y += car1b1speed;
                    }
                    if (downDown == true && car1b1.Y > 5)
                    {
                        car1s1.X += car1s1speed;
                    }
                    if (downDown == true && car1b1.Y > 5)
                    {
                        car1b2.X += car1b2speed;
                    }
                    if (downDown == true && car1b1.Y > 5)
                    {
                        car1s2.X += car1s2speed;
                    }
                    //reverse up for car1
                    if (upDown == true && car1b1.Y > 5)
                    {
                        car1b1.Y -= car1b1speed;
                    }
                    if (upDown == true && car1s1.Y > 5)
                    {
                        car1s1.Y -= car1s1speed;
                    }
                    if (upDown == true && car1b2.Y > 5)
                    {
                        car1b2.Y -= car1b2speed;
                    }
                    if (upDown == true && car1s2.Y > 5)
                    {
                        car1s2.Y -= car1s2speed;
                    }

                    //reverse a for  car2
                    if (aDown == true && car2b1.X > 5)
                    {
                        car2b1.X += car2b1speed;
                    }
                    if (aDown == true && car2b2.X > 5)
                    {
                        car2b2.X += car2b2speed;
                    }
                    if (aDown == true && car2s1.X > 5)
                    {
                        car2s1.X += car1s1speed;
                    }
                    if (aDown == true && car2s2.X > 5)
                    {
                        car2s2.X += car2s2speed;
                    }
                    //reverse d for car2
                    if (dDown == true && car2b1.X < this.Width - car2b2.Width)
                    {
                        car2b1.X -= car2b1speed;
                    }
                    if (dDown == true && car2b2.X < this.Width - car2b2.Width)
                    {
                        car2b2.X -= car2b2speed;
                    }
                    if (dDown == true && car2s1.X < this.Width - car2b2.Width)
                    {
                        car2s1.X -= car2s1speed;
                    }
                    if (dDown == true && car2s2.X < this.Width - car2b2.Width)
                    {
                        car2s2.X -= car2s2speed;
                    }
                    //reverse s for car2
                    if (sDown == true && car2b1.Y > 5)
                    {
                        car2b1.Y += car2b1speed;
                    }
                    if (sDown == true && car2b2.Y > 5)
                    {
                        car2b2.Y += car2b2speed;
                    }
                    if (sDown == true && car2s1.Y > 5)
                    {
                        car2s1.Y += car1s1speed;
                    }
                    if (sDown == true && car2s2.Y > 5)
                    {
                        car2s2.Y += car2s2speed;
                    }
                    //reverse w for car2
                    if (wDown == true && car2b1.Y < this.Width - car2b2.Width)
                    {
                        car2b1.Y -= car2b1speed;
                    }
                    if (wDown == true && car2b2.Y < this.Width - car2b2.Width)
                    {
                        car2b2.Y -= car2b2speed;
                    }
                    if (wDown == true && car2s1.Y < this.Width - car2b2.Width)
                    {
                        car2s1.Y -= car2s1speed;
                    }
                    if (wDown == true && car2s2.Y < this.Width - car2b2.Width)
                    {
                        car2s2.Y -= car2s2speed;
                    }
                }
            }
            // If car1 side2 crashes into car2 bumper2
            if (car2b2.IntersectsWith(car1s1))
            {

                {
                    //reverse left for  car1 
                    if (leftDown == true && car1b1.X > 5)
                    {
                        car1b1.X += car1b1speed;
                    }
                    if (leftDown == true && car1s1.X > 5)
                    {
                        car1s1.X += car1s1speed;
                    }
                    if (leftDown == true && car1b2.X > 5)
                    {
                        car1b2.X += car1b2speed;
                    }
                    if (leftDown == true && car1s1.X > 5)
                    {
                        car1s2.X += car1s2speed;
                    }
                    //reverse right for car1
                    if (rightDown == true && car1b1.X < this.Width - car1b1.Width)
                    {
                        car1b1.X -= car1b1speed;
                    }
                    if (rightDown == true && car1s1.X < this.Width - car1s1.Width)
                    {
                        car1s1.X -= car1s1speed;
                    }
                    if (rightDown == true && car1b2.X < this.Width - car1b2.Width)
                    {
                        car1b2.X -= car1b2speed;
                    }
                    if (rightDown == true && car1s1.X < this.Width - car1s1.Width)
                    {
                        car1s1.X -= car1s1speed;
                    }
                    //reverse down for car1
                    if (downDown == true && car1b1.Y > 5)
                    {
                        car1b1.Y += car1b1speed;
                    }
                    if (downDown == true && car1b1.Y > 5)
                    {
                        car1s1.X += car1s1speed;
                    }
                    if (downDown == true && car1b1.Y > 5)
                    {
                        car1b2.X += car1b2speed;
                    }
                    if (downDown == true && car1b1.Y > 5)
                    {
                        car1s2.X += car1s2speed;
                    }
                    //reverse up for car1
                    if (upDown == true && car1b1.Y > 5)
                    {
                        car1b1.Y -= car1b1speed;
                    }
                    if (upDown == true && car1s1.Y > 5)
                    {
                        car1s1.Y -= car1s1speed;
                    }
                    if (upDown == true && car1b2.Y > 5)
                    {
                        car1b2.Y -= car1b2speed;
                    }
                    if (upDown == true && car1s2.Y > 5)
                    {
                        car1s2.Y -= car1s2speed;
                    }

                    //reverse a for  car2
                    if (aDown == true && car2b1.X > 5)
                    {
                        car2b1.X += car2b1speed;
                    }
                    if (aDown == true && car2b2.X > 5)
                    {
                        car2b2.X += car2b2speed;
                    }
                    if (aDown == true && car2s1.X > 5)
                    {
                        car2s1.X += car1s1speed;
                    }
                    if (aDown == true && car2s2.X > 5)
                    {
                        car2s2.X += car2s2speed;
                    }
                    //reverse d for car2
                    if (dDown == true && car2b1.X < this.Width - car2b2.Width)
                    {
                        car2b1.X -= car2b1speed;
                    }
                    if (dDown == true && car2b2.X < this.Width - car2b2.Width)
                    {
                        car2b2.X -= car2b2speed;
                    }
                    if (dDown == true && car2s1.X < this.Width - car2b2.Width)
                    {
                        car2s1.X -= car2s1speed;
                    }
                    if (dDown == true && car2s2.X < this.Width - car2b2.Width)
                    {
                        car2s2.X -= car2s2speed;
                    }
                    //reverse s for car2
                    if (sDown == true && car2b1.Y > 5)
                    {
                        car2b1.Y += car2b1speed;
                    }
                    if (sDown == true && car2b2.Y > 5)
                    {
                        car2b2.Y += car2b2speed;
                    }
                    if (sDown == true && car2s1.Y > 5)
                    {
                        car2s1.Y += car1s1speed;
                    }
                    if (sDown == true && car2s2.Y > 5)
                    {
                        car2s2.Y += car2s2speed;
                    }
                    //reverse w for car2
                    if (wDown == true && car2b1.Y < this.Width - car2b2.Width)
                    {
                        car2b1.Y -= car2b1speed;
                    }
                    if (wDown == true && car2b2.Y < this.Width - car2b2.Width)
                    {
                        car2b2.Y -= car2b2speed;
                    }
                    if (wDown == true && car2s1.Y < this.Width - car2b2.Width)
                    {
                        car2s1.Y -= car2s1speed;
                    }
                    if (wDown == true && car2s2.Y < this.Width - car2b2.Width)
                    {
                        car2s2.Y -= car2s2speed;
                    }
                }
            }
            // If car1 bumper2 crashes into car2 bumper2
            if (car2b2.IntersectsWith(car1b2))
            {

                {
                    //reverse left for  car1 
                    if (leftDown == true && car1b1.X > 5)
                    {
                        car1b1.X += car1b1speed;
                    }
                    if (leftDown == true && car1s1.X > 5)
                    {
                        car1s1.X += car1s1speed;
                    }
                    if (leftDown == true && car1b2.X > 5)
                    {
                        car1b2.X += car1b2speed;
                    }
                    if (leftDown == true && car1s1.X > 5)
                    {
                        car1s2.X += car1s2speed;
                    }
                    //reverse right for car1
                    if (rightDown == true && car1b1.X < this.Width - car1b1.Width)
                    {
                        car1b1.X -= car1b1speed;
                    }
                    if (rightDown == true && car1s1.X < this.Width - car1s1.Width)
                    {
                        car1s1.X -= car1s1speed;
                    }
                    if (rightDown == true && car1b2.X < this.Width - car1b2.Width)
                    {
                        car1b2.X -= car1b2speed;
                    }
                    if (rightDown == true && car1s1.X < this.Width - car1s1.Width)
                    {
                        car1s1.X -= car1s1speed;
                    }
                    //reverse down for car1
                    if (downDown == true && car1b1.Y > 5)
                    {
                        car1b1.Y += car1b1speed;
                    }
                    if (downDown == true && car1b1.Y > 5)
                    {
                        car1s1.X += car1s1speed;
                    }
                    if (downDown == true && car1b1.Y > 5)
                    {
                        car1b2.X += car1b2speed;
                    }
                    if (downDown == true && car1b1.Y > 5)
                    {
                        car1s2.X += car1s2speed;
                    }
                    //reverse up for car1
                    if (upDown == true && car1b1.Y > 5)
                    {
                        car1b1.Y -= car1b1speed;
                    }
                    if (upDown == true && car1s1.Y > 5)
                    {
                        car1s1.Y -= car1s1speed;
                    }
                    if (upDown == true && car1b2.Y > 5)
                    {
                        car1b2.Y -= car1b2speed;
                    }
                    if (upDown == true && car1s2.Y > 5)
                    {
                        car1s2.Y -= car1s2speed;
                    }

                    //reverse a for  car2
                    if (aDown == true && car2b1.X > 5)
                    {
                        car2b1.X += car2b1speed;
                    }
                    if (aDown == true && car2b2.X > 5)
                    {
                        car2b2.X += car2b2speed;
                    }
                    if (aDown == true && car2s1.X > 5)
                    {
                        car2s1.X += car1s1speed;
                    }
                    if (aDown == true && car2s2.X > 5)
                    {
                        car2s2.X += car2s2speed;
                    }
                    //reverse d for car2
                    if (dDown == true && car2b1.X < this.Width - car2b2.Width)
                    {
                        car2b1.X -= car2b1speed;
                    }
                    if (dDown == true && car2b2.X < this.Width - car2b2.Width)
                    {
                        car2b2.X -= car2b2speed;
                    }
                    if (dDown == true && car2s1.X < this.Width - car2b2.Width)
                    {
                        car2s1.X -= car2s1speed;
                    }
                    if (dDown == true && car2s2.X < this.Width - car2b2.Width)
                    {
                        car2s2.X -= car2s2speed;
                    }
                    //reverse s for car2
                    if (sDown == true && car2b1.Y > 5)
                    {
                        car2b1.Y += car2b1speed;
                    }
                    if (sDown == true && car2b2.Y > 5)
                    {
                        car2b2.Y += car2b2speed;
                    }
                    if (sDown == true && car2s1.Y > 5)
                    {
                        car2s1.Y += car1s1speed;
                    }
                    if (sDown == true && car2s2.Y > 5)
                    {
                        car2s2.Y += car2s2speed;
                    }
                    //reverse w for car2
                    if (wDown == true && car2b1.Y < this.Width - car2b2.Width)
                    {
                        car2b1.Y -= car2b1speed;
                    }
                    if (wDown == true && car2b2.Y < this.Width - car2b2.Width)
                    {
                        car2b2.Y -= car2b2speed;
                    }
                    if (wDown == true && car2s1.Y < this.Width - car2b2.Width)
                    {
                        car2s1.Y -= car2s1speed;
                    }
                    if (wDown == true && car2s2.Y < this.Width - car2b2.Width)
                    {
                        car2s2.Y -= car2s2speed;
                    }
                }
            }
            // If car1 bumper1 crashes into car2 bumper1
            if (car1b1.IntersectsWith(car2b1))
            {
                //reverse left for  car1 
                if (leftDown == true && car1b1.X > 5)
                {
                    car1b1.X += car1b1speed;
                }
                if (leftDown == true && car1s1.X > 5)
                {
                    car1s1.X += car1s1speed;
                }
                if (leftDown == true && car1b2.X > 5)
                {
                    car1b2.X += car1b2speed;
                }
                if (leftDown == true && car1s1.X > 5)
                {
                    car1s2.X += car1s2speed;
                }
                //reverse right for car1
                if (rightDown == true && car1b1.X < this.Width - car1b1.Width)
                {
                    car1b1.X -= car1b1speed;
                }
                if (rightDown == true && car1s1.X < this.Width - car1s1.Width)
                {
                    car1s1.X -= car1s1speed;
                }
                if (rightDown == true && car1b2.X < this.Width - car1b2.Width)
                {
                    car1b2.X -= car1b2speed;
                }
                if (rightDown == true && car1s1.X < this.Width - car1s1.Width)
                {
                    car1s1.X -= car1s1speed;
                }
                //reverse down for car1
                if (downDown == true && car1b1.Y > 5)
                {
                    car1b1.Y += car1b1speed;
                }
                if (downDown == true && car1b1.Y > 5)
                {
                    car1s1.X += car1s1speed;
                }
                if (downDown == true && car1b1.Y > 5)
                {
                    car1b2.X += car1b2speed;
                }
                if (downDown == true && car1b1.Y > 5)
                {
                    car1s2.X += car1s2speed;
                }
                //reverse up for car1
                if (upDown == true && car1b1.Y > 5)
                {
                    car1b1.Y -= car1b1speed;
                }
                if (upDown == true && car1s1.Y > 5)
                {
                    car1s1.Y -= car1s1speed;
                }
                if (upDown == true && car1b2.Y > 5)
                {
                    car1b2.Y -= car1b2speed;
                }
                if (upDown == true && car1s2.Y > 5)
                {
                    car1s2.Y -= car1s2speed;
                }

                //reverse a for  car2
                if (aDown == true && car2b1.X > 5)
                {
                    car2b1.X += car2b1speed;
                }
                if (aDown == true && car2b2.X > 5)
                {
                    car2b2.X += car2b2speed;
                }
                if (aDown == true && car2s1.X > 5)
                {
                    car2s1.X += car1s1speed;
                }
                if (aDown == true && car2s2.X > 5)
                {
                    car2s2.X += car2s2speed;
                }
                //reverse d for car2
                if (dDown == true && car2b1.X < this.Width - car2b2.Width)
                {
                    car2b1.X -= car2b1speed;
                }
                if (dDown == true && car2b2.X < this.Width - car2b2.Width)
                {
                    car2b2.X -= car2b2speed;
                }
                if (dDown == true && car2s1.X < this.Width - car2b2.Width)
                {
                    car2s1.X -= car2s1speed;
                }
                if (dDown == true && car2s2.X < this.Width - car2b2.Width)
                {
                    car2s2.X -= car2s2speed;
                }
                //reverse s for car2
                if (sDown == true && car2b1.Y > 5)
                {
                    car2b1.Y += car2b1speed;
                }
                if (sDown == true && car2b2.Y > 5)
                {
                    car2b2.Y += car2b2speed;
                }
                if (sDown == true && car2s1.Y > 5)
                {
                    car2s1.Y += car1s1speed;
                }
                if (sDown == true && car2s2.Y > 5)
                {
                    car2s2.Y += car2s2speed;
                }
                //reverse w for car2
                if (wDown == true && car2b1.Y < this.Width - car2b2.Width)
                {
                    car2b1.Y -= car2b1speed;
                }
                if (wDown == true && car2b2.Y < this.Width - car2b2.Width)
                {
                    car2b2.Y -= car2b2speed;
                }
                if (wDown == true && car2s1.Y < this.Width - car2b2.Width)
                {
                    car2s1.Y -= car2s1speed;
                }
                if (wDown == true && car2s2.Y < this.Width - car2b2.Width)
                {
                    car2s2.Y -= car2s2speed;
                }
            }


            //If car points exceed three on either side
            if (car1points == 3)
                gameTimer.Stop();
            if (car2points == 3)
            {
                gameTimer.Stop();
            }
            Refresh();
        }
    }
}