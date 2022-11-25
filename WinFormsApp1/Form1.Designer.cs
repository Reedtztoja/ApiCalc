namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.rateUSDTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rateEuroTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rateCHFTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ammountPLNTextBox = new System.Windows.Forms.TextBox();
            this.ammountPLNlabel = new System.Windows.Forms.Label();
            this.USDButton = new System.Windows.Forms.RadioButton();
            this.EURButton = new System.Windows.Forms.RadioButton();
            this.CHFButton = new System.Windows.Forms.RadioButton();
            this.calculatedAmmount = new System.Windows.Forms.TextBox();
            this.foreignwaluta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(234, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Pobierz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rateUSDTextBox
            // 
            this.rateUSDTextBox.Location = new System.Drawing.Point(73, 6);
            this.rateUSDTextBox.Name = "rateUSDTextBox";
            this.rateUSDTextBox.Size = new System.Drawing.Size(100, 23);
            this.rateUSDTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kurs USD";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rateEuroTextBox
            // 
            this.rateEuroTextBox.Location = new System.Drawing.Point(73, 35);
            this.rateEuroTextBox.Name = "rateEuroTextBox";
            this.rateEuroTextBox.Size = new System.Drawing.Size(100, 23);
            this.rateEuroTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kurs EUR";
            // 
            // rateCHFTextBox
            // 
            this.rateCHFTextBox.Location = new System.Drawing.Point(73, 64);
            this.rateCHFTextBox.Name = "rateCHFTextBox";
            this.rateCHFTextBox.Size = new System.Drawing.Size(100, 23);
            this.rateCHFTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kurs CHF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kalkulator walut";
            // 
            // ammountPLNTextBox
            // 
            this.ammountPLNTextBox.Location = new System.Drawing.Point(12, 159);
            this.ammountPLNTextBox.Name = "ammountPLNTextBox";
            this.ammountPLNTextBox.Size = new System.Drawing.Size(100, 23);
            this.ammountPLNTextBox.TabIndex = 9;
            // 
            // ammountPLNlabel
            // 
            this.ammountPLNlabel.AutoSize = true;
            this.ammountPLNlabel.Location = new System.Drawing.Point(12, 141);
            this.ammountPLNlabel.Name = "ammountPLNlabel";
            this.ammountPLNlabel.Size = new System.Drawing.Size(59, 15);
            this.ammountPLNlabel.TabIndex = 10;
            this.ammountPLNlabel.Text = "Kwota (zł)";
            // 
            // USDButton
            // 
            this.USDButton.AutoSize = true;
            this.USDButton.Location = new System.Drawing.Point(118, 163);
            this.USDButton.Name = "USDButton";
            this.USDButton.Size = new System.Drawing.Size(47, 19);
            this.USDButton.TabIndex = 11;
            this.USDButton.TabStop = true;
            this.USDButton.Text = "USD";
            this.USDButton.UseVisualStyleBackColor = true;
            this.USDButton.Click += new System.EventHandler(this.Exchange);
            // 
            // EURButton
            // 
            this.EURButton.AutoSize = true;
            this.EURButton.Location = new System.Drawing.Point(118, 188);
            this.EURButton.Name = "EURButton";
            this.EURButton.Size = new System.Drawing.Size(46, 19);
            this.EURButton.TabIndex = 12;
            this.EURButton.TabStop = true;
            this.EURButton.Text = "EUR";
            this.EURButton.UseVisualStyleBackColor = true;
            this.EURButton.Click += new System.EventHandler(this.Exchange);
            // 
            // CHFButton
            // 
            this.CHFButton.AutoSize = true;
            this.CHFButton.Location = new System.Drawing.Point(118, 213);
            this.CHFButton.Name = "CHFButton";
            this.CHFButton.Size = new System.Drawing.Size(48, 19);
            this.CHFButton.TabIndex = 13;
            this.CHFButton.TabStop = true;
            this.CHFButton.Text = "CHF";
            this.CHFButton.UseVisualStyleBackColor = true;
            this.CHFButton.Click += new System.EventHandler(this.Exchange);
            // 
            // calculatedAmmount
            // 
            this.calculatedAmmount.Location = new System.Drawing.Point(209, 159);
            this.calculatedAmmount.Name = "calculatedAmmount";
            this.calculatedAmmount.Size = new System.Drawing.Size(100, 23);
            this.calculatedAmmount.TabIndex = 14;
            // 
            // foreignwaluta
            // 
            this.foreignwaluta.AutoSize = true;
            this.foreignwaluta.Location = new System.Drawing.Point(218, 141);
            this.foreignwaluta.Name = "foreignwaluta";
            this.foreignwaluta.Size = new System.Drawing.Size(73, 15);
            this.foreignwaluta.TabIndex = 15;
            this.foreignwaluta.Text = "Waluta obca";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.foreignwaluta);
            this.Controls.Add(this.calculatedAmmount);
            this.Controls.Add(this.CHFButton);
            this.Controls.Add(this.EURButton);
            this.Controls.Add(this.USDButton);
            this.Controls.Add(this.ammountPLNlabel);
            this.Controls.Add(this.ammountPLNTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rateCHFTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rateEuroTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rateUSDTextBox);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button button1;
        private TextBox rateUSDTextBox;
        private Label label1;
        private TextBox rateEuroTextBox;
        private Label label2;
        private TextBox rateCHFTextBox;
        private Label label3;
        private Label label4;
        private TextBox ammountPLNTextBox;
        private Label ammountPLNlabel;
        private RadioButton USDButton;
        private RadioButton EURButton;
        private RadioButton CHFButton;
        private TextBox calculatedAmmount;
        private Label foreignwaluta;
    }
}