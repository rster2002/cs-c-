using Model;
using Quick.SQLInterface;
using System.Collections.Generic;
using System.Linq;

namespace DAL {
    public class ReservationDAO {
        private SQLInterface sqlInterface = new SQLInterface();

        public List<Reservation> GetAll() {
            List<Dictionary<string, object>> records = sqlInterface
                .execute(
                    "SELECT Reservations.Id AS ReservationId, * " +
                    "FROM Reservations " +
                    "JOIN Customers ON Reservations.CustomerId = Customers.Id " +
                    "JOIN Books ON Reservations.BookId = Books.Id;"
                );

            return records
                .Select(toReservationObject)
                .ToList();
        }

        public Reservation GetById(int id) {
            List<Dictionary<string, object>> records = sqlInterface
                .param("id", id)
                .execute(
                    "SELECT *" +
                    "FROM Customers" +
                    "WHERE Id = @id"
                );

            return toReservationObject(records[0]);
        }

        private Reservation toReservationObject(Dictionary<string, object> record) {
            return new Reservation() {
                Id = (int) record["ReservationId"],
                book = new Book() {
                    Id = (int) record["BookId"],
                    Title = (string) record["Title"],
                    Author = (string) record["Author"]
                },
                customer = new Customer() {
                    Id = (int) record["CustomerId"],
                    FirstName = (string) record["FirstName"],
                    LastName = (string) record["LastName"],
                    EmailAddress = (string) record["EmailAddress"]
                }
            };
        }
    }
}
