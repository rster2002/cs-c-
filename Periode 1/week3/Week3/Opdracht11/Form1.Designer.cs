namespace Opdracht11 {
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
            this.inputValue1 = new System.Windows.Forms.TextBox();
            this.inputValue2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.outputBiggestNumber = new System.Windows.Forms.Label();
            this.outputAverage = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.outputDifference = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Getal 1";
            // 
            // inputValue1
            // 
            this.inputValue1.Location = new System.Drawing.Point(135, 10);
            this.inputValue1.Name = "inputValue1";
            this.inputValue1.Size = new System.Drawing.Size(100, 26);
            this.inputValue1.TabIndex = 1;
            // 
            // inputValue2
            // 
            this.inputValue2.Location = new System.Drawing.Point(135, 42);
            this.inputValue2.Name = "inputValue2";
            this.inputValue2.Size = new System.Drawing.Size(100, 26);
            this.inputValue2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Getal 2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "Bereken gemiddelde";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Grootste getal";
            // 
            // outputBiggestNumber
            // 
            this.outputBiggestNumber.AutoSize = true;
            this.outputBiggestNumber.Location = new System.Drawing.Point(140, 119);
            this.outputBiggestNumber.Name = "outputBiggestNumber";
            this.outputBiggestNumber.Size = new System.Drawing.Size(14, 20);
            this.outputBiggestNumber.TabIndex = 6;
            this.outputBiggestNumber.Text = "-";
            // 
            // outputAverage
            // 
            this.outputAverage.AutoSize = true;
            this.outputAverage.Location = new System.Drawing.Point(140, 148);
            this.outputAverage.Name = "outputAverage";
            this.outputAverage.Size = new System.Drawing.Size(14, 20);
            this.outputAverage.TabIndex = 8;
            this.outputAverage.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Gemiddelde";
            // 
            // outputDifference
            // 
            this.outputDifference.AutoSize = true;
            this.outputDifference.Location = new System.Drawing.Point(140, 177);
            this.outputDifference.Name = "outputDifference";
            this.outputDifference.Size = new System.Drawing.Size(14, 20);
            this.outputDifference.TabIndex = 10;
            this.outputDifference.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Verschil";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 204);
            this.Controls.Add(this.outputDifference);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.outputAverage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.outputBiggestNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inputValue2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputValue1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputValue1;
        private System.Windows.Forms.TextBox inputValue2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label outputBiggestNumber;
        private System.Windows.Forms.Label outputAverage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label outputDifference;
        private System.Windows.Forms.Label label8;
    }
}

