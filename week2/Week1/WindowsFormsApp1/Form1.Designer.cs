namespace WindowsFormsApp1 {
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
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.inputTshirts = new System.Windows.Forms.TextBox();
            this.inputPants = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.outputTotal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.outputVat = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.outputPrice = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.outputDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aantal T-shirts (30,00 euro)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Aantal Broeken (100,00 euro)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 95);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(428, 51);
            this.button1.TabIndex = 2;
            this.button1.Text = "Bereken";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // inputTshirts
            // 
            this.inputTshirts.Location = new System.Drawing.Point(302, 15);
            this.inputTshirts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputTshirts.Name = "inputTshirts";
            this.inputTshirts.Size = new System.Drawing.Size(148, 26);
            this.inputTshirts.TabIndex = 3;
            // 
            // inputPants
            // 
            this.inputPants.Location = new System.Drawing.Point(302, 55);
            this.inputPants.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputPants.Name = "inputPants";
            this.inputPants.Size = new System.Drawing.Size(148, 26);
            this.inputPants.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.outputTotal);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.outputVat);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.outputPrice);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.outputDate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(24, 155);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(428, 168);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rekening";
            // 
            // outputTotal
            // 
            this.outputTotal.AutoSize = true;
            this.outputTotal.Location = new System.Drawing.Point(249, 132);
            this.outputTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputTotal.Name = "outputTotal";
            this.outputTotal.Size = new System.Drawing.Size(71, 20);
            this.outputTotal.TabIndex = 7;
            this.outputTotal.Text = "10:10:10";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 132);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "Totaal prijs:";
            // 
            // outputVat
            // 
            this.outputVat.AutoSize = true;
            this.outputVat.Location = new System.Drawing.Point(249, 98);
            this.outputVat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputVat.Name = "outputVat";
            this.outputVat.Size = new System.Drawing.Size(71, 20);
            this.outputVat.TabIndex = 5;
            this.outputVat.Text = "10:10:10";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 98);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "BTW:";
            // 
            // outputPrice
            // 
            this.outputPrice.AutoSize = true;
            this.outputPrice.Location = new System.Drawing.Point(249, 65);
            this.outputPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputPrice.Name = "outputPrice";
            this.outputPrice.Size = new System.Drawing.Size(71, 20);
            this.outputPrice.TabIndex = 3;
            this.outputPrice.Text = "10:10:10";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 65);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Prijs:";
            // 
            // outputDate
            // 
            this.outputDate.AutoSize = true;
            this.outputDate.Location = new System.Drawing.Point(249, 31);
            this.outputDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputDate.Name = "outputDate";
            this.outputDate.Size = new System.Drawing.Size(71, 20);
            this.outputDate.TabIndex = 1;
            this.outputDate.Text = "10:10:10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Datum:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 345);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.inputPants);
            this.Controls.Add(this.inputTshirts);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox inputTshirts;
        private System.Windows.Forms.TextBox inputPants;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label outputDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label outputTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label outputVat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label outputPrice;
        private System.Windows.Forms.Label label6;
    }
}

