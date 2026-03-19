namespace FoodOrderApp
{
    partial class ProductsForm
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
            lbProdukty = new ListBox();
            btnDodaj = new Button();
            btnAnuluj = new Button();
            SuspendLayout();
            // 
            // lbProdukty
            // 
            lbProdukty.FormattingEnabled = true;
            lbProdukty.ItemHeight = 30;
            lbProdukty.Location = new Point(305, 59);
            lbProdukty.Name = "lbProdukty";
            lbProdukty.Size = new Size(165, 124);
            lbProdukty.TabIndex = 0;
            lbProdukty.SelectedIndexChanged += lbProdukty_SelectedIndexChanged;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(321, 241);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(131, 40);
            btnDodaj.TabIndex = 1;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // btnAnuluj
            // 
            btnAnuluj.Location = new Point(321, 325);
            btnAnuluj.Name = "btnAnuluj";
            btnAnuluj.Size = new Size(131, 40);
            btnAnuluj.TabIndex = 2;
            btnAnuluj.Text = "Anuluj";
            btnAnuluj.UseVisualStyleBackColor = true;
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAnuluj);
            Controls.Add(btnDodaj);
            Controls.Add(lbProdukty);
            Name = "ProductsForm";
            Text = "Form1";
            Load += ProductsForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbProdukty;
        private Button btnDodaj;
        private Button btnAnuluj;
    }
}