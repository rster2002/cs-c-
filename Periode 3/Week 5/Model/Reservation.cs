using System;

namespace Model {
    public class Reservation {
        private int id;

        public int Id { get; set; }
        public DateTime ReservationDate { get; set; }
        public Book book;
        public Customer customer;

        public override string ToString() {
            return $"'{book.Title}' reserved by {customer.FullName}";
        }
    }
}
