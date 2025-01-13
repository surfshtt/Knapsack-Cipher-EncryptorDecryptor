namespace Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Msg_to_encrypt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Public_key = new TextBox();
            label3 = new Label();
            Private_key = new TextBox();
            label4 = new Label();
            N_field = new TextBox();
            label5 = new Label();
            N1_field = new TextBox();
            label6 = new Label();
            M_field = new TextBox();
            label7 = new Label();
            Encrypt_buttton = new Button();
            Decrypt_button = new Button();
            label8 = new Label();
            Encrypted_message = new TextBox();
            Save_button = new Button();
            button1 = new Button();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            SuspendLayout();
            // 
            // Msg_to_encrypt
            // 
            Msg_to_encrypt.Font = new Font("Segoe UI", 25F);
            Msg_to_encrypt.Location = new Point(22, 48);
            Msg_to_encrypt.Name = "Msg_to_encrypt";
            Msg_to_encrypt.Size = new Size(375, 52);
            Msg_to_encrypt.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19F);
            label1.Location = new Point(64, 9);
            label1.Name = "label1";
            label1.Size = new Size(285, 36);
            label1.TabIndex = 1;
            label1.Text = "Message for encryption";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19F);
            label2.Location = new Point(139, 125);
            label2.Name = "label2";
            label2.Size = new Size(131, 36);
            label2.TabIndex = 3;
            label2.Text = "Public key";
            // 
            // Public_key
            // 
            Public_key.Font = new Font("Segoe UI", 25F);
            Public_key.Location = new Point(22, 164);
            Public_key.Name = "Public_key";
            Public_key.Size = new Size(375, 52);
            Public_key.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19F);
            label3.Location = new Point(139, 226);
            label3.Name = "label3";
            label3.Size = new Size(140, 36);
            label3.TabIndex = 5;
            label3.Text = "Private key";
            // 
            // Private_key
            // 
            Private_key.Font = new Font("Segoe UI", 25F);
            Private_key.Location = new Point(22, 265);
            Private_key.Name = "Private_key";
            Private_key.Size = new Size(276, 52);
            Private_key.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 19F);
            label4.Location = new Point(32, 351);
            label4.Name = "label4";
            label4.Size = new Size(30, 36);
            label4.TabIndex = 7;
            label4.Text = "n";
            // 
            // N_field
            // 
            N_field.Font = new Font("Segoe UI", 25F);
            N_field.Location = new Point(22, 390);
            N_field.Name = "N_field";
            N_field.Size = new Size(52, 52);
            N_field.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 19F);
            label5.Location = new Point(171, 351);
            label5.Name = "label5";
            label5.Size = new Size(30, 36);
            label5.TabIndex = 9;
            label5.Text = "n";
            // 
            // N1_field
            // 
            N1_field.Font = new Font("Segoe UI", 25F);
            N1_field.Location = new Point(161, 390);
            N1_field.Name = "N1_field";
            N1_field.Size = new Size(52, 52);
            N1_field.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 19F);
            label6.Location = new Point(307, 351);
            label6.Name = "label6";
            label6.Size = new Size(37, 36);
            label6.TabIndex = 11;
            label6.Text = "m";
            // 
            // M_field
            // 
            M_field.Font = new Font("Segoe UI", 25F);
            M_field.Location = new Point(297, 390);
            M_field.Name = "M_field";
            M_field.Size = new Size(52, 52);
            M_field.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(190, 351);
            label7.Name = "label7";
            label7.Size = new Size(23, 19);
            label7.TabIndex = 12;
            label7.Text = "-1";
            // 
            // Encrypt_buttton
            // 
            Encrypt_buttton.BackColor = Color.PaleGreen;
            Encrypt_buttton.Font = new Font("Segoe UI", 25F);
            Encrypt_buttton.Location = new Point(22, 481);
            Encrypt_buttton.Name = "Encrypt_buttton";
            Encrypt_buttton.Size = new Size(329, 65);
            Encrypt_buttton.TabIndex = 13;
            Encrypt_buttton.Text = "Encrypt";
            Encrypt_buttton.UseVisualStyleBackColor = false;
            Encrypt_buttton.Click += Encrypt_buttton_Click;
            // 
            // Decrypt_button
            // 
            Decrypt_button.BackColor = Color.Tomato;
            Decrypt_button.Font = new Font("Segoe UI", 25F);
            Decrypt_button.Location = new Point(22, 559);
            Decrypt_button.Name = "Decrypt_button";
            Decrypt_button.Size = new Size(329, 65);
            Decrypt_button.TabIndex = 14;
            Decrypt_button.Text = "Decrypt";
            Decrypt_button.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 19F);
            label8.Location = new Point(580, 9);
            label8.Name = "label8";
            label8.Size = new Size(237, 36);
            label8.TabIndex = 16;
            label8.Text = "Encrypted message";
            // 
            // Encrypted_message
            // 
            Encrypted_message.Font = new Font("Segoe UI", 25F);
            Encrypted_message.Location = new Point(506, 48);
            Encrypted_message.Name = "Encrypted_message";
            Encrypted_message.Size = new Size(375, 52);
            Encrypted_message.TabIndex = 15;
            // 
            // Save_button
            // 
            Save_button.BackColor = Color.Ivory;
            Save_button.Font = new Font("Segoe UI", 25F);
            Save_button.Location = new Point(961, 41);
            Save_button.Name = "Save_button";
            Save_button.Size = new Size(184, 59);
            Save_button.TabIndex = 17;
            Save_button.Text = "Save";
            Save_button.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Ivory;
            button1.Font = new Font("Segoe UI", 25F);
            button1.Location = new Point(1164, 41);
            button1.Name = "button1";
            button1.Size = new Size(184, 59);
            button1.TabIndex = 18;
            button1.Text = "Upload";
            button1.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(314, 257);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(74, 19);
            checkBox1.TabIndex = 20;
            checkBox1.Text = "By hands";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(314, 282);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(102, 19);
            checkBox2.TabIndex = 21;
            checkBox2.Text = "Only first num";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(314, 307);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(73, 19);
            checkBox3.TabIndex = 22;
            checkBox3.Text = "From file";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1360, 642);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(Save_button);
            Controls.Add(label8);
            Controls.Add(Encrypted_message);
            Controls.Add(Decrypt_button);
            Controls.Add(Encrypt_buttton);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(M_field);
            Controls.Add(label5);
            Controls.Add(N1_field);
            Controls.Add(label4);
            Controls.Add(N_field);
            Controls.Add(label3);
            Controls.Add(Private_key);
            Controls.Add(label2);
            Controls.Add(Public_key);
            Controls.Add(label1);
            Controls.Add(Msg_to_encrypt);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Msg_to_encrypt;
        private Label label1;
        private Label label2;
        private TextBox Public_key;
        private Label label3;
        private TextBox Private_key;
        private Label label4;
        private TextBox N_field;
        private Label label5;
        private TextBox N1_field;
        private Label label6;
        private TextBox M_field;
        private Label label7;
        private Button Encrypt_buttton;
        private Button Decrypt_button;
        private Label label8;
        private TextBox Encrypted_message;
        private Button Save_button;
        private Button button1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
    }
}
