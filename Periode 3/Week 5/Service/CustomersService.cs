using DAL;
using Model;
using System.Collections.Generic;

namespace Service {
    public class CustomersService
    {
        CustomerDAO customerDAO = new CustomerDAO();
        ReservationDAO reservationDAO = new ReservationDAO();

        public List<Customer> getAll() => customerDAO.getAll();
        public List<Reservation> getReservations(Customer customer) => reservationDAO.getByCustomer(customer);
    }
}
