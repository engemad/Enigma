﻿namespace SecurityForms
{
    partial class SecurityForms
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
            this.EncBTN = new System.Windows.Forms.Button();
            this.DecBTN = new System.Windows.Forms.Button();
            this.comboBoxChooseType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.exitBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MessageTXT = new System.Windows.Forms.TextBox();
            this.EncryptionMessageTXT = new System.Windows.Forms.TextBox();
            this.DecryptionMessageTXT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.keyTXT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.notificationTXT = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EncBTN
            // 
            this.EncBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.EncBTN.Location = new System.Drawing.Point(482, 448);
            this.EncBTN.Name = "EncBTN";
            this.EncBTN.Size = new System.Drawing.Size(136, 40);
            this.EncBTN.TabIndex = 0;
            this.EncBTN.Text = "Encryption";
            this.EncBTN.UseVisualStyleBackColor = true;
            this.EncBTN.Click += new System.EventHandler(this.EncBTN_Click);
            // 
            // DecBTN
            // 
            this.DecBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DecBTN.Location = new System.Drawing.Point(624, 448);
            this.DecBTN.Name = "DecBTN";
            this.DecBTN.Size = new System.Drawing.Size(122, 40);
            this.DecBTN.TabIndex = 1;
            this.DecBTN.Text = "Decryption";
            this.DecBTN.UseVisualStyleBackColor = true;
            this.DecBTN.Click += new System.EventHandler(this.DecBTN_Click);
            // 
            // comboBoxChooseType
            // 
            this.comboBoxChooseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChooseType.FormattingEnabled = true;
            this.comboBoxChooseType.Items.AddRange(new object[] {
            "1 - Caeser Cipher",
            "2 - Monoalphabetic Cipher",
            "3 - Playfair Cipher",
            "4 - Polyalphabetic Cipher",
            "5 - Rail Fence",
            "6 - T Des Cipher",
            "7 - Simple Des"});
            this.comboBoxChooseType.Location = new System.Drawing.Point(228, 102);
            this.comboBoxChooseType.Name = "comboBoxChooseType";
            this.comboBoxChooseType.Size = new System.Drawing.Size(244, 24);
            this.comboBoxChooseType.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose Your Encryption Type :";
            // 
            // exitBTN
            // 
            this.exitBTN.Location = new System.Drawing.Point(752, 448);
            this.exitBTN.Name = "exitBTN";
            this.exitBTN.Size = new System.Drawing.Size(113, 40);
            this.exitBTN.TabIndex = 4;
            this.exitBTN.Text = "Exit";
            this.exitBTN.UseVisualStyleBackColor = true;
            this.exitBTN.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter Your Message :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(11, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Encrypted Message :";
            // 
            // MessageTXT
            // 
            this.MessageTXT.Location = new System.Drawing.Point(228, 150);
            this.MessageTXT.Multiline = true;
            this.MessageTXT.Name = "MessageTXT";
            this.MessageTXT.Size = new System.Drawing.Size(244, 74);
            this.MessageTXT.TabIndex = 7;
            // 
            // EncryptionMessageTXT
            // 
            this.EncryptionMessageTXT.Location = new System.Drawing.Point(228, 249);
            this.EncryptionMessageTXT.Multiline = true;
            this.EncryptionMessageTXT.Name = "EncryptionMessageTXT";
            this.EncryptionMessageTXT.ReadOnly = true;
            this.EncryptionMessageTXT.Size = new System.Drawing.Size(244, 80);
            this.EncryptionMessageTXT.TabIndex = 8;
            // 
            // DecryptionMessageTXT
            // 
            this.DecryptionMessageTXT.Location = new System.Drawing.Point(228, 342);
            this.DecryptionMessageTXT.Multiline = true;
            this.DecryptionMessageTXT.Name = "DecryptionMessageTXT";
            this.DecryptionMessageTXT.ReadOnly = true;
            this.DecryptionMessageTXT.Size = new System.Drawing.Size(244, 78);
            this.DecryptionMessageTXT.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(9, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Decrypted Message :";
            // 
            // keyTXT
            // 
            this.keyTXT.Location = new System.Drawing.Point(491, 105);
            this.keyTXT.Multiline = true;
            this.keyTXT.Name = "keyTXT";
            this.keyTXT.PasswordChar = '*';
            this.keyTXT.Size = new System.Drawing.Size(377, 75);
            this.keyTXT.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(488, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Key :";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(491, 186);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(90, 21);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Show key";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.notificationTXT);
            this.groupBox1.Location = new System.Drawing.Point(491, 229);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 191);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Notifications";
            // 
            // notificationTXT
            // 
            this.notificationTXT.BackColor = System.Drawing.SystemColors.ControlDark;
            this.notificationTXT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notificationTXT.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notificationTXT.ForeColor = System.Drawing.SystemColors.Highlight;
            this.notificationTXT.Location = new System.Drawing.Point(3, 20);
            this.notificationTXT.Multiline = true;
            this.notificationTXT.Name = "notificationTXT";
            this.notificationTXT.ReadOnly = true;
            this.notificationTXT.Size = new System.Drawing.Size(371, 168);
            this.notificationTXT.TabIndex = 15;
            // 
            // SecurityForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 502);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.keyTXT);
            this.Controls.Add(this.DecryptionMessageTXT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EncryptionMessageTXT);
            this.Controls.Add(this.MessageTXT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exitBTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxChooseType);
            this.Controls.Add(this.DecBTN);
            this.Controls.Add(this.EncBTN);
            this.Name = "SecurityForms";
            this.Text = "Enigma  Turing";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EncBTN;
        private System.Windows.Forms.Button DecBTN;
        private System.Windows.Forms.ComboBox comboBoxChooseType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exitBTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MessageTXT;
        private System.Windows.Forms.TextBox EncryptionMessageTXT;
        private System.Windows.Forms.TextBox DecryptionMessageTXT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox keyTXT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox notificationTXT;
    }
}

