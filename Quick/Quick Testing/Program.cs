using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Quick.SQLInterface;


namespace Quick_Testing {
    class Program {
        static void Main(string[] args) {
            SQLConfig.SetConnectionString(ConfigurationManager.ConnectionStrings["sandbox"].ConnectionString);

            Program program = new Program();
            program.start();
        }

        void start() {
            UserDAO userDAO = new UserDAO();
            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine("Starting timer");
            stopwatch.Start();

            List<User> users = userDAO.GetAll();

            userDAO.GetAll();

            foreach (User user in users) {
                Console.WriteLine("{0}: {1}", user.username, user.salt);
            }

            stopwatch.Stop();
            Console.WriteLine("Stopped timer: " + stopwatch.ElapsedMilliseconds);

            Console.ReadKey();
        }
    }
}
