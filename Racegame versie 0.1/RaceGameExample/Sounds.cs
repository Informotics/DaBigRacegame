using System.Media;
using RaceGameExample.Properties;


namespace RaceGameExample
{
    public static class Sounds
    {
        public static SoundPlayer BANG = new SoundPlayer();
        public static SoundPlayer BOOM = new SoundPlayer();
        public static SoundPlayer KABOOM = new SoundPlayer();
        public static SoundPlayer KAPOW = new SoundPlayer();
        public static SoundPlayer KLETS = new SoundPlayer();
        public static SoundPlayer PATS = new SoundPlayer();
        public static SoundPlayer Finallap = new SoundPlayer();
        public static SoundPlayer Finish = new SoundPlayer();
        public static SoundPlayer Car1Speed1 = new SoundPlayer();
        public static SoundPlayer Car1Speed2 = new SoundPlayer();
        public static SoundPlayer Car1Speed3 = new SoundPlayer();
        public static SoundPlayer Car2Speed1 = new SoundPlayer();
        public static SoundPlayer Car2Speed2 = new SoundPlayer();
        public static SoundPlayer Car2Speed3 = new SoundPlayer();
        public static SoundPlayer Offroad = new SoundPlayer();
        public static SoundPlayer Refill = new SoundPlayer();
        public static SoundPlayer Klik = new SoundPlayer(Resources.Click1);

        public static void loadSounds()
        {
            BANG.Load();
            BOOM.Load();
            KABOOM.Load();
            KAPOW.Load();
            KLETS.Load();
            PATS.Load();
            Finallap.Load();
            Finish.Load();
            Car1Speed1.Load();
            Car1Speed2.Load();
            Car1Speed3.Load();
            Car2Speed1.Load();
            Car2Speed2.Load();
            Car2Speed3.Load();
            Offroad.Load();
            Refill.Load();
            Klik.Load();
        }
    }
}
