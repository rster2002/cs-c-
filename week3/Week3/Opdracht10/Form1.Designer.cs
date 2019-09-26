namespace Opdracht10 {
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
            this.inputSalery = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.outputRaise = new System.Windows.Forms.Label();
            this.outputNewSalery = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Huidige maandsalaris";
            // 
            // inputSalery
            // 
            this.inputSalery.Location = new System.Drawing.Point(211, 10);
            this.inputSalery.Name = "inputSalery";
            this.inputSalery.Size = new System.Drawing.Size(100, 26);
            this.inputSalery.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Verhoging";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(294, 43);
            this.button1.TabIndex = 3;
            this.button1.Text = "Bereken nieuw salaris";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // outputRaise
            // 
            this.outputRaise.AutoSize = true;
            this.outputRaise.Location = new System.Drawing.Point(229, 88);
            this.outputRaise.Name = "outputRaise";
            this.outputRaise.Size = new System.Drawing.Size(14, 20);
            this.outputRaise.TabIndex = 4;
            this.outputRaise.Text = "-";
            // 
            // outputNewSalery
            // 
            this.outputNewSalery.AutoSize = true;
            this.outputNewSalery.Location = new System.Drawing.Point(229, 123);
            this.outputNewSalery.Name = "outputNewSalery";
            this.outputNewSalery.Size = new System.Drawing.Size(14, 20);
            this.outputNewSalery.TabIndex = 6;
            this.outputNewSalery.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nieuwe salaris";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 155);
            this.Controls.Add(this.outputNewSalery);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.outputRaise);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputSalery);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputSalery;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label outputRaise;
        private System.Windows.Forms.Label outputNewSalery;
        private System.Windows.Forms.Label label5;
    }
}

