namespace FoodOrderApp
{
    partial class MainForm
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
            lvKoszyk = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            btnWybierz = new Button();
            btnTransport = new Button();
            btnZaplac = new Button();
            lblSuma = new Label();
            SuspendLayout();
            // 
            // lvKoszyk
            // 
            lvKoszyk.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            lvKoszyk.Location = new Point(66, 63);
            lvKoszyk.Name = "lvKoszyk";
            lvKoszyk.Size = new Size(402, 287);
            lvKoszyk.TabIndex = 0;
            lvKoszyk.UseCompatibleStateImageBehavior = false;
            lvKoszyk.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Produkt";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Cena";
            columnHeader2.Width = 150;
            // 
            // btnWybierz
            // 
            btnWybierz.Location = new Point(533, 131);
            btnWybierz.Name = "btnWybierz";
            btnWybierz.Size = new Size(213, 40);
            btnWybierz.TabIndex = 1;
            btnWybierz.Text = "Wybierz Produkty";
            btnWybierz.UseVisualStyleBackColor = true;
            btnWybierz.Click += btnWybierz_Click;
            // 
            // btnTransport
            // 
            btnTransport.Location = new Point(533, 215);
            btnTransport.Name = "btnTransport";
            btnTransport.Size = new Size(213, 40);
            btnTransport.TabIndex = 2;
            btnTransport.Text = "Opcje Transportu";
            btnTransport.UseVisualStyleBackColor = true;
            btnTransport.Click += btnTransport_Click;
            // 
            // btnZaplac
            // 
            btnZaplac.Location = new Point(533, 310);
            btnZaplac.Name = "btnZaplac";
            btnZaplac.Size = new Size(213, 40);
            btnZaplac.TabIndex = 3;
            btnZaplac.Text = "Płatność";
            btnZaplac.UseVisualStyleBackColor = true;
            btnZaplac.Click += btnZaplac_Click;
            // 
            // lblSuma
            // 
            lblSuma.AutoSize = true;
            lblSuma.Location = new Point(569, 51);
            lblSuma.Name = "lblSuma";
            lblSuma.Size = new Size(136, 30);
            lblSuma.TabIndex = 4;
            lblSuma.Text = "Suma: 0,00 zł";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSuma);
            Controls.Add(btnZaplac);
            Controls.Add(btnTransport);
            Controls.Add(btnWybierz);
            Controls.Add(lvKoszyk);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvKoszyk;
        private Button btnWybierz;
        private Button btnTransport;
        private Button btnZaplac;
        private Label lblSuma;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
    }
}
