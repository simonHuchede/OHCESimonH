using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHCESimonH.langues
{
    public class LangueFrancaise : ILangue
    {

        /// <inheritdoc />
        public string BienDit => Expressions.Français.BienDit;

        /// <inheritdoc />
        public string Bonjour => Expressions.Français.Bonjour;

        /// <inheritdoc />
        public string AuRevoir => Expressions.Français.AuRevoir;
    }
}
