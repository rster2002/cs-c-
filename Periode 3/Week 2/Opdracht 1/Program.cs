using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1 {
    class Program {
        static void Main(string[] args) {
            Program program = new Program();
            program.start();
        }

        void start() {
            BookStore bookStore = new BookStore();

            bookStore.addBook(new Book() {
                title = "Dracula",
                author = "Bram Stoker",
                price = 15.00            
            });

            bookStore.addBook(new Book() {
                title = "Joe speedboot",
                author = "Tommy Wieringa",
                price = 12.50
            });

            bookStore.addBook(new Magazine() {
                title = "Time",
                author = "IDK",
                price = 3.90,
                dayOfPublication = DayOfWeek.Friday,
            });

            bookStore.addBook(new Magazine() {
                title = "Donald Duck",
                author = "Disney",
                price = 2.15,
                dayOfPublication = DayOfWeek.Thursday,
            });

            bookStore.addBook(new Book() {
                title = "The Hobbit",
                author = "J.R.R. Tolkien",
                price = 12.50
            });

            bookStore.printInventory();

            Console.ReadKey();
        }
    }
}
