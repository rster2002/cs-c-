namespace Opdracht5 {
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
            this.inputBox1 = new System.Windows.Forms.TextBox();
            this.inputBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.calculateAverage = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.outputAverage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Geef getal 1: ";
            // 
            // inputBox1
            // 
            this.inputBox1.Location = new System.Drawing.Point(117, 10);
            this.inputBox1.Name = "inputBox1";
            this.inputBox1.Size = new System.Drawing.Size(100, 20);
            this.inputBox1.TabIndex = 1;
            // 
            // inputBox2
            // 
            this.inputBox2.Location = new System.Drawing.Point(117, 36);
            this.inputBox2.Name = "inputBox2";
            this.inputBox2.Size = new System.Drawing.Size(100, 20);
            this.inputBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Geef getal 2: ";
            // 
            // inputBox3
            // 
            this.inputBox3.Location = new System.Drawing.Point(117, 62);
            this.inputBox3.Name = "inputBox3";
            this.inputBox3.Size = new System.Drawing.Size(100, 20);
            this.inputBox3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Geef getal 3: ";
            // 
            // calculateAverage
            // 
            this.calculateAverage.Location = new System.Drawing.Point(16, 88);
            this.calculateAverage.Name = "calculateAverage";
            this.calculateAverage.Size = new System.Drawing.Size(201, 23);
            this.calculateAverage.TabIndex = 6;
            this.calculateAverage.Text = "Bereken gemiddelde";
            this.calculateAverage.UseVisualStyleBackColor = true;
            this.calculateAverage.Click += new System.EventHandler(this.CalculateAverage_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Gemiddelde:";
            // 
            // outputAverage
            // 
            this.outputAverage.AutoSize = true;
            this.outputAverage.Location = new System.Drawing.Point(151, 118);
            this.outputAverage.Name = "outputAverage";
            this.outputAverage.Size = new System.Drawing.Size(10, 13);
            this.outputAverage.TabIndex = 8;
            this.outputAverage.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 144);
            this.Controls.Add(this.outputAverage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.calculateAverage);
            this.Controls.Add(this.inputBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Sequentie - opdracht 5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputBox1;
        private System.Windows.Forms.TextBox inputBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button calculateAverage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label outputAverage;
    }
}

