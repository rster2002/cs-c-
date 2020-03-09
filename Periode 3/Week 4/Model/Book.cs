using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Book {
        private int id;

        public string Author { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }

        public override string ToString() {
            return $"{Id}. '{Title}' by {Author}";
        }
    }
}
