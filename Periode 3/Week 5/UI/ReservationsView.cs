using Model;
using Service;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UI {
    public partial class ReservationsView:Form {
        public ReservationsView() {
            InitializeComponent();
            refreshReservations();
        }

        public void refreshReservations() {
            ReservationsService reservationsService = new ReservationsService();
            List<Reservation> reservations = reservationsService.getAll();

            reservationsList.Items.Clear();

            foreach (Reservation reservation in reservations) {
                ListViewItem item = new ListViewItem(reservation.Id.ToString());
                item.SubItems.Add(reservation.customer.ToString());
                item.SubItems.Add(reservation.book.ToString());

                reservationsList.Items.Add(item);
            }
        }
    }
}
