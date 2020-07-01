using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_2 {
    class Single: IVinylSingle {
        public string Artist { get; set; }
        public string Title { get; set; }
        public int Ranking { get; set; }

        public Single(int ranking, string title, string artist) {
            Ranking = ranking;
            Title = title;
            Artist = artist;
        }

        public void Pause() {
            Console.WriteLine($"Paused playing single '{ToString()}'");
        }

        public void Play() {
            Console.WriteLine($"playing single '{ToString()}'");
        }

        public void Stop() {
            Console.WriteLine($"Stopped playing single '{ToString()}'");
        }

        public override string ToString() {
            return $"{Title}, {Artist} ({Ranking})";
        }
    }
}
