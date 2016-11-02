using System.Media;
using RaceGameExample.Properties;


namespace RaceGameExample
{
    public static class Sounds
    {
        public static SoundPlayer BANG = new SoundPlayer(Resources.BANG);
        public static SoundPlayer BOOM = new SoundPlayer(Resources.BOOM);
        public static SoundPlayer Victory = new SoundPlayer(Resources.Victory);
        public static SoundPlayer KAPOW = new SoundPlayer(Resources.KAPOW);
        public static SoundPlayer KLETS = new SoundPlayer(Resources.KLETS);
        public static SoundPlayer PATS = new SoundPlayer(Resources.PATS);
        public static SoundPlayer Finallap = new SoundPlayer(Resources.Finallap);
        public static SoundPlayer Finish = new SoundPlayer(Resources.Finish);
        public static SoundPlayer Car1Speed1 = new SoundPlayer(Resources.Car1Speed1);
        public static SoundPlayer Car1Speed2 = new SoundPlayer(Resources.Car1Speed2);
        public static SoundPlayer Car1Speed3 = new SoundPlayer(Resources.Car1Speed3);
        public static SoundPlayer Car2Speed1 = new SoundPlayer(Resources.Car2Speed1);
        public static SoundPlayer Car2Speed2 = new SoundPlayer(Resources.Car2Speed2);
        public static SoundPlayer Car2Speed3 = new SoundPlayer(Resources.Car2Speed3);
        public static SoundPlayer Offroad = new SoundPlayer(Resources.Offroad);
        public static SoundPlayer Refill = new SoundPlayer(Resources.Refill);
        public static SoundPlayer Klik = new SoundPlayer(Resources.Click1);
        public static SoundPlayer Countdown = new SoundPlayer(Resources.Countdown);
        public static SoundPlayer Refill2 = new SoundPlayer(Resources.Refill2);

        public static void loadSounds()
        {
            BANG.Load();
            BOOM.Load();
            Victory.Load();
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
            Countdown.Load();
            Refill2.Load();
        }
    }
}
