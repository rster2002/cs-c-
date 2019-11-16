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
            this.lblClass = new System.Windows.Forms.Label();
            this.radiobtnSecondClass = new System.Windows.Forms.RadioButton();
            this.radiobtnFirstClass = new System.Windows.Forms.RadioButton();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtboxAmount = new System.Windows.Forms.TextBox();
            this.txtboxRailRunnerAmount = new System.Windows.Forms.TextBox();
            this.lblRailRunner = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtboxOutputPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(12, 9);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(60, 20);
            this.lblClass.TabIndex = 0;
            this.lblClass.Text = "Klasse:";
            // 
            // radiobtnSecondClass
            // 
            this.radiobtnSecondClass.AutoSize = true;
            this.radiobtnSecondClass.Checked = true;
            this.radiobtnSecondClass.Location = new System.Drawing.Point(104, 7);
            this.radiobtnSecondClass.Name = "radiobtnSecondClass";
            this.radiobtnSecondClass.Size = new System.Drawing.Size(101, 24);
            this.radiobtnSecondClass.TabIndex = 1;
            this.radiobtnSecondClass.TabStop = true;
            this.radiobtnSecondClass.Text = "2e klasse";
            this.radiobtnSecondClass.UseVisualStyleBackColor = true;
            // 
            // radiobtnFirstClass
            // 
            this.radiobtnFirstClass.AutoSize = true;
            this.radiobtnFirstClass.Location = new System.Drawing.Point(227, 7);
            this.radiobtnFirstClass.Name = "radiobtnFirstClass";
            this.radiobtnFirstClass.Size = new System.Drawing.Size(101, 24);
            this.radiobtnFirstClass.TabIndex = 2;
            this.radiobtnFirstClass.Text = "1e klasse";
            this.radiobtnFirstClass.UseVisualStyleBackColor = true;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(12, 57);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(59, 20);
            this.lblAmount.TabIndex = 3;
            this.lblAmount.Text = "Aantal:";
            // 
            // txtboxAmount
            // 
            this.txtboxAmount.Location = new System.Drawing.Point(104, 54);
            this.txtboxAmount.Name = "txtboxAmount";
            this.txtboxAmount.Size = new System.Drawing.Size(224, 26);
            this.txtboxAmount.TabIndex = 4;
            this.txtboxAmount.Text = "0";
            // 
            // txtboxRailRunnerAmount
            // 
            this.txtboxRailRunnerAmount.Location = new System.Drawing.Point(104, 86);
            this.txtboxRailRunnerAmount.Name = "txtboxRailRunnerAmount";
            this.txtboxRailRunnerAmount.Size = new System.Drawing.Size(224, 26);
            this.txtboxRailRunnerAmount.TabIndex = 6;
            this.txtboxRailRunnerAmount.Text = "0";
            // 
            // lblRailRunner
            // 
            this.lblRailRunner.AutoSize = true;
            this.lblRailRunner.Location = new System.Drawing.Point(12, 89);
            this.lblRailRunner.Name = "lblRailRunner";
            this.lblRailRunner.Size = new System.Drawing.Size(86, 20);
            this.lblRailRunner.TabIndex = 5;
            this.lblRailRunner.Text = "Railrunner:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(104, 146);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(224, 35);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Bereken";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // txtboxOutputPrice
            // 
            this.txtboxOutputPrice.Location = new System.Drawing.Point(105, 187);
            this.txtboxOutputPrice.Name = "txtboxOutputPrice";
            this.txtboxOutputPrice.ReadOnly = true;
            this.txtboxOutputPrice.Size = new System.Drawing.Size(223, 26);
            this.txtboxOutputPrice.TabIndex = 8;
            this.txtboxOutputPrice.Text = "0.00";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(12, 190);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(42, 20);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "Prijs:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 254);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtboxOutputPrice);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtboxRailRunnerAmount);
            this.Controls.Add(this.lblRailRunner);
            this.Controls.Add(this.txtboxAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.radiobtnFirstClass);
            this.Controls.Add(this.radiobtnSecondClass);
            this.Controls.Add(this.lblClass);
            this.Name = "Form1";
            this.Text = "NS Dagkaart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.RadioButton radiobtnSecondClass;
        private System.Windows.Forms.RadioButton radiobtnFirstClass;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtboxAmount;
        private System.Windows.Forms.TextBox txtboxRailRunnerAmount;
        private System.Windows.Forms.Label lblRailRunner;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtboxOutputPrice;
        private System.Windows.Forms.Label lblPrice;
    }
}

