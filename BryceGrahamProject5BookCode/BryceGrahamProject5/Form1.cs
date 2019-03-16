/****************************
 * Form1 Class
 * Bryce Graham
 * CS 2282
 * Beard
 * Allows a user to interact with
 * the book code
 **************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BryceGrahamProject5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Book book;
        CodeBook codeBook;
        Message message;
        SecretMessage secretMessage;

        // Creates a codebook from a book in a file
        private void addBookButton_Click(object sender, EventArgs e)
        {
            book = new Book(bookTextBox.Text.Trim());
            codeBook = new CodeBook(book);
            MessageBox.Show("Codebook created");
            encodeButton.Enabled = true;
            decodeButton.Enabled = true;
        }

        // Encodes a message from a file using the book code
        private void encodeButton_Click(object sender, EventArgs e)
        {
            message = new Message(messageTextBox.Text.Trim());
            richTextBox1.Text = codeBook.encodeMessage(message);
        }

        // Decodes a secret message encoded with the book code
        private void decodeButton_Click(object sender, EventArgs e)
        {
            secretMessage = new SecretMessage(secretMessageTextBox.Text.Trim());
            richTextBox1.Text = codeBook.decodeMessage(secretMessage);
        }
    }
}