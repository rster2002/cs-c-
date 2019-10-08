namespace Opdracht7 {
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
            this.textboxTempInput = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radiobuttonCelciusToKelvin = new System.Windows.Forms.RadioButton();
            this.radiobuttonCelciusToFahrenheit = new System.Windows.Forms.RadioButton();
            this.radiobuttonFahrenheitToCelcius = new System.Windows.Forms.RadioButton();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Graden: ";
            // 
            // textboxTempInput
            // 
            this.textboxTempInput.Location = new System.Drawing.Point(166, 6);
            this.textboxTempInput.Name = "textboxTempInput";
            this.textboxTempInput.Size = new System.Drawing.Size(100, 26);
            this.textboxTempInput.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radiobuttonFahrenheitToCelcius);
            this.groupBox1.Controls.Add(this.radiobuttonCelciusToFahrenheit);
            this.groupBox1.Controls.Add(this.radiobuttonCelciusToKelvin);
            this.groupBox1.Location = new System.Drawing.Point(16, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 121);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Omrekenen";
            // 
            // radiobuttonCelciusToKelvin
            // 
            this.radiobuttonCelciusToKelvin.AutoSize = true;
            this.radiobuttonCelciusToKelvin.Checked = true;
            this.radiobuttonCelciusToKelvin.Location = new System.Drawing.Point(20, 25);
            this.radiobuttonCelciusToKelvin.Name = "radiobuttonCelciusToKelvin";
            this.radiobuttonCelciusToKelvin.Size = new System.Drawing.Size(70, 24);
            this.radiobuttonCelciusToKelvin.TabIndex = 3;
            this.radiobuttonCelciusToKelvin.TabStop = true;
            this.radiobuttonCelciusToKelvin.Text = "C -> K";
            this.radiobuttonCelciusToKelvin.UseVisualStyleBackColor = true;
            // 
            // radiobuttonCelciusToFahrenheit
            // 
            this.radiobuttonCelciusToFahrenheit.AutoSize = true;
            this.radiobuttonCelciusToFahrenheit.Location = new System.Drawing.Point(20, 55);
            this.radiobuttonCelciusToFahrenheit.Name = "radiobuttonCelciusToFahrenheit";
            this.radiobuttonCelciusToFahrenheit.Size = new System.Drawing.Size(70, 24);
            this.radiobuttonCelciusToFahrenheit.TabIndex = 4;
            this.radiobuttonCelciusToFahrenheit.TabStop = true;
            this.radiobuttonCelciusToFahrenheit.Text = "C -> F";
            this.radiobuttonCelciusToFahrenheit.UseVisualStyleBackColor = true;
            // 
            // radiobuttonFahrenheitToCelcius
            // 
            this.radiobuttonFahrenheitToCelcius.AutoSize = true;
            this.radiobuttonFahrenheitToCelcius.Location = new System.Drawing.Point(20, 85);
            this.radiobuttonFahrenheitToCelcius.Name = "radiobuttonFahrenheitToCelcius";
            this.radiobuttonFahrenheitToCelcius.Size = new System.Drawing.Size(70, 24);
            this.radiobuttonFahrenheitToCelcius.TabIndex = 5;
            this.radiobuttonFahrenheitToCelcius.TabStop = true;
            this.radiobuttonFahrenheitToCelcius.Text = "F -> C";
            this.radiobuttonFahrenheitToCelcius.UseVisualStyleBackColor = true;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(16, 165);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(250, 29);
            this.buttonCalculate.TabIndex = 3;
            this.buttonCalculate.Text = "Bereken";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.ButtonCalculate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Omgerekende waarde:";
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(215, 197);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(14, 20);
            this.labelOutput.TabIndex = 5;
            this.labelOutput.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 240);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textboxTempInput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textboxTempInput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radiobuttonFahrenheitToCelcius;
        private System.Windows.Forms.RadioButton radiobuttonCelciusToFahrenheit;
        private System.Windows.Forms.RadioButton radiobuttonCelciusToKelvin;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelOutput;
    }
}

