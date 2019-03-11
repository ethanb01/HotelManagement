namespace HotelManagement.UI
{
    partial class Form_Product
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
            this.label_pr = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button_deleteRoom = new System.Windows.Forms.Button();
            this.button_clean = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.groupBox_filter = new System.Windows.Forms.GroupBox();
            this.comboBox_filter_onStock = new System.Windows.Forms.ComboBox();
            this.comboBox_filter_category = new System.Windows.Forms.ComboBox();
            this.textbox_filter_productName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox_product = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.texbox_nameProduct = new System.Windows.Forms.TextBox();
            this.roomnum = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_details = new System.Windows.Forms.TextBox();
            this.textBox_quantity = new System.Windows.Forms.TextBox();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.groupBox_filter.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_pr
            // 
            this.label_pr.AutoSize = true;
            this.label_pr.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_pr.Location = new System.Drawing.Point(168, 497);
            this.label_pr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_pr.Name = "label_pr";
            this.label_pr.Size = new System.Drawing.Size(102, 39);
            this.label_pr.TabIndex = 64;
            this.label_pr.Text = "Price";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_id.Location = new System.Drawing.Point(618, 209);
            this.label_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(37, 39);
            this.label_id.TabIndex = 62;
            this.label_id.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(168, 204);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 39);
            this.label7.TabIndex = 61;
            this.label7.Text = "ID";
            // 
            // button_deleteRoom
            // 
            this.button_deleteRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_deleteRoom.ForeColor = System.Drawing.Color.Red;
            this.button_deleteRoom.Location = new System.Drawing.Point(629, 786);
            this.button_deleteRoom.Margin = new System.Windows.Forms.Padding(2);
            this.button_deleteRoom.Name = "button_deleteRoom";
            this.button_deleteRoom.Size = new System.Drawing.Size(266, 89);
            this.button_deleteRoom.TabIndex = 60;
            this.button_deleteRoom.Text = "DELETE ROOM";
            this.button_deleteRoom.UseVisualStyleBackColor = true;
            this.button_deleteRoom.Click += new System.EventHandler(this.Delete);
            // 
            // button_clean
            // 
            this.button_clean.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clean.ForeColor = System.Drawing.Color.Coral;
            this.button_clean.Location = new System.Drawing.Point(407, 791);
            this.button_clean.Margin = new System.Windows.Forms.Padding(2);
            this.button_clean.Name = "button_clean";
            this.button_clean.Size = new System.Drawing.Size(180, 84);
            this.button_clean.TabIndex = 59;
            this.button_clean.Text = "Clean";
            this.button_clean.UseVisualStyleBackColor = true;
            this.button_clean.Click += new System.EventHandler(this.Clean);
            // 
            // button_cancel
            // 
            this.button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel.Location = new System.Drawing.Point(365, 933);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(2);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(222, 78);
            this.button_cancel.TabIndex = 58;
            this.button_cancel.Text = "Exit";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.Exit);
            // 
            // button_save
            // 
            this.button_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.ForeColor = System.Drawing.Color.Green;
            this.button_save.Location = new System.Drawing.Point(219, 791);
            this.button_save.Margin = new System.Windows.Forms.Padding(2);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(170, 84);
            this.button_save.TabIndex = 57;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.Save);
            // 
            // groupBox_filter
            // 
            this.groupBox_filter.Controls.Add(this.comboBox_filter_onStock);
            this.groupBox_filter.Controls.Add(this.comboBox_filter_category);
            this.groupBox_filter.Controls.Add(this.textbox_filter_productName);
            this.groupBox_filter.Controls.Add(this.label5);
            this.groupBox_filter.Controls.Add(this.label4);
            this.groupBox_filter.Controls.Add(this.label6);
            this.groupBox_filter.Location = new System.Drawing.Point(1153, 636);
            this.groupBox_filter.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_filter.Name = "groupBox_filter";
            this.groupBox_filter.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_filter.Size = new System.Drawing.Size(606, 256);
            this.groupBox_filter.TabIndex = 56;
            this.groupBox_filter.TabStop = false;
            this.groupBox_filter.Text = "Filter";
            // 
            // comboBox_filter_onStock
            // 
            this.comboBox_filter_onStock.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_filter_onStock.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_filter_onStock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_filter_onStock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_filter_onStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_filter_onStock.FormattingEnabled = true;
            this.comboBox_filter_onStock.Items.AddRange(new object[] {
            "Is in stock?",
            "Yes",
            "No"});
            this.comboBox_filter_onStock.Location = new System.Drawing.Point(308, 179);
            this.comboBox_filter_onStock.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_filter_onStock.Name = "comboBox_filter_onStock";
            this.comboBox_filter_onStock.Size = new System.Drawing.Size(272, 45);
            this.comboBox_filter_onStock.TabIndex = 35;
            this.comboBox_filter_onStock.TextChanged += new System.EventHandler(this.comboBox_filter_category_TextChanged);
            // 
            // comboBox_filter_category
            // 
            this.comboBox_filter_category.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_filter_category.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_filter_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_filter_category.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_filter_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_filter_category.FormattingEnabled = true;
            this.comboBox_filter_category.Location = new System.Drawing.Point(308, 102);
            this.comboBox_filter_category.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_filter_category.Name = "comboBox_filter_category";
            this.comboBox_filter_category.Size = new System.Drawing.Size(272, 45);
            this.comboBox_filter_category.TabIndex = 34;
            this.comboBox_filter_category.TextChanged += new System.EventHandler(this.comboBox_filter_category_TextChanged);
            // 
            // textbox_filter_productName
            // 
            this.textbox_filter_productName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textbox_filter_productName.Location = new System.Drawing.Point(308, 40);
            this.textbox_filter_productName.Margin = new System.Windows.Forms.Padding(2);
            this.textbox_filter_productName.Multiline = true;
            this.textbox_filter_productName.Name = "textbox_filter_productName";
            this.textbox_filter_productName.Size = new System.Drawing.Size(272, 44);
            this.textbox_filter_productName.TabIndex = 15;
            this.textbox_filter_productName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Check_Name);
            this.textbox_filter_productName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.groupbox_productNumber_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(3, 108);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(303, 39);
            this.label5.TabIndex = 14;
            this.label5.Text = "Category Product";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(4, 40);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 39);
            this.label4.TabIndex = 8;
            this.label4.Text = "Product Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(4, 185);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 39);
            this.label6.TabIndex = 7;
            this.label6.Text = "On Stock";
            // 
            // listBox_product
            // 
            this.listBox_product.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_product.FormattingEnabled = true;
            this.listBox_product.ItemHeight = 31;
            this.listBox_product.Location = new System.Drawing.Point(786, 272);
            this.listBox_product.Margin = new System.Windows.Forms.Padding(2);
            this.listBox_product.Name = "listBox_product";
            this.listBox_product.Size = new System.Drawing.Size(323, 407);
            this.listBox_product.TabIndex = 55;
            this.listBox_product.DoubleClick += new System.EventHandler(this.listBox_Clients_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(637, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(338, 63);
            this.label3.TabIndex = 54;
            this.label3.Text = "PRODUCTS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(1216, 266);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 39);
            this.label1.TabIndex = 50;
            this.label1.Text = "Category Product";
            // 
            // texbox_nameProduct
            // 
            this.texbox_nameProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.texbox_nameProduct.Location = new System.Drawing.Point(487, 266);
            this.texbox_nameProduct.Margin = new System.Windows.Forms.Padding(2);
            this.texbox_nameProduct.Multiline = true;
            this.texbox_nameProduct.Name = "texbox_nameProduct";
            this.texbox_nameProduct.Size = new System.Drawing.Size(213, 45);
            this.texbox_nameProduct.TabIndex = 49;
            // 
            // roomnum
            // 
            this.roomnum.AutoSize = true;
            this.roomnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.roomnum.Location = new System.Drawing.Point(168, 272);
            this.roomnum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.roomnum.Name = "roomnum";
            this.roomnum.Size = new System.Drawing.Size(251, 39);
            this.roomnum.TabIndex = 48;
            this.roomnum.Text = "Name Product";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.Location = new System.Drawing.Point(168, 381);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(369, 39);
            this.label8.TabIndex = 66;
            this.label8.Text = "Quantity on the Stock";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label9.Location = new System.Drawing.Point(168, 608);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 39);
            this.label9.TabIndex = 68;
            this.label9.Text = "Details";
            // 
            // textBox_details
            // 
            this.textBox_details.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox_details.Location = new System.Drawing.Point(370, 608);
            this.textBox_details.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_details.Multiline = true;
            this.textBox_details.Name = "textBox_details";
            this.textBox_details.Size = new System.Drawing.Size(402, 135);
            this.textBox_details.TabIndex = 69;
            // 
            // textBox_quantity
            // 
            this.textBox_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox_quantity.Location = new System.Drawing.Point(569, 381);
            this.textBox_quantity.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_quantity.Multiline = true;
            this.textBox_quantity.Name = "textBox_quantity";
            this.textBox_quantity.Size = new System.Drawing.Size(131, 45);
            this.textBox_quantity.TabIndex = 70;
            // 
            // textBox_price
            // 
            this.textBox_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox_price.Location = new System.Drawing.Point(498, 497);
            this.textBox_price.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_price.Multiline = true;
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(213, 45);
            this.textBox_price.TabIndex = 71;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(1223, 330);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(175, 204);
            this.listBox1.TabIndex = 72;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 25;
            this.listBox2.Location = new System.Drawing.Point(1461, 330);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(175, 204);
            this.listBox2.TabIndex = 73;
            // 
            // Form_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1813, 1044);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox_price);
            this.Controls.Add(this.textBox_quantity);
            this.Controls.Add(this.textBox_details);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label_pr);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button_deleteRoom);
            this.Controls.Add(this.button_clean);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.groupBox_filter);
            this.Controls.Add(this.listBox_product);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.texbox_nameProduct);
            this.Controls.Add(this.roomnum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_Product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Product";
            this.Load += new System.EventHandler(this.Form_Product_Load);
            this.groupBox_filter.ResumeLayout(false);
            this.groupBox_filter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_pr;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_deleteRoom;
        private System.Windows.Forms.Button button_clean;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.GroupBox groupBox_filter;
        private System.Windows.Forms.ComboBox comboBox_filter_onStock;
        private System.Windows.Forms.ComboBox comboBox_filter_category;
        private System.Windows.Forms.TextBox textbox_filter_productName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBox_product;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox texbox_nameProduct;
        private System.Windows.Forms.Label roomnum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_details;
        private System.Windows.Forms.TextBox textBox_quantity;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
    }
}