using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quick.SQLInterface;
using System.IO;

namespace Quick_Testing {
    public class UserDAO: SQLInterface<User> {
        private void BasicSelect() {
            Line("SELECT *");
            Line("FROM [Users];");
        }

        public override List<User> GetAll() {
            BasicSelect();

            return Execute();
        }

        public override User GetById(int id) {
            BasicSelect();
            Line("WHERE [UserId] = @id");

            Param("id", id);

            return Execute()[0];
        }

        protected override User ProcessRecord(Record record) {
            return new User() {
                username = (string) record["Username"],
                salt = (int) record["Salt"]
            };
        }
    }
}
