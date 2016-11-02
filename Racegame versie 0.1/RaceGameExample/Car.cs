using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using System.Windows.Media;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace RaceGameExample {
    class Car {
        private Point position;
        private float rotation;
        public double speed;
        private bool leftPressed = false, rightPressed = false, throttlePressed = false, brakePressed = false;
        private Keys leftKey, rightKey, throttleKey, brakeKey;
        private Image image;
        public float fuel = 500;
        public int laps = 1;
        private int Map;
        const float rotateAmount = 3.0f;
        public bool check1 = false;
        public bool check2 = false;
        public bool check3 = false;
        public bool finish = false;
        public bool OutFuel = false;
        public bool pit = false;
        public int pitCount = 0;

        /// <summary>
        /// Constructor of the car class
        /// </summary>
        public Car(int postionx, int positiony, float rotation, double speed, Keys leftKey, Keys rightKey, Keys throttleKey, Keys  brakeKey, Image image)
        {
            position.X = postionx;
            position.Y = positiony;
            this.rotation = rotation;
            this.speed = speed;
            this.leftKey = leftKey;
            this.rightKey = rightKey;
            this.throttleKey = throttleKey;
            this.brakeKey = brakeKey;
            this.image = image;
        }

        public void handleKeyDownEvent(KeyEventArgs keys) 
        {
            if (leftKey == keys.KeyCode)
                leftPressed = true;
            if (rightKey == keys.KeyCode)
                rightPressed = true;
            if (throttleKey == keys.KeyCode)
                throttlePressed = true;
            if (brakeKey == keys.KeyCode)
                brakePressed = true;
        }

        public void handleKeyUpEvent(KeyEventArgs keys) 
        {
            if (leftKey == keys.KeyCode)
                leftPressed = false;
            if (rightKey == keys.KeyCode)
                rightPressed = false;
            if (throttleKey == keys.KeyCode)
                throttlePressed = false;
            if (brakeKey == keys.KeyCode)
                brakePressed = false;
        }

        public Point getPosition() 
        {
            return position;
        }

        public float getRotation()
        {
            return rotation;
        }

        public Image getImage() 
        {
            return image;
        }

        public void AmountFuel ()
        {
            if (speed != 0)
            {
                fuel -= 0.069f;
            }

            if (fuel <= 0)
            {
                coast();
                OutFuel = true;
                fuel = 0;
            }
        }

        public void checkpointCount ()
        {
            Map = ChooseMap.Map;

            //Map 1 checkpoints en pit
            if (Map == 1)
            {
                //Set de positie van de pitstop
                if (getPosition().X > 130 && getPosition().X < 365 && getPosition().Y > 515 && getPosition().Y < 595)
                {
                    //Refuel en limit speed
                    pit = true;
                    fuel = 90;
                    OutFuel = false;
                    speed = speed + .1;
                    if (speed >= 1.5)
                    {
                        speed = 1.5;
                    }
                }
                if (pit)
                {
                    pit = false;
                    //Telt op zolang je erin zit
                    pitCount++;
                }

                //Set de positie van de checkpoints
                if (getPosition().X > 200 && getPosition().X < 375 && getPosition().Y > 250 && getPosition().Y < 260)
                {
                    check1 = true;
                }
                if (getPosition().X > 870 && getPosition().X < 1024 && getPosition().Y > 580 && getPosition().Y < 590)
                {
                    check2 = true;
                }
                if (getPosition().Y > 290 && getPosition().Y < 450 && getPosition().X > 560 && getPosition().X < 570)
                {
                    check3 = true;
                }
                if (getPosition().Y > 540 && getPosition().Y < 768 && getPosition().X > 230 && getPosition().X < 240 && check2)
                {
                    finish = true;
                }

                //Check of alle checkpoints true zijn
                if (check1 && check2 && check3 && finish)
                {
                    check1 = false;
                    check2 = false;
                    check3 = false;
                    finish = false;
                    laps++;
                    //Laps + 1 tot laps = 4
                    if (laps > 2)
                    {
                        Sounds.Finallap.Play();
                    }
                    if (laps > 3 && pitCount > 0)
                    {
                        //Game end
                        Sounds.Finish.PlaySync();
                        Sounds.Victory.Play();
                        MessageBox.Show("you win");
                    }
                }
            }

            //Map 2 checkpoints en pit
            if (Map == 2)
            {
                if ((getPosition().X > 20 && getPosition().X < 85 && getPosition().Y > 90 && getPosition().Y < 320) || (getPosition().X > 100 && getPosition().X < 140 && getPosition().Y > 85 && getPosition().Y < 215))
                {
                    pit = true;
                    fuel = 90;
                    OutFuel = false;
                    speed = speed + .1;
                    if (speed >= 1.5)
                    {
                        speed = 1.5;
                    }

                }
                if (pit)
                {
                    pit = false;
                    pitCount++;
                }

                if (getPosition().X > 485 && getPosition().X < 495 && getPosition().Y > 130 && getPosition().Y < 290)
                {
                    check1 = true;
                }
                if (getPosition().X > 820 && getPosition().X < 1000 && getPosition().Y > 385 && getPosition().Y < 395)
                {
                    check2 = true;
                }
                if (getPosition().X > 240 && getPosition().X < 250 && getPosition().Y > 600 && getPosition().Y < 760)
                {
                    check3 = true;
                }
                if (getPosition().Y > 230 && getPosition().Y < 240 && getPosition().X > 0 && getPosition().X < 260 && check2)
                {
                    finish = true;
                }
                if (check1 && check2 && check3 && finish)
                {
                    check1 = false;
                    check2 = false;
                    check3 = false;
                    finish = false;
                    laps++;
                    if (laps > 3 && pitCount > 0)
                    {
                        MessageBox.Show("you win");
                    }
                }
            }

            //Map 3 checkpoints en pit
            if (Map == 3)
            {
                if ((getPosition().X > 250 && getPosition().X < 390 && getPosition().Y > 145 && getPosition().Y < 230 ) || (getPosition().X > 280 && getPosition().X < 375 && getPosition().Y > 225 && getPosition().Y < 275))
                {
                    pit = true;
                    fuel = 90;
                    OutFuel = false;
                    speed = speed + .1;
                    if (speed >= 0.8)
                    {
                        speed = 0.8;
                    }

                }
                if (pit)
                {
                    pit = false;
                    pitCount++;
                }

                if (getPosition().X > 355 && getPosition().X < 510 && getPosition().Y > 340 && getPosition().Y < 350)
                {
                    check1 = true;
                }
                if (getPosition().X > 790 && getPosition().X < 960 && getPosition().Y > 570 && getPosition().Y < 580)
                {
                    check2 = true;
                }
                if (getPosition().X > 105 && getPosition().X < 285 && getPosition().Y > 420 && getPosition().Y < 430)
                {
                    check3 = true;
                }
                if (getPosition().Y > 0 && getPosition().Y < 165 && getPosition().X > 545 && getPosition().X < 555 && check2)
                {
                    finish = true;
                }
                if (check1 && check2 && check3 && finish)
                {
                    check1 = false;
                    check2 = false;
                    check3 = false;
                    finish = false;
                    laps++;
                    if (laps > 3 && pitCount > 0)
                    {
                        MessageBox.Show("you win");
                    }
                }
            }

        }

        /// <summary>
        /// Verander de positieve snelheid van de auto als vooruit is ingedrukt
        /// </summary>
        private void accelerate() 
        {
            if (OutFuel == false){
                    speed = speed + .1;
                    if (speed >= 3.0)
                    {
                        speed = speed + .05;
                        if (speed >= 5.0)
                        {
                        speed = 5.0;
                        }
                    }
            }
        }

           


        /// <summary>
        /// Verandere de negatieve snelheid van de auto als achteruit is ingedrukt
        /// </summary>
        private void brake() 
        {
            if (OutFuel == false && pit == false)
            {
                speed = speed - .1;

                if (speed <= -2.0)
                {
                    speed = -2.0;
                }
            }
        }

        /// <summary>
        /// Stop de auto langzaam als achteruit of vooruit wordt losgelaten
        /// </summary>
        private void coast()
        {
            if (speed >= .02)
                speed -= .05;
            else if (speed <= -.02)
                speed += 0.05;
            else
                speed = 0;
        }

        /// <summary>
        /// Verander de kant waar de auto op gaat naar rechts
        /// </summary>
        private void rotateRight()
        {
            if (speed != 0)
            {
                if (speed < 0)
                {
                    this.rotation -= rotateAmount;
                }
                else
                {
                    this.rotation += rotateAmount;
                }
            }
        }

        /// <summary>
        /// Verander de kant waar de auto op gaat naar links
        /// </summary>
        private void rotateLeft()
        {
            if (speed != 0)
            {
                if (speed < 0)
                {
                    this.rotation += rotateAmount;
                }
                else
                {
                    this.rotation -= rotateAmount;
                }
            }
        }

        private void changeSpeed()
        {
            if (throttlePressed)
                accelerate();
            else if (brakePressed)
                brake();
            else
                coast();
            
            if (leftPressed)
                rotateLeft();
            else if (rightPressed)
                rotateRight();
        }

        /// <summary>
        /// Bepaalt de nieuwe positie van de auto`s
        /// </summary>
        public void calculateNewPosition()
        {
            changeSpeed();
            position.X -= (int)Math.Round(speed * (Math.Cos(rotation * Math.PI / 180)));
            position.Y -= (int)Math.Round(speed * (Math.Sin(rotation * Math.PI / 180))); 
        }
    }
}
