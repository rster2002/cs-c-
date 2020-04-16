using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1 {
    class BookStore {
        private List<BookStoreItem> items = new List<BookStoreItem>();

        public void add(BookStoreItem item) => items.Add(item);

        public void printAllItems() {
            foreach (BookStoreItem item in items) {
                Console.WriteLine(item);
            }
        }
    }
}
