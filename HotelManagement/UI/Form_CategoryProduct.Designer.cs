namespace HotelManagement.UI
{
    partial class Form_CategoryProduct
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
            this.textBox_category = new System.Windows.Forms.TextBox();
            this.button_deleteCity = new System.Windows.Forms.Button();
            this.button_clean = new System.Windows.Forms.Button();
            this.label_id = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox_Category = new System.Windows.Forms.ListBox();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_category
            // 
            this.textBox_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox_category.Location = new System.Drawing.Point(319, 226);
            this.textBox_category.MaxLength = 9;
            this.textBox_category.Multiline = true;
            this.textBox_category.Name = "textBox_category";
            this.textBox_category.Size = new System.Drawing.Size(212, 48);
            this.textBox_category.TabIndex = 78;
            // 
            // button_deleteCity
            // 
            this.button_deleteCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_deleteCity.ForeColor = System.Drawing.Color.Red;
            this.button_deleteCity.Location = new System.Drawing.Point(582, 865);
            this.button_deleteCity.Name = "button_deleteCity";
            this.button_deleteCity.Size = new System.Drawing.Size(267, 45);
            this.button_deleteCity.TabIndex = 73;
            this.button_deleteCity.Text = "DELETE CITY";
            this.button_deleteCity.UseVisualStyleBackColor = true;
            this.button_deleteCity.Click += new System.EventHandler(this.button_deleteCategoryProduct_Click);
            // 
            // button_clean
            // 
            this.button_clean.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clean.ForeColor = System.Drawing.Color.Coral;
            this.button_clean.Location = new System.Drawing.Point(346, 865);
            this.button_clean.Name = "button_clean";
            this.button_clean.Size = new System.Drawing.Size(161, 45);
            this.button_clean.TabIndex = 72;
            this.button_clean.Text = "Clean";
            this.button_clean.UseVisualStyleBackColor = true;
            this.button_clean.Click += new System.EventHandler(this.Clean);
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_id.Location = new System.Drawing.Point(312, 153);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(36, 39);
            this.label_id.TabIndex = 71;
            this.label_id.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(54, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 39);
            this.label2.TabIndex = 70;
            this.label2.Text = "ID";
            // 
            // listBox_Category
            // 
            this.listBox_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_Category.FormattingEnabled = true;
            this.listBox_Category.ItemHeight = 31;
            this.listBox_Category.Location = new System.Drawing.Point(959, 226);
            this.listBox_Category.Name = "listBox_Category";
            this.listBox_Category.Size = new System.Drawing.Size(596, 562);
            this.listBox_Category.TabIndex = 69;
            this.listBox_Category.DoubleClick += new System.EventHandler(this.listBox_CategoryProduct_DoubleClick);
            // 
            // button_cancel
            // 
            this.button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel.Location = new System.Drawing.Point(1505, 865);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(161, 45);
            this.button_cancel.TabIndex = 68;
            this.button_cancel.Text = "Exit";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.Exit);
            // 
            // button_save
            // 
            this.button_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.ForeColor = System.Drawing.Color.Green;
            this.button_save.Location = new System.Drawing.Point(128, 865);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(161, 45);
            this.button_save.TabIndex = 67;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.Save);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(544, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(627, 63);
            this.label1.TabIndex = 66;
            this.label1.Text = "CATEGORY PRODUCT";
            // 
            // category
            // 
            this.category.AutoSize = true;
            this.category.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.category.Location = new System.Drawing.Point(54, 226);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(166, 39);
            this.category.TabIndex = 65;
            this.category.Text = "Category";
            // 
            // Form_CategoryProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1743, 1006);
            this.Controls.Add(this.textBox_category);
            this.Controls.Add(this.button_deleteCity);
            this.Controls.Add(this.button_clean);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox_Category);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.category);
            this.Name = "Form_CategoryProduct";
            this.Text = "Form_CategoryProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_category;
        private System.Windows.Forms.Button button_deleteCity;
        private System.Windows.Forms.Button button_clean;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox_Category;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label category;
    }
}