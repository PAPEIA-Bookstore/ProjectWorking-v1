namespace login_register
{
    partial class TransactionPage
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
            paymentButton = new Button();
            label1 = new Label();
            label2 = new Label();
            TopLabel = new Label();
            label4 = new Label();
            label5 = new Label();
            label9 = new Label();
            panel1 = new Panel();
            titleTextBox = new TextBox();
            authorTextBox = new TextBox();
            isbnTextBox = new TextBox();
            priceTextBox = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label3 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // paymentButton
            // 
            paymentButton.BackColor = Color.Tan;
            paymentButton.FlatStyle = FlatStyle.Flat;
            paymentButton.Font = new Font("Candara", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            paymentButton.ForeColor = Color.PapayaWhip;
            paymentButton.Location = new Point(772, 482);
            paymentButton.Name = "paymentButton";
            paymentButton.Size = new Size(215, 40);
            paymentButton.TabIndex = 0;
            paymentButton.Text = "Complete Payment";
            paymentButton.UseVisualStyleBackColor = false;
            paymentButton.Click += Payment_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara", 14.25F, FontStyle.Bold);
            label1.ForeColor = Color.PapayaWhip;
            label1.Location = new Point(14, 9);
            label1.Name = "label1";
            label1.Size = new Size(47, 23);
            label1.TabIndex = 1;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Candara", 14.25F, FontStyle.Bold);
            label2.ForeColor = Color.PapayaWhip;
            label2.Location = new Point(341, 9);
            label2.Name = "label2";
            label2.Size = new Size(67, 23);
            label2.TabIndex = 2;
            label2.Text = "Author";
            // 
            // TopLabel
            // 
            TopLabel.AutoSize = true;
            TopLabel.BackColor = Color.PapayaWhip;
            TopLabel.Font = new Font("Candara", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TopLabel.ForeColor = Color.FromArgb(73, 60, 52);
            TopLabel.Location = new Point(60, 34);
            TopLabel.Name = "TopLabel";
            TopLabel.Size = new Size(159, 36);
            TopLabel.TabIndex = 3;
            TopLabel.Text = "Transaction";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Candara", 14.25F, FontStyle.Bold);
            label4.ForeColor = Color.PapayaWhip;
            label4.Location = new Point(583, 9);
            label4.Name = "label4";
            label4.Size = new Size(49, 23);
            label4.TabIndex = 4;
            label4.Text = "ISBN";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Candara", 14.25F, FontStyle.Bold);
            label5.ForeColor = Color.PapayaWhip;
            label5.Location = new Point(819, 9);
            label5.Name = "label5";
            label5.Size = new Size(51, 23);
            label5.TabIndex = 5;
            label5.Text = "Price";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Candara", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(73, 60, 52);
            label9.Location = new Point(60, 210);
            label9.Name = "label9";
            label9.Size = new Size(112, 23);
            label9.TabIndex = 10;
            label9.Text = "Card Details:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Tan;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(60, 103);
            panel1.Name = "panel1";
            panel1.Size = new Size(927, 41);
            panel1.TabIndex = 12;
            // 
            // titleTextBox
            // 
            titleTextBox.BackColor = Color.PapayaWhip;
            titleTextBox.Font = new Font("Candara", 12F);
            titleTextBox.Location = new Point(60, 140);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(342, 27);
            titleTextBox.TabIndex = 13;
            // 
            // authorTextBox
            // 
            authorTextBox.BackColor = Color.PapayaWhip;
            authorTextBox.Font = new Font("Candara", 12F);
            authorTextBox.Location = new Point(401, 140);
            authorTextBox.Name = "authorTextBox";
            authorTextBox.Size = new Size(244, 27);
            authorTextBox.TabIndex = 14;
            // 
            // isbnTextBox
            // 
            isbnTextBox.BackColor = Color.PapayaWhip;
            isbnTextBox.Font = new Font("Candara", 12F);
            isbnTextBox.Location = new Point(643, 140);
            isbnTextBox.Name = "isbnTextBox";
            isbnTextBox.Size = new Size(239, 27);
            isbnTextBox.TabIndex = 15;
            // 
            // priceTextBox
            // 
            priceTextBox.BackColor = Color.PapayaWhip;
            priceTextBox.Font = new Font("Candara", 12F);
            priceTextBox.Location = new Point(879, 140);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(108, 27);
            priceTextBox.TabIndex = 16;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.PapayaWhip;
            textBox1.Font = new Font("Candara", 12F);
            textBox1.Location = new Point(202, 240);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(332, 27);
            textBox1.TabIndex = 17;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.PapayaWhip;
            textBox2.Font = new Font("Candara", 12F);
            textBox2.Location = new Point(202, 269);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(332, 27);
            textBox2.TabIndex = 18;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.PapayaWhip;
            textBox3.Font = new Font("Candara", 12F);
            textBox3.Location = new Point(202, 298);
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.Size = new Size(89, 27);
            textBox3.TabIndex = 19;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.PapayaWhip;
            textBox4.Font = new Font("Candara", 12F);
            textBox4.Location = new Point(434, 298);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 27);
            textBox4.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Candara", 12F);
            label3.Location = new Point(96, 244);
            label3.Name = "label3";
            label3.Size = new Size(100, 19);
            label3.TabIndex = 21;
            label3.Text = "Card Number";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Candara", 12F);
            label6.Location = new Point(106, 272);
            label6.Name = "label6";
            label6.Size = new Size(90, 19);
            label6.TabIndex = 22;
            label6.Text = "Card Owner";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Candara", 12F);
            label7.Location = new Point(119, 302);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.No;
            label7.Size = new Size(77, 19);
            label7.TabIndex = 23;
            label7.Text = "CVV Digits";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Candara", 12F);
            label8.Location = new Point(315, 302);
            label8.Name = "label8";
            label8.Size = new Size(113, 19);
            label8.TabIndex = 24;
            label8.Text = "Expiration Date";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Candara", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(73, 60, 52);
            label11.Location = new Point(62, 356);
            label11.Name = "label11";
            label11.Size = new Size(80, 23);
            label11.TabIndex = 25;
            label11.Text = "Address:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Candara", 12F);
            label12.Location = new Point(106, 450);
            label12.Name = "label12";
            label12.RightToLeft = RightToLeft.No;
            label12.Size = new Size(90, 19);
            label12.TabIndex = 32;
            label12.Text = "Postal Code";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Candara", 12F);
            label13.Location = new Point(162, 420);
            label13.Name = "label13";
            label13.Size = new Size(34, 19);
            label13.TabIndex = 31;
            label13.Text = "City";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Candara", 12F);
            label14.Location = new Point(88, 391);
            label14.Name = "label14";
            label14.Size = new Size(108, 19);
            label14.TabIndex = 30;
            label14.Text = "Road, Number";
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.PapayaWhip;
            textBox6.Font = new Font("Candara", 12F);
            textBox6.Location = new Point(202, 446);
            textBox6.Name = "textBox6";
            textBox6.PasswordChar = '*';
            textBox6.Size = new Size(89, 27);
            textBox6.TabIndex = 28;
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.PapayaWhip;
            textBox7.Font = new Font("Candara", 12F);
            textBox7.Location = new Point(202, 417);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(332, 27);
            textBox7.TabIndex = 27;
            // 
            // textBox8
            // 
            textBox8.BackColor = Color.PapayaWhip;
            textBox8.Font = new Font("Candara", 12F);
            textBox8.Location = new Point(202, 388);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(332, 27);
            textBox8.TabIndex = 26;
            // 
            // TransactionPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(1073, 566);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(textBox6);
            Controls.Add(textBox7);
            Controls.Add(textBox8);
            Controls.Add(label11);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(priceTextBox);
            Controls.Add(isbnTextBox);
            Controls.Add(authorTextBox);
            Controls.Add(titleTextBox);
            Controls.Add(panel1);
            Controls.Add(label9);
            Controls.Add(TopLabel);
            Controls.Add(paymentButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TransactionPage";
            Text = "TransactionPage";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button paymentButton;
        private Label label1;
        private Label label2;
        private Label TopLabel;
        private Label label4;
        private Label label5;
        private Label label9;
        private Panel panel1;
        private TextBox titleTextBox;
        private TextBox authorTextBox;
        private TextBox isbnTextBox;
        private TextBox priceTextBox;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label3;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
    }
}