using System;

namespace Opdracht_1 {
    class Program {
        static void Main(string[] args) {
            Program program = new Program();
            program.start();
        }

        void start() {
            BookStore bookStore = new BookStore();

            bookStore.addItem(new Book() {
                title = "Dracula",
                author = "Bram Stoker",
                price = 15.00,
                quantity = 6,
            });

            bookStore.addItem(new Book() {
                title = "Joe speedboot",
                author = "Tommy Wieringa",
                price = 12.50,
                quantity = 18,
            });

            bookStore.addItem(new Magazine() {
                title = "Time",
                price = 3.90,
                dayOfPublication = DayOfWeek.Friday,
                quantity = 83,
            });

            bookStore.addItem(new Magazine() {
                title = "Donald Duck",
                price = 2.15,
                dayOfPublication = DayOfWeek.Thursday,
                quantity = 73,
            });

            bookStore.addItem(new Book() {
                title = "The Hobbit",
                author = "J.R.R. Tolkien",
                price = 12.50,
                quantity = 4,
            });

            bookStore.printInventory();

            Console.ReadKey();
        }
    }
}
