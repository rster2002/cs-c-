namespace UI {
    partial class BooksView {
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
            this.cmbBoxBooks = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reservedByList = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // cmbBoxBooks
            // 
            this.cmbBoxBooks.FormattingEnabled = true;
            this.cmbBoxBooks.Location = new System.Drawing.Point(408, 6);
            this.cmbBoxBooks.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBoxBooks.Name = "cmbBoxBooks";
            this.cmbBoxBooks.Size = new System.Drawing.Size(381, 21);
            this.cmbBoxBooks.TabIndex = 2;
            this.cmbBoxBooks.SelectedIndexChanged += new System.EventHandler(this.cmbBoxBooks_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Book";
            // 
            // reservedByList
            // 
            this.reservedByList.HideSelection = false;
            this.reservedByList.Location = new System.Drawing.Point(12, 32);
            this.reservedByList.Name = "reservedByList";
            this.reservedByList.Size = new System.Drawing.Size(776, 406);
            this.reservedByList.TabIndex = 4;
            this.reservedByList.UseCompatibleStateImageBehavior = false;
            this.reservedByList.View = System.Windows.Forms.View.List;
            // 
            // BooksView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reservedByList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBoxBooks);
            this.Name = "BooksView";
            this.Text = "Books";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBoxBooks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView reservedByList;
    }
}