using System;
using System.Collections.Generic;
using System.Linq;

namespace Opdracht_2 {
    class Reservation {
        // Interface properties
        public Customer PlacedBy { get; set; }
        private List<Ticket> Tickets { get; } = new List<Ticket>();
        public double PriceTotal {
            get {
                double price = Tickets.Sum(x => x.Price);

                return PlacedBy.Discount ? price * 0.90 : price;
            }
        }

        public void addTicket(Ticket ticket) {
            Tickets.Add(ticket);
        }

        public void printReservation() {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Registration placed by {0}", PlacedBy.Name);
            Console.ResetColor();

            foreach (Ticket ticket in Tickets) {
                ticket.printTicket();
            }

            Console.WriteLine("Total cost: {0}", PriceTotal);
        }
    }
}
