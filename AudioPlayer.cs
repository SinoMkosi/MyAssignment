using System;
using System.Media;
using System.IO;

namespace MyAssignment
{
    public class AudioPlayer

    {
       public static void PlayGreeting()
        {
            SoundPlayer player = new SoundPlayer("greeting.wav");
            player.PlaySync();
        }
    }
}

