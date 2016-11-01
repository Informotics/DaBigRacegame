using System;
using System.Media;
using RaceGameExample.Properties;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;


namespace RaceGameExample {
    public partial class formRaceGame : Form
    {

        Bitmap Backbuffer;

        List<Car> cars = new List<Car>();
        //Maak de auto ints aan
        int Carplayer1;
        int Carplayer2;
        int Map;

        public formRaceGame()
        {
            InitializeComponent();
            Carplayer1 = PickerP1.CarP1;
            Carplayer2 = PickerP2.CarP2;
            Map = ChooseMap.Map;

            if (Map == 1)
            {
                this.BackgroundImage = Properties.Resources.Racebaan;
                if (Carplayer2 == 1)
                {
                    Car car1 = new Car(270, 630, 0, 0, Keys.Left, Keys.Right, Keys.Up, Keys.Down, new Bitmap(Path.Combine(Environment.CurrentDirectory, "BMW-M6-GT3.png")));
                    cars.Add(car1);
                }
                if (Carplayer2 == 2)
                {
                    Car car1 = new Car(270, 630, 0, 0, Keys.Left, Keys.Right, Keys.Up, Keys.Down, new Bitmap(Path.Combine(Environment.CurrentDirectory, "Ferarri458Italia.png")));
                    cars.Add(car1);
                }
                if (Carplayer2 == 3)
                {
                    Car car1 = new Car(270, 630, 0, 0, Keys.Left, Keys.Right, Keys.Up, Keys.Down, new Bitmap(Path.Combine(Environment.CurrentDirectory, "MercedesAMG-GTR.png")));
                    cars.Add(car1);
                }
                if (Carplayer2 == 4)
                {
                    Car car1 = new Car(270, 630, 0, 0, Keys.Left, Keys.Right, Keys.Up, Keys.Down, new Bitmap(Path.Combine(Environment.CurrentDirectory, "Porsche911-GTR-RS.png")));
                    cars.Add(car1);
                }

                //Check welke auto player 2 koos en maak hem aan
                if (Carplayer1 == 1)
                {
                    Car car2 = new Car(270, 660, 0, 0, Keys.A, Keys.D, Keys.W, Keys.S, new Bitmap(Path.Combine(Environment.CurrentDirectory, "BMW-M6-GT3.png")));
                    cars.Add(car2);
                }
                if (Carplayer1 == 2)
                {
                    Car car2 = new Car(270, 660, 0, 0, Keys.A, Keys.D, Keys.W, Keys.S, new Bitmap(Path.Combine(Environment.CurrentDirectory, "Ferarri458Italia.png")));
                    cars.Add(car2);
                }
                if (Carplayer1 == 3)
                {
                    Car car2 = new Car(270, 660, 0, 0, Keys.A, Keys.D, Keys.W, Keys.S, new Bitmap(Path.Combine(Environment.CurrentDirectory, "MercedesAMG-GTR.png")));
                    cars.Add(car2);
                }
                if (Carplayer1 == 4)
                {
                    Car car2 = new Car(270, 660, 0, 0, Keys.A, Keys.D, Keys.W, Keys.S, new Bitmap(Path.Combine(Environment.CurrentDirectory, "Porsche911-GTR-RS.png")));
                    cars.Add(car2);
                }
            }

            if (Map == 2)
            {
                this.BackgroundImage = Properties.Resources.RacebaanSnow;
                if (Carplayer2 == 1)
                {
                    Car car1 = new Car(148, 285, 90, 0, Keys.Left, Keys.Right, Keys.Up, Keys.Down, new Bitmap(Path.Combine(Environment.CurrentDirectory, "BMW-M6-GT3.png")));
                    cars.Add(car1);
                }
                if (Carplayer2 == 2)
                {
                    Car car1 = new Car(148, 285, 90, 0, Keys.Left, Keys.Right, Keys.Up, Keys.Down, new Bitmap(Path.Combine(Environment.CurrentDirectory, "Ferarri458Italia.png")));
                    cars.Add(car1);
                }
                if (Carplayer2 == 3)
                {
                    Car car1 = new Car(148, 285, 90, 0, Keys.Left, Keys.Right, Keys.Up, Keys.Down, new Bitmap(Path.Combine(Environment.CurrentDirectory, "MercedesAMG-GTR.png")));
                    cars.Add(car1);
                }
                if (Carplayer2 == 4)
                {
                    Car car1 = new Car(148, 285, 90, 0, Keys.Left, Keys.Right, Keys.Up, Keys.Down, new Bitmap(Path.Combine(Environment.CurrentDirectory, "Porsche911-GTR-RS.png")));
                    cars.Add(car1);
                }

                //Check welke auto player 2 koos en maak hem aan
                if (Carplayer1 == 1)
                {
                    Car car2 = new Car(178, 285, 90, 0, Keys.A, Keys.D, Keys.W, Keys.S, new Bitmap(Path.Combine(Environment.CurrentDirectory, "BMW-M6-GT3.png")));
                    cars.Add(car2);
                }
                if (Carplayer1 == 2)
                {
                    Car car2 = new Car(178, 285, 90, 0, Keys.A, Keys.D, Keys.W, Keys.S, new Bitmap(Path.Combine(Environment.CurrentDirectory, "Ferarri458Italia.png")));
                    cars.Add(car2);
                }
                if (Carplayer1 == 3)
                {
                    Car car2 = new Car(178, 285, 90, 0, Keys.A, Keys.D, Keys.W, Keys.S, new Bitmap(Path.Combine(Environment.CurrentDirectory, "MercedesAMG-GTR.png")));
                    cars.Add(car2);
                }
                if (Carplayer1 == 4)
                {
                    Car car2 = new Car(178, 285, 90, 0, Keys.A, Keys.D, Keys.W, Keys.S, new Bitmap(Path.Combine(Environment.CurrentDirectory, "Porsche911-GTR-RS.png")));
                    cars.Add(car2);
                }
            }
            if (Map == 3)
            {
                this.BackgroundImage = Properties.Resources.RacebaanDesert;
                if (Carplayer2 == 1)
                {
                    Car car1 = new Car(155, 302, 0, 0, Keys.Left, Keys.Right, Keys.Up, Keys.Down, new Bitmap(Path.Combine(Environment.CurrentDirectory, "BMW-M6-GT3.png")));
                    cars.Add(car1);
                }
                if (Carplayer2 == 2)
                {
                    Car car1 = new Car(155, 302, 0, 0, Keys.Left, Keys.Right, Keys.Up, Keys.Down, new Bitmap(Path.Combine(Environment.CurrentDirectory, "Ferarri458Italia.png")));
                    cars.Add(car1);
                }
                if (Carplayer2 == 3)
                {
                    Car car1 = new Car(155, 302, 0, 0, Keys.Left, Keys.Right, Keys.Up, Keys.Down, new Bitmap(Path.Combine(Environment.CurrentDirectory, "MercedesAMG-GTR.png")));
                    cars.Add(car1);
                }
                if (Carplayer2 == 4)
                {
                    Car car1 = new Car(155, 302, 0, 0, Keys.Left, Keys.Right, Keys.Up, Keys.Down, new Bitmap(Path.Combine(Environment.CurrentDirectory, "Porsche911-GTR-RS.png")));
                    cars.Add(car1);
                }

                //Check welke auto player 2 koos en maak hem aan
                if (Carplayer1 == 1)
                {
                    Car car2 = new Car(209, 302, 0, 0, Keys.A, Keys.D, Keys.W, Keys.S, new Bitmap(Path.Combine(Environment.CurrentDirectory, "BMW-M6-GT3.png")));
                    cars.Add(car2);
                }
                if (Carplayer1 == 2)
                {
                    Car car2 = new Car(209, 302, 0, 0, Keys.A, Keys.D, Keys.W, Keys.S, new Bitmap(Path.Combine(Environment.CurrentDirectory, "Ferarri458Italia.png")));
                    cars.Add(car2);
                }
                if (Carplayer1 == 3)
                {
                    Car car2 = new Car(209, 302, 0, 0, Keys.A, Keys.D, Keys.W, Keys.S, new Bitmap(Path.Combine(Environment.CurrentDirectory, "MercedesAMG-GTR.png")));
                    cars.Add(car2);
                }
                if (Carplayer1 == 4)
                {
                    Car car2 = new Car(209, 302, 0, 0, Keys.A, Keys.D, Keys.W, Keys.S, new Bitmap(Path.Combine(Environment.CurrentDirectory, "Porsche911-GTR-RS.png")));
                    cars.Add(car2);
                }
            }

            //Check welke auto player 1 koos en maak hem aan


            this.SetStyle(
            ControlStyles.UserPaint |
            ControlStyles.AllPaintingInWmPaint |
            ControlStyles.DoubleBuffer, true);

            this.ResizeEnd += new EventHandler(Form1_CreateBackBuffer);
            this.Load += new EventHandler(Form1_CreateBackBuffer);
            this.Paint += new PaintEventHandler(Form1_Paint);

            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            this.KeyUp += new KeyEventHandler(Form1_KeyUp);
        }

