using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RaceGameExample
{
    public partial class PickerP2 : Form
    {
        public PickerP2()
        {
            InitializeComponent();
        }

        //Creer auto INT .
        public static int CarP2;


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //BMW
        private void button1_Click(object sender, EventArgs e)
        {
            Sounds.Klik.Play();
            CarP2 = 1;
            this.Visible = false;
            var myForm = new formRaceGame();
            myForm.Show();
        }

        //Ferrari
        private void button3_Click(object sender, EventArgs e)
        {
            Sounds.Klik.Play();
            CarP2 = 2;
            this.Visible = false;
            var myForm = new formRaceGame();
            myForm.Show();
        }

        //Mercedes
        private void button2_Click(object sender, EventArgs e)
        {
            Sounds.Klik.Play();
            CarP2 = 3;
            this.Visible = false;
            var myForm = new formRaceGame();
            myForm.Show();
        }

        //Porche
        private void button4_Click(object sender, EventArgs e)
        {
            Sounds.Klik.Play();
            CarP2 = 4;
            this.Visible = false;
            var myForm = new formRaceGame();
            myForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Sounds.Klik.PlaySync();
            Sounds.Go.Play();
            this.Visible = false;
            var myForm = new PickerP1();
            myForm.Show();
        }
    }
}
