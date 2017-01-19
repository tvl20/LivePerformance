using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LivePerformance.DAL;

namespace LivePerformance
{
    public partial class OverzichtBestellingForm : Form
    {
        private BestellingBizLog bestellingRepo = new BestellingBizLog(new BestellingMSSQLrepo(new ItemMSSQLrepo()));
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
            AddItemForm frm2 = new AddItemForm();
            frm2.ShowDialog();
            if (frm2.ToAddItem != null)
            {
                bestelling.Items.Add(frm2.ToAddItem);
                bestellingRepo.AddItem(bestelling.ID, frm2.ToAddItem);
            }
            updateList();
        }
    }
}
