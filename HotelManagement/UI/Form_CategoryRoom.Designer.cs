namespace HotelManagement.UI
{
    partial class Form_CategoryRoom
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
            this.button_deleteCity = new System.Windows.Forms.Button();
            this.button_clean = new System.Windows.Forms.Button();
            this.label_ID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox_Category = new System.Windows.Forms.ListBox();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_maxplace = new System.Windows.Forms.TextBox();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.textBox_category = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_deleteCity
            // 
            this.button_deleteCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_deleteCity.ForeColor = System.Drawing.Color.Red;
            this.button_deleteCity.Location = new System.Drawing.Point(593, 894);
            this.button_deleteCity.Name = "button_deleteCity";
            this.button_deleteCity.Size = new System.Drawing.Size(267, 45);
            this.button_deleteCity.TabIndex = 58;
            this.button_deleteCity.Text = "DELETE CITY";
            this.button_deleteCity.UseVisualStyleBackColor = true;
            this.button_deleteCity.Click += new System.EventHandler(this.button_deleteCategoryRoom_Click);
            // 
            // button_clean
            // 
            this.button_clean.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clean.ForeColor = System.Drawing.Color.Coral;
            this.button_clean.Location = new System.Drawing.Point(357, 894);
            this.button_clean.Name = "button_clean";
            this.button_clean.Size = new System.Drawing.Size(161, 45);
            this.button_clean.TabIndex = 57;
            this.button_clean.Text = "Clean";
            this.button_clean.UseVisualStyleBackColor = true;
            this.button_clean.Click += new System.EventHandler(this.button_clean_Click);
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_ID.Location = new System.Drawing.Point(323, 182);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(36, 39);
            this.label_ID.TabIndex = 56;
            this.label_ID.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(65, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 39);
            this.label2.TabIndex = 55;
            this.label2.Text = "ID";
            // 
            // listBox_Category
            // 
            this.listBox_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_Category.FormattingEnabled = true;
            this.listBox_Category.ItemHeight = 31;
            this.listBox_Category.Location = new System.Drawing.Point(970, 255);
            this.listBox_Category.Name = "listBox_Category";
            this.listBox_Category.Size = new System.Drawing.Size(596, 562);
            this.listBox_Category.TabIndex = 54;
            this.listBox_Category.DoubleClick += new System.EventHandler(this.listBox_Category_DoubleClick);
            // 
            // button_cancel
            // 
            this.button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel.Location = new System.Drawing.Point(1516, 894);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(161, 45);
            this.button_cancel.TabIndex = 53;
            this.button_cancel.Text = "Exit";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.Cancel_Button);
            // 
            // button_save
            // 
            this.button_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.ForeColor = System.Drawing.Color.Green;
            this.button_save.Location = new System.Drawing.Point(139, 894);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(161, 45);
            this.button_save.TabIndex = 52;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(555, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(525, 63);
            this.label1.TabIndex = 51;
            this.label1.Text = "CATEGORY ROOM";
            // 
            // category
            // 
            this.category.AutoSize = true;
            this.category.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.category.Location = new System.Drawing.Point(65, 255);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(166, 39);
            this.category.TabIndex = 49;
            this.category.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(65, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 39);
            this.label3.TabIndex = 60;
            this.label3.Text = "Max Places";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(65, 480);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 39);
            this.label4.TabIndex = 61;
            this.label4.Text = "Price";
            // 
            // textBox_maxplace
            // 
            this.textBox_maxplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox_maxplace.Location = new System.Drawing.Point(330, 355);
            this.textBox_maxplace.MaxLength = 9;
            this.textBox_maxplace.Multiline = true;
            this.textBox_maxplace.Name = "textBox_maxplace";
            this.textBox_maxplace.Size = new System.Drawing.Size(212, 48);
            this.textBox_maxplace.TabIndex = 62;
            // 
            // textBox_price
            // 
            this.textBox_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox_price.Location = new System.Drawing.Point(330, 480);
            this.textBox_price.MaxLength = 9;
            this.textBox_price.Multiline = true;
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(212, 48);
            this.textBox_price.TabIndex = 63;
            // 
            // textBox_category
            // 
            this.textBox_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox_category.Location = new System.Drawing.Point(330, 255);
            this.textBox_category.MaxLength = 9;
            this.textBox_category.Multiline = true;
            this.textBox_category.Name = "textBox_category";
            this.textBox_category.Size = new System.Drawing.Size(212, 48);
            this.textBox_category.TabIndex = 64;
            // 
            // Form_CategoryRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1743, 1021);
            this.Controls.Add(this.textBox_category);
            this.Controls.Add(this.textBox_price);
            this.Controls.Add(this.textBox_maxplace);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_deleteCity);
            this.Controls.Add(this.button_clean);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox_Category);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.category);
            this.Name = "Form_CategoryRoom";
            this.Text = "Form_CategoryRoom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_deleteCity;
        private System.Windows.Forms.Button button_clean;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox_Category;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label category;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_maxplace;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.TextBox textBox_category;
    }
}