using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        public float fuel = 90;
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
        /// <param name="postionx">starting position of the car (Horiz)</param>
        /// <param name="positiony">starting position of the car (Vert)</param>
        /// <param name="rotation">starting rotation of the car (0 for car is pointing left)</param>
        /// <param name="speed">starting speed of the car</param>
        /// <param name="leftKey">the key to steer left</param>
        /// <param name="rightKey">the key to steer right</param>
        /// <param name="throttleKey">the key to throttle</param>
        /// <param name="brakeKey">the key to brake/reverse</param>
        /// <param name="image">the image used to draw the car</param>
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
            if (Map == 1)
            {
                if (getPosition().X > 124 && getPosition().X < 360 && getPosition().Y > 510 && getPosition().Y < 620)
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

                    if (getPosition().X > 250 && getPosition().X < 370 && getPosition().Y > 150 && getPosition().Y < 200)
                    {
                        check1 = true;
                    }
                    if (getPosition().X > 900 && getPosition().X < 1010 && getPosition().Y > 560 && getPosition().Y < 620)
                    {
                        check2 = true;
                    }
                    if (getPosition().Y > 310 && getPosition().Y < 430 && getPosition().X > 540 && getPosition().X < 580)
                    {
                        check3 = true;
                    }
                    if (getPosition().Y > 540 && getPosition().Y < 745 && getPosition().X > 210 && getPosition().X < 260 && check2)
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
                        if (laps == 4 && pitCount > 0)
                        {
                        Sounds.Finish.PlaySync();
                        Sounds.Victory.Play();
                            MessageBox.Show("You win!");
                        }
                    }
            }

        }

        private void accelerate() 
        {
            if (OutFuel == false){
                    speed = speed + .1;
                    if (speed >= 5.0)
                    {
                        speed = 5.0;
                    }
                }         
        }

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

        private void coast()
        {
            if (speed >= .02)
                speed -= .05;
            else if (speed <= -.02)
                speed += 0.05;
            else
                speed = 0;
        }

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
        /// Calculates the new position for the car
        /// </summary>
        public void calculateNewPosition()
        {
            changeSpeed();
            position.X -= (int)Math.Round(speed * (Math.Cos(rotation * Math.PI / 180))); //pure magic here!
            position.Y -= (int)Math.Round(speed * (Math.Sin(rotation * Math.PI / 180))); //pure next lvl coding
        }
    }
}
