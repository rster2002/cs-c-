using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_3 {
    class Program {
        static void Main(string[] args) {
            Program program = new Program();
            program.start();
        }

        void start() {
            MP3Player player = new MP3Player();

            player.addSong(new Song(
                title: "Wish You Where Here",
                author: "Pink Floyd",
                playTimeInSeconds: 192
            ));

            player.addSong(new Song(
                title: "Dazed and Confused",
                author: "Led Zeppelin",
                playTimeInSeconds: 240
            ));

            player.addSong(new Song(
                title: "Billionaire",
                author: "Bruno Mars",
                playTimeInSeconds: 213
            ));

            SimpleMP3Display mp3Display1 = new SimpleMP3Display(player);
            FancyMP3Display mp3Display2 = new FancyMP3Display(player);

            player.nextSong();
            player.nextSong();
            player.nextSong();

            Console.ReadKey();
        }
    }
}