        void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            foreach (Car car in cars)
                car.handleKeyUpEvent(e);
        }

        void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            foreach (Car car in cars)
                car.handleKeyDownEvent(e);
        }

        void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (Backbuffer != null)
            {
                e.Graphics.DrawImageUnscaled(Backbuffer, Point.Empty);
            }

            Draw(e.Graphics);
        }

        void Form1_CreateBackBuffer(object sender, EventArgs e)
        {
            if (Backbuffer != null)
                Backbuffer.Dispose();

            Backbuffer = new Bitmap(ClientSize.Width, ClientSize.Height);
        }

        void Draw(Graphics g) {
            int CarIndex = 1;
            foreach (Car car in cars) {
                //next lvl magic
                car.checkpointCount();
                //String drawCheck1 = "1: " + car.check1;
                //DrawString(g, drawCheck1, 10, 10 * CarIndex);
                //String drawCheck2 = "2: " + car.check2;
                //DrawString(g, drawCheck2, 100, 10 * CarIndex);
                //String drawCheck3 = "3: " + car.check3;
                //DrawString(g, drawCheck3, 200, 10 * CarIndex);
                String drawSpeed = "Speed: " + car.speed
                String drawFinish = "Finish: " + car.finish;
                DrawString(g, drawFinish, 300, 10 * CarIndex);
                String drawLaps= "Lap: " + car.laps;
                DrawString(g, drawLaps, 500, 10 * CarIndex);

                float moveX = car.getImage().Width / 2f + car.getPosition().X;
                float moveY = car.getImage().Height / 2f + car.getPosition().Y;
                g.TranslateTransform(moveX, moveY);
                g.RotateTransform(car.getRotation());
                g.TranslateTransform(-moveX, -moveY);
                String drawPos = "X: " + car.getPosition().X + " Y:" +car.getPosition().Y;
                DrawString(g, drawPos, car.getPosition().X + 20, car.getPosition().Y + 20);
                

                g.DrawImage(car.getImage(), car.getPosition().X, car.getPosition().Y);
                g.ResetTransform();

                CarIndex += 2;
            }
        }
        //DONT TOUCH
        void DrawString(Graphics g, string str, int x, int y)
        {
            Font drawFont = new Font("Century Gothic Bold Italic", 16);
            SolidBrush drawBrush = new SolidBrush(Color.Red);

            // Draw string to screen
            g.DrawString(str, drawFont, drawBrush, x, y);
        }

        private void timerGameTicks_Tick(object sender, EventArgs e)
        {
            foreach (Car car in cars)
                car.calculateNewPosition();

            Invalidate();

        }
    }
}
