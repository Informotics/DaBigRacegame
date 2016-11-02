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


namespace RaceGameExample
{
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

            //Map 1
            if (Map == 1)
            {
                this.BackgroundImage = Properties.Resources.Racebaan;
                if (Carplayer2 == 1)
                {
                    Car car2 = new Car(270, 670, 0, 0, Keys.Left, Keys.Right, Keys.Up, Keys.Down, new Bitmap(Path.Combine(Environment.CurrentDirectory, "BMW-M6-GT3.png")));
                    cars.Add(car2);
                }
                if (Carplayer2 == 2)
                {
                    Car car2 = new Car(270, 670, 0, 0, Keys.Left, Keys.Right, Keys.Up, Keys.Down, new Bitmap(Path.Combine(Environment.CurrentDirectory, "Ferarri458Italia.png")));
                    cars.Add(car2);
                }
                if (Carplayer2 == 3)
                {
                    Car car2 = new Car(270, 670, 0, 0, Keys.Left, Keys.Right, Keys.Up, Keys.Down, new Bitmap(Path.Combine(Environment.CurrentDirectory, "MercedesAMG-GTR.png")));
                    cars.Add(car2);
                }
                if (Carplayer2 == 4)
                {
                    Car car2 = new Car(270, 670, 0, 0, Keys.Left, Keys.Right, Keys.Up, Keys.Down, new Bitmap(Path.Combine(Environment.CurrentDirectory, "Porsche911-GTR-RS.png")));
                    cars.Add(car2);
                }
                //Check welke auto player 1 koos en maak hem aan

                if (Carplayer1 == 1)
                {
                    Car car1 = new Car(270, 700, 0, 0, Keys.A, Keys.D, Keys.W, Keys.S, new Bitmap(Path.Combine(Environment.CurrentDirectory, "BMW-M6-GT3.png")));
                    cars.Add(car1);
                }
                if (Carplayer1 == 2)
                {
                    Car car1 = new Car(270, 700, 0, 0, Keys.A, Keys.D, Keys.W, Keys.S, new Bitmap(Path.Combine(Environment.CurrentDirectory, "Ferarri458Italia.png")));
                    cars.Add(car1);
                }
                if (Carplayer1 == 3)
                {
                    Car car1 = new Car(270, 700, 0, 0, Keys.A, Keys.D, Keys.W, Keys.S, new Bitmap(Path.Combine(Environment.CurrentDirectory, "MercedesAMG-GTR.png")));
                    cars.Add(car1);
                }
                if (Carplayer1 == 4)
                {
                    Car car1 = new Car(270, 700, 0, 0, Keys.A, Keys.D, Keys.W, Keys.S, new Bitmap(Path.Combine(Environment.CurrentDirectory, "Porsche911-GTR-RS.png")));
                    cars.Add(car1);
                }
                //Check welke auto player 2 koos en maak hem aan
            }

            //Map 2
            if (Map == 2)
            {
                this.BackgroundImage = Properties.Resources.RacebaanSnow;
                eendgif.Visible = false;
                if (Carplayer2 == 1)
                {
                    Car car2 = new Car(138, 280, 90, 0, Keys.Left, Keys.Right, Keys.Up, Keys.Down, new Bitmap(Path.Combine(Environment.CurrentDirectory, "BMW-M6-GT3.png")));
                    cars.Add(car2);
                }
                if (Carplayer2 == 2)
                {
                    Car car2 = new Car(138, 280, 90, 0, Keys.Left, Keys.Right, Keys.Up, Keys.Down, new Bitmap(Path.Combine(Environment.CurrentDirectory, "Ferarri458Italia.png")));
                    cars.Add(car2);
                }
                if (Carplayer2 == 3)
                {
                    Car car2 = new Car(138, 280, 90, 0, Keys.Left, Keys.Right, Keys.Up, Keys.Down, new Bitmap(Path.Combine(Environment.CurrentDirectory, "MercedesAMG-GTR.png")));
                    cars.Add(car2);
                }
                if (Carplayer2 == 4)
                {
                    Car car2 = new Car(138, 280, 90, 0, Keys.Left, Keys.Right, Keys.Up, Keys.Down, new Bitmap(Path.Combine(Environment.CurrentDirectory, "Porsche911-GTR-RS.png")));
                    cars.Add(car2);
                }
                //Check welke auto player 1 koos en maak hem aan

                if (Carplayer1 == 1)
                {
                    Car car1 = new Car(196, 280, 90, 0, Keys.A, Keys.D, Keys.W, Keys.S, new Bitmap(Path.Combine(Environment.CurrentDirectory, "BMW-M6-GT3.png")));
                    cars.Add(car1);
                }
                if (Carplayer1 == 2)
                {
                    Car car1 = new Car(196, 280, 90, 0, Keys.A, Keys.D, Keys.W, Keys.S, new Bitmap(Path.Combine(Environment.CurrentDirectory, "Ferarri458Italia.png")));
                    cars.Add(car1);
                }
                if (Carplayer1 == 3)
                {
                    Car car1 = new Car(196, 280, 90, 0, Keys.A, Keys.D, Keys.W, Keys.S, new Bitmap(Path.Combine(Environment.CurrentDirectory, "MercedesAMG-GTR.png")));
                    cars.Add(car1);
                }
                if (Carplayer1 == 4)
                {
                    Car car1 = new Car(196, 280, 90, 0, Keys.A, Keys.D, Keys.W, Keys.S, new Bitmap(Path.Combine(Environment.CurrentDirectory, "Porsche911-GTR-RS.png")));
                    cars.Add(car1);
                }
                //Check welke auto player 2 koos en maak hem aan
            }

