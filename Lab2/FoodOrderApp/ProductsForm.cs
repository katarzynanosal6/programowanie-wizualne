using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodOrderApp
{
    public partial class ProductsForm : Form
    {
        public ProductsForm(string komunikat)
        {
            InitializeComponent();
            this.Text = komunikat;

            lbProdukty.Items.Add("Pizza - 30,00 zl");
            lbProdukty.Items.Add("Burger - 25,00 zl");
            lbProdukty.Items.Add("Sałatka - 15,00 zl");
        }
        public string WybranyProdukt { get; private set; }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (lbProdukty.SelectedItem != null)
            {
                WybranyProdukt = lbProdukty.SelectedItem.ToString() ?? "";

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Wybierz najpierw produkt z listy");
            }
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {

        }

        private void lbProdukty_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
