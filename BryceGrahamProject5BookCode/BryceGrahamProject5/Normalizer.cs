/****************************
 * Normalizer Class
 * Bryce Graham
 * CS 2282
 * Beard
 * Converts a Book into all
 * lowercase without punctuation
 **************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BryceGrahamProject5
{
    class Normalizer
    {
        public Normalizer()
        { }

        // Replaces newlines with spaces, uppercase with lowercase and removes punctuation from a book
        public string normalize(TextFile rawText)
        { 
            StringBuilder builder = new StringBuilder();
            Regex endline = new Regex(@"\t|\n|\r");
            rawText.MyText = endline.Replace(rawText.MyText, " ");
            for (int i = 0; i < rawText.MyText.Length; i++ )
            {
                if ((char.ToLower(rawText.MyText[i]) <= 'z' && char.ToLower(rawText.MyText[i]) >= 'a') || rawText.MyText[i] == ' ')
                    builder.Append(char.ToLower(rawText.MyText[i]));
            }
                return builder.ToString();
        }

        // Puts the secret message into a standardized format
        public string normalizeSecretMessage(TextFile rawText)
        {
            StringBuilder builder = new StringBuilder();
            Regex endline = new Regex(@"\t|\n|\r");
            rawText.MyText = endline.Replace(rawText.MyText, " ");
            for (int i = 0; i < rawText.MyText.Length; i++)
            {
                if (char.IsDigit(rawText.MyText[i]) || rawText.MyText[i] == '-' || rawText.MyText[i] == ' ')
                    builder.Append(rawText.MyText[i]);
            }
            return builder.ToString();
        }
    }
}
