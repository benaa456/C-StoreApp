namespace StoreAppV1._1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox_qty = new System.Windows.Forms.ListBox();
            this.listBox_name = new System.Windows.Forms.ListBox();
            this.listBox_price = new System.Windows.Forms.ListBox();
            this.textBox_totalPrice = new System.Windows.Forms.TextBox();
            this.textBox_qty = new System.Windows.Forms.TextBox();
            this.label_qty = new System.Windows.Forms.Label();
            this.label_totalPrice = new System.Windows.Forms.Label();
            this.button_pay = new System.Windows.Forms.Button();
            this.textBox_scan = new System.Windows.Forms.TextBox();
            this.label_scan = new System.Windows.Forms.Label();
            this.textBox_items = new System.Windows.Forms.TextBox();
            this.button_addItem = new System.Windows.Forms.Button();
            this.button_subtractItem = new System.Windows.Forms.Button();
            this.button_scan = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_qty
            // 
            this.listBox_qty.FormattingEnabled = true;
            this.listBox_qty.Location = new System.Drawing.Point(489, 30);
            this.listBox_qty.Name = "listBox_qty";
            this.listBox_qty.Size = new System.Drawing.Size(37, 225);
            this.listBox_qty.TabIndex = 0;
            // 
            // listBox_name
            // 
            this.listBox_name.FormattingEnabled = true;
            this.listBox_name.Location = new System.Drawing.Point(532, 30);
            this.listBox_name.Name = "listBox_name";
            this.listBox_name.Size = new System.Drawing.Size(140, 225);
            this.listBox_name.TabIndex = 1;
            // 
            // listBox_price
            // 
            this.listBox_price.FormattingEnabled = true;
            this.listBox_price.Location = new System.Drawing.Point(678, 30);
            this.listBox_price.Name = "listBox_price";
            this.listBox_price.Size = new System.Drawing.Size(63, 225);
            this.listBox_price.TabIndex = 2;
            // 
            // textBox_totalPrice
            // 
            this.textBox_totalPrice.Location = new System.Drawing.Point(678, 271);
            this.textBox_totalPrice.Name = "textBox_totalPrice";
            this.textBox_totalPrice.Size = new System.Drawing.Size(63, 20);
            this.textBox_totalPrice.TabIndex = 3;
            // 
            // textBox_qty
            // 
            this.textBox_qty.Location = new System.Drawing.Point(489, 271);
            this.textBox_qty.Name = "textBox_qty";
            this.textBox_qty.Size = new System.Drawing.Size(37, 20);
            this.textBox_qty.TabIndex = 4;
            // 
            // label_qty
            // 
            this.label_qty.AutoSize = true;
            this.label_qty.Location = new System.Drawing.Point(441, 274);
            this.label_qty.Name = "label_qty";
            this.label_qty.Size = new System.Drawing.Size(23, 13);
            this.label_qty.TabIndex = 5;
            this.label_qty.Text = "Qty";
            // 
            // label_totalPrice
            // 
            this.label_totalPrice.AutoSize = true;
            this.label_totalPrice.Location = new System.Drawing.Point(597, 277);
            this.label_totalPrice.Name = "label_totalPrice";
            this.label_totalPrice.Size = new System.Drawing.Size(58, 13);
            this.label_totalPrice.TabIndex = 6;
            this.label_totalPrice.Text = "Total Price";
            // 
            // button_pay
            // 
            this.button_pay.Location = new System.Drawing.Point(575, 357);
            this.button_pay.Name = "button_pay";
            this.button_pay.Size = new System.Drawing.Size(75, 23);
            this.button_pay.TabIndex = 7;
            this.button_pay.Text = "pay";
            this.button_pay.UseVisualStyleBackColor = true;
            this.button_pay.Click += new System.EventHandler(this.button_pay_Click);
            // 
            // textBox_scan
            // 
            this.textBox_scan.Location = new System.Drawing.Point(40, 323);
            this.textBox_scan.Name = "textBox_scan";
            this.textBox_scan.Size = new System.Drawing.Size(100, 20);
            this.textBox_scan.TabIndex = 8;
            // 
            // label_scan
            // 
            this.label_scan.AutoSize = true;
            this.label_scan.Location = new System.Drawing.Point(40, 288);
            this.label_scan.Name = "label_scan";
            this.label_scan.Size = new System.Drawing.Size(85, 13);
            this.label_scan.TabIndex = 9;
            this.label_scan.Text = "Barcode Reader";
            // 
            // textBox_items
            // 
            this.textBox_items.Location = new System.Drawing.Point(146, 323);
            this.textBox_items.Name = "textBox_items";
            this.textBox_items.Size = new System.Drawing.Size(25, 20);
            this.textBox_items.TabIndex = 10;
            this.textBox_items.Text = "1";
            this.textBox_items.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_addItem
            // 
            this.button_addItem.Location = new System.Drawing.Point(185, 288);
            this.button_addItem.Name = "button_addItem";
            this.button_addItem.Size = new System.Drawing.Size(36, 23);
            this.button_addItem.TabIndex = 11;
            this.button_addItem.Text = "button1";
            this.button_addItem.UseVisualStyleBackColor = true;
            this.button_addItem.Click += new System.EventHandler(this.button_addItem_Click);
            // 
            // button_subtractItem
            // 
            this.button_subtractItem.Location = new System.Drawing.Point(178, 340);
            this.button_subtractItem.Name = "button_subtractItem";
            this.button_subtractItem.Size = new System.Drawing.Size(43, 23);
            this.button_subtractItem.TabIndex = 12;
            this.button_subtractItem.Text = "button1";
            this.button_subtractItem.UseVisualStyleBackColor = true;
            this.button_subtractItem.Click += new System.EventHandler(this.button_subtractItem_Click);
            // 
            // button_scan
            // 
            this.button_scan.Location = new System.Drawing.Point(43, 356);
            this.button_scan.Name = "button_scan";
            this.button_scan.Size = new System.Drawing.Size(75, 23);
            this.button_scan.TabIndex = 13;
            this.button_scan.Text = "Scan";
            this.button_scan.UseVisualStyleBackColor = true;
            this.button_scan.Click += new System.EventHandler(this.button_scan_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(13, 87);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(75, 23);
            this.button_search.TabIndex = 15;
            this.button_search.Text = "search items";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_scan);
            this.Controls.Add(this.button_subtractItem);
            this.Controls.Add(this.button_addItem);
            this.Controls.Add(this.textBox_items);
            this.Controls.Add(this.label_scan);
            this.Controls.Add(this.textBox_scan);
            this.Controls.Add(this.button_pay);
            this.Controls.Add(this.label_totalPrice);
            this.Controls.Add(this.label_qty);
            this.Controls.Add(this.textBox_qty);
            this.Controls.Add(this.textBox_totalPrice);
            this.Controls.Add(this.listBox_price);
            this.Controls.Add(this.listBox_name);
            this.Controls.Add(this.listBox_qty);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_qty;
        private System.Windows.Forms.ListBox listBox_name;
        private System.Windows.Forms.ListBox listBox_price;
        private System.Windows.Forms.TextBox textBox_totalPrice;
        private System.Windows.Forms.TextBox textBox_qty;
        private System.Windows.Forms.Label label_qty;
        private System.Windows.Forms.Label label_totalPrice;
        private System.Windows.Forms.Button button_pay;
        private System.Windows.Forms.TextBox textBox_scan;
        private System.Windows.Forms.Label label_scan;
        private System.Windows.Forms.TextBox textBox_items;
        private System.Windows.Forms.Button button_addItem;
        private System.Windows.Forms.Button button_subtractItem;
        private System.Windows.Forms.Button button_scan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_search;
    }
}