            //Map 3
            if (Map == 3)
            {
                this.BackgroundImage = Properties.Resources.RacebaanDesert;
                eendgif.Visible = false;
                if (Carplayer2 == 1)
                {
                    Car car2 = new Car(460, 60, 180, 0, Keys.Left, Keys.Right, Keys.Up, Keys.Down, new Bitmap(Path.Combine(Environment.CurrentDirectory, "BMW-M6-GT3.png")));
                    cars.Add(car2);
                }
                if (Carplayer2 == 2)
                {
                    Car car2 = new Car(460, 60, 180, 0, Keys.Left, Keys.Right, Keys.Up, Keys.Down, new Bitmap(Path.Combine(Environment.CurrentDirectory, "Ferarri458Italia.png")));
                    cars.Add(car2);
                }
                if (Carplayer2 == 3)
                {
                    Car car2 = new Car(460, 60, 180, 0, Keys.Left, Keys.Right, Keys.Up, Keys.Down, new Bitmap(Path.Combine(Environment.CurrentDirectory, "MercedesAMG-GTR.png")));
                    cars.Add(car2);
                }
                if (Carplayer2 == 4)
                {
                    Car car2 = new Car(460, 60, 180, 0, Keys.Left, Keys.Right, Keys.Up, Keys.Down, new Bitmap(Path.Combine(Environment.CurrentDirectory, "Porsche911-GTR-RS.png")));
                    cars.Add(car2);
                }
                //Check welke auto player 1 koos en maak hem aan

                if (Carplayer1 == 1)
                {
                    Car car1 = new Car(460, 90, 180, 0, Keys.A, Keys.D, Keys.W, Keys.S, new Bitmap(Path.Combine(Environment.CurrentDirectory, "BMW-M6-GT3.png")));
                    cars.Add(car1);
                }
                if (Carplayer1 == 2)
                {
                    Car car1 = new Car(460, 90, 180, 0, Keys.A, Keys.D, Keys.W, Keys.S, new Bitmap(Path.Combine(Environment.CurrentDirectory, "Ferarri458Italia.png")));
                    cars.Add(car1);
                }
                if (Carplayer1 == 3)
                {
                    Car car1 = new Car(460, 90, 180, 0, Keys.A, Keys.D, Keys.W, Keys.S, new Bitmap(Path.Combine(Environment.CurrentDirectory, "MercedesAMG-GTR.png")));
                    cars.Add(car1);
                }
                if (Carplayer1 == 4)
                {
                    Car car1 = new Car(460, 90, 180, 0, Keys.A, Keys.D, Keys.W, Keys.S, new Bitmap(Path.Combine(Environment.CurrentDirectory, "Porsche911-GTR-RS.png")));
                    cars.Add(car1);
                }
                //Check welke auto player 2 koos en maak hem aan
            }

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

