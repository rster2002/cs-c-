using DAL;
using Model;
using Quick.SQLInterface;
using System;
using System.Configuration;

namespace UI {
    class Program {
        static void Main(string[] args) {
            SQLInterface.setGlobalConfigString(ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString);

            Program program = new Program();
            program.start();
        }

        void start() {
            ReservationDAO reservationDAO = new ReservationDAO();

            foreach (Reservation reservation in reservationDAO.GetAll()) {
                Console.WriteLine(reservation);
            }

            Console.ReadKey();
        }
    }
}
