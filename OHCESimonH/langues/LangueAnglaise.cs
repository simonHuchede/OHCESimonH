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
        public string DireBonjour(PeriodeJournee période)
        {
            switch (période)
            {
                case PeriodeJournee.Defaut:
                    return Expressions.English.Hello;

                case PeriodeJournee.Matin:
                    return Expressions.English.GoodMorning;

                case PeriodeJournee.AprèsMidi:
                    return Expressions.English.GoodAfternoon;

                case PeriodeJournee.Soir:
                    return Expressions.English.GoodEvening;

                case PeriodeJournee.Nuit:
                    return Expressions.English.GoodNight;

                default: return Expressions.English.Hello;
            }
        }


        /// <inheritdoc />
        public string DireAuRevoir(PeriodeJournee période)
        {
            switch (période)
            {
                case PeriodeJournee.Defaut:
                    return Expressions.English.GoodBye;

                case PeriodeJournee.Matin:
                    return Expressions.English.HaveAGoodDay;

                case PeriodeJournee.AprèsMidi:
                    return Expressions.English.HaveAGoodAfternoon;

                case PeriodeJournee.Soir:
                    return Expressions.English.HaveAGoodEvening;

                case PeriodeJournee.Nuit:
                    return Expressions.English.HaveAGoodNight;

                default: return Expressions.English.GoodBye;
            }
        }
    }
}
