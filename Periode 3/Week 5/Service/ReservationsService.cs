using DAL;
using Model;
using System.Collections.Generic;

namespace Service {
    public class ReservationsService {
        ReservationDAO reservationDAO = new ReservationDAO();

        public List<Reservation> getAll() => reservationDAO.getAll();
        public List<Reservation> getByCustomer(Customer customer) => reservationDAO.getByCustomer(customer);
        public List<Reservation> getByBook(Book book) => reservationDAO.getByBook(book);
    }
}
