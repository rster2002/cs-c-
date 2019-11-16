namespace Opdracht6 {
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
            this.inputStartKM = new System.Windows.Forms.TextBox();
            this.inputCostPerKM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputEndKM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnErase = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.outputPriceNoVat = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.outputVat = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.outputPriceTotal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.outputDistance = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Begin KM";
            // 
            // inputStartKM
            // 
            this.inputStartKM.Location = new System.Drawing.Point(121, 10);
            this.inputStartKM.Name = "inputStartKM";
            this.inputStartKM.Size = new System.Drawing.Size(100, 20);
            this.inputStartKM.TabIndex = 1;
            // 
            // inputCostPerKM
            // 
            this.inputCostPerKM.Location = new System.Drawing.Point(121, 62);
            this.inputCostPerKM.Name = "inputCostPerKM";
            this.inputCostPerKM.Size = new System.Drawing.Size(100, 20);
            this.inputCostPerKM.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prijs per KM";
            // 
            // inputEndKM
            // 
            this.inputEndKM.Location = new System.Drawing.Point(121, 36);
            this.inputEndKM.Name = "inputEndKM";
            this.inputEndKM.Size = new System.Drawing.Size(100, 20);
            this.inputEndKM.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Eind KM";
            // 
            // btnErase
            // 
            this.btnErase.Location = new System.Drawing.Point(227, 8);
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(75, 23);
            this.btnErase.TabIndex = 5;
            this.btnErase.Text = "Wissen";
            this.btnErase.UseVisualStyleBackColor = true;
            this.btnErase.Click += new System.EventHandler(this.BtnErase_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(227, 60);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Bereken";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.outputDistance);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.outputPriceTotal);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.outputVat);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.outputPriceNoVat);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(16, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 114);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bedragen";
            // 
            // outputPriceNoVat
            // 
            this.outputPriceNoVat.AutoSize = true;
            this.outputPriceNoVat.Location = new System.Drawing.Point(208, 41);
            this.outputPriceNoVat.Name = "outputPriceNoVat";
            this.outputPriceNoVat.Size = new System.Drawing.Size(10, 13);
            this.outputPriceNoVat.TabIndex = 1;
            this.outputPriceNoVat.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Prijs excl. BTW";
            // 
            // outputVat
            // 
            this.outputVat.AutoSize = true;
            this.outputVat.Location = new System.Drawing.Point(208, 65);
            this.outputVat.Name = "outputVat";
            this.outputVat.Size = new System.Drawing.Size(10, 13);
            this.outputVat.TabIndex = 3;
            this.outputVat.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "BTW";
            // 
            // outputPriceTotal
            // 
            this.outputPriceTotal.AutoSize = true;
            this.outputPriceTotal.Location = new System.Drawing.Point(208, 91);
            this.outputPriceTotal.Name = "outputPriceTotal";
            this.outputPriceTotal.Size = new System.Drawing.Size(10, 13);
            this.outputPriceTotal.TabIndex = 5;
            this.outputPriceTotal.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Prijs incl. BTW";
            // 
            // outputDistance
            // 
            this.outputDistance.AutoSize = true;
            this.outputDistance.Location = new System.Drawing.Point(208, 16);
            this.outputDistance.Name = "outputDistance";
            this.outputDistance.Size = new System.Drawing.Size(10, 13);
            this.outputDistance.TabIndex = 7;
            this.outputDistance.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Afstand in KM";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(308, 214);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnErase);
            this.Controls.Add(this.inputEndKM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputCostPerKM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputStartKM);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputStartKM;
        private System.Windows.Forms.TextBox inputCostPerKM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputEndKM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnErase;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label outputPriceNoVat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label outputPriceTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label outputVat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label outputDistance;
        private System.Windows.Forms.Label label7;
    }
}

