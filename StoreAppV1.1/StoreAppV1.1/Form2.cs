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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private Form1 mainform = null;
        public Form2(Form callingFrom)
        {
            mainform = callingFrom as Form1;
            InitializeComponent();
            
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            Items_products product = new Items_products();
            product.name = textBox_name.Text;
            product.barcode = textBox_barcode.Text;
            product.price = Double.Parse(textBox_price.Text);
            product.quantity = Int32.Parse(textBox_quantity.Text);
            AccessSQLite.SaveItems(product);
            MessageBox.Show("product added to the database");
            mainform.getFromSQLite();
        }
    }
}
