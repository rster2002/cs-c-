using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Opdracht_2 {
    class Program {
        static void Main(string[] args) {
            Program myProgram = new Program();
            myProgram.Start();
        }

        void Start() {
            List<IVinylSingle> singles = ReadSingles(".\\..\\..\\files\\singles.csv");
            List<IVinylAlbum> albums = ReadAlbums(".\\..\\..\\files\\albums.csv");

            // create jukebox
            JukeBox jukeBox = new JukeBox(singles);

            List<AlbumAdapter> albumSingles = albums.Select(album => new AlbumAdapter(album)).ToList();
            jukeBox.Singles.AddRange(albumSingles);

            // select single
            Console.Write("Select a single to play {0}..{1}: ", 1, jukeBox.Singles.Count);
            int index = int.Parse(Console.ReadLine());

            while (index > 0) {
                jukeBox.SelectSingle(index);

                // play selected single
                jukeBox.Afspelen();

                Console.WriteLine();

                // select next single
                Console.Write("Select a number to play {0}..{1}: ", 1, jukeBox.Singles.Count);
                index = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("end of program...");
            Console.ReadKey();
        }

        List<IVinylSingle> ReadSingles(string filename) {
            // format file: <ranking;title;artist>

            List<IVinylSingle> singles = new List<IVinylSingle>();

            if (!File.Exists(filename))
                return singles;

            StreamReader reader = new StreamReader(filename);
            while (!reader.EndOfStream) {
                string line = reader.ReadLine();
                string[] items = line.Split(';');
                Single single = new Single(int.Parse(items[0]), items[1], items[2]);
                singles.Add(single);
            }
            reader.Close();

            return singles;
        }

        List<IVinylAlbum> ReadAlbums(string filename) {
            // format file: <title;band;year>

            List<IVinylAlbum> albums = new List<IVinylAlbum>();
            List<string> lines = File.ReadLines(filename).ToList();

            foreach (string line in lines) {
                string[] items = line.Split(';');

                albums.Add(new Album(
                    title: items[0],
                    band: items[1],
                    year: int.Parse(items[2])
                ));
            }

            return albums;
        }
    }
}