        void Draw(Graphics g)
        {
            int CarIndex = 1;
            Rectangle[] carBoxes = new Rectangle[] {
            new Rectangle(cars[0].getPosition().X, cars[0].getPosition().Y, cars[0].getImage().Width, cars[0].getImage().Height),
            new Rectangle(cars[1].getPosition().X, cars[1].getPosition().Y, cars[1].getImage().Width, cars[1].getImage().Height)
        };

            
            for(int i = 0; i< cars.Count; i++)
            {
                Car car = cars[i];
                //Start checkpoint code en fuel code
                car.checkpointCount();
                car.AmountFuel();

                //Checkpoint displays
                //String drawCheck1 = "1: " + car.check1;
                //DrawString(g, drawCheck1, 10, 40 * CarIndex);

                //String drawCheck2 = "2: " + car.check2;
                //DrawString(g, drawCheck2, 100, 40 * CarIndex);

                //String drawCheck3 = "3: " + car.check3;
                //DrawString(g, drawCheck3, 200, 40 * CarIndex);

                //String drawFinish = "Finish: " + car.finish;
                //DrawString(g, drawFinish, 300, 40 * CarIndex);

                if (Map == 1)
                {
                    //ShowSpeed
                    String drawSpeed = "Speed: " + Math.Round(car.speed * 56) + "Km/u";
                    DrawString(g, drawSpeed, 0, 10 * CarIndex);

                    //ShowLaps
                    String drawLaps = "Lap: " + car.laps + "/3";
                    DrawString(g, drawLaps, 120, 10 * CarIndex);

                    //ShowFuel
                    String drawFuel = "Fuel: " + Math.Round(car.fuel);
                    DrawString(g, drawFuel, 220, 10 * CarIndex);

                    //ShowPit
                    String drawPit = "Pits: " + car.pitCount;
                    DrawString(g, drawPit, 320, 10 * CarIndex);
                }
                if (Map == 2)
                {
                    //ShowSpeed
                    String drawSpeed = "Speed: " + Math.Round(car.speed * 56) + "Km/u";
                    DrawString(g, drawSpeed, 0, 10 * CarIndex);

                    //ShowLaps
                    String drawLaps = "Lap: " + car.laps + "/3";
                    DrawString(g, drawLaps, 120, 10 * CarIndex);

                    //ShowFuel
                    String drawFuel = "Fuel: " + Math.Round(car.fuel);
                    DrawString(g, drawFuel, 220, 10 * CarIndex);

                    //ShowPit
                    String drawPit = "Pits: " + car.pitCount;
                    DrawString(g, drawPit, 320, 10 * CarIndex);
                }
                if (Map == 3)
                {
                    //ShowSpeed
                    String drawSpeed = "Speed: " + Math.Round(car.speed * 56) + "Km/u";
                    DrawString(g, drawSpeed, 0, 10 * CarIndex);

                    //ShowLaps
                    String drawLaps = "Lap: " + car.laps + "/3";
                    DrawString(g, drawLaps, 120, 10 * CarIndex);

                    //ShowFuel
                    String drawFuel = "Fuel: " + Math.Round(car.fuel);
                    DrawString(g, drawFuel, 220, 10 * CarIndex);

                    //ShowPit
                    String drawPit = "Pits: " + car.pitCount;
                    DrawString(g, drawPit, 320, 10 * CarIndex);
                }

                //Zet middelpunt van auto
                float moveX = car.getImage().Width / 2f + car.getPosition().X;
                float moveY = car.getImage().Height / 2f + car.getPosition().Y;
                g.TranslateTransform(moveX, moveY);
                g.RotateTransform(car.getRotation());
                g.TranslateTransform(-moveX, -moveY);

                g.DrawRectangle(Pens.Red, carBoxes[i]);

                if (carBoxes[0].IntersectsWith(carBoxes[1]))
                {
                    car.speed = 2;
                }

                //Draw de auto
                g.DrawImage(car.getImage(), car.getPosition().X, car.getPosition().Y);
                g.ResetTransform();
                CarIndex += 2;


                //Coords van auto
                //String drawPos = "X: " + car.getPosition().X + " Y:" + car.getPosition().Y;
                //DrawString(g, drawPos, car.getPosition().X + 20, car.getPosition().Y + 20);


            }
        }
        //Properties van de drawstring
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

        private void formRaceGame_Load(object sender, EventArgs e)
        {

        }
    }
}
