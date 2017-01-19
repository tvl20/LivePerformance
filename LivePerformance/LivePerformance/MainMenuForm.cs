using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
                OverzichtBestellingForm frm2 = new OverzichtBestellingForm((Bestelling) lb_Bestellingen.SelectedItem);
                frm2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecteer een bestelling");
            }
        }

        private void btn_PrintBon_Click(object sender, EventArgs e)
        {
            if (lb_Bestellingen.SelectedItem != null)
            {
                Bestelling bestelling = (Bestelling)lb_Bestellingen.SelectedItem;
                //de bon word naar C:\Bon geschreven
                
                StreamWriter sw = new StreamWriter(@"C:\Bon.txt");
                sw.WriteLine("Pizzeria La Crosta Insapore");
                if (bestelling.Klant != null)
                {
                    sw.WriteLine("Klantbon voor: " + bestelling.Klant.Naam);
                }
                else
                {
                    sw.WriteLine("Klantbon voor: -undefined-");
                }
                sw.WriteLine();

                if (bestelling.Items != null)
                {
                    foreach (Item bestellingItem in bestelling.Items)
                    {
                        sw.WriteLine(bestellingItem);
                    }
                }
                
                sw.WriteLine();
                sw.WriteLine("Prijs exclusief BTW: " + Convert.ToString(bestelling.PrijsExBtw));
                sw.WriteLine("BTW bedrag: " + Convert.ToString(bestelling.Prijs - bestelling.PrijsExBtw));
                sw.WriteLine("Te betalen bedrag: " + Convert.ToString(bestelling.Prijs));
                sw.Close();
            }
            else
            {
                MessageBox.Show("Selecteer een bestelling om een bon uit te kunnen printen");
            }
        }
    }
}
