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
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textboxComparasonNumber = new System.Windows.Forms.TextBox();
            this.labelList1 = new System.Windows.Forms.Label();
            this.labelList2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inhoud tabel vooraf";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Inhoud tabel achteraf";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 454);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 44);
            this.button1.TabIndex = 42;
            this.button1.Text = "Vergelijk";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textboxComparasonNumber
            // 
            this.textboxComparasonNumber.Location = new System.Drawing.Point(16, 463);
            this.textboxComparasonNumber.Name = "textboxComparasonNumber";
            this.textboxComparasonNumber.Size = new System.Drawing.Size(154, 26);
            this.textboxComparasonNumber.TabIndex = 43;
            // 
            // labelList1
            // 
            this.labelList1.AutoSize = true;
            this.labelList1.Location = new System.Drawing.Point(12, 44);
            this.labelList1.Name = "labelList1";
            this.labelList1.Size = new System.Drawing.Size(0, 20);
            this.labelList1.TabIndex = 44;
            // 
            // labelList2
            // 
            this.labelList2.AutoSize = true;
            this.labelList2.Location = new System.Drawing.Point(206, 44);
            this.labelList2.Name = "labelList2";
            this.labelList2.Size = new System.Drawing.Size(0, 20);
            this.labelList2.TabIndex = 45;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 510);
            this.Controls.Add(this.labelList2);
            this.Controls.Add(this.labelList1);
            this.Controls.Add(this.textboxComparasonNumber);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textboxComparasonNumber;
        private System.Windows.Forms.Label labelList1;
        private System.Windows.Forms.Label labelList2;
    }
}

