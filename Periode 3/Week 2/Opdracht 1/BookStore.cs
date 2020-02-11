using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1 {
    class BookStore {
        private List<Book> books = new List<Book>();

        public void addBook(Book book) {
            books.Add(book);
        }

        public void printInventory() {
            double totalPrice = 0;

            foreach (Book book in books) {
                book.printEntry();
                totalPrice += book.price;
            }

            Console.WriteLine();
            Console.WriteLine($"Total sales price: {totalPrice}");
        }
    }
}
