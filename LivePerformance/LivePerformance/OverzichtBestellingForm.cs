using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LivePerformance
{
    public partial class OverzichtBestellingForm : Form
    {
        private Bestelling bestelling;

        private void updateList()
        {
            lb_ItemsBestelling.Items.Clear();
            foreach (Item bestellingItem in bestelling.Items)
            {
                lb_ItemsBestelling.Items.Add(bestellingItem);
            }
            lbl_Prijs.Text = Convert.ToString(bestelling.Prijs);
        }
        public OverzichtBestellingForm(Bestelling bestelling)
        {
            InitializeComponent();
            this.bestelling = bestelling;
            updateList();
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_AddItem_Click(object sender, EventArgs e)
        {

        }
    }
}
