using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreAppV1._1
{
    public partial class Form3 : Form
    {
        List<Items_products> store_inventory = new List<Items_products>();
        string search = "";
        public Form3()
        {
            InitializeComponent();
            store_inventory = AccessSQLite.LoadItems();
            LoadDataGridView();

        }
        private void LoadDataGridView()
        {
            dataGridView1.Rows.Clear();
            foreach (var items in store_inventory)
            {
                dataGridView1.Rows.Add(items.name, items.barcode, items.price, items.quantity);
            }
        }
        private void Button_search_Click(object sender, EventArgs e)
        {
            store_inventory.Clear();
            store_inventory = AccessSQLite.searchDatabase(search);
            LoadDataGridView();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            search = " WHERE name = '" + TextBox_search.Text + "'";
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            search = " WHERE barcode = '" + TextBox_search.Text + "'";
        }

        private void qtyLessThanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            search = " Where quantity <= '" + TextBox_search.Text + "'";
        }

        private void qtyMoreThanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            search = " Where quantity >= '" + TextBox_search.Text + "'";
        }
    }
}
