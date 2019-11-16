namespace Opdracht13 {
    partial class Form1 {
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
            this.textboxDaysRented = new System.Windows.Forms.TextBox();
            this.textboxKMDriven = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkboxFuelCostByRenter = new System.Windows.Forms.CheckBox();
            this.textboxLitersTanked = new System.Windows.Forms.TextBox();
            this.labelLitersTanked = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelRentCost = new System.Windows.Forms.Label();
            this.btnCalcRent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hoeveel dagen gehuurd";
            // 
            // textboxDaysRented
            // 
            this.textboxDaysRented.Location = new System.Drawing.Point(189, 6);
            this.textboxDaysRented.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textboxDaysRented.Name = "textboxDaysRented";
            this.textboxDaysRented.Size = new System.Drawing.Size(68, 20);
            this.textboxDaysRented.TabIndex = 1;
            // 
            // textboxKMDriven
            // 
            this.textboxKMDriven.Location = new System.Drawing.Point(189, 30);
            this.textboxKMDriven.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textboxKMDriven.Name = "textboxKMDriven";
            this.textboxKMDriven.Size = new System.Drawing.Size(68, 20);
            this.textboxKMDriven.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hoeveel KM gereden";
            // 
            // checkboxFuelCostByRenter
            // 
            this.checkboxFuelCostByRenter.AutoSize = true;
            this.checkboxFuelCostByRenter.Location = new System.Drawing.Point(11, 57);
            this.checkboxFuelCostByRenter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkboxFuelCostByRenter.Name = "checkboxFuelCostByRenter";
            this.checkboxFuelCostByRenter.Size = new System.Drawing.Size(152, 17);
            this.checkboxFuelCostByRenter.TabIndex = 4;
            this.checkboxFuelCostByRenter.Text = "Tanken op kosten huurder";
            this.checkboxFuelCostByRenter.UseVisualStyleBackColor = true;
            this.checkboxFuelCostByRenter.CheckedChanged += new System.EventHandler(this.CheckboxFuelCostByRenter_CheckedChanged);
            // 
            // textboxLitersTanked
            // 
            this.textboxLitersTanked.Location = new System.Drawing.Point(189, 84);
            this.textboxLitersTanked.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textboxLitersTanked.Name = "textboxLitersTanked";
            this.textboxLitersTanked.Size = new System.Drawing.Size(68, 20);
            this.textboxLitersTanked.TabIndex = 6;
            this.textboxLitersTanked.Visible = false;
            // 
            // labelLitersTanked
            // 
            this.labelLitersTanked.AutoSize = true;
            this.labelLitersTanked.Location = new System.Drawing.Point(9, 85);
            this.labelLitersTanked.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLitersTanked.Name = "labelLitersTanked";
            this.labelLitersTanked.Size = new System.Drawing.Size(110, 13);
            this.labelLitersTanked.TabIndex = 5;
            this.labelLitersTanked.Text = "Hoeveel liters getankt";
            this.labelLitersTanked.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 139);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Huurbedrag";
            // 
            // labelRentCost
            // 
            this.labelRentCost.AutoSize = true;
            this.labelRentCost.Location = new System.Drawing.Point(192, 139);
            this.labelRentCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRentCost.Name = "labelRentCost";
            this.labelRentCost.Size = new System.Drawing.Size(10, 13);
            this.labelRentCost.TabIndex = 8;
            this.labelRentCost.Text = "-";
            // 
            // btnCalcRent
            // 
            this.btnCalcRent.Location = new System.Drawing.Point(12, 108);
            this.btnCalcRent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalcRent.Name = "btnCalcRent";
            this.btnCalcRent.Size = new System.Drawing.Size(246, 29);
            this.btnCalcRent.TabIndex = 9;
            this.btnCalcRent.Text = "Bereken huur";
            this.btnCalcRent.UseVisualStyleBackColor = true;
            this.btnCalcRent.Click += new System.EventHandler(this.BtnCalcRent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 172);
            this.Controls.Add(this.btnCalcRent);
            this.Controls.Add(this.labelRentCost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textboxLitersTanked);
            this.Controls.Add(this.labelLitersTanked);
            this.Controls.Add(this.checkboxFuelCostByRenter);
            this.Controls.Add(this.textboxKMDriven);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textboxDaysRented);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textboxDaysRented;
        private System.Windows.Forms.TextBox textboxKMDriven;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkboxFuelCostByRenter;
        private System.Windows.Forms.TextBox textboxLitersTanked;
        private System.Windows.Forms.Label labelLitersTanked;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelRentCost;
        private System.Windows.Forms.Button btnCalcRent;
    }
}

