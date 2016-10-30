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
    public partial class Splash_Screen : Form
    {
        public Splash_Screen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            var myForm = new formRaceGame();
            myForm.Show();

        }
    }
}
