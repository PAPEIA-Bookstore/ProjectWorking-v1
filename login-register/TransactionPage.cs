﻿using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_register
{
    public partial class TransactionPage : Form
    {
        private Book book;
        List<TextBox> paymentFields;
        List<TextBox> addressFields;

        public TransactionPage(Book book)
        {
            InitializeComponent();
            this.book = book;
            titleTextBox.Text = book.title;
            authorTextBox.Text = book.author;
            isbnTextBox.Text = book.isbn;
            priceTextBox.Text = book.price.ToString() + "€";


        }

        private void Payment_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            string price = book.price.ToString(CultureInfo.InvariantCulture);
            NpgsqlConnection connection = DBHandler.OpenConnection();
            NpgsqlCommand command = DBHandler.GetCommand(connection);
            command.CommandText = "INSERT INTO transactions(username,time,price,isbn) VALUES('" + User.GetUsername() + "','" + time.ToString() + "'," + price + ",'" + book.isbn + "');";
            command.ExecuteNonQuery();
            MessageBox.Show("Transaction Successful!","Thank you for choosing us", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DBHandler.CloseConnection(connection,command);
        }
    }
}
