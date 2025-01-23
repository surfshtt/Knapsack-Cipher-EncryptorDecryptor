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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            Upload_button = new Button();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            pictureBox1 = new PictureBox();
            Symb1 = new Label();
            Symb2 = new Label();
            Symb3 = new Label();
            Symb5 = new Label();
            Symb4 = new Label();
            Symb7 = new Label();
            Symb6 = new Label();
            Bin7 = new Label();
            Bin6 = new Label();
            Bin5 = new Label();
            Bin4 = new Label();
            Bin3 = new Label();
            Bin2 = new Label();
            Bin1 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            label26 = new Label();
            label27 = new Label();
            label28 = new Label();
            label29 = new Label();
            label30 = new Label();
            label31 = new Label();
            label32 = new Label();
            label33 = new Label();
            label34 = new Label();
            label35 = new Label();
            label36 = new Label();
            label37 = new Label();
            label38 = new Label();
            label39 = new Label();
            label40 = new Label();
            label41 = new Label();
            label42 = new Label();
            label43 = new Label();
            label44 = new Label();
            label45 = new Label();
            label46 = new Label();
            label47 = new Label();
            label48 = new Label();
            label49 = new Label();
            label50 = new Label();
            label51 = new Label();
            label52 = new Label();
            label53 = new Label();
            label54 = new Label();
            label55 = new Label();
            label56 = new Label();
            label57 = new Label();
            label58 = new Label();
            label59 = new Label();
            label60 = new Label();
            label61 = new Label();
            label62 = new Label();
            label63 = new Label();
            label64 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            label1.Location = new Point(10, 9);
            label1.Name = "label1";
            label1.Size = new Size(418, 36);
            label1.TabIndex = 1;
            label1.Text = "Message for encryption/decryption";
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
            N_field.Location = new Point(10, 390);
            N_field.Name = "N_field";
            N_field.Size = new Size(110, 52);
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
            N1_field.Location = new Point(126, 390);
            N1_field.Name = "N1_field";
            N1_field.Size = new Size(122, 52);
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
            M_field.Location = new Point(254, 390);
            M_field.Name = "M_field";
            M_field.Size = new Size(119, 52);
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
            Decrypt_button.Click += Decrypt_button_Click;
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
            Save_button.Click += Save_button_Click;
            // 
            // Upload_button
            // 
            Upload_button.BackColor = Color.Ivory;
            Upload_button.Font = new Font("Segoe UI", 25F);
            Upload_button.Location = new Point(1164, 41);
            Upload_button.Name = "Upload_button";
            Upload_button.Size = new Size(184, 59);
            Upload_button.TabIndex = 18;
            Upload_button.Text = "Upload";
            Upload_button.UseVisualStyleBackColor = false;
            Upload_button.Click += Upload_button_Click;
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
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(402, 430);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(73, 19);
            checkBox4.TabIndex = 25;
            checkBox4.Text = "From file";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(402, 405);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(73, 19);
            checkBox5.TabIndex = 24;
            checkBox5.Text = "Generate";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(402, 380);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(74, 19);
            checkBox6.TabIndex = 23;
            checkBox6.Text = "By hands";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(489, 179);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(859, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // Symb1
            // 
            Symb1.AutoSize = true;
            Symb1.BorderStyle = BorderStyle.FixedSingle;
            Symb1.Font = new Font("Segoe UI", 16F);
            Symb1.Location = new Point(528, 291);
            Symb1.Name = "Symb1";
            Symb1.Size = new Size(2, 32);
            Symb1.TabIndex = 27;
            // 
            // Symb2
            // 
            Symb2.AutoSize = true;
            Symb2.BorderStyle = BorderStyle.FixedSingle;
            Symb2.Font = new Font("Segoe UI", 16F);
            Symb2.Location = new Point(528, 327);
            Symb2.Name = "Symb2";
            Symb2.Size = new Size(2, 32);
            Symb2.TabIndex = 28;
            // 
            // Symb3
            // 
            Symb3.AutoSize = true;
            Symb3.BorderStyle = BorderStyle.FixedSingle;
            Symb3.Font = new Font("Segoe UI", 16F);
            Symb3.Location = new Point(528, 367);
            Symb3.Name = "Symb3";
            Symb3.Size = new Size(2, 32);
            Symb3.TabIndex = 29;
            // 
            // Symb5
            // 
            Symb5.AutoSize = true;
            Symb5.BorderStyle = BorderStyle.FixedSingle;
            Symb5.Font = new Font("Segoe UI", 16F);
            Symb5.Location = new Point(528, 441);
            Symb5.Name = "Symb5";
            Symb5.Size = new Size(2, 32);
            Symb5.TabIndex = 31;
            // 
            // Symb4
            // 
            Symb4.AutoSize = true;
            Symb4.BorderStyle = BorderStyle.FixedSingle;
            Symb4.Font = new Font("Segoe UI", 16F);
            Symb4.Location = new Point(528, 405);
            Symb4.Name = "Symb4";
            Symb4.Size = new Size(2, 32);
            Symb4.TabIndex = 30;
            // 
            // Symb7
            // 
            Symb7.AutoSize = true;
            Symb7.BorderStyle = BorderStyle.FixedSingle;
            Symb7.Font = new Font("Segoe UI", 16F);
            Symb7.Location = new Point(528, 517);
            Symb7.Name = "Symb7";
            Symb7.Size = new Size(2, 32);
            Symb7.TabIndex = 34;
            // 
            // Symb6
            // 
            Symb6.AutoSize = true;
            Symb6.BorderStyle = BorderStyle.FixedSingle;
            Symb6.Font = new Font("Segoe UI", 16F);
            Symb6.Location = new Point(528, 481);
            Symb6.Name = "Symb6";
            Symb6.Size = new Size(2, 32);
            Symb6.TabIndex = 33;
            // 
            // Bin7
            // 
            Bin7.AutoSize = true;
            Bin7.BorderStyle = BorderStyle.FixedSingle;
            Bin7.Font = new Font("Segoe UI", 16F);
            Bin7.Location = new Point(653, 517);
            Bin7.Name = "Bin7";
            Bin7.Size = new Size(2, 32);
            Bin7.TabIndex = 41;
            // 
            // Bin6
            // 
            Bin6.AutoSize = true;
            Bin6.BorderStyle = BorderStyle.FixedSingle;
            Bin6.Font = new Font("Segoe UI", 16F);
            Bin6.Location = new Point(653, 481);
            Bin6.Name = "Bin6";
            Bin6.Size = new Size(2, 32);
            Bin6.TabIndex = 40;
            // 
            // Bin5
            // 
            Bin5.AutoSize = true;
            Bin5.BorderStyle = BorderStyle.FixedSingle;
            Bin5.Font = new Font("Segoe UI", 16F);
            Bin5.Location = new Point(653, 441);
            Bin5.Name = "Bin5";
            Bin5.Size = new Size(2, 32);
            Bin5.TabIndex = 39;
            // 
            // Bin4
            // 
            Bin4.AutoSize = true;
            Bin4.BorderStyle = BorderStyle.FixedSingle;
            Bin4.Font = new Font("Segoe UI", 16F);
            Bin4.Location = new Point(653, 405);
            Bin4.Name = "Bin4";
            Bin4.Size = new Size(2, 32);
            Bin4.TabIndex = 38;
            // 
            // Bin3
            // 
            Bin3.AutoSize = true;
            Bin3.BorderStyle = BorderStyle.FixedSingle;
            Bin3.Font = new Font("Segoe UI", 16F);
            Bin3.Location = new Point(653, 367);
            Bin3.Name = "Bin3";
            Bin3.Size = new Size(2, 32);
            Bin3.TabIndex = 37;
            // 
            // Bin2
            // 
            Bin2.AutoSize = true;
            Bin2.BorderStyle = BorderStyle.FixedSingle;
            Bin2.Font = new Font("Segoe UI", 16F);
            Bin2.Location = new Point(653, 327);
            Bin2.Name = "Bin2";
            Bin2.Size = new Size(2, 32);
            Bin2.TabIndex = 36;
            // 
            // Bin1
            // 
            Bin1.AutoSize = true;
            Bin1.BorderStyle = BorderStyle.FixedSingle;
            Bin1.Font = new Font("Segoe UI", 16F);
            Bin1.Location = new Point(653, 291);
            Bin1.Name = "Bin1";
            Bin1.Size = new Size(2, 32);
            Bin1.TabIndex = 35;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BorderStyle = BorderStyle.FixedSingle;
            label9.Font = new Font("Segoe UI", 16F);
            label9.Location = new Point(787, 517);
            label9.Name = "label9";
            label9.Size = new Size(2, 32);
            label9.TabIndex = 48;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BorderStyle = BorderStyle.FixedSingle;
            label10.Font = new Font("Segoe UI", 16F);
            label10.Location = new Point(787, 481);
            label10.Name = "label10";
            label10.Size = new Size(2, 32);
            label10.TabIndex = 47;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BorderStyle = BorderStyle.FixedSingle;
            label11.Font = new Font("Segoe UI", 16F);
            label11.Location = new Point(787, 441);
            label11.Name = "label11";
            label11.Size = new Size(2, 32);
            label11.TabIndex = 46;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BorderStyle = BorderStyle.FixedSingle;
            label12.Font = new Font("Segoe UI", 16F);
            label12.Location = new Point(787, 405);
            label12.Name = "label12";
            label12.Size = new Size(2, 32);
            label12.TabIndex = 45;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BorderStyle = BorderStyle.FixedSingle;
            label13.Font = new Font("Segoe UI", 16F);
            label13.Location = new Point(787, 367);
            label13.Name = "label13";
            label13.Size = new Size(2, 32);
            label13.TabIndex = 44;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BorderStyle = BorderStyle.FixedSingle;
            label14.Font = new Font("Segoe UI", 16F);
            label14.Location = new Point(787, 327);
            label14.Name = "label14";
            label14.Size = new Size(2, 32);
            label14.TabIndex = 43;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BorderStyle = BorderStyle.FixedSingle;
            label15.Font = new Font("Segoe UI", 16F);
            label15.Location = new Point(787, 291);
            label15.Name = "label15";
            label15.Size = new Size(2, 32);
            label15.TabIndex = 42;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BorderStyle = BorderStyle.FixedSingle;
            label16.Font = new Font("Segoe UI", 16F);
            label16.Location = new Point(832, 517);
            label16.Name = "label16";
            label16.Size = new Size(2, 32);
            label16.TabIndex = 55;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BorderStyle = BorderStyle.FixedSingle;
            label17.Font = new Font("Segoe UI", 16F);
            label17.Location = new Point(832, 481);
            label17.Name = "label17";
            label17.Size = new Size(2, 32);
            label17.TabIndex = 54;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BorderStyle = BorderStyle.FixedSingle;
            label18.Font = new Font("Segoe UI", 16F);
            label18.Location = new Point(832, 441);
            label18.Name = "label18";
            label18.Size = new Size(2, 32);
            label18.TabIndex = 53;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BorderStyle = BorderStyle.FixedSingle;
            label19.Font = new Font("Segoe UI", 16F);
            label19.Location = new Point(832, 405);
            label19.Name = "label19";
            label19.Size = new Size(2, 32);
            label19.TabIndex = 52;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BorderStyle = BorderStyle.FixedSingle;
            label20.Font = new Font("Segoe UI", 16F);
            label20.Location = new Point(832, 367);
            label20.Name = "label20";
            label20.Size = new Size(2, 32);
            label20.TabIndex = 51;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BorderStyle = BorderStyle.FixedSingle;
            label21.Font = new Font("Segoe UI", 16F);
            label21.Location = new Point(832, 327);
            label21.Name = "label21";
            label21.Size = new Size(2, 32);
            label21.TabIndex = 50;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BorderStyle = BorderStyle.FixedSingle;
            label22.Font = new Font("Segoe UI", 16F);
            label22.Location = new Point(832, 291);
            label22.Name = "label22";
            label22.Size = new Size(2, 32);
            label22.TabIndex = 49;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.BorderStyle = BorderStyle.FixedSingle;
            label23.Font = new Font("Segoe UI", 16F);
            label23.Location = new Point(879, 517);
            label23.Name = "label23";
            label23.Size = new Size(2, 32);
            label23.TabIndex = 69;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.BorderStyle = BorderStyle.FixedSingle;
            label24.Font = new Font("Segoe UI", 16F);
            label24.Location = new Point(879, 481);
            label24.Name = "label24";
            label24.Size = new Size(2, 32);
            label24.TabIndex = 68;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.BorderStyle = BorderStyle.FixedSingle;
            label25.Font = new Font("Segoe UI", 16F);
            label25.Location = new Point(879, 441);
            label25.Name = "label25";
            label25.Size = new Size(2, 32);
            label25.TabIndex = 67;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.BorderStyle = BorderStyle.FixedSingle;
            label26.Font = new Font("Segoe UI", 16F);
            label26.Location = new Point(879, 405);
            label26.Name = "label26";
            label26.Size = new Size(2, 32);
            label26.TabIndex = 66;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.BorderStyle = BorderStyle.FixedSingle;
            label27.Font = new Font("Segoe UI", 16F);
            label27.Location = new Point(879, 367);
            label27.Name = "label27";
            label27.Size = new Size(2, 32);
            label27.TabIndex = 65;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.BorderStyle = BorderStyle.FixedSingle;
            label28.Font = new Font("Segoe UI", 16F);
            label28.Location = new Point(879, 327);
            label28.Name = "label28";
            label28.Size = new Size(2, 32);
            label28.TabIndex = 64;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.BorderStyle = BorderStyle.FixedSingle;
            label29.Font = new Font("Segoe UI", 16F);
            label29.Location = new Point(879, 291);
            label29.Name = "label29";
            label29.Size = new Size(2, 32);
            label29.TabIndex = 63;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.BorderStyle = BorderStyle.FixedSingle;
            label30.Font = new Font("Segoe UI", 16F);
            label30.Location = new Point(928, 517);
            label30.Name = "label30";
            label30.Size = new Size(2, 32);
            label30.TabIndex = 62;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.BorderStyle = BorderStyle.FixedSingle;
            label31.Font = new Font("Segoe UI", 16F);
            label31.Location = new Point(928, 481);
            label31.Name = "label31";
            label31.Size = new Size(2, 32);
            label31.TabIndex = 61;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.BorderStyle = BorderStyle.FixedSingle;
            label32.Font = new Font("Segoe UI", 16F);
            label32.Location = new Point(928, 441);
            label32.Name = "label32";
            label32.Size = new Size(2, 32);
            label32.TabIndex = 60;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.BorderStyle = BorderStyle.FixedSingle;
            label33.Font = new Font("Segoe UI", 16F);
            label33.Location = new Point(928, 405);
            label33.Name = "label33";
            label33.Size = new Size(2, 32);
            label33.TabIndex = 59;
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.BorderStyle = BorderStyle.FixedSingle;
            label34.Font = new Font("Segoe UI", 16F);
            label34.Location = new Point(928, 367);
            label34.Name = "label34";
            label34.Size = new Size(2, 32);
            label34.TabIndex = 58;
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.BorderStyle = BorderStyle.FixedSingle;
            label35.Font = new Font("Segoe UI", 16F);
            label35.Location = new Point(928, 327);
            label35.Name = "label35";
            label35.Size = new Size(2, 32);
            label35.TabIndex = 57;
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.BorderStyle = BorderStyle.FixedSingle;
            label36.Font = new Font("Segoe UI", 16F);
            label36.Location = new Point(928, 291);
            label36.Name = "label36";
            label36.Size = new Size(2, 32);
            label36.TabIndex = 56;
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.BorderStyle = BorderStyle.FixedSingle;
            label37.Font = new Font("Segoe UI", 16F);
            label37.Location = new Point(976, 517);
            label37.Name = "label37";
            label37.Size = new Size(2, 32);
            label37.TabIndex = 90;
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.BorderStyle = BorderStyle.FixedSingle;
            label38.Font = new Font("Segoe UI", 16F);
            label38.Location = new Point(976, 481);
            label38.Name = "label38";
            label38.Size = new Size(2, 32);
            label38.TabIndex = 89;
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.BorderStyle = BorderStyle.FixedSingle;
            label39.Font = new Font("Segoe UI", 16F);
            label39.Location = new Point(976, 441);
            label39.Name = "label39";
            label39.Size = new Size(2, 32);
            label39.TabIndex = 88;
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.BorderStyle = BorderStyle.FixedSingle;
            label40.Font = new Font("Segoe UI", 16F);
            label40.Location = new Point(976, 405);
            label40.Name = "label40";
            label40.Size = new Size(2, 32);
            label40.TabIndex = 87;
            // 
            // label41
            // 
            label41.AutoSize = true;
            label41.BorderStyle = BorderStyle.FixedSingle;
            label41.Font = new Font("Segoe UI", 16F);
            label41.Location = new Point(976, 367);
            label41.Name = "label41";
            label41.Size = new Size(2, 32);
            label41.TabIndex = 86;
            // 
            // label42
            // 
            label42.AutoSize = true;
            label42.BorderStyle = BorderStyle.FixedSingle;
            label42.Font = new Font("Segoe UI", 16F);
            label42.Location = new Point(976, 327);
            label42.Name = "label42";
            label42.Size = new Size(2, 32);
            label42.TabIndex = 85;
            // 
            // label43
            // 
            label43.AutoSize = true;
            label43.BorderStyle = BorderStyle.FixedSingle;
            label43.Font = new Font("Segoe UI", 16F);
            label43.Location = new Point(976, 291);
            label43.Name = "label43";
            label43.Size = new Size(2, 32);
            label43.TabIndex = 84;
            // 
            // label44
            // 
            label44.AutoSize = true;
            label44.BorderStyle = BorderStyle.FixedSingle;
            label44.Font = new Font("Segoe UI", 16F);
            label44.Location = new Point(1020, 517);
            label44.Name = "label44";
            label44.Size = new Size(2, 32);
            label44.TabIndex = 83;
            // 
            // label45
            // 
            label45.AutoSize = true;
            label45.BorderStyle = BorderStyle.FixedSingle;
            label45.Font = new Font("Segoe UI", 16F);
            label45.Location = new Point(1020, 481);
            label45.Name = "label45";
            label45.Size = new Size(2, 32);
            label45.TabIndex = 82;
            // 
            // label46
            // 
            label46.AutoSize = true;
            label46.BorderStyle = BorderStyle.FixedSingle;
            label46.Font = new Font("Segoe UI", 16F);
            label46.Location = new Point(1020, 441);
            label46.Name = "label46";
            label46.Size = new Size(2, 32);
            label46.TabIndex = 81;
            // 
            // label47
            // 
            label47.AutoSize = true;
            label47.BorderStyle = BorderStyle.FixedSingle;
            label47.Font = new Font("Segoe UI", 16F);
            label47.Location = new Point(1020, 405);
            label47.Name = "label47";
            label47.Size = new Size(2, 32);
            label47.TabIndex = 80;
            // 
            // label48
            // 
            label48.AutoSize = true;
            label48.BorderStyle = BorderStyle.FixedSingle;
            label48.Font = new Font("Segoe UI", 16F);
            label48.Location = new Point(1020, 367);
            label48.Name = "label48";
            label48.Size = new Size(2, 32);
            label48.TabIndex = 79;
            // 
            // label49
            // 
            label49.AutoSize = true;
            label49.BorderStyle = BorderStyle.FixedSingle;
            label49.Font = new Font("Segoe UI", 16F);
            label49.Location = new Point(1020, 327);
            label49.Name = "label49";
            label49.Size = new Size(2, 32);
            label49.TabIndex = 78;
            // 
            // label50
            // 
            label50.AutoSize = true;
            label50.BorderStyle = BorderStyle.FixedSingle;
            label50.Font = new Font("Segoe UI", 16F);
            label50.Location = new Point(1020, 291);
            label50.Name = "label50";
            label50.Size = new Size(2, 32);
            label50.TabIndex = 77;
            // 
            // label51
            // 
            label51.AutoSize = true;
            label51.BorderStyle = BorderStyle.FixedSingle;
            label51.Font = new Font("Segoe UI", 16F);
            label51.Location = new Point(1064, 517);
            label51.Name = "label51";
            label51.Size = new Size(2, 32);
            label51.TabIndex = 76;
            // 
            // label52
            // 
            label52.AutoSize = true;
            label52.BorderStyle = BorderStyle.FixedSingle;
            label52.Font = new Font("Segoe UI", 16F);
            label52.Location = new Point(1064, 481);
            label52.Name = "label52";
            label52.Size = new Size(2, 32);
            label52.TabIndex = 75;
            // 
            // label53
            // 
            label53.AutoSize = true;
            label53.BorderStyle = BorderStyle.FixedSingle;
            label53.Font = new Font("Segoe UI", 16F);
            label53.Location = new Point(1064, 441);
            label53.Name = "label53";
            label53.Size = new Size(2, 32);
            label53.TabIndex = 74;
            // 
            // label54
            // 
            label54.AutoSize = true;
            label54.BorderStyle = BorderStyle.FixedSingle;
            label54.Font = new Font("Segoe UI", 16F);
            label54.Location = new Point(1064, 405);
            label54.Name = "label54";
            label54.Size = new Size(2, 32);
            label54.TabIndex = 73;
            // 
            // label55
            // 
            label55.AutoSize = true;
            label55.BorderStyle = BorderStyle.FixedSingle;
            label55.Font = new Font("Segoe UI", 16F);
            label55.Location = new Point(1064, 367);
            label55.Name = "label55";
            label55.Size = new Size(2, 32);
            label55.TabIndex = 72;
            // 
            // label56
            // 
            label56.AutoSize = true;
            label56.BorderStyle = BorderStyle.FixedSingle;
            label56.Font = new Font("Segoe UI", 16F);
            label56.Location = new Point(1064, 327);
            label56.Name = "label56";
            label56.Size = new Size(2, 32);
            label56.TabIndex = 71;
            // 
            // label57
            // 
            label57.AutoSize = true;
            label57.BorderStyle = BorderStyle.FixedSingle;
            label57.Font = new Font("Segoe UI", 16F);
            label57.Location = new Point(1064, 291);
            label57.Name = "label57";
            label57.Size = new Size(2, 32);
            label57.TabIndex = 70;
            // 
            // label58
            // 
            label58.AutoSize = true;
            label58.BorderStyle = BorderStyle.FixedSingle;
            label58.Font = new Font("Segoe UI", 16F);
            label58.Location = new Point(1186, 517);
            label58.Name = "label58";
            label58.Size = new Size(2, 32);
            label58.TabIndex = 97;
            // 
            // label59
            // 
            label59.AutoSize = true;
            label59.BorderStyle = BorderStyle.FixedSingle;
            label59.Font = new Font("Segoe UI", 16F);
            label59.Location = new Point(1186, 481);
            label59.Name = "label59";
            label59.Size = new Size(2, 32);
            label59.TabIndex = 96;
            // 
            // label60
            // 
            label60.AutoSize = true;
            label60.BorderStyle = BorderStyle.FixedSingle;
            label60.Font = new Font("Segoe UI", 16F);
            label60.Location = new Point(1186, 441);
            label60.Name = "label60";
            label60.Size = new Size(2, 32);
            label60.TabIndex = 95;
            // 
            // label61
            // 
            label61.AutoSize = true;
            label61.BorderStyle = BorderStyle.FixedSingle;
            label61.Font = new Font("Segoe UI", 16F);
            label61.Location = new Point(1186, 405);
            label61.Name = "label61";
            label61.Size = new Size(2, 32);
            label61.TabIndex = 94;
            // 
            // label62
            // 
            label62.AutoSize = true;
            label62.BorderStyle = BorderStyle.FixedSingle;
            label62.Font = new Font("Segoe UI", 16F);
            label62.Location = new Point(1186, 367);
            label62.Name = "label62";
            label62.Size = new Size(2, 32);
            label62.TabIndex = 93;
            // 
            // label63
            // 
            label63.AutoSize = true;
            label63.BorderStyle = BorderStyle.FixedSingle;
            label63.Font = new Font("Segoe UI", 16F);
            label63.Location = new Point(1186, 327);
            label63.Name = "label63";
            label63.Size = new Size(2, 32);
            label63.TabIndex = 92;
            // 
            // label64
            // 
            label64.AutoSize = true;
            label64.BorderStyle = BorderStyle.FixedSingle;
            label64.Font = new Font("Segoe UI", 16F);
            label64.Location = new Point(1186, 291);
            label64.Name = "label64";
            label64.Size = new Size(2, 32);
            label64.TabIndex = 91;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1382, 642);
            Controls.Add(label58);
            Controls.Add(label59);
            Controls.Add(label60);
            Controls.Add(label61);
            Controls.Add(label62);
            Controls.Add(label63);
            Controls.Add(label64);
            Controls.Add(label37);
            Controls.Add(label38);
            Controls.Add(label39);
            Controls.Add(label40);
            Controls.Add(label41);
            Controls.Add(label42);
            Controls.Add(label43);
            Controls.Add(label44);
            Controls.Add(label45);
            Controls.Add(label46);
            Controls.Add(label47);
            Controls.Add(label48);
            Controls.Add(label49);
            Controls.Add(label50);
            Controls.Add(label51);
            Controls.Add(label52);
            Controls.Add(label53);
            Controls.Add(label54);
            Controls.Add(label55);
            Controls.Add(label56);
            Controls.Add(label57);
            Controls.Add(label23);
            Controls.Add(label24);
            Controls.Add(label25);
            Controls.Add(label26);
            Controls.Add(label27);
            Controls.Add(label28);
            Controls.Add(label29);
            Controls.Add(label30);
            Controls.Add(label31);
            Controls.Add(label32);
            Controls.Add(label33);
            Controls.Add(label34);
            Controls.Add(label35);
            Controls.Add(label36);
            Controls.Add(label16);
            Controls.Add(label17);
            Controls.Add(label18);
            Controls.Add(label19);
            Controls.Add(label20);
            Controls.Add(label21);
            Controls.Add(label22);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(Bin7);
            Controls.Add(Bin6);
            Controls.Add(Bin5);
            Controls.Add(Bin4);
            Controls.Add(Bin3);
            Controls.Add(Bin2);
            Controls.Add(Bin1);
            Controls.Add(Symb7);
            Controls.Add(Symb6);
            Controls.Add(Symb5);
            Controls.Add(Symb4);
            Controls.Add(Symb3);
            Controls.Add(Symb2);
            Controls.Add(Symb1);
            Controls.Add(pictureBox1);
            Controls.Add(checkBox4);
            Controls.Add(checkBox5);
            Controls.Add(checkBox6);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(Upload_button);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Button Upload_button;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private PictureBox pictureBox1;
        private Label Symb1;
        private Label Symb2;
        private Label Symb3;
        private Label Symb5;
        private Label Symb4;
        private Label Symb7;
        private Label Symb6;
        private Label Bin7;
        private Label Bin6;
        private Label Bin5;
        private Label Bin4;
        private Label Bin3;
        private Label Bin2;
        private Label Bin1;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label25;
        private Label label26;
        private Label label27;
        private Label label28;
        private Label label29;
        private Label label30;
        private Label label31;
        private Label label32;
        private Label label33;
        private Label label34;
        private Label label35;
        private Label label36;
        private Label label37;
        private Label label38;
        private Label label39;
        private Label label40;
        private Label label41;
        private Label label42;
        private Label label43;
        private Label label44;
        private Label label45;
        private Label label46;
        private Label label47;
        private Label label48;
        private Label label49;
        private Label label50;
        private Label label51;
        private Label label52;
        private Label label53;
        private Label label54;
        private Label label55;
        private Label label56;
        private Label label57;
        private Label label58;
        private Label label59;
        private Label label60;
        private Label label61;
        private Label label62;
        private Label label63;
        private Label label64;
    }
}
