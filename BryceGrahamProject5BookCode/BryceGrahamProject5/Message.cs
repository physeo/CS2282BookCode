/****************************
 * Book Class
 * Bryce Graham
 * CS 2282
 * Represents a message
 **************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BryceGrahamProject5
{
    class Message : TextFile
    {
        public Message()
            : base()
        {
            
        }
        public Message(string fileName)
            :base(fileName)
        {

        }
    }
}
