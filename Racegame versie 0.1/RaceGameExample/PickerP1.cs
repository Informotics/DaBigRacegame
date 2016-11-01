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
    public partial class PickerP1 : Form
    {
        public PickerP1()
        {
            InitializeComponent();
        }

        //Creer auto INT
        public static int CarP1;


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //BMW
        private void button1_Click(object sender, EventArgs e)
        {
            Sounds.Klik.Play();
            CarP1 = 1;
            this.Visible = false;
            var myForm = new PickerP2();
            myForm.Show();
        }

        //Ferrari
        private void button3_Click(object sender, EventArgs e)
        {
            Sounds.Klik.Play();
            CarP1 = 2;
            this.Visible = false;
            var myForm = new PickerP2();
            myForm.Show();
        }

        //Mercedes
        private void button2_Click(object sender, EventArgs e)
        {
            Sounds.Klik.Play();
            CarP1 = 3;
            this.Visible = false;
            var myForm = new PickerP2();
            myForm.Show();
        }

        //Porche
        private void button4_Click(object sender, EventArgs e)
        {
            Sounds.Klik.Play();
            CarP1 = 4;
            this.Visible = false;
            var myForm = new PickerP2();
            myForm.Show();
        }
    }
}
