namespace login_register
{
    partial class AuthorPage
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
            pictureBox1 = new PictureBox();
            authorNameLabel = new Label();
            label2 = new Label();
            profCover = new PictureBox();
            authorUsernameLabel = new Label();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            cover_label = new Label();
            cover_textBox = new TextBox();
            isbn_label = new Label();
            isbn_textBox = new TextBox();
            price_label = new Label();
            price_textBox = new TextBox();
            author_label = new Label();
            author_textBox = new TextBox();
            category_label = new Label();
            category_textBox = new TextBox();
            title_label = new Label();
            title_textBox = new TextBox();
            panel1 = new Panel();
            richTextBox1 = new RichTextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)profCover).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(16, 211);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // authorNameLabel
            // 
            authorNameLabel.AutoSize = true;
            authorNameLabel.Font = new Font("Candara", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            authorNameLabel.ForeColor = Color.PapayaWhip;
            authorNameLabel.Location = new Point(143, 211);
            authorNameLabel.Name = "authorNameLabel";
            authorNameLabel.Size = new Size(138, 36);
            authorNameLabel.TabIndex = 2;
            authorNameLabel.Text = "Full Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.PapayaWhip;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(73, 60, 52);
            label2.Location = new Point(143, 290);
            label2.Name = "label2";
            label2.Size = new Size(84, 21);
            label2.TabIndex = 4;
            label2.Text = "Author ✔";
            label2.Click += label2_Click;
            // 
            // profCover
            // 
            profCover.Image = Properties.Resources.profCover;
            profCover.Location = new Point(0, 0);
            profCover.Name = "profCover";
            profCover.Size = new Size(1089, 195);
            profCover.SizeMode = PictureBoxSizeMode.StretchImage;
            profCover.TabIndex = 5;
            profCover.TabStop = false;
            // 
            // authorUsernameLabel
            // 
            authorUsernameLabel.AutoSize = true;
            authorUsernameLabel.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            authorUsernameLabel.ForeColor = Color.PapayaWhip;
            authorUsernameLabel.Location = new Point(143, 247);
            authorUsernameLabel.Name = "authorUsernameLabel";
            authorUsernameLabel.Size = new Size(109, 23);
            authorUsernameLabel.TabIndex = 6;
            authorUsernameLabel.Text = "@username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.PapayaWhip;
            label1.Location = new Point(216, 7);
            label1.Name = "label1";
            label1.Size = new Size(318, 36);
            label1.TabIndex = 8;
            label1.Text = "Add a Book in the Library";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(73, 60, 52);
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.6851215F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.3158455F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.6831951F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.3158455F));
            tableLayoutPanel1.Controls.Add(cover_label, 2, 2);
            tableLayoutPanel1.Controls.Add(cover_textBox, 3, 2);
            tableLayoutPanel1.Controls.Add(isbn_label, 0, 2);
            tableLayoutPanel1.Controls.Add(isbn_textBox, 0, 2);
            tableLayoutPanel1.Controls.Add(price_label, 2, 1);
            tableLayoutPanel1.Controls.Add(price_textBox, 3, 1);
            tableLayoutPanel1.Controls.Add(author_label, 0, 1);
            tableLayoutPanel1.Controls.Add(author_textBox, 1, 1);
            tableLayoutPanel1.Controls.Add(category_label, 2, 0);
            tableLayoutPanel1.Controls.Add(category_textBox, 3, 0);
            tableLayoutPanel1.Controls.Add(title_label, 0, 0);
            tableLayoutPanel1.Controls.Add(title_textBox, 1, 0);
            tableLayoutPanel1.Location = new Point(52, 66);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(628, 157);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // cover_label
            // 
            cover_label.Anchor = AnchorStyles.Left;
            cover_label.AutoSize = true;
            cover_label.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cover_label.ForeColor = Color.PapayaWhip;
            cover_label.Location = new Point(316, 119);
            cover_label.Name = "cover_label";
            cover_label.Size = new Size(66, 23);
            cover_label.TabIndex = 11;
            cover_label.Text = "Cover :";
            // 
            // cover_textBox
            // 
            cover_textBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cover_textBox.BackColor = Color.PapayaWhip;
            cover_textBox.Location = new Point(414, 119);
            cover_textBox.Name = "cover_textBox";
            cover_textBox.Size = new Size(211, 23);
            cover_textBox.TabIndex = 10;
            // 
            // isbn_label
            // 
            isbn_label.Anchor = AnchorStyles.Left;
            isbn_label.AutoSize = true;
            isbn_label.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            isbn_label.ForeColor = Color.PapayaWhip;
            isbn_label.Location = new Point(3, 119);
            isbn_label.Name = "isbn_label";
            isbn_label.Size = new Size(58, 23);
            isbn_label.TabIndex = 15;
            isbn_label.Text = "ISBN :";
            // 
            // isbn_textBox
            // 
            isbn_textBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            isbn_textBox.BackColor = Color.PapayaWhip;
            isbn_textBox.Location = new Point(101, 119);
            isbn_textBox.Name = "isbn_textBox";
            isbn_textBox.Size = new Size(209, 23);
            isbn_textBox.TabIndex = 14;
            // 
            // price_label
            // 
            price_label.Anchor = AnchorStyles.Left;
            price_label.AutoSize = true;
            price_label.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            price_label.ForeColor = Color.PapayaWhip;
            price_label.Location = new Point(316, 66);
            price_label.Name = "price_label";
            price_label.Size = new Size(60, 23);
            price_label.TabIndex = 13;
            price_label.Text = "Price :";
            // 
            // price_textBox
            // 
            price_textBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            price_textBox.BackColor = Color.PapayaWhip;
            price_textBox.Location = new Point(414, 66);
            price_textBox.Name = "price_textBox";
            price_textBox.Size = new Size(211, 23);
            price_textBox.TabIndex = 12;
            // 
            // author_label
            // 
            author_label.Anchor = AnchorStyles.Left;
            author_label.AutoSize = true;
            author_label.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            author_label.ForeColor = Color.PapayaWhip;
            author_label.Location = new Point(3, 66);
            author_label.Name = "author_label";
            author_label.Size = new Size(76, 23);
            author_label.TabIndex = 11;
            author_label.Text = "Author :";
            // 
            // author_textBox
            // 
            author_textBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            author_textBox.BackColor = Color.PapayaWhip;
            author_textBox.Location = new Point(101, 66);
            author_textBox.Name = "author_textBox";
            author_textBox.Size = new Size(209, 23);
            author_textBox.TabIndex = 10;
            // 
            // category_label
            // 
            category_label.Anchor = AnchorStyles.Left;
            category_label.AutoSize = true;
            category_label.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            category_label.ForeColor = Color.PapayaWhip;
            category_label.Location = new Point(316, 14);
            category_label.Name = "category_label";
            category_label.Size = new Size(92, 23);
            category_label.TabIndex = 9;
            category_label.Text = "Category :";
            // 
            // category_textBox
            // 
            category_textBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            category_textBox.BackColor = Color.PapayaWhip;
            category_textBox.Location = new Point(414, 14);
            category_textBox.Name = "category_textBox";
            category_textBox.Size = new Size(211, 23);
            category_textBox.TabIndex = 8;
            // 
            // title_label
            // 
            title_label.Anchor = AnchorStyles.Left;
            title_label.AutoSize = true;
            title_label.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            title_label.ForeColor = Color.PapayaWhip;
            title_label.Location = new Point(3, 14);
            title_label.Name = "title_label";
            title_label.Size = new Size(54, 23);
            title_label.TabIndex = 7;
            title_label.Text = "Title :";
            // 
            // title_textBox
            // 
            title_textBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            title_textBox.BackColor = Color.PapayaWhip;
            title_textBox.Location = new Point(101, 14);
            title_textBox.Name = "title_textBox";
            title_textBox.Size = new Size(209, 23);
            title_textBox.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(73, 60, 52);
            panel1.Controls.Add(richTextBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Location = new Point(335, 192);
            panel1.Name = "panel1";
            panel1.Size = new Size(762, 418);
            panel1.TabIndex = 11;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.PapayaWhip;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Location = new Point(153, 239);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(524, 152);
            richTextBox1.TabIndex = 17;
            richTextBox1.Text = "";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.PapayaWhip;
            label3.Location = new Point(55, 300);
            label3.Name = "label3";
            label3.Size = new Size(52, 23);
            label3.TabIndex = 16;
            label3.Text = "Plot :";
            // 
            // AuthorPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(1089, 605);
            Controls.Add(profCover);
            Controls.Add(panel1);
            Controls.Add(authorUsernameLabel);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(authorNameLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AuthorPage";
            Text = "AuthorPage";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)profCover).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label authorNameLabel;
        private Label label2;
        private PictureBox profCover;
        private Label authorUsernameLabel;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox title_textBox;
        private Label cover_label;
        private TextBox cover_textBox;
        private Label isbn_label;
        private TextBox isbn_textBox;
        private Label price_label;
        private TextBox price_textBox;
        private Label author_label;
        private TextBox author_textBox;
        private Label category_label;
        private TextBox category_textBox;
        private Label title_label;
        private Panel panel1;
        private RichTextBox richTextBox1;
        private Label label3;
    }
}