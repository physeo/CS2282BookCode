/****************************
 * TextFile Class
 * Bryce Graham
 * CS 2282
 * Beard
 * Reads in a file, stores and
 * normalizes it for use.
 * *Uses readFile code from DictionaryAndTextFileSampler
 **************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace BryceGrahamProject5
{
    class TextFile
    {
        protected Normalizer normalizer;
        protected string myText;
        protected List<string> words;

        public TextFile()
        {
            normalizer = new Normalizer();
            myText = "";
            words = new List<string>();
        }
        public TextFile(string fileName)
        {
            normalizer = new Normalizer();
            myText = readFile(fileName);
            myText = normalizer.normalize(this);
            words = new List<string>();
            addWords();
        }

        public string MyText
        {
            get { return myText; }
            set { myText = value; }
        }

        public List<string> Words
        {
            get { return words; }
        }

        // Reads a text file into a string
        protected string readFile(string filename)
        {
            Int32 _bufferSize;
            StringBuilder stringBuilder = new StringBuilder();
            FileStream fileStream;
            try
            {
                fileStream = new FileStream(filename, FileMode.Open, FileAccess.Read);
            }
            catch(FileNotFoundException ex)
            {
                throw ex;
            }

            // set buffer size to file length
            _bufferSize = Convert.ToInt32(fileStream.Length);
            using (StreamReader streamReader = new StreamReader(fileStream))
            {
                char[] fileContents = new char[_bufferSize];
                int charsRead = streamReader.Read(fileContents, 0, _bufferSize);
                if (charsRead == 0)
                    throw new Exception("File is 0 bytes");
                while (charsRead > 0)
                {
                    stringBuilder.Append(fileContents);
                    charsRead = streamReader.Read(fileContents, 0, _bufferSize);
                }
            }

            fileStream.Close();
            return stringBuilder.ToString();
        }

        // Adds individual words to a list
        protected void addWords()
        {
            char[] delimiters = new char[] { ' ', '\r', '\n' };
            string[] wordArray = myText.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            words = wordArray.ToList();
        }
    }
}
