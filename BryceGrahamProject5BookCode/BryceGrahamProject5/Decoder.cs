/****************************
 * Decoder Class
 * Bryce Graham
 * CS 2282
 * Beard
 * Decodes a message encoded in
 * the book code
 **************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BryceGrahamProject5
{
    class Decoder
    {
        Book book;

        public Decoder()
        {
            book = new Book();
        }

        public Decoder(Book _book)
        {
            book = _book;
        }

        // Decodes a secret message encoded with a book code
        public string decodeMessage(Message encodedMessage)
        {
            StringBuilder decodedMessage = new StringBuilder();
            int index;
            foreach(string indexNumber in encodedMessage.Words)
            {
                if (int.TryParse(indexNumber, out index) && index != -1)
                    decodedMessage.Append(book.Words[index] + " ");
                else decodedMessage.Append("-1 ");
            }
            return decodedMessage.ToString();
        }
    }
}
