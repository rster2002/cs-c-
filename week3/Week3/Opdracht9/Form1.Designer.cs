namespace Opdracht9 {
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
            this.radioSoccer = new System.Windows.Forms.RadioButton();
            this.radioTennis = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.inputAge = new System.Windows.Forms.TextBox();
            this.inputDuration = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.outputContribution = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sportsoort:";
            // 
            // radioSoccer
            // 
            this.radioSoccer.AutoSize = true;
            this.radioSoccer.Location = new System.Drawing.Point(131, 6);
            this.radioSoccer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioSoccer.Name = "radioSoccer";
            this.radioSoccer.Size = new System.Drawing.Size(68, 20);
            this.radioSoccer.TabIndex = 1;
            this.radioSoccer.TabStop = true;
            this.radioSoccer.Text = "Voetbal";
            this.radioSoccer.UseVisualStyleBackColor = true;
            // 
            // radioTennis
            // 
            this.radioTennis.AutoSize = true;
            this.radioTennis.Location = new System.Drawing.Point(131, 25);
            this.radioTennis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioTennis.Name = "radioTennis";
            this.radioTennis.Size = new System.Drawing.Size(64, 20);
            this.radioTennis.TabIndex = 2;
            this.radioTennis.TabStop = true;
            this.radioTennis.Text = "Tennis";
            this.radioTennis.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Leeftijd:";
            // 
            // inputAge
            // 
            this.inputAge.Location = new System.Drawing.Point(131, 46);
            this.inputAge.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputAge.Name = "inputAge";
            this.inputAge.Size = new System.Drawing.Size(90, 20);
            this.inputAge.TabIndex = 4;
            // 
            // inputDuration
            // 
            this.inputDuration.Location = new System.Drawing.Point(131, 67);
            this.inputDuration.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputDuration.Name = "inputDuration";
            this.inputDuration.Size = new System.Drawing.Size(90, 20);
            this.inputDuration.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Duur lidmaadschap";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 88);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "Bereken";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 120);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Te betalen contributie";
            // 
            // outputContribution
            // 
            this.outputContribution.AutoSize = true;
            this.outputContribution.BackColor = System.Drawing.SystemColors.Control;
            this.outputContribution.Location = new System.Drawing.Point(153, 120);
            this.outputContribution.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.outputContribution.Name = "outputContribution";
            this.outputContribution.Size = new System.Drawing.Size(10, 13);
            this.outputContribution.TabIndex = 9;
            this.outputContribution.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 149);
            this.Controls.Add(this.outputContribution);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inputDuration);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputAge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioTennis);
            this.Controls.Add(this.radioSoccer);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioSoccer;
        private System.Windows.Forms.RadioButton radioTennis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputAge;
        private System.Windows.Forms.TextBox inputDuration;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label outputContribution;
    }
}

