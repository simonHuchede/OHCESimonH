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
        private readonly PeriodeJournee _périodeJournée;
        public Ohce(ILangue langue)
        {
            _langue = langue;
        }
        public Ohce(ILangue langue,PeriodeJournee periodeJournee)
        {
            _langue = langue;
            _périodeJournée = periodeJournee;
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
            stringBuilder.Append(_langue.DireBonjour(_périodeJournée) + "\n");
            stringBuilder.Append(input);
            return stringBuilder.ToString();
        }

        public string DireAuRevoir(string input)
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append(input + "\n");
            stringBuilder.Append(_langue.DireAuRevoir(_périodeJournée));
            return stringBuilder.ToString();
        }
    }
}
