using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHCESimonH
{
    public class Ohce
    {
        private readonly ILangue _langue;
        public Ohce(ILangue langue)
        {
            _langue = langue;
        }
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
                stringBuilder.Append(_langue.BienDit);

            return stringBuilder.ToString();
        }
        public string DireBonjour(string input)
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append(_langue.Bonjour + "\n");
            stringBuilder.Append(input);
            return stringBuilder.ToString();
        }

        public string DireAuRevoir(string input)
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append(input + "\n");
            stringBuilder.Append(_langue.AuRevoir);
            return stringBuilder.ToString();
        }
    }
}
