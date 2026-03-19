namespace FoodOrderApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnWybierz_Click(object sender, EventArgs e)
        {
            ProductsForm oknoProduktow = new ProductsForm("Wybierz swoje danie: ");
            if (oknoProduktow.ShowDialog() == DialogResult.OK)
            {
                string dane = oknoProduktow.WybranyProdukt;

                string[] czesci = dane.Split('-');
                string nazwa = czesci[0].Trim();
                string cena = czesci.Length > 1 ? czesci[1].Trim() : "0,00";

                ListViewItem wiersz = new ListViewItem(nazwa);
                wiersz.SubItems.Add(cena);

                lvKoszyk.Items.Add(wiersz);
                PrzeliczSume();
            }
        }
        private void PrzeliczSume()
        {
            double suma = 0;

            foreach (ListViewItem produkt in lvKoszyk.Items)
            {
                if (produkt.SubItems.Count > 1)
                {
                    string cenaTekst = produkt.SubItems[1].Text;
                    
                    cenaTekst = produkt.SubItems[1].Text
                                             .Replace("z³", "")
                                             .Replace("+", "")
                                             .Replace(".", ",")
                                             .Trim();

                    if (double.TryParse(cenaTekst, out double cena))
                    {
                        suma += cena;
                    }
                }
            }

            lblSuma.Text = $"Suma: {suma:F2} z³";
        }


        private void btnTransport_Click(object sender, EventArgs e)
        {
            TransportForm oknoTransportu = new TransportForm();

            if (oknoTransportu.ShowDialog() == DialogResult.OK)
            {
                if (oknoTransportu.CzyKurier)
                {
                    ListViewItem dostawa = new ListViewItem("Dostawa Kurier");
                    dostawa.SubItems.Add("15,00");
                    lvKoszyk.Items.Add(dostawa);

                    PrzeliczSume();
                }
            }
        }

        private void btnZaplac_Click(object sender, EventArgs e)
        {
            PaymentForm oknoPlatnosci = new PaymentForm();

            oknoPlatnosci.PrzyjmijSume(lblSuma.Text);

            oknoPlatnosci.ShowDialog();
        }
    }

}
