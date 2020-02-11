using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1 {
    class Book {
        public string title;
        public string author;
        public double price;

        public Book() { }

        public Book(string title, string author, double price) {
            this.title = title;
            this.author = author;
            this.price = price;
        }

        public virtual void printEntry() {
            Console.WriteLine($"[Book] {title} by {author}, {price}");
        }
    }
}
