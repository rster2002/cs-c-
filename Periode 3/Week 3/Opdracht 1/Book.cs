using System;

namespace Opdracht_1 {
    class Book: BookStoreItem {
        public string Author { get; private set; }
        private string author;

        public Book() { }

        public Book(string title, string author, double price) {
            this.title = title;
            this.author = author;
            this.price = price;
        }

        override public void print() {
            Console.WriteLine($"[Book] {title} by {author}, {price} ({quantity}x)");
        }
    }
}
