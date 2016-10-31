using System;
using System.Media;
using RaceGameExample.Properties;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RaceGameExample
{
    public static class Sounds
    {
        public static SoundPlayer Klik = new SoundPlayer(Resources.Click1);

        public static void loadSounds()
        {
            Klik.Load();
        }
    }
}
