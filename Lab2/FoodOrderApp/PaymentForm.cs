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
    public partial class PaymentForm : Form
    {
        public PaymentForm()
        {
            InitializeComponent();
        }

        public void PrzyjmijSume(string sumaTekst)
        {
            lblDoZaplaty.Text = "Razem do zapłaty: " + sumaTekst;
        }

        private void btnZaplac_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zamówienie przyjęte do realizacji!");
            this.Close();
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
