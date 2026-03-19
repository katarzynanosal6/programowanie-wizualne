namespace FoodOrderApp
{
    partial class TransportForm
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
            cbKurier = new CheckBox();
            cbPaczkomat = new CheckBox();
            cbUbezpieczenie = new CheckBox();
            cbPriorytet = new CheckBox();
            btnZatwierdzTransport = new Button();
            SuspendLayout();
            // 
            // cbKurier
            // 
            cbKurier.AutoSize = true;
            cbKurier.Location = new Point(228, 40);
            cbKurier.Name = "cbKurier";
            cbKurier.Size = new Size(169, 34);
            cbKurier.TabIndex = 0;
            cbKurier.Text = "Kurier (+15 zł)";
            cbKurier.UseVisualStyleBackColor = true;
            // 
            // cbPaczkomat
            // 
            cbPaczkomat.AutoSize = true;
            cbPaczkomat.Location = new Point(228, 103);
            cbPaczkomat.Name = "cbPaczkomat";
            cbPaczkomat.Size = new Size(215, 34);
            cbPaczkomat.TabIndex = 1;
            cbPaczkomat.Text = "Paczkomat (+10 zł)";
            cbPaczkomat.UseVisualStyleBackColor = true;
            // 
            // cbUbezpieczenie
            // 
            cbUbezpieczenie.AutoSize = true;
            cbUbezpieczenie.Location = new Point(228, 172);
            cbUbezpieczenie.Name = "cbUbezpieczenie";
            cbUbezpieczenie.Size = new Size(324, 34);
            cbUbezpieczenie.TabIndex = 2;
            cbUbezpieczenie.Text = "Ubezpieczenie przesyłki (+5 zł)";
            cbUbezpieczenie.UseVisualStyleBackColor = true;
            // 
            // cbPriorytet
            // 
            cbPriorytet.AutoSize = true;
            cbPriorytet.Location = new Point(228, 244);
            cbPriorytet.Name = "cbPriorytet";
            cbPriorytet.Size = new Size(306, 34);
            cbPriorytet.TabIndex = 3;
            cbPriorytet.Text = "Dostawa Priorytetowa (+7 zł)";
            cbPriorytet.UseVisualStyleBackColor = true;
            // 
            // btnZatwierdzTransport
            // 
            btnZatwierdzTransport.Location = new Point(264, 336);
            btnZatwierdzTransport.Name = "btnZatwierdzTransport";
            btnZatwierdzTransport.Size = new Size(222, 40);
            btnZatwierdzTransport.TabIndex = 4;
            btnZatwierdzTransport.Text = "Zatwierdź wybór";
            btnZatwierdzTransport.UseVisualStyleBackColor = true;
            btnZatwierdzTransport.Click += btnZatwierdzTransport_Click_1;
            // 
            // TransportForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnZatwierdzTransport);
            Controls.Add(cbPriorytet);
            Controls.Add(cbUbezpieczenie);
            Controls.Add(cbPaczkomat);
            Controls.Add(cbKurier);
            Name = "TransportForm";
            Text = "Form1";
            Load += TransportForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox cbKurier;
        private CheckBox cbPaczkomat;
        private CheckBox cbUbezpieczenie;
        private CheckBox cbPriorytet;
        private Button btnZatwierdzTransport;
    }
}