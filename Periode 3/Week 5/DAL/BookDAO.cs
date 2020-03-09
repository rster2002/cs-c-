using Model;
using Quick.SQLInterface;
using System.Collections.Generic;
using System.Linq;

namespace DAL {
    public class BookDAO {
        private SQLInterface sqlInterface = new SQLInterface();

        public List<Book> GetAll() {
            List<Dictionary<string, object>> records = sqlInterface
                .execute(
                    "SELECT * " +
                    "FROM Books"
                );

            return records
                .Select(toBookObject)
                .ToList();
        }

        public Book GetById(int id) {
            List<Dictionary<string, object>> records = sqlInterface
                .param("id", id)
                .execute(
                    "SELECT *" +
                    "FROM Books" +
                    "WHERE Id = @id"
                );

            return toBookObject(records[0]);
        }

        private Book toBookObject(Dictionary<string, object> record) {
            return new Book() {
                Title = (string) record["Title"],
                Author = (string) record["Author"],
                Id = (int) record["Id"]
            };
        }
    }
}
