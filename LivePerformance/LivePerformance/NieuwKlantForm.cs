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
    public partial class NieuwKlantForm : Form
    {
        private BestellingBizLog bestellingRepo = new BestellingBizLog(new BestellingMSSQLrepo(new ItemMSSQLrepo()));

        public NieuwKlantForm()
        {
            InitializeComponent();
        }

        private void bt_AddKlant_Click(object sender, EventArgs e)
        {
            if (tb_Naam.Text.Length > 0 && tb_Adres.Text.Length > 0)
            {
                bestellingRepo.NewKlant(tb_Naam.Text, tb_Adres.Text);
            }
            else
            {
                MessageBox.Show("Vul allebei de velden in aub");
            }
            this.Close();
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
