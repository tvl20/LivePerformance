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
    public partial class MainMenuForm : Form
    {
        private ItemBizLog itemRepo = new ItemBizLog(new ItemMSSQLrepo());
        private BestellingBizLog bestellingRepo = new BestellingBizLog(new BestellingMSSQLrepo(new ItemMSSQLrepo()));

        private void updateList()
        {
            lb_Bestellingen.Items.Clear();
            List<Bestelling> bestellingen = bestellingRepo.GetBestellingen();
            foreach (Bestelling bestelling in bestellingen)
            {
                lb_Bestellingen.Items.Add(bestelling);
            }
        }
        public MainMenuForm()
        {
            InitializeComponent();
            updateList();
        }

        private void btn_NieuwBestelling_Click(object sender, EventArgs e)
        {
            NieuwBestellingForm frm2 = new NieuwBestellingForm();
            frm2.ShowDialog();
            updateList();
        }

        private void btn_NieuwKlant_Click(object sender, EventArgs e)
        {
            NieuwKlantForm frm2 = new NieuwKlantForm();
            frm2.ShowDialog();
            updateList();
        }

        private void btn_OpenBestelling_Click(object sender, EventArgs e)
        {
            if (lb_Bestellingen.SelectedItem != null)
            {
                
            }
            else
            {
                MessageBox.Show("Selecteer een bestelling");
            }
        }
    }
}
