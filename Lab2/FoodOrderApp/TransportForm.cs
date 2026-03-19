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
    public partial class TransportForm : Form
    {
        public bool CzyKurier { get; private set; }
        public TransportForm()
        {
            InitializeComponent();
        }

        private void btnZatwierdzTransport_Click(object sender, EventArgs e)
        {
            if (cbKurier.Checked)
            {
                this.CzyKurier = true;
            }
            else
            {
                this.CzyKurier = false;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void TransportForm_Load(object sender, EventArgs e)
        {

        }

        private void btnZatwierdzTransport_Click_1(object sender, EventArgs e)
        {
            this.CzyKurier = cbKurier.Checked;

            this.DialogResult = DialogResult.OK;

            this.Close();

        }
    }
}
