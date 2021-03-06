﻿namespace HotelManagement.UI
{
    partial class Form_Client
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
            this.first_name = new System.Windows.Forms.Label();
            this.textBox_first_name = new System.Windows.Forms.TextBox();
            this.textBox_lastname = new System.Windows.Forms.TextBox();
            this.last_name = new System.Windows.Forms.Label();
            this.textBox_mail = new System.Windows.Forms.TextBox();
            this.mail = new System.Windows.Forms.Label();
            this.textBox_taz = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_creditcard = new System.Windows.Forms.TextBox();
            this.credit_card = new System.Windows.Forms.Label();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.Label();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.listBox_Clients = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_ID = new System.Windows.Forms.Label();
            this.button_clean = new System.Windows.Forms.Button();
            this.button_deleteClient = new System.Windows.Forms.Button();
            this.groupBox_filter = new System.Windows.Forms.GroupBox();
            this.groupbox_phone = new System.Windows.Forms.TextBox();
            this.groupbox_taz = new System.Windows.Forms.TextBox();
            this.groupbox_lastname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.Label();
            this.comboBox_city = new System.Windows.Forms.ComboBox();
            this.button_add_city = new System.Windows.Forms.Button();
            this.groupBox_filter.SuspendLayout();
            this.SuspendLayout();
            // 
            // first_name
            // 
            this.first_name.AutoSize = true;
            this.first_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.first_name.Location = new System.Drawing.Point(65, 203);
            this.first_name.Name = "first_name";
            this.first_name.Size = new System.Drawing.Size(198, 39);
            this.first_name.TabIndex = 1;
            this.first_name.Text = "First Name";
            // 
            // textBox_first_name
            // 
            this.textBox_first_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox_first_name.Location = new System.Drawing.Point(306, 203);
            this.textBox_first_name.Multiline = true;
            this.textBox_first_name.Name = "textBox_first_name";
            this.textBox_first_name.Size = new System.Drawing.Size(212, 48);
            this.textBox_first_name.TabIndex = 3;
            this.textBox_first_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Check_Name);
            // 
            // textBox_lastname
            // 
            this.textBox_lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox_lastname.Location = new System.Drawing.Point(306, 300);
            this.textBox_lastname.Multiline = true;
            this.textBox_lastname.Name = "textBox_lastname";
            this.textBox_lastname.Size = new System.Drawing.Size(212, 48);
            this.textBox_lastname.TabIndex = 5;
            this.textBox_lastname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Check_Name);
            // 
            // last_name
            // 
            this.last_name.AutoSize = true;
            this.last_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.last_name.Location = new System.Drawing.Point(65, 300);
            this.last_name.Name = "last_name";
            this.last_name.Size = new System.Drawing.Size(194, 39);
            this.last_name.TabIndex = 4;
            this.last_name.Text = "Last Name";
            // 
            // textBox_mail
            // 
            this.textBox_mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox_mail.Location = new System.Drawing.Point(306, 501);
            this.textBox_mail.Multiline = true;
            this.textBox_mail.Name = "textBox_mail";
            this.textBox_mail.Size = new System.Drawing.Size(421, 48);
            this.textBox_mail.TabIndex = 9;
            // 
            // mail
            // 
            this.mail.AutoSize = true;
            this.mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.mail.Location = new System.Drawing.Point(65, 501);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(85, 39);
            this.mail.TabIndex = 8;
            this.mail.Text = "Mail";
            // 
            // textBox_taz
            // 
            this.textBox_taz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox_taz.Location = new System.Drawing.Point(306, 404);
            this.textBox_taz.MaxLength = 9;
            this.textBox_taz.Multiline = true;
            this.textBox_taz.Name = "textBox_taz";
            this.textBox_taz.Size = new System.Drawing.Size(212, 48);
            this.textBox_taz.TabIndex = 7;
            this.textBox_taz.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Check_Num);
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.id.Location = new System.Drawing.Point(65, 404);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(72, 39);
            this.id.TabIndex = 6;
            this.id.Text = "T.Z";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(555, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 63);
            this.label1.TabIndex = 10;
            this.label1.Text = "CLIENT FILE";
            // 
            // textBox_creditcard
            // 
            this.textBox_creditcard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox_creditcard.Location = new System.Drawing.Point(306, 598);
            this.textBox_creditcard.MaxLength = 16;
            this.textBox_creditcard.Multiline = true;
            this.textBox_creditcard.Name = "textBox_creditcard";
            this.textBox_creditcard.Size = new System.Drawing.Size(421, 48);
            this.textBox_creditcard.TabIndex = 12;
            this.textBox_creditcard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Check_Num);
            // 
            // credit_card
            // 
            this.credit_card.AutoSize = true;
            this.credit_card.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.credit_card.Location = new System.Drawing.Point(65, 598);
            this.credit_card.Name = "credit_card";
            this.credit_card.Size = new System.Drawing.Size(205, 39);
            this.credit_card.TabIndex = 11;
            this.credit_card.Text = "Credit Card";
            // 
            // textBox_phone
            // 
            this.textBox_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox_phone.Location = new System.Drawing.Point(306, 695);
            this.textBox_phone.MaxLength = 10;
            this.textBox_phone.Multiline = true;
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(212, 48);
            this.textBox_phone.TabIndex = 14;
            this.textBox_phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Check_Num);
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Phone.Location = new System.Drawing.Point(65, 695);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(121, 39);
            this.Phone.TabIndex = 13;
            this.Phone.Text = "Phone";
            // 
            // button_cancel
            // 
            this.button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel.Location = new System.Drawing.Point(1516, 842);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(161, 45);
            this.button_cancel.TabIndex = 23;
            this.button_cancel.Text = "Exit";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_save
            // 
            this.button_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.ForeColor = System.Drawing.Color.Green;
            this.button_save.Location = new System.Drawing.Point(139, 910);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(161, 45);
            this.button_save.TabIndex = 22;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // listBox_Clients
            // 
            this.listBox_Clients.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_Clients.FormattingEnabled = true;
            this.listBox_Clients.ItemHeight = 31;
            this.listBox_Clients.Location = new System.Drawing.Point(785, 203);
            this.listBox_Clients.Name = "listBox_Clients";
            this.listBox_Clients.Size = new System.Drawing.Size(596, 562);
            this.listBox_Clients.TabIndex = 24;
            this.listBox_Clients.DoubleClick += new System.EventHandler(this.listBox_Clients_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(65, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 39);
            this.label2.TabIndex = 25;
            this.label2.Text = "ID";
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_ID.Location = new System.Drawing.Point(323, 130);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(36, 39);
            this.label_ID.TabIndex = 26;
            this.label_ID.Text = "0";
            // 
            // button_clean
            // 
            this.button_clean.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clean.ForeColor = System.Drawing.Color.Coral;
            this.button_clean.Location = new System.Drawing.Point(357, 910);
            this.button_clean.Name = "button_clean";
            this.button_clean.Size = new System.Drawing.Size(161, 45);
            this.button_clean.TabIndex = 27;
            this.button_clean.Text = "Clean";
            this.button_clean.UseVisualStyleBackColor = true;
            this.button_clean.Click += new System.EventHandler(this.button_clean_Click);
            // 
            // button_deleteClient
            // 
            this.button_deleteClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_deleteClient.ForeColor = System.Drawing.Color.Red;
            this.button_deleteClient.Location = new System.Drawing.Point(593, 910);
            this.button_deleteClient.Name = "button_deleteClient";
            this.button_deleteClient.Size = new System.Drawing.Size(267, 45);
            this.button_deleteClient.TabIndex = 28;
            this.button_deleteClient.Text = "DELETE CLIENT";
            this.button_deleteClient.UseVisualStyleBackColor = true;
            this.button_deleteClient.Click += new System.EventHandler(this.button_deleteClient_Click);
            // 
            // groupBox_filter
            // 
            this.groupBox_filter.Controls.Add(this.groupbox_phone);
            this.groupBox_filter.Controls.Add(this.groupbox_taz);
            this.groupBox_filter.Controls.Add(this.groupbox_lastname);
            this.groupBox_filter.Controls.Add(this.label5);
            this.groupBox_filter.Controls.Add(this.label4);
            this.groupBox_filter.Controls.Add(this.label3);
            this.groupBox_filter.Location = new System.Drawing.Point(1431, 203);
            this.groupBox_filter.Name = "groupBox_filter";
            this.groupBox_filter.Size = new System.Drawing.Size(512, 271);
            this.groupBox_filter.TabIndex = 29;
            this.groupBox_filter.TabStop = false;
            this.groupBox_filter.Text = "Filter";
            // 
            // groupbox_phone
            // 
            this.groupbox_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupbox_phone.Location = new System.Drawing.Point(240, 201);
            this.groupbox_phone.Multiline = true;
            this.groupbox_phone.Name = "groupbox_phone";
            this.groupbox_phone.Size = new System.Drawing.Size(212, 48);
            this.groupbox_phone.TabIndex = 17;
            this.groupbox_phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Check_Num);
            this.groupbox_phone.KeyUp += new System.Windows.Forms.KeyEventHandler(this.groupbox_lastname_KeyUp);
            // 
            // groupbox_taz
            // 
            this.groupbox_taz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupbox_taz.Location = new System.Drawing.Point(240, 126);
            this.groupbox_taz.Multiline = true;
            this.groupbox_taz.Name = "groupbox_taz";
            this.groupbox_taz.Size = new System.Drawing.Size(212, 48);
            this.groupbox_taz.TabIndex = 16;
            this.groupbox_taz.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Check_Num);
            this.groupbox_taz.KeyUp += new System.Windows.Forms.KeyEventHandler(this.groupbox_lastname_KeyUp);
            // 
            // groupbox_lastname
            // 
            this.groupbox_lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupbox_lastname.Location = new System.Drawing.Point(240, 44);
            this.groupbox_lastname.Multiline = true;
            this.groupbox_lastname.Name = "groupbox_lastname";
            this.groupbox_lastname.Size = new System.Drawing.Size(212, 48);
            this.groupbox_lastname.TabIndex = 15;
            this.groupbox_lastname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Check_Name);
            this.groupbox_lastname.KeyUp += new System.Windows.Forms.KeyEventHandler(this.groupbox_lastname_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(24, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 39);
            this.label5.TabIndex = 14;
            this.label5.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(24, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 39);
            this.label4.TabIndex = 8;
            this.label4.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(33, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 39);
            this.label3.TabIndex = 7;
            this.label3.Text = "T.Z";
            // 
            // city
            // 
            this.city.AutoSize = true;
            this.city.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.city.Location = new System.Drawing.Point(71, 803);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(82, 39);
            this.city.TabIndex = 30;
            this.city.Text = "City";
            // 
            // comboBox_city
            // 
            this.comboBox_city.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_city.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_city.FormattingEnabled = true;
            this.comboBox_city.Location = new System.Drawing.Point(306, 797);
            this.comboBox_city.Name = "comboBox_city";
            this.comboBox_city.Size = new System.Drawing.Size(212, 45);
            this.comboBox_city.TabIndex = 31;
            // 
            // button_add_city
            // 
            this.button_add_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add_city.Location = new System.Drawing.Point(545, 803);
            this.button_add_city.Name = "button_add_city";
            this.button_add_city.Size = new System.Drawing.Size(42, 39);
            this.button_add_city.TabIndex = 32;
            this.button_add_city.Text = "+";
            this.button_add_city.UseVisualStyleBackColor = true;
            this.button_add_city.Click += new System.EventHandler(this.button_add_city_Click);
            // 
            // Form_Client
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(1983, 1012);
            this.Controls.Add(this.button_add_city);
            this.Controls.Add(this.comboBox_city);
            this.Controls.Add(this.city);
            this.Controls.Add(this.groupBox_filter);
            this.Controls.Add(this.button_deleteClient);
            this.Controls.Add(this.button_clean);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox_Clients);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.textBox_phone);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.textBox_creditcard);
            this.Controls.Add(this.credit_card);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_mail);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.textBox_taz);
            this.Controls.Add(this.id);
            this.Controls.Add(this.textBox_lastname);
            this.Controls.Add(this.last_name);
            this.Controls.Add(this.textBox_first_name);
            this.Controls.Add(this.first_name);
            this.Name = "Form_Client";
            this.Text = "Form_Client";
            this.groupBox_filter.ResumeLayout(false);
            this.groupBox_filter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label first_name;
        private System.Windows.Forms.TextBox textBox_first_name;
        private System.Windows.Forms.TextBox textBox_lastname;
        private System.Windows.Forms.Label last_name;
        private System.Windows.Forms.TextBox textBox_mail;
        private System.Windows.Forms.Label mail;
        private System.Windows.Forms.TextBox textBox_taz;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_creditcard;
        private System.Windows.Forms.Label credit_card;
        private System.Windows.Forms.TextBox textBox_phone;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.ListBox listBox_Clients;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Button button_clean;
        private System.Windows.Forms.Button button_deleteClient;
        private System.Windows.Forms.GroupBox groupBox_filter;
        private System.Windows.Forms.TextBox groupbox_phone;
        private System.Windows.Forms.TextBox groupbox_taz;
        private System.Windows.Forms.TextBox groupbox_lastname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label city;
        private System.Windows.Forms.ComboBox comboBox_city;
        private System.Windows.Forms.Button button_add_city;
    }
}

