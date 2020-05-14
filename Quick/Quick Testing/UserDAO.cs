using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quick.SQLInterface;
using System.IO;

namespace Quick_Testing {
    public class UserDAO: SQLInterface {
        public List<int> numbers = new List<int>();

        public List<User> getAll() {
            line("SELECT *");
            line("FROM Users");

            return recordsToUsers(execute());
        }

        public User getById(int id) {
            line("SELECT *");
            line("FROM Users");
            line("WHERE UserId = @id");

            param("id", id);

            return recordToUser(execute()[0]);
        }

        private List<User> recordsToUsers(List<Dictionary<string, object>> records) {
            return records
                .Select(recordToUser)
                .ToList();
        }

        private User recordToUser(Dictionary<string, object> record) {
            return new User() {
                username = (string) record["Username"],
                salt = (int) record["Salt"]
            };
        }
    }
}
