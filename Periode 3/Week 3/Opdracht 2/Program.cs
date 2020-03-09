using System;

namespace Opdracht_2 {
    class Program {
        static void Main(string[] args) {
            Program program = new Program();

            try {
                program.start();
            } catch (Exception exception) {
                Console.WriteLine(exception.Message);
                Console.ReadKey();
            }
        }

        void start() {
            Customer customer1 = new Customer() {
                Name = "Phonor Lygal",
                DateOfBirth = new DateTime(2012, 4, 4),
            };

            Customer customer2 = new Customer() {
                Name = "Mr Koal",
                DateOfBirth = new DateTime(2001, 8, 14),
            };

            printCustomer(customer1);
            Console.WriteLine();
            printCustomer(customer2);

            Ticket ticket1 = new Ticket() {
                MovieName = "Bohemian Rapsodi",
                Price = 10.50,
                Screen = 1,
                StartDate = new DateTime(2019, 2, 23, 21, 30, 00),
                MinAge = 6,
            };

            Ticket ticket2 = new Ticket() {
                MovieName = "The Prodigy",
                Price = 10.50,
                Screen = 4,
                StartDate = new DateTime(2019, 2, 23, 22, 00, 00),
                MinAge = 16,
            };

            Ticket ticket3 = new Ticket() {
                MovieName = "Green Book",
                Price = 10.50,
                Screen = 5,
                StartDate = new DateTime(2019, 2, 25, 19, 00, 00),
                MinAge = 12,
            };

            Reservation reservation1 = new Reservation() {
                PlacedBy = customer1
            };

            Reservation reservation2 = new Reservation() {
                PlacedBy = customer2
            };

            reservation1.addTicket(ticket1);
            reservation1.addTicket(ticket2);
            reservation1.addTicket(ticket3);

            reservation2.addTicket(ticket1);
            reservation2.addTicket(ticket2);
            reservation2.addTicket(ticket3);

            Console.WriteLine();
            Console.WriteLine();

            reservation1.printReservation();

            Console.WriteLine();

            reservation2.printReservation();

            Console.ReadKey();
        }

        void printCustomer(Customer customer) {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(customer.Name);
            Console.ResetColor();

            Console.WriteLine("Date of birth: {0}", customer.DateOfBirth);
            Console.WriteLine("Age: {0}", customer.Age);
            Console.WriteLine("Date of registration: {0}", customer.DateOfRegistration);
            Console.WriteLine("Discount: {0}", customer.Discount);
        }
    }
}
