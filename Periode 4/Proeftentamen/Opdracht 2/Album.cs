using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_2 {
    class Album: IVinylAlbum {
        public string Band { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }

        public Album(string band, string title, int year) {
            Band = band;
            Title = title;
            Year = year;
        }

        public void Pause() {
            Console.WriteLine($"Paused playing album '{ToString()}'");
        }

        public void Play() {
            Console.WriteLine($"playing album '{ToString()}'");
        }

        public void Stop() {
            Console.WriteLine($"Stopped playing album '{ToString()}'");
        }

        public override string ToString() {
            return $"{Title}, {Band} ({Year})";
        }
    }
}
