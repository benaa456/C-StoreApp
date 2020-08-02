using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;

namespace StoreAppV1._1
{
    public partial class Form1 : Form
    {
        List<Items_products> purchasing = new List<Items_products>();
        List<Items_products> store_inventory = new List<Items_products>();
        Thread thread;
        int qty;
        public Form1()
        {
            InitializeComponent();
            getFromSQLite();
        }
        public void getFromSQLite()
        {//get from SQLite
            store_inventory = AccessSQLite.LoadItems();
        }

        private void button_pay_Click(object sender, EventArgs e)
        {
            //removes all items from the purchasing list and refreshed the listbox

            foreach (var purchased in store_inventory)
            {
                AccessSQLite.UpdateDatabase(purchased);
            }

            purchasing.Clear();
            update_listbox();
        }
        private void update_listbox()
        {//sets whats being displayed in all three listboxes
            listBox_name.DataSource = null;
            listBox_name.DataSource = purchasing;
            listBox_name.DisplayMember = "name";

            listBox_price.DataSource = null;
            listBox_price.DataSource = purchasing;
            listBox_price.DisplayMember = "price";

            listBox_qty.DataSource = null;
            listBox_qty.DataSource = purchasing;
            listBox_qty.DisplayMember = "quantity";

            double total_price = 0;
            int total_quantity = 0;
            foreach (var items in purchasing)
            {
                total_price += (items.price * items.quantity);
                total_quantity += items.quantity;

            }
            textBox_totalPrice.Text = total_price.ToString();
            textBox_qty.Text = total_quantity.ToString();
        }
        private void update_purchasingList()
        {
            string brcode = textBox_scan.Text;
            qty = Int32.Parse(textBox_items.Text);
            foreach (var stock in store_inventory)
            {
                if (stock.barcode == brcode)
                {
                    stock.quantity -= qty;//added id Here*******************************************************
                    purchasing.Add(new Items_products { id = stock.id, name = stock.name, barcode = stock.barcode, price = stock.price, quantity = qty });
                }
            }
            update_listbox();
        }
        private void button_scan_Click(object sender, EventArgs e)
        {
            //barcode scanner
            update_purchasingList();
        }

        private void button_addItem_Click(object sender, EventArgs e)
        {
            textBox_items.Text = (Int32.Parse(textBox_items.Text) + 1).ToString();
        }

        private void button_subtractItem_Click(object sender, EventArgs e)
        {
            //so the quantity doesnt go lower than 0
            if ((qty = Int32.Parse(textBox_items.Text)) > 0)
            {
                textBox_items.Text = (Int32.Parse(textBox_items.Text) - 1).ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.ShowDialog();
        }

        private void button_search_Click(object sender, EventArgs e)
        {//opens form3 and closes form1 w/o closing the program
            this.Close();
            thread = new Thread(openForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();

        }

        private void openForm()
        {
            Application.Run(new Form3());
        }
    }
}
