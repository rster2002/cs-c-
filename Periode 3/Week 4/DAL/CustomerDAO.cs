using Model;
using Quick.SQLInterface;
using System.Collections.Generic;
using System.Linq;

namespace DAL {
    public class CustomerDAO {
        private SQLInterface sqlInterface = new SQLInterface();

        public List<Customer> GetAll() {
            List<Dictionary<string, object>> records = sqlInterface
                .execute(
                    "SELECT * " +
                    "FROM Customers"
                );

            return records
                .Select(toCustomerObject)
                .ToList();
        }

        public Customer GetById(int id) {
            List<Dictionary<string, object>> records = sqlInterface
                .param("id", id)
                .execute(
                    "SELECT *" +
                    "FROM Customers" +
                    "WHERE Id = @id"
                );

            return toCustomerObject(records[0]);
        }

        private Customer toCustomerObject(Dictionary<string, object> record) {
            return new Customer() {
                FirstName = (string) record["FirstName"],
                LastName = (string) record["LastName"],
                EmailAddress = (string) record["EmailAddress"],
                Id = (int) record["Id"]
            };
        }
    }
}
