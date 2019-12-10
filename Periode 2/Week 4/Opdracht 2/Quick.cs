using System;
using System.Collections.Generic;
using System.IO;

// Version 4

namespace Quick {
    namespace Input {
        class Input {
            private string defaultInvalidInputMessage = "Dit is geen geldig getal";

            private int internalReadInt(string message, string invalidInputMessage, Func<int, bool> validationMethod) {
                while (true) {
                    Console.Write(message);

                    bool validNumber = int.TryParse(Console.ReadLine(), out int input);

                    if (validNumber) {
                        bool validInput = validationMethod(input);

                        if (validInput) {
                            return input;
                        } else {
                            Console.WriteLine(invalidInputMessage, input);
                        }
                    } else {
                        Console.WriteLine("Dit is geen geldig getal");
                    }
                }
            }

            private string internalReadString(string message, string invalidInputMessage, Func<string, bool> validationMethod) {
                while (true) {
                    Console.Write(message);
                    string input = Console.ReadLine();

                    bool validInput = validationMethod(input);

                    if (validInput) {
                        return input;
                    } else {
                        Console.WriteLine(invalidInputMessage);
                    }
                }
            }

            private char internalReadChar(string message, string invalidInputMessage, Func<char, bool> validationMethod) {
                while (true) {
                    Console.Write(message);
                    char input = Console.ReadKey().KeyChar;

                    Console.Write("\n");

                    bool validInput = validationMethod(input);

                    if (validInput) {
                        return input;
                    } else {
                        Console.WriteLine(invalidInputMessage);
                    }
                }
            }

            public int readInt(string message) {
                return internalReadInt(message, defaultInvalidInputMessage, i => true);
            }

            public int readInt(string message, string invalidInputMessage) {
                return internalReadInt(message, invalidInputMessage, i => true);
            }

            public int readInt(string message, int min, int max) {
                return internalReadInt(message, defaultInvalidInputMessage, i => i >= min && i <= max);
            }

            public int readInt(string message, string invalidInputMessage, int min, int max) {
                return internalReadInt(message, invalidInputMessage, i => i >= min && i <= max);
            }

            public int readInt(string message, Func<int, bool> validationMethod) {
                return internalReadInt(message, defaultInvalidInputMessage, validationMethod);
            }

            public int readInt(string message, string invalidInputMessage, Func<int, bool> validationMethod) {
                return internalReadInt(message, invalidInputMessage, validationMethod);
            }

            public string readString(string message) {
                return internalReadString(message, defaultInvalidInputMessage, i => true);
            }

            public string readString(string message, Func<string, bool> validationMethod) {
                return internalReadString(message, defaultInvalidInputMessage, validationMethod);
            }

            public string readString(string message, string invalidInputMessage, Func<string, bool> validationMethod) {
                return internalReadString(message, invalidInputMessage, validationMethod);
            }

            public char readChar(string message) {
                return internalReadChar(message, defaultInvalidInputMessage, i => true);
            }

            public char readChar(string message, Func<char, bool> validationMethod) {
                return internalReadChar(message, defaultInvalidInputMessage, validationMethod);
            }

            public char readChar(string message, string invalidInputMessage, Func<char, bool> validationMethod) {
                return internalReadChar(message, invalidInputMessage, validationMethod);
            }
        }
    }

    namespace IO {
        class IO {
            private string filePath;

            public IO(string path) {
                filePath = path;
            }

            public bool exists() {
                return File.Exists(filePath);
            }

            public List<string> readToList() {
                List<string> list = new List<string>();

                StreamReader stream = new StreamReader(filePath);

                while (!stream.EndOfStream) {
                    string line = stream.ReadLine();

                    list.Add(line);
                }

                stream.Close();

                return list;
            }

            public List<Dictionary<string, string>> readFromCsv(char seperator = ',') {
                List<Dictionary<string, string>> list = new List<Dictionary<string, string>>();

                StreamReader stream = new StreamReader(filePath);

                string firstLine = stream.ReadLine();
                string[] keys = firstLine.Split(seperator);

                while (!stream.EndOfStream) {
                    string line = stream.ReadLine();
                    string[] values = line.Split(seperator);

                    Dictionary<string, string> dictionary = new Dictionary<string, string>();

                    for (int i = 0; i < keys.Length; i++) {
                        dictionary.Add(keys[i], values[i]);
                    }

                    list.Add(dictionary);
                }

                stream.Close();

                return list;
            }
        }
    }
}
