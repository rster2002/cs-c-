using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Quick
{
    namespace Input {
        public class Input {
            private string defaultInvalidIntMessage = "Dit is geen geldig getal";
            private string defaultInvalidStringMessage = "Dit is geen geldige invoer";
            private string defaultInvalidCharMessage = "Dit is geen letter";

            public Input(string invalidIntMessage = "", string invalidStringMessage = "", string invalidCharMessage = "") {
                if (invalidIntMessage.Length > 0) defaultInvalidIntMessage = invalidIntMessage;
                if (invalidStringMessage.Length > 0) defaultInvalidStringMessage = invalidStringMessage;
                if (invalidCharMessage.Length > 0) defaultInvalidCharMessage = invalidCharMessage;
            }

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

                    if (input.Length > 0) {
                        bool validInput = validationMethod(input);

                        if (validInput) {
                            return input;
                        } else {
                            Console.WriteLine(invalidInputMessage);
                        }
                    } else {
                        Console.WriteLine(defaultInvalidStringMessage);
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
                return internalReadInt(message, defaultInvalidIntMessage, i => true);
            }

            public int readInt(string message, string invalidInputMessage) {
                return internalReadInt(message, invalidInputMessage, i => true);
            }

            public int readInt(string message, int min, int max) {
                return internalReadInt(message, defaultInvalidIntMessage, i => i >= min && i <= max);
            }

            public int readInt(string message, string invalidInputMessage, int min, int max) {
                return internalReadInt(message, invalidInputMessage, i => i >= min && i <= max);
            }

            public int readInt(string message, Func<int, bool> validationMethod) {
                return internalReadInt(message, defaultInvalidIntMessage, validationMethod);
            }

            public int readInt(string message, string invalidInputMessage, Func<int, bool> validationMethod) {
                return internalReadInt(message, invalidInputMessage, validationMethod);
            }

            public string readString(string message) {
                return internalReadString(message, defaultInvalidStringMessage, i => true);
            }

            public string readString(string message, Func<string, bool> validationMethod) {
                return internalReadString(message, defaultInvalidStringMessage, validationMethod);
            }

            public string readString(string message, string invalidInputMessage, Func<string, bool> validationMethod) {
                return internalReadString(message, invalidInputMessage, validationMethod);
            }

            public char readChar(string message) {
                return internalReadChar(message, defaultInvalidCharMessage, i => true);
            }

            public char readChar(string message, Func<char, bool> validationMethod) {
                return internalReadChar(message, defaultInvalidCharMessage, validationMethod);
            }

            public char readChar(string message, string invalidInputMessage, Func<char, bool> validationMethod) {
                return internalReadChar(message, invalidInputMessage, validationMethod);
            }
        }
    }

    namespace FS {
        public class FileRef {
            public string filePath;

            public FileRef(string filePath) {
                this.filePath = filePath;
            }

            private void internalWriteLines(string path, List<string> lines) {
                StreamWriter streamWriter = new StreamWriter(path: path);

                foreach (string line in lines) {
                    streamWriter.WriteLine(line);
                }

                streamWriter.Close();
            }

            private void internalAppendLines(string path, List<string> lines) {
                StreamWriter streamWriter = new StreamWriter(path: path, append: true);

                foreach (string line in lines) {
                    streamWriter.WriteLine(line);
                }

                streamWriter.Close();
            }

            private List<string> internalReadToList(string path) {
                if (File.Exists(path)) {
                    List<string> lines = new List<string>();
                    StreamReader streamReader = new StreamReader(path);

                    while (!streamReader.EndOfStream) {
                        lines.Add(streamReader.ReadLine());
                    }

                    streamReader.Close();

                    return lines;
                } else {
                    throw new Exception("Files does not exists");
                }
            }

            public void writeLines(List<string> lines) {
                internalWriteLines(path: filePath, lines: lines);
            }

            public void writeLines(string path, List<string> lines) {
                internalWriteLines(path: path, lines: lines);
            }

            public void appendLines(List<string> lines) {
                internalAppendLines(path: filePath, lines: lines);
            }

            public void appendLines(string path, List<string> lines) {
                internalAppendLines(path: path, lines: lines);
            }

            public List<string> readToList() {
                return internalReadToList(path: filePath);
            }

            public List<string> readToList(string path) {
                return internalReadToList(path: path);
            }
            
            private void internalForLines(string path, Action<string> action) {
                List<string> lines = internalReadToList(path: path);

                foreach (string line in lines) {
                    action(line);
                }
            }

            public void forLines(Action<string> action) {
                internalForLines(path: filePath, action: action);
            }

            public void forLines(string path, Action<string> action) {
                internalForLines(path: path, action: action);
            }
        }
    }
}
