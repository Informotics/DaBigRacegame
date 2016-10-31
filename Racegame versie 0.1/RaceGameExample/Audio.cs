using System.Media;

namespace RaceGame
{
    /// <summary>
    /// Class waar de audiofiles zich in bevinden.
    /// </summary>
    public static class AudioFiles
    {
        public static SoundPlayer Click1 = new SoundPlayer("Click1.wav");

        public static bool IsCrashing = false;

        public static void loadSounds()
        {
            Click1.Load();

        }
    }
}

