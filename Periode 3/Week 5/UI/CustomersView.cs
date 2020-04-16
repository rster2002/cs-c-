using Model;
using Service;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UI {
    public partial class CustomersView:Form {
        CustomersService customersService = new CustomersService();
        ReservationsService reservationsService = new ReservationsService();

        public CustomersView() {
            InitializeComponent();

            refreshCustomersList();
        }

        private void refreshCustomersList() {
            cmbBoxCustomers.Items.Clear();

            List<Customer> customers = customersService.getAll();

            foreach (Customer customer in customers) {
                cmbBoxCustomers.Items.Add(customer);
            }

            if (customers.Count > 0) {
                cmbBoxCustomers.SelectedIndex = 0;
            }
        }

        private void cmbBoxCustomers_SelectedIndexChanged(object sender, EventArgs e) {
            if (cmbBoxCustomers.Items.Count == 0) {
                return;
            }

            List<Reservation> reservations = reservationsService.getByCustomer((Customer) cmbBoxCustomers.SelectedItem);

            reservationsListView.Items.Clear();

            foreach (Reservation reservation in reservations) {
                reservationsListView.Items.Add(new ListViewItem() {
                    Text = reservation.ToString(),
                    Tag = reservation
                });
            }
        }
    }
}
