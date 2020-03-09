using System;

namespace Quick {
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
}
