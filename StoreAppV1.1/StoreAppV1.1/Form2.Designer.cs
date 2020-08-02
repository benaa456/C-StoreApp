namespace StoreAppV1._1
{
    partial class Form2
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
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_barcode = new System.Windows.Forms.TextBox();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.textBox_quantity = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.label_barcode = new System.Windows.Forms.Label();
            this.label_price = new System.Windows.Forms.Label();
            this.label_quantity = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(100, 82);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(100, 20);
            this.textBox_name.TabIndex = 0;
            // 
            // textBox_barcode
            // 
            this.textBox_barcode.Location = new System.Drawing.Point(100, 158);
            this.textBox_barcode.Name = "textBox_barcode";
            this.textBox_barcode.Size = new System.Drawing.Size(100, 20);
            this.textBox_barcode.TabIndex = 1;
            // 
            // textBox_price
            // 
            this.textBox_price.Location = new System.Drawing.Point(100, 231);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(100, 20);
            this.textBox_price.TabIndex = 2;
            // 
            // textBox_quantity
            // 
            this.textBox_quantity.Location = new System.Drawing.Point(100, 299);
            this.textBox_quantity.Name = "textBox_quantity";
            this.textBox_quantity.Size = new System.Drawing.Size(100, 20);
            this.textBox_quantity.TabIndex = 3;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(100, 47);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(35, 13);
            this.label_name.TabIndex = 4;
            this.label_name.Text = "Name";
            // 
            // label_barcode
            // 
            this.label_barcode.AutoSize = true;
            this.label_barcode.Location = new System.Drawing.Point(100, 125);
            this.label_barcode.Name = "label_barcode";
            this.label_barcode.Size = new System.Drawing.Size(47, 13);
            this.label_barcode.TabIndex = 5;
            this.label_barcode.Text = "Barcode";
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Location = new System.Drawing.Point(103, 197);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(31, 13);
            this.label_price.TabIndex = 6;
            this.label_price.Text = "Price";
            // 
            // label_quantity
            // 
            this.label_quantity.AutoSize = true;
            this.label_quantity.Location = new System.Drawing.Point(100, 264);
            this.label_quantity.Name = "label_quantity";
            this.label_quantity.Size = new System.Drawing.Size(46, 13);
            this.label_quantity.TabIndex = 7;
            this.label_quantity.Text = "Quantity";
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(103, 356);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 8;
            this.button_add.Text = "ADD";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 450);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.label_quantity);
            this.Controls.Add(this.label_price);
            this.Controls.Add(this.label_barcode);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.textBox_quantity);
            this.Controls.Add(this.textBox_price);
            this.Controls.Add(this.textBox_barcode);
            this.Controls.Add(this.textBox_name);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_barcode;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.TextBox textBox_quantity;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_barcode;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.Label label_quantity;
        private System.Windows.Forms.Button button_add;
    }
}