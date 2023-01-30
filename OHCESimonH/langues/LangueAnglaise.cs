using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHCESimonH.langues
{
    public class LangueAnglaise : ILangue
    {   /// <inheritdoc />
        public string BienDit => Expressions.English.WellSaid;
        /// <inheritdoc />
        public string Bonjour => Expressions.English.Hello;

        /// <inheritdoc />
        public string AuRevoir => Expressions.English.GoodBye;
    }
}
