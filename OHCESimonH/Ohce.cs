using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHCESimonH
{
    public class Ohce
    {
        public Ohce()
        {
        }

        public string Miroir(string input)
        {

            StringBuilder stringBuilder = new StringBuilder();
            string reversed = new string(
                input.Reverse().ToArray()
            );
            stringBuilder.Append(reversed);

            return stringBuilder.ToString();
        }

        public string Palindrome(string input)
        {
            StringBuilder stringBuilder = new StringBuilder();
            string reversed = new string(
                input.Reverse().ToArray()
            );
            stringBuilder.Append(reversed + " \n");
            if (reversed.Equals(input))
                stringBuilder.Append("Bien dit");

            return stringBuilder.ToString();
        }
    }
}
