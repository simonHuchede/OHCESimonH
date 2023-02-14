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
        public string DireBonjour(PeriodeJournee période)
        {
            switch (période)
            {
                case PeriodeJournee.Defaut:
                    return Expressions.Français.Bonjour;

                case PeriodeJournee.Matin:
                    return Expressions.Français.Bonjour;

                case PeriodeJournee.AprèsMidi:
                    return Expressions.Français.BonAprèsMidi;

                case PeriodeJournee.Soir:
                    return Expressions.Français.Bonsoir;

                case PeriodeJournee.Nuit:
                    return Expressions.Français.BonneNuit;

                default: return Expressions.Français.Bonjour;
            }
        }

        /// <inheritdoc />
        public string DireAuRevoir(PeriodeJournee période)
        {
            switch (période)
            {
                case PeriodeJournee.Defaut:
                    return Expressions.Français.AuRevoir;

                case PeriodeJournee.Matin:
                    return Expressions.Français.BonneJournee;

                case PeriodeJournee.AprèsMidi:
                    return Expressions.Français.BonneApresMidi;

                case PeriodeJournee.Soir:
                    return Expressions.Français.BonneSoiree;

                case PeriodeJournee.Nuit:
                    return Expressions.Français.BonneNuit;

                default: return Expressions.Français.AuRevoir;
            }
        }
    }
}
