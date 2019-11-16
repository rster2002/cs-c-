namespace Opdracht8 {
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
            this.textboxNInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSumOutput = new System.Windows.Forms.Label();
            this.labelFormulaOutput = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelConclution = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Geef een getal (n)";
            // 
            // textboxNInput
            // 
            this.textboxNInput.Location = new System.Drawing.Point(156, 6);
            this.textboxNInput.Name = "textboxNInput";
            this.textboxNInput.Size = new System.Drawing.Size(100, 20);
            this.textboxNInput.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Vergelijk";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "som = 1 + 2 + ... + n";
            // 
            // labelSumOutput
            // 
            this.labelSumOutput.AutoSize = true;
            this.labelSumOutput.Location = new System.Drawing.Point(199, 73);
            this.labelSumOutput.Name = "labelSumOutput";
            this.labelSumOutput.Size = new System.Drawing.Size(10, 13);
            this.labelSumOutput.TabIndex = 4;
            this.labelSumOutput.Text = "-";
            // 
            // labelFormulaOutput
            // 
            this.labelFormulaOutput.AutoSize = true;
            this.labelFormulaOutput.Location = new System.Drawing.Point(199, 105);
            this.labelFormulaOutput.Name = "labelFormulaOutput";
            this.labelFormulaOutput.Size = new System.Drawing.Size(10, 13);
            this.labelFormulaOutput.TabIndex = 6;
            this.labelFormulaOutput.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "som = n * (n + 1) / 2";
            // 
            // labelConclution
            // 
            this.labelConclution.AutoSize = true;
            this.labelConclution.Location = new System.Drawing.Point(12, 136);
            this.labelConclution.Name = "labelConclution";
            this.labelConclution.Size = new System.Drawing.Size(10, 13);
            this.labelConclution.TabIndex = 7;
            this.labelConclution.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelConclution);
            this.Controls.Add(this.labelFormulaOutput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelSumOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textboxNInput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textboxNInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelSumOutput;
        private System.Windows.Forms.Label labelFormulaOutput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelConclution;
    }
}

