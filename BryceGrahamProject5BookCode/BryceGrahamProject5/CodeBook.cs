/****************************
 * CodeBook Class
 * Bryce Graham
 * CS 2282
 * Beard
 * Stores the keys and values
 * for the book code
 **************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BryceGrahamProject5
{
    class CodeBook
    {
        Encoder encoder;
        Decoder decoder;
        Dictionary<string, List<int>> theCode;

        public CodeBook()
        {
            encoder = new Encoder();
            decoder = new Decoder();
            theCode = new Dictionary<string, List<int>>();
        }
        public CodeBook(Book book)
        {
            theCode = new Dictionary<string, List<int>>();
            createCodeDictionary(book);
            encoder = new Encoder(this);
            decoder = new Decoder(book);
        }

        public Dictionary<string, List<int>> TheCode
        {
            get { return theCode; }
        }

        // creates a key value pair between each word in the book's word list
        // and a list of ints
        public void createCodeDictionary(Book book)
        {
            List<int> wordIndexes = new List<int>();
            foreach(string word in book.Words)
            {
                if (!theCode.ContainsKey(word))
                {
                    wordIndexes = findAllIndexesOf(word, book.Words);
                    theCode.Add(word, wordIndexes);
                }
            }
        }

        // Stores all occuring indexes of a particular word in a list in a list of integers
        public List<int> findAllIndexesOf(string s, List<string> sList)
        {
            List<int> wordIndexes = new List<int>();
            int currentIndex = 0;
            foreach(string word in sList)
            {
                if (word == s)
                    wordIndexes.Add(currentIndex);
                currentIndex++;
            }
            return wordIndexes;
        }

        public string encodeMessage(Message _message)
        {
            return encoder.encodeMessage(_message);
        }

        public string decodeMessage(SecretMessage _secretMessage)
        {
            return decoder.decodeMessage(_secretMessage);
        }
    }
}
