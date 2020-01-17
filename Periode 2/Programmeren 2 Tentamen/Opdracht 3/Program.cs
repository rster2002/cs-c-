using System;
using System.Collections.Generic;
using System.IO;

namespace Opdracht_3 {
    class Program {
        static void Main(string[] args) {
            Program program = new Program();
            program.start();
        }

        void start() {
            try {
                List<Song> songs = importSongs("top2000-2019.csv");

                List<string> doubleArtists = findDoubleArtists(songs);
                Dictionary<string, List<Song>> doubleTitles = findDoubleTitles(songs);

                printHeader("'dubbele' artiesten");
                printDoubleArtists(doubleArtists);

                Console.WriteLine();

                printHeader("Veel voorkomende titels");
                printDoubleTitles(doubleTitles);

                Console.ReadKey();
            } catch (Exception exception) {
                Console.WriteLine("Fout opgetreden: {0}", exception.Message);
            }
        }

        List<Song> importSongs(string fileName) {
            if (!File.Exists(fileName)) throw new Exception($"Kon het bestand '{fileName}' niet vinden");

            try {
                using (StreamReader streamReader = new StreamReader(fileName)) {
                    List<Song> songs = new List<Song>();

                    while (!streamReader.EndOfStream) {
                        string line = streamReader.ReadLine();
                        string[] fields = line.Split(';');

                        Song song = new Song() {
                            ranking = int.Parse(fields[0]),
                            title = fields[1],
                            artist = fields[2],
                            yearOfPublication = int.Parse(fields[3])
                        };

                        songs.Add(song);
                    }

                    return songs;
                }
            } catch (Exception exception) {
                throw exception;
            }
        }

        void printSongs(List<Song> songs) {
            foreach (Song song in songs) {
                printSong(song);
            }
        }

        void printSong(Song song) {
            Console.WriteLine(
                "{0}. {1} - {2}",
                song.ranking,
                song.title,
                song.artist
            );
        }

        void printHeader(string header) {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(header);
            Console.ResetColor();
        }

        List<string> findDoubleArtists(List<Song> songs) {
            List<string> doubleArtists = new List<string>();

            for (int i = 0; i < songs.Count - 1; i++) {
                Song song = songs[i];
                Song nextSong = songs[i + 1];

                if (song.artist == nextSong.artist && !doubleArtists.Contains(song.artist)) {
                    doubleArtists.Add(song.artist);
                }
            }

            return doubleArtists;
        }

        void printDoubleArtists(List<string> doubleArtists) {
            foreach (string artist in doubleArtists) {
                Console.WriteLine(artist);
            }
        }

        Dictionary<string, List<Song>> findDoubleTitles(List<Song> songs) {
            Dictionary<string, List<Song>> doubleTitles = new Dictionary<string, List<Song>>();

            foreach (Song song in songs) {
                string title = song.title;

                if (!doubleTitles.ContainsKey(title)) {
                    doubleTitles.Add(title, new List<Song>());
                }

                doubleTitles[title].Add(song);
            }

            return doubleTitles;
        }

        void printDoubleTitles(Dictionary<string, List<Song>> doubleTitles) {
            foreach (KeyValuePair<string, List<Song>> entry in doubleTitles) {
                string title = entry.Key;
                List<Song> list = entry.Value;

                if (list.Count >= 3) {
                    Console.WriteLine("{0} ({1}x)", title, list.Count);

                    foreach (Song song in list) {
                        Console.WriteLine("{0, 6}. {1}", song.ranking, song.artist);
                    }
                }
            }
        }
    }
}
