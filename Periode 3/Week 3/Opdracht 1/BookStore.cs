using System;
using System.Collections.Generic;
using System.Linq;

namespace Opdracht_1 {
    class BookStore {
        private List<BookStoreItem> items = new List<BookStoreItem>();
        public int Count { get { return items.Count; } private set { } }
        public double TotalPrice {
            get {
                return items.Aggregate(0d, (acc, item) => acc + item.price * item.quantity);
            }
            private set { }
        }

        public void addItem(BookStoreItem item) {
            items.Add(item);
        }

        public void printInventory() {
            foreach (BookStoreItem item in items) {
                item.print();
            }

            Console.WriteLine();
            Console.WriteLine($"Total sales price: {TotalPrice}");
        }
    }
}
