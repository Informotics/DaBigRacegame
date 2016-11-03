using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Media;
using RaceGameExample.Properties;
using System.Windows.Forms;

namespace RaceGameExample
{
    public partial class Splash_Screen : Form
    {

        public Splash_Screen()
        {
            InitializeComponent();
        }


        //Close on escape
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                Application.Exit();
            }
            return base.ProcessDialogKey(keyData);
        }

        //Start knop
        private void button1_Click(object sender, EventArgs e)
        {
            Sounds.Klik.Play();
            this.Visible = false;
            var myForm = new ChooseMap();
            myForm.Show();
        }
    }
}
