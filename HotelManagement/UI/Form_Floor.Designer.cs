namespace HotelManagement.UI
{
    partial class Form_Floor
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
            this.textBox_floor = new System.Windows.Forms.TextBox();
            this.button_deleteCity = new System.Windows.Forms.Button();
            this.button_clean = new System.Windows.Forms.Button();
            this.label_ID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox_Floors = new System.Windows.Forms.ListBox();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_floor
            // 
            this.textBox_floor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox_floor.Location = new System.Drawing.Point(279, 253);
            this.textBox_floor.MaxLength = 9;
            this.textBox_floor.Multiline = true;
            this.textBox_floor.Name = "textBox_floor";
            this.textBox_floor.Size = new System.Drawing.Size(212, 48);
            this.textBox_floor.TabIndex = 78;
            // 
            // button_deleteCity
            // 
            this.button_deleteCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_deleteCity.ForeColor = System.Drawing.Color.Red;
            this.button_deleteCity.Location = new System.Drawing.Point(542, 892);
            this.button_deleteCity.Name = "button_deleteCity";
            this.button_deleteCity.Size = new System.Drawing.Size(267, 45);
            this.button_deleteCity.TabIndex = 73;
            this.button_deleteCity.Text = "DELETE CITY";
            this.button_deleteCity.UseVisualStyleBackColor = true;
            this.button_deleteCity.Click += new System.EventHandler(this.button_deleteFloor_Click);
            // 
            // button_clean
            // 
            this.button_clean.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clean.ForeColor = System.Drawing.Color.Coral;
            this.button_clean.Location = new System.Drawing.Point(306, 892);
            this.button_clean.Name = "button_clean";
            this.button_clean.Size = new System.Drawing.Size(161, 45);
            this.button_clean.TabIndex = 72;
            this.button_clean.Text = "Clean";
            this.button_clean.UseVisualStyleBackColor = true;
            this.button_clean.Click += new System.EventHandler(this.button_clean_Click);
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_ID.Location = new System.Drawing.Point(272, 180);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(36, 39);
            this.label_ID.TabIndex = 71;
            this.label_ID.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(14, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 39);
            this.label2.TabIndex = 70;
            this.label2.Text = "ID";
            // 
            // listBox_Floors
            // 
            this.listBox_Floors.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_Floors.FormattingEnabled = true;
            this.listBox_Floors.ItemHeight = 31;
            this.listBox_Floors.Location = new System.Drawing.Point(919, 253);
            this.listBox_Floors.Name = "listBox_Floors";
            this.listBox_Floors.Size = new System.Drawing.Size(596, 562);
            this.listBox_Floors.TabIndex = 69;
            // 
            // button_cancel
            // 
            this.button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel.Location = new System.Drawing.Point(1465, 892);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(161, 45);
            this.button_cancel.TabIndex = 68;
            this.button_cancel.Text = "Exit";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.Cancel_Button);
            // 
            // button_save
            // 
            this.button_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.ForeColor = System.Drawing.Color.Green;
            this.button_save.Location = new System.Drawing.Point(88, 892);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(161, 45);
            this.button_save.TabIndex = 67;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(504, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 63);
            this.label1.TabIndex = 66;
            this.label1.Text = "FLOOR";
            // 
            // category
            // 
            this.category.AutoSize = true;
            this.category.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.category.Location = new System.Drawing.Point(14, 253);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(101, 39);
            this.category.TabIndex = 65;
            this.category.Text = "Floor";
            // 
            // Form_Floor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1699, 1014);
            this.Controls.Add(this.textBox_floor);
            this.Controls.Add(this.button_deleteCity);
            this.Controls.Add(this.button_clean);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox_Floors);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.category);
            this.Name = "Form_Floor";
            this.Text = "Form_Floor";
            this.DoubleClick += new System.EventHandler(this.listBox_Category_DoubleClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_floor;
        private System.Windows.Forms.Button button_deleteCity;
        private System.Windows.Forms.Button button_clean;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox_Floors;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label category;
    }
}