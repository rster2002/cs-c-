namespace UI {
    partial class CustomersView {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBoxCustomers = new System.Windows.Forms.ComboBox();
            this.reservationsListView = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search customer";
            // 
            // cmbBoxCustomers
            // 
            this.cmbBoxCustomers.FormattingEnabled = true;
            this.cmbBoxCustomers.Location = new System.Drawing.Point(408, 5);
            this.cmbBoxCustomers.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBoxCustomers.Name = "cmbBoxCustomers";
            this.cmbBoxCustomers.Size = new System.Drawing.Size(381, 21);
            this.cmbBoxCustomers.TabIndex = 1;
            this.cmbBoxCustomers.SelectedIndexChanged += new System.EventHandler(this.cmbBoxCustomers_SelectedIndexChanged);
            // 
            // reservationsListView
            // 
            this.reservationsListView.HideSelection = false;
            this.reservationsListView.Location = new System.Drawing.Point(8, 53);
            this.reservationsListView.Margin = new System.Windows.Forms.Padding(2);
            this.reservationsListView.Name = "reservationsListView";
            this.reservationsListView.Size = new System.Drawing.Size(781, 386);
            this.reservationsListView.TabIndex = 2;
            this.reservationsListView.UseCompatibleStateImageBehavior = false;
            this.reservationsListView.View = System.Windows.Forms.View.List;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Reservations:";
            // 
            // CustomersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reservationsListView);
            this.Controls.Add(this.cmbBoxCustomers);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CustomersView";
            this.Text = "CustomersForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBoxCustomers;
        private System.Windows.Forms.ListView reservationsListView;
        private System.Windows.Forms.Label label2;
    }
}