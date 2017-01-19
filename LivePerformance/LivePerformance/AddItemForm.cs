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
    public partial class AddItemForm : Form
    {
        private ItemBizLog itemRepo = new ItemBizLog(new ItemMSSQLrepo());
        public Item ToAddItem = null;
        private void updateList()
        {
            lb_Items.Items.Clear();
            if (rbtn_Drank.Checked)
            {
                List<Drank> dranken = itemRepo.GetDranken();
                foreach (Drank drank in dranken)
                {
                    lb_Items.Items.Add(drank);
                }
            } else if (rbtn_Salade.Checked)
            {
                List<Salade> salades = itemRepo.GetSalades();
                foreach (Salade salade in salades)
                {
                    lb_Items.Items.Add(salade);
                }
            } else if (rbtn_StandaardPizza.Checked)
            {
                List<Pizza> pizzas = itemRepo.GetPizzas();
                foreach (Pizza pizza in pizzas)
                {
                    lb_Items.Items.Add(pizza);
                }
            }
        }
        public AddItemForm()
        {
            InitializeComponent();
            rbtn_StandaardPizza.Checked = true;
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_Add_Click(object sender, EventArgs e)
        {
            if (lb_Items.SelectedItem != null)
            {
                ToAddItem = (Item)lb_Items.SelectedItem;
                this.Close();
            }
            else
            {
                MessageBox.Show("Selecteer eerst een product");
            }
        }

        private void rbtn_StandaardPizza_CheckedChanged(object sender, EventArgs e)
        {
            updateList();
        }

        private void rbtn_Salade_CheckedChanged(object sender, EventArgs e)
        {
            updateList();
        }

        private void rbtn_Drank_CheckedChanged(object sender, EventArgs e)
        {
            updateList();
        }
    }
}
