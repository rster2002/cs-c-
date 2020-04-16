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

            bookStore.add(new Book() {
                author = "Bram Stoker",
                title = "Dracula",
                price = 15.00f,
                numberOfItems = 5,
            });

            bookStore.add(new Book() {
                author = "Tommy Wieringa",
                title = "Joe speedboat",
                price = 12.50f,
                numberOfItems = 3,
            });

            bookStore.add(new Magazine() {
                title = "Time",
                releaseDay = DayOfWeek.Friday,
                price = 3.90f,
                numberOfItems = 10,
            });

            bookStore.add(new Magazine() {
                title = "Donald Duck",
                releaseDay = DayOfWeek.Thursday,
                price = 2.50f,
                numberOfItems = 15,
            });

            bookStore.add(new CD() {
                title = "The Cure",
                artist = "Seventeen Seconds",
                price = 3.90f,
                numberOfItems = 5,
            });

            bookStore.printAllItems();

            Console.ReadKey();
        }
    }
}
