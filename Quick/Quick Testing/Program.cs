using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quick.SQLInterface;

namespace Quick_Testing {
    class Program {
        static void Main(string[] args) {
            SQLInterface.setGlobalConfigString(ConfigurationManager.ConnectionStrings["sandbox"].ConnectionString);

            Program program = new Program();
            program.start();
        }

        void start() {
            UserDAO userDAO = new UserDAO();
            List<User> users = userDAO.getAll();

            foreach (User user in users) {
                Console.WriteLine("{0}: {1}", user.username, user.salt);
            }

            User admin = userDAO.getById(2);
            Console.WriteLine("{0}: {1}", admin.username, admin.salt);

            Console.ReadKey();
        }
    }
}
