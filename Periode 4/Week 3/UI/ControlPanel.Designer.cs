namespace UI {
    partial class mainForm {
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
            this.btnNextStation = new System.Windows.Forms.Button();
            this.btnNewDisplay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNextStation
            // 
            this.btnNextStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextStation.Location = new System.Drawing.Point(155, 177);
            this.btnNextStation.Name = "btnNextStation";
            this.btnNextStation.Size = new System.Drawing.Size(214, 74);
            this.btnNextStation.TabIndex = 0;
            this.btnNextStation.Text = "Volgend Station";
            this.btnNextStation.UseVisualStyleBackColor = true;
            this.btnNextStation.Click += new System.EventHandler(this.btnNextStationClick);
            // 
            // btnNewDisplay
            // 
            this.btnNewDisplay.Location = new System.Drawing.Point(12, 415);
            this.btnNewDisplay.Name = "btnNewDisplay";
            this.btnNewDisplay.Size = new System.Drawing.Size(95, 23);
            this.btnNewDisplay.TabIndex = 1;
            this.btnNewDisplay.Text = "Nieuw display";
            this.btnNewDisplay.UseVisualStyleBackColor = true;
            this.btnNewDisplay.Click += new System.EventHandler(this.btnNewDisplayClick);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 450);
            this.Controls.Add(this.btnNewDisplay);
            this.Controls.Add(this.btnNextStation);
            this.Name = "mainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNextStation;
        private System.Windows.Forms.Button btnNewDisplay;
    }
}

