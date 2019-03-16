/****************************
 * Encoder Class
 * Bryce Graham
 * CS 2282
 * Encodes a message into book code
 **************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BryceGrahamProject5
{
    class Encoder
    {
        CodeBook code;
        public Encoder()
        {
            code = new CodeBook();
        }

        public Encoder(CodeBook _code)
        {
            code = _code;
        }

        // Turns a message into a string of index numbers
        // of words in a list from a code book
        public string encodeMessage(Message message)
        {
            StringBuilder encodedMessage = new StringBuilder();    
            List<int> indexList = new List<int>();
            Random rand = new Random();
            int randIndex;
            int i = 0;
            foreach (string word in message.Words)
            {
                if (code.TheCode.TryGetValue(message.Words[i], out indexList))
                {
                    randIndex = rand.Next(indexList.Count);
                    encodedMessage.Append(indexList[randIndex].ToString() + " ");
                }
                else
                    encodedMessage.Append("-1 ");
                i++;
            }
            return encodedMessage.ToString();
        }
    }
}
