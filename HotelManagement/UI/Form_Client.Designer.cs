namespace HotelManagement
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
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_creditcard = new System.Windows.Forms.TextBox();
            this.credit_card = new System.Windows.Forms.Label();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.Label();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.listBox_Clients = new System.Windows.Forms.ListBox();
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
            // textBox_id
            // 
            this.textBox_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox_id.Location = new System.Drawing.Point(306, 404);
            this.textBox_id.MaxLength = 9;
            this.textBox_id.Multiline = true;
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(212, 48);
            this.textBox_id.TabIndex = 7;
            this.textBox_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Check_Num);
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.id.Location = new System.Drawing.Point(65, 404);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(53, 39);
            this.id.TabIndex = 6;
            this.id.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(189, 34);
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
            this.button_cancel.Location = new System.Drawing.Point(376, 842);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(161, 45);
            this.button_cancel.TabIndex = 23;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(139, 842);
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
            this.listBox_Clients.Location = new System.Drawing.Point(970, 203);
            this.listBox_Clients.Name = "listBox_Clients";
            this.listBox_Clients.Size = new System.Drawing.Size(596, 562);
            this.listBox_Clients.TabIndex = 24;
            // 
            // Form_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1792, 1012);
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
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.id);
            this.Controls.Add(this.textBox_lastname);
            this.Controls.Add(this.last_name);
            this.Controls.Add(this.textBox_first_name);
            this.Controls.Add(this.first_name);
            this.Name = "Form_Client";
            this.Text = "Form_Client";
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
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_creditcard;
        private System.Windows.Forms.Label credit_card;
        private System.Windows.Forms.TextBox textBox_phone;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.ListBox listBox_Clients;
    }
}

