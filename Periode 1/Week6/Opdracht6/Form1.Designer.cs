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
            this.textboxInput = new System.Windows.Forms.TextBox();
            this.buttonByRef = new System.Windows.Forms.Button();
            this.buttonByOut = new System.Windows.Forms.Button();
            this.buttonByReturn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Getal: ";
            // 
            // textboxInput
            // 
            this.textboxInput.Location = new System.Drawing.Point(257, 6);
            this.textboxInput.Name = "textboxInput";
            this.textboxInput.Size = new System.Drawing.Size(100, 26);
            this.textboxInput.TabIndex = 1;
            // 
            // buttonByRef
            // 
            this.buttonByRef.Location = new System.Drawing.Point(16, 38);
            this.buttonByRef.Name = "buttonByRef";
            this.buttonByRef.Size = new System.Drawing.Size(341, 31);
            this.buttonByRef.TabIndex = 2;
            this.buttonByRef.Text = "Bereken kwadraad By Reference";
            this.buttonByRef.UseVisualStyleBackColor = true;
            this.buttonByRef.Click += new System.EventHandler(this.ButtonByRef_Click);
            // 
            // buttonByOut
            // 
            this.buttonByOut.Location = new System.Drawing.Point(16, 75);
            this.buttonByOut.Name = "buttonByOut";
            this.buttonByOut.Size = new System.Drawing.Size(341, 31);
            this.buttonByOut.TabIndex = 3;
            this.buttonByOut.Text = "Bereken kwadraad By Out";
            this.buttonByOut.UseVisualStyleBackColor = true;
            this.buttonByOut.Click += new System.EventHandler(this.ButtonByOut_Click);
            // 
            // buttonByReturn
            // 
            this.buttonByReturn.Location = new System.Drawing.Point(16, 112);
            this.buttonByReturn.Name = "buttonByReturn";
            this.buttonByReturn.Size = new System.Drawing.Size(341, 31);
            this.buttonByReturn.TabIndex = 4;
            this.buttonByReturn.Text = "Bereken kwadraad By Return";
            this.buttonByReturn.UseVisualStyleBackColor = true;
            this.buttonByReturn.Click += new System.EventHandler(this.ButtonByReturn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Uitkomst";
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(253, 146);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(14, 20);
            this.labelOutput.TabIndex = 6;
            this.labelOutput.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 223);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonByReturn);
            this.Controls.Add(this.buttonByOut);
            this.Controls.Add(this.buttonByRef);
            this.Controls.Add(this.textboxInput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textboxInput;
        private System.Windows.Forms.Button buttonByRef;
        private System.Windows.Forms.Button buttonByOut;
        private System.Windows.Forms.Button buttonByReturn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelOutput;
    }
}

