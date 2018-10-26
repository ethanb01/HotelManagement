namespace HotelManagement.UI
{
    partial class Form_City
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
            this.listBox_City = new System.Windows.Forms.ListBox();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_cityname = new System.Windows.Forms.TextBox();
            this.cityname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_deleteCity
            // 
            this.button_deleteCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_deleteCity.ForeColor = System.Drawing.Color.Red;
            this.button_deleteCity.Location = new System.Drawing.Point(549, 900);
            this.button_deleteCity.Name = "button_deleteCity";
            this.button_deleteCity.Size = new System.Drawing.Size(267, 45);
            this.button_deleteCity.TabIndex = 48;
            this.button_deleteCity.Text = "DELETE CITY";
            this.button_deleteCity.UseVisualStyleBackColor = true;
            this.button_deleteCity.Click += new System.EventHandler(this.button_deleteCity_Click);
            // 
            // button_clean
            // 
            this.button_clean.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clean.ForeColor = System.Drawing.Color.Coral;
            this.button_clean.Location = new System.Drawing.Point(313, 900);
            this.button_clean.Name = "button_clean";
            this.button_clean.Size = new System.Drawing.Size(161, 45);
            this.button_clean.TabIndex = 47;
            this.button_clean.Text = "Clean";
            this.button_clean.UseVisualStyleBackColor = true;
            this.button_clean.Click += new System.EventHandler(this.button_clean_Click);
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_ID.Location = new System.Drawing.Point(279, 188);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(36, 39);
            this.label_ID.TabIndex = 46;
            this.label_ID.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(21, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 39);
            this.label2.TabIndex = 45;
            this.label2.Text = "ID";
            // 
            // listBox_City
            // 
            this.listBox_City.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_City.FormattingEnabled = true;
            this.listBox_City.ItemHeight = 31;
            this.listBox_City.Location = new System.Drawing.Point(926, 261);
            this.listBox_City.Name = "listBox_City";
            this.listBox_City.Size = new System.Drawing.Size(596, 562);
            this.listBox_City.TabIndex = 44;
            this.listBox_City.DoubleClick += new System.EventHandler(this.listBox_City_DoubleClick);
            // 
            // button_cancel
            // 
            this.button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel.Location = new System.Drawing.Point(1472, 900);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(161, 45);
            this.button_cancel.TabIndex = 43;
            this.button_cancel.Text = "Exit";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.Cancel_Button);
            // 
            // button_save
            // 
            this.button_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.ForeColor = System.Drawing.Color.Green;
            this.button_save.Location = new System.Drawing.Point(95, 900);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(161, 45);
            this.button_save.TabIndex = 42;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(511, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 63);
            this.label1.TabIndex = 41;
            this.label1.Text = "CITY FILE";
            // 
            // textBox_cityname
            // 
            this.textBox_cityname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox_cityname.Location = new System.Drawing.Point(262, 261);
            this.textBox_cityname.Multiline = true;
            this.textBox_cityname.Name = "textBox_cityname";
            this.textBox_cityname.Size = new System.Drawing.Size(212, 48);
            this.textBox_cityname.TabIndex = 40;
            this.textBox_cityname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Check_Name);
            // 
            // cityname
            // 
            this.cityname.AutoSize = true;
            this.cityname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cityname.Location = new System.Drawing.Point(21, 261);
            this.cityname.Name = "cityname";
            this.cityname.Size = new System.Drawing.Size(189, 39);
            this.cityname.TabIndex = 39;
            this.cityname.Text = "City Name";
            // 
            // Form_City
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1654, 1033);
            this.Controls.Add(this.button_deleteCity);
            this.Controls.Add(this.button_clean);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox_City);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_cityname);
            this.Controls.Add(this.cityname);
            this.Name = "Form_City";
            this.Text = "Form_City";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_deleteCity;
        private System.Windows.Forms.Button button_clean;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox_City;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_cityname;
        private System.Windows.Forms.Label cityname;
    }
}