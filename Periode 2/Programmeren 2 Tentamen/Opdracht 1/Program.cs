using System;

namespace Opdracht_1 {
    class Program {
        const string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz.,?!#@%$ ";

        static void Main(string[] args) {
            Program program = new Program();
            program.start();
        }

        void start() {
            string secretKey = createSecretKey(32);

            Console.WriteLine($"Geheime sleutel: {secretKey}");

            Console.Write("Geef een bericht: ");
            string message = Console.ReadLine();

            try {
                string encryptedMessage = oneTimePad(message, secretKey);

                Console.WriteLine($"Versleuteld bericht: {encryptedMessage}");
            } catch (Exception exception) {
                Console.WriteLine($"Fout opgetreden tijdens het versleutelen: {exception.Message}");
            }

            Console.ReadKey();
        }

        string createSecretKey(int length) {
            Random random = new Random();
            string key = "";

            for (int i = 1; i <= length; i++) {
                int randomIndex = random.Next(0, alphabet.Length);

                key += alphabet[randomIndex];
            }

            return key;
        }

        string oneTimePad(string message, string key) {
            string encryptedMessage = "";

            for (int i = 0; i < message.Length; i++) {
                char messageChar = message[i];
                char keyChar = key[i];

                int indexMessageChar = alphabet.IndexOf(messageChar);
                int indexKeyChar = alphabet.IndexOf(keyChar);

                if (indexMessageChar == -1) throw new Exception($"karacter {messageChar} komt niet voor in het gebruikte alphabet");

                int secretCharacterIndex = (indexMessageChar + indexKeyChar) % alphabet.Length;

                encryptedMessage += alphabet[secretCharacterIndex];
            }

            return encryptedMessage;
        }
    }
}
