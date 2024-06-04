using login_register.Properties;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_register
{
    public partial class BookPage : Form
    {
        private ContainerForm containerForm;
        private Book book;
        private int stars;

        public BookPage(Book book, ContainerForm containerForm)
        {
            InitializeComponent();
            this.book = book;
            this.containerForm = containerForm;
            stars = 0;
            coverPictureBox.Load(book.cover);
            bookTitle.Text = book.title;
            authorLabel.Text = "by " + book.author;
            categoryLabel.Text = "Category: " + book.category;
            plotText.Text = book.plot;
            isbnLabel.Text = "ISBN: " + book.isbn;
            buyButton.Text = "Buy: " + book.price.ToString() + "€";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void star1_Click(object sender, EventArgs e)
        {
            star1.Image = Resources.star_filled;
            star2.Image = Resources.star_empty;
            star3.Image = Resources.star_empty;
            star4.Image = Resources.star_empty;
            star5.Image = Resources.star_empty;
            stars = 1;
        }

        private void star2_Click(object sender, EventArgs e)
        {
            star1.Image = Resources.star_filled;
            star2.Image = Resources.star_filled;
            star3.Image = Resources.star_empty;
            star4.Image = Resources.star_empty;
            star5.Image = Resources.star_empty;
            stars = 2;
        }

        private void star3_Click(object sender, EventArgs e)
        {
            star1.Image = Resources.star_filled;
            star2.Image = Resources.star_filled;
            star3.Image = Resources.star_filled;
            star4.Image = Resources.star_empty;
            star5.Image = Resources.star_empty;
            stars = 3;
        }

        private void star4_Click(object sender, EventArgs e)
        {
            star1.Image = Resources.star_filled;
            star2.Image = Resources.star_filled;
            star3.Image = Resources.star_filled;
            star4.Image = Resources.star_filled;
            star5.Image = Resources.star_empty;
            stars = 4;
        }

        private void star5_Click(object sender, EventArgs e)
        {
            star1.Image = Resources.star_filled;
            star2.Image = Resources.star_filled;
            star3.Image = Resources.star_filled;
            star4.Image = Resources.star_filled;
            star5.Image = Resources.star_filled;
            stars = 5;
        }

        private void postReviewButton_Click(object sender, EventArgs e)
        {
            string text = reviewText.Text;
            DateTime time = DateTime.Now;
            string isbn = book.isbn;    //get isbn from book here
            NpgsqlConnection connection = DBHandler.OpenConnection();
            NpgsqlCommand command = DBHandler.GetCommand(connection);
            command.CommandText = "INSERT INTO REVIEWS(username, isbn, text, stars, time) VALUES('" + User.GetUsername() + "', '" + isbn + "', '" + text + "', " + stars + ", '" + time.ToString() + "');";
            command.ExecuteNonQuery();
            MessageBox.Show("You review has been posted!", "Thank you", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DBHandler.CloseConnection(connection, command);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void forumButton_Click(object sender, EventArgs e)
        {
            Forum forum = new Forum(this.book);
            this.containerForm.LoadForm(forum);
            this.containerForm.Show();
            this.Close();
        }
    }
}
