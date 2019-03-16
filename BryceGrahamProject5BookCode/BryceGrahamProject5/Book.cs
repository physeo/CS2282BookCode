/****************************
 * Book Class
 * Bryce Graham
 * CS 2282
 * Represents a book
 **************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BryceGrahamProject5
{
    class Book : TextFile
    {
        public Book()
            : base()
        {
            
        }
        public Book(string fileName)
            :base(fileName)
        {

        }
    }
}
