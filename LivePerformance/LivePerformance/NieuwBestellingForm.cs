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
    public partial class NieuwBestellingForm : Form
    {
        private BestellingBizLog bestellingRepo = new BestellingBizLog(new BestellingMSSQLrepo(new ItemMSSQLrepo()));

        public Klant klant = null;

        public NieuwBestellingForm()
        {
            InitializeComponent();
            List<Klant> klanten = bestellingRepo.GetKlanten();
            foreach (Klant klant in klanten)
            {
                lb_Klanten.Items.Add(klant);
            }
        }

        private void bt_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_SelectKlant_Click(object sender, EventArgs e)
        {
            if (lb_Klanten.SelectedItem != null)
            {
                klant = (Klant)lb_Klanten.SelectedItem;
                tb_SelectedKlant.Text = klant.ToString();
            }
            else
            {
                MessageBox.Show("Selecteer eerst een klant");
            }
        }

        private void bt_Clear_Click(object sender, EventArgs e)
        {
            klant = null;
            tb_SelectedKlant.Clear();
        }

        private void bt_Confirm_Click(object sender, EventArgs e)
        {
            bestellingRepo.NewBestelling(klant);
            this.Close();
        }
    }
}
