namespace HotelManagement.UI
{
    partial class Form_Room
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
            this.textBox_room_number = new System.Windows.Forms.TextBox();
            this.roomnum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_add_category = new System.Windows.Forms.Button();
            this.comboBox_category = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox_Rooms = new System.Windows.Forms.ListBox();
            this.groupBox_filter = new System.Windows.Forms.GroupBox();
            this.comboBox_filter_floor = new System.Windows.Forms.ComboBox();
            this.comboBox_filter_category = new System.Windows.Forms.ComboBox();
            this.textbox_filter_room_number = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_deleteRoom = new System.Windows.Forms.Button();
            this.button_clean = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label_ID = new System.Windows.Forms.Label();
            this.comboBox_floor = new System.Windows.Forms.ComboBox();
            this.label_pr = new System.Windows.Forms.Label();
            this.label_price = new System.Windows.Forms.Label();
            this.button_new_floor = new System.Windows.Forms.Button();
            this.groupBox_filter.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_room_number
            // 
            this.textBox_room_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox_room_number.Location = new System.Drawing.Point(357, 226);
            this.textBox_room_number.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_room_number.Multiline = true;
            this.textBox_room_number.Name = "textBox_room_number";
            this.textBox_room_number.Size = new System.Drawing.Size(213, 45);
            this.textBox_room_number.TabIndex = 5;
            // 
            // roomnum
            // 
            this.roomnum.AutoSize = true;
            this.roomnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.roomnum.Location = new System.Drawing.Point(56, 232);
            this.roomnum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.roomnum.Name = "roomnum";
            this.roomnum.Size = new System.Drawing.Size(254, 39);
            this.roomnum.TabIndex = 4;
            this.roomnum.Text = "Room Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(56, 303);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "Category Room";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(65, 380);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 39);
            this.label2.TabIndex = 8;
            this.label2.Text = "Floor";
            // 
            // button_add_category
            // 
            this.button_add_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add_category.Location = new System.Drawing.Point(574, 303);
            this.button_add_category.Margin = new System.Windows.Forms.Padding(2);
            this.button_add_category.Name = "button_add_category";
            this.button_add_category.Size = new System.Drawing.Size(51, 45);
            this.button_add_category.TabIndex = 34;
            this.button_add_category.Text = "+";
            this.button_add_category.UseVisualStyleBackColor = true;
            this.button_add_category.Click += new System.EventHandler(this.button_add_category_Click);
            // 
            // comboBox_category
            // 
            this.comboBox_category.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_category.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_category.BackColor = System.Drawing.Color.White;
            this.comboBox_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_category.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_category.FormattingEnabled = true;
            this.comboBox_category.Location = new System.Drawing.Point(350, 303);
            this.comboBox_category.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_category.Name = "comboBox_category";
            this.comboBox_category.Size = new System.Drawing.Size(220, 45);
            this.comboBox_category.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(318, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 63);
            this.label3.TabIndex = 35;
            this.label3.Text = "ROOMS";
            // 
            // listBox_Rooms
            // 
            this.listBox_Rooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_Rooms.FormattingEnabled = true;
            this.listBox_Rooms.ItemHeight = 31;
            this.listBox_Rooms.Location = new System.Drawing.Point(670, 132);
            this.listBox_Rooms.Margin = new System.Windows.Forms.Padding(2);
            this.listBox_Rooms.Name = "listBox_Rooms";
            this.listBox_Rooms.Size = new System.Drawing.Size(323, 407);
            this.listBox_Rooms.TabIndex = 36;
            this.listBox_Rooms.DoubleClick += new System.EventHandler(this.listBox_Clients_DoubleClick);
            // 
            // groupBox_filter
            // 
            this.groupBox_filter.Controls.Add(this.comboBox_filter_floor);
            this.groupBox_filter.Controls.Add(this.comboBox_filter_category);
            this.groupBox_filter.Controls.Add(this.textbox_filter_room_number);
            this.groupBox_filter.Controls.Add(this.label5);
            this.groupBox_filter.Controls.Add(this.label4);
            this.groupBox_filter.Controls.Add(this.label6);
            this.groupBox_filter.Location = new System.Drawing.Point(1070, 124);
            this.groupBox_filter.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_filter.Name = "groupBox_filter";
            this.groupBox_filter.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_filter.Size = new System.Drawing.Size(454, 256);
            this.groupBox_filter.TabIndex = 37;
            this.groupBox_filter.TabStop = false;
            this.groupBox_filter.Text = "Filter";
            // 
            // comboBox_filter_floor
            // 
            this.comboBox_filter_floor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_filter_floor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_filter_floor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_filter_floor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_filter_floor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_filter_floor.FormattingEnabled = true;
            this.comboBox_filter_floor.Location = new System.Drawing.Point(308, 179);
            this.comboBox_filter_floor.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_filter_floor.Name = "comboBox_filter_floor";
            this.comboBox_filter_floor.Size = new System.Drawing.Size(108, 45);
            this.comboBox_filter_floor.TabIndex = 35;
            this.comboBox_filter_floor.TextChanged += new System.EventHandler(this.comboBox_filter_category_TextChanged);
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
            this.comboBox_filter_category.Size = new System.Drawing.Size(108, 45);
            this.comboBox_filter_category.TabIndex = 34;
            this.comboBox_filter_category.TextChanged += new System.EventHandler(this.comboBox_filter_category_TextChanged);
            // 
            // textbox_filter_room_number
            // 
            this.textbox_filter_room_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textbox_filter_room_number.Location = new System.Drawing.Point(308, 40);
            this.textbox_filter_room_number.Margin = new System.Windows.Forms.Padding(2);
            this.textbox_filter_room_number.Multiline = true;
            this.textbox_filter_room_number.Name = "textbox_filter_room_number";
            this.textbox_filter_room_number.Size = new System.Drawing.Size(108, 44);
            this.textbox_filter_room_number.TabIndex = 15;
            this.textbox_filter_room_number.KeyUp += new System.Windows.Forms.KeyEventHandler(this.groupbox_roomNumber_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(3, 108);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(273, 39);
            this.label5.TabIndex = 14;
            this.label5.Text = "Category Room";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(4, 40);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 39);
            this.label4.TabIndex = 8;
            this.label4.Text = "Room Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(20, 185);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 39);
            this.label6.TabIndex = 7;
            this.label6.Text = "Floor";
            // 
            // button_deleteRoom
            // 
            this.button_deleteRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_deleteRoom.ForeColor = System.Drawing.Color.Red;
            this.button_deleteRoom.Location = new System.Drawing.Point(513, 646);
            this.button_deleteRoom.Margin = new System.Windows.Forms.Padding(2);
            this.button_deleteRoom.Name = "button_deleteRoom";
            this.button_deleteRoom.Size = new System.Drawing.Size(266, 89);
            this.button_deleteRoom.TabIndex = 41;
            this.button_deleteRoom.Text = "DELETE ROOM";
            this.button_deleteRoom.UseVisualStyleBackColor = true;
            this.button_deleteRoom.Click += new System.EventHandler(this.button_deleteClient_Click);
            // 
            // button_clean
            // 
            this.button_clean.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clean.ForeColor = System.Drawing.Color.Coral;
            this.button_clean.Location = new System.Drawing.Point(291, 651);
            this.button_clean.Margin = new System.Windows.Forms.Padding(2);
            this.button_clean.Name = "button_clean";
            this.button_clean.Size = new System.Drawing.Size(180, 84);
            this.button_clean.TabIndex = 40;
            this.button_clean.Text = "Clean";
            this.button_clean.UseVisualStyleBackColor = true;
            this.button_clean.Click += new System.EventHandler(this.button_clean_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel.Location = new System.Drawing.Point(1081, 651);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(2);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(222, 78);
            this.button_cancel.TabIndex = 39;
            this.button_cancel.Text = "Exit";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click_1);
            // 
            // button_save
            // 
            this.button_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.ForeColor = System.Drawing.Color.Green;
            this.button_save.Location = new System.Drawing.Point(103, 651);
            this.button_save.Margin = new System.Windows.Forms.Padding(2);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(170, 84);
            this.button_save.TabIndex = 38;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(56, 164);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 39);
            this.label7.TabIndex = 42;
            this.label7.Text = "ID";
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_ID.Location = new System.Drawing.Point(350, 169);
            this.label_ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(37, 39);
            this.label_ID.TabIndex = 43;
            this.label_ID.Text = "0";
            // 
            // comboBox_floor
            // 
            this.comboBox_floor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_floor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_floor.BackColor = System.Drawing.SystemColors.HighlightText;
            this.comboBox_floor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_floor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_floor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_floor.FormattingEnabled = true;
            this.comboBox_floor.Location = new System.Drawing.Point(350, 375);
            this.comboBox_floor.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_floor.Name = "comboBox_floor";
            this.comboBox_floor.Size = new System.Drawing.Size(220, 45);
            this.comboBox_floor.TabIndex = 44;
            // 
            // label_pr
            // 
            this.label_pr.AutoSize = true;
            this.label_pr.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_pr.Location = new System.Drawing.Point(65, 460);
            this.label_pr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_pr.Name = "label_pr";
            this.label_pr.Size = new System.Drawing.Size(102, 39);
            this.label_pr.TabIndex = 45;
            this.label_pr.Text = "Price";
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_price.Location = new System.Drawing.Point(350, 460);
            this.label_price.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(37, 39);
            this.label_price.TabIndex = 46;
            this.label_price.Text = "0";
            // 
            // button_new_floor
            // 
            this.button_new_floor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_new_floor.Location = new System.Drawing.Point(576, 374);
            this.button_new_floor.Margin = new System.Windows.Forms.Padding(2);
            this.button_new_floor.Name = "button_new_floor";
            this.button_new_floor.Size = new System.Drawing.Size(49, 45);
            this.button_new_floor.TabIndex = 47;
            this.button_new_floor.Text = "+";
            this.button_new_floor.UseVisualStyleBackColor = true;
            this.button_new_floor.Click += new System.EventHandler(this.button_new_floor_Click);
            // 
            // Form_Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1609, 845);
            this.Controls.Add(this.button_new_floor);
            this.Controls.Add(this.label_price);
            this.Controls.Add(this.label_pr);
            this.Controls.Add(this.comboBox_floor);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button_deleteRoom);
            this.Controls.Add(this.button_clean);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.groupBox_filter);
            this.Controls.Add(this.listBox_Rooms);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_add_category);
            this.Controls.Add(this.comboBox_category);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_room_number);
            this.Controls.Add(this.roomnum);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_Room";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Room";
            this.groupBox_filter.ResumeLayout(false);
            this.groupBox_filter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_room_number;
        private System.Windows.Forms.Label roomnum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_add_category;
        private System.Windows.Forms.ComboBox comboBox_category;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox_Rooms;
        private System.Windows.Forms.GroupBox groupBox_filter;
        private System.Windows.Forms.ComboBox comboBox_filter_floor;
        private System.Windows.Forms.ComboBox comboBox_filter_category;
        private System.Windows.Forms.TextBox textbox_filter_room_number;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_deleteRoom;
        private System.Windows.Forms.Button button_clean;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.ComboBox comboBox_floor;
        private System.Windows.Forms.Label label_pr;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.Button button_new_floor;
    }
}