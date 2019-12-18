using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Quick.Input;

namespace Opdracht_3 {
    class Program {
        const string fileNamePath = "./dictionary.csv";
        Input input = new Input(invalidStringMessage: "Dit is geen geldige invoer");

        static void Main(string[] args) {
            Program program = new Program();
            program.start();
        }

        void start() {
            try {
                if (File.Exists(path: fileNamePath)) {
                    Dictionary<string, string> translationMap = readTranslationFile(path: fileNamePath);

                    translateWords(translationMap: translationMap);
                } else {
                    throw new Exception("Het bestand kon niet worden gevonden");
                }
            } catch (Exception exception) {
                Console.WriteLine("Er is een fout opgetreden: ");
                Console.WriteLine(exception.Message);
                Console.ReadKey();
            }
        }

        Dictionary<string, string> readTranslationFile(string path) {
            try {
                using (StreamReader streamReader = new StreamReader(path)) {
                    Dictionary<string, string> translationMap = new Dictionary<string, string>();

                    while (!streamReader.EndOfStream) {
                        string line = streamReader.ReadLine();
                        string[] words = line.Split(';');

                        translationMap.Add(words[0], words[1]);
                    }

                    return translationMap;
                }
            } catch (Exception exception) {
                throw exception;
            }
        }

        void translateWords(Dictionary<string, string> translationMap) {
            Console.WriteLine("Voer 'stop' in om te stoppen met woorden vertalen.");
            Console.WriteLine("Voer 'listall' in om alle vertalingen te laten zien.");

            while (true) {
                string dutchWord = input.readString("Geef een (nederlands) woord om te vertalen: ");

                if (dutchWord == "stop") {
                    return;
                } else if (dutchWord == "listall") {
                    showAllTranslations(translationMap: translationMap);
                } else {
                    if (translationMap.ContainsKey(dutchWord)) {
                        string englishWord = translationMap[dutchWord];

                        showTranslation(originalWord: dutchWord, translatedWord: englishWord);
                    } else {
                        Console.WriteLine("Dit woord staat niet in het woordenboek");
                    }

                    Console.WriteLine();
                }
            }
        }

        void showTranslation(string originalWord, string translatedWord) {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"'{originalWord}' => '{translatedWord}'");
            Console.ResetColor();
        }

        void showAllTranslations(Dictionary<string, string> translationMap) {
            foreach (KeyValuePair<string, string> translation in translationMap) {
                showTranslation(originalWord: translation.Key, translatedWord: translation.Value);
            }
        }
    }
}
