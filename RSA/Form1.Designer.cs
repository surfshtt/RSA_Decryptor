namespace RSA
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label3 = new Label();
            Encrypt = new Button();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            textBox7 = new TextBox();
            label5 = new Label();
            textBox8 = new TextBox();
            label8 = new Label();
            Decrypt = new Button();
            textBox9 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 29F);
            label1.Location = new Point(44, 9);
            label1.Name = "label1";
            label1.Size = new Size(44, 52);
            label1.TabIndex = 0;
            label1.Text = "P";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 29F);
            label2.Location = new Point(192, 9);
            label2.Name = "label2";
            label2.Size = new Size(51, 52);
            label2.TabIndex = 1;
            label2.Text = "Q";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 25F);
            textBox1.Location = new Point(22, 64);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(105, 52);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 25F);
            textBox2.Location = new Point(164, 64);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(105, 52);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 25F);
            textBox3.Location = new Point(22, 211);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(270, 52);
            textBox3.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 29F);
            label3.Location = new Point(44, 145);
            label3.Name = "label3";
            label3.Size = new Size(233, 52);
            label3.TabIndex = 5;
            label3.Text = "Сообщение";
            // 
            // Encrypt
            // 
            Encrypt.BackColor = Color.LightGoldenrodYellow;
            Encrypt.Font = new Font("Segoe UI", 29F);
            Encrypt.Location = new Point(10, 354);
            Encrypt.Name = "Encrypt";
            Encrypt.Size = new Size(387, 76);
            Encrypt.TabIndex = 6;
            Encrypt.Text = "Зашифровать";
            Encrypt.UseVisualStyleBackColor = false;
            Encrypt.Click += Encrypt_Click;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 25F);
            textBox4.Location = new Point(10, 296);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(387, 52);
            textBox4.TabIndex = 7;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 25F);
            textBox5.Location = new Point(695, 77);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(105, 52);
            textBox5.TabIndex = 12;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 25F);
            textBox6.Location = new Point(530, 77);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(105, 52);
            textBox6.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 29F);
            label7.Location = new Point(723, 22);
            label7.Name = "label7";
            label7.Size = new Size(42, 52);
            label7.TabIndex = 10;
            label7.Text = "e";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 29F);
            label6.Location = new Point(552, 22);
            label6.Name = "label6";
            label6.Size = new Size(56, 52);
            label6.TabIndex = 9;
            label6.Text = "fn";
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Segoe UI", 25F);
            textBox7.Location = new Point(695, 211);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(105, 52);
            textBox7.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 29F);
            label5.Location = new Point(723, 156);
            label5.Name = "label5";
            label5.Size = new Size(44, 52);
            label5.TabIndex = 13;
            label5.Text = "n";
            // 
            // textBox8
            // 
            textBox8.Font = new Font("Segoe UI", 25F);
            textBox8.Location = new Point(530, 211);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(105, 52);
            textBox8.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 29F);
            label8.Location = new Point(552, 156);
            label8.Name = "label8";
            label8.Size = new Size(45, 52);
            label8.TabIndex = 15;
            label8.Text = "d";
            // 
            // Decrypt
            // 
            Decrypt.BackColor = Color.Coral;
            Decrypt.Font = new Font("Segoe UI", 29F);
            Decrypt.Location = new Point(413, 354);
            Decrypt.Name = "Decrypt";
            Decrypt.Size = new Size(387, 76);
            Decrypt.TabIndex = 17;
            Decrypt.Text = "Расшифровать";
            Decrypt.UseVisualStyleBackColor = false;
            Decrypt.Click += Decrypt_Click;
            // 
            // textBox9
            // 
            textBox9.Font = new Font("Segoe UI", 25F);
            textBox9.Location = new Point(413, 296);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(387, 52);
            textBox9.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 436);
            Controls.Add(textBox9);
            Controls.Add(Decrypt);
            Controls.Add(textBox8);
            Controls.Add(label8);
            Controls.Add(textBox7);
            Controls.Add(label5);
            Controls.Add(textBox5);
            Controls.Add(textBox6);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(Encrypt);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label3;
        private Button Encrypt;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label7;
        private Label label6;
        private TextBox textBox7;
        private Label label5;
        private TextBox textBox8;
        private Label label8;
        private Button Decrypt;
        private TextBox textBox9;
    }
}
