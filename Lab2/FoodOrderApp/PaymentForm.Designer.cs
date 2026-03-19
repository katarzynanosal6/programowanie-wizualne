namespace FoodOrderApp
{
    partial class PaymentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            rbKarta = new RadioButton();
            rbGotowka = new RadioButton();
            rbBlik = new RadioButton();
            rbPrzelew = new RadioButton();
            lblDoZaplaty = new Label();
            btnFinalizuj = new Button();
            SuspendLayout();
            // 
            // rbKarta
            // 
            rbKarta.AutoSize = true;
            rbKarta.Location = new Point(155, 134);
            rbKarta.Name = "rbKarta";
            rbKarta.Size = new Size(86, 34);
            rbKarta.TabIndex = 0;
            rbKarta.TabStop = true;
            rbKarta.Text = "Karta";
            rbKarta.UseVisualStyleBackColor = true;
            // 
            // rbGotowka
            // 
            rbGotowka.AutoSize = true;
            rbGotowka.Location = new Point(155, 210);
            rbGotowka.Name = "rbGotowka";
            rbGotowka.Size = new Size(119, 34);
            rbGotowka.TabIndex = 1;
            rbGotowka.TabStop = true;
            rbGotowka.Text = "Gotówka";
            rbGotowka.UseVisualStyleBackColor = true;
            // 
            // rbBlik
            // 
            rbBlik.AutoSize = true;
            rbBlik.Location = new Point(155, 289);
            rbBlik.Name = "rbBlik";
            rbBlik.Size = new Size(78, 34);
            rbBlik.TabIndex = 2;
            rbBlik.TabStop = true;
            rbBlik.Text = "BLIK";
            rbBlik.UseVisualStyleBackColor = true;
            // 
            // rbPrzelew
            // 
            rbPrzelew.AutoSize = true;
            rbPrzelew.Location = new Point(155, 366);
            rbPrzelew.Name = "rbPrzelew";
            rbPrzelew.Size = new Size(109, 34);
            rbPrzelew.TabIndex = 3;
            rbPrzelew.TabStop = true;
            rbPrzelew.Text = "Przelew";
            rbPrzelew.UseVisualStyleBackColor = true;
            // 
            // lblDoZaplaty
            // 
            lblDoZaplaty.AutoSize = true;
            lblDoZaplaty.Location = new Point(156, 54);
            lblDoZaplaty.Name = "lblDoZaplaty";
            lblDoZaplaty.Size = new Size(184, 30);
            lblDoZaplaty.TabIndex = 4;
            lblDoZaplaty.Text = "Do zapłaty: 0,00 zł";
            // 
            // btnFinalizuj
            // 
            btnFinalizuj.Location = new Point(544, 210);
            btnFinalizuj.Name = "btnFinalizuj";
            btnFinalizuj.Size = new Size(131, 40);
            btnFinalizuj.TabIndex = 5;
            btnFinalizuj.Text = "Zapłać";
            btnFinalizuj.UseVisualStyleBackColor = true;
            // 
            // PaymentForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFinalizuj);
            Controls.Add(lblDoZaplaty);
            Controls.Add(rbPrzelew);
            Controls.Add(rbBlik);
            Controls.Add(rbGotowka);
            Controls.Add(rbKarta);
            Name = "PaymentForm";
            Text = "PaymentForm";
            Load += PaymentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rbKarta;
        private RadioButton rbGotowka;
        private RadioButton rbBlik;
        private RadioButton rbPrzelew;
        private Label lblDoZaplaty;
        private Button btnFinalizuj;
    }
}