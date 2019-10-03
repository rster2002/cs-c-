namespace AUT_NS {
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
            this.textboxInputTrain = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelVervoerder = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textboxInputTrain
            // 
            this.textboxInputTrain.Location = new System.Drawing.Point(12, 12);
            this.textboxInputTrain.Name = "textboxInputTrain";
            this.textboxInputTrain.Size = new System.Drawing.Size(100, 20);
            this.textboxInputTrain.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 20);
            this.button1.TabIndex = 1;
            this.button1.Text = "Zoek";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // labelVervoerder
            // 
            this.labelVervoerder.AutoSize = true;
            this.labelVervoerder.Location = new System.Drawing.Point(12, 35);
            this.labelVervoerder.Name = "labelVervoerder";
            this.labelVervoerder.Size = new System.Drawing.Size(35, 13);
            this.labelVervoerder.TabIndex = 0;
            this.labelVervoerder.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelVervoerder);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textboxInputTrain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textboxInputTrain;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelVervoerder;
    }
}

