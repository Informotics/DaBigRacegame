using System.Media;
using RaceGameExample.Properties;


namespace RaceGameExample
{
    public static class Sounds
    {
        public static SoundPlayer Victory = new SoundPlayer(Resources.Victory);
        public static SoundPlayer Finallap = new SoundPlayer(Resources.Finallap);
        public static SoundPlayer Finish = new SoundPlayer(Resources.Finish);
        public static SoundPlayer Refill = new SoundPlayer(Resources.Refill);
        public static SoundPlayer Klik = new SoundPlayer(Resources.Click1);
        public static SoundPlayer Countdown = new SoundPlayer(Resources.Countdown);
        public static SoundPlayer Player1Win = new SoundPlayer(Resources.Player1wins);
        public static SoundPlayer Player2Win = new SoundPlayer(Resources.Player2wins);

        public static void loadSounds()
        {
            Finallap.Load();
            Finish.Load();
            Refill.Load();
            Klik.Load();
            Countdown.Load();
            Player1Win.Load();
            Player2Win.Load();
        }
    }
}
