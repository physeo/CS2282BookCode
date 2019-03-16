/****************************
 * Book Class
 * Bryce Graham
 * CS 2282
 * Represents a special message
 * that has been encoded by the
 * book code.
 **************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BryceGrahamProject5
{
    class SecretMessage : Message
    {
        public SecretMessage()
        { }

        public SecretMessage(string fileName)
        {
            normalizer = new Normalizer();
            myText = readFile(fileName);
            myText = normalizer.normalizeSecretMessage(this);
            words = new List<string>();
            addWords();
        }
    }
}
