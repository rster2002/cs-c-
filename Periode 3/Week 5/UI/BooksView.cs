using Model;
using Service;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UI {
    public partial class BooksView:Form {
        public BooksView() {
            InitializeComponent();
            refreshBooks();
        }

        public void refreshBooks() {
            BooksServices booksServices = new BooksServices();
            List<Book> books = booksServices.getAll();

            cmbBoxBooks.Items.Clear();

            foreach (Book book in books) {
                cmbBoxBooks.Items.Add(book);
            }

            cmbBoxBooks.SelectedIndex = 0;
        }

        private void cmbBoxBooks_SelectedIndexChanged(object sender, EventArgs e) {
            if (cmbBoxBooks.Items.Count == 0) return;

            ReservationsService reservationsService = new ReservationsService();

            Book selectedBook = (Book) cmbBoxBooks.SelectedItem;
            List<Reservation> reservations = reservationsService.getByBook(selectedBook);

            reservedByList.Items.Clear();

            foreach (Reservation reservation in reservations) {
                reservedByList.Items.Add(reservation.customer.ToString());
            }
        }
    }
}
