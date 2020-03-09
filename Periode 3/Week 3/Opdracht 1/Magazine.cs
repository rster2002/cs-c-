using System;

namespace Opdracht_1 {
    class Magazine: BookStoreItem {
        public DayOfWeek dayOfPublication { get; set; }

        override public void print() {
            Console.WriteLine($"[Magazine] '{title}' - release day: {dayOfPublication}, {price} ({quantity}x)");
        }
    }
}
