using OHCESimonH;
using OHCESimonH.langues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace OHCE.Test.xUnit
{
    public class LanguesTest
    {
        [Theory]
        [InlineData(PeriodeJournee.Soir, Expressions.Français.Bonsoir)]
        [InlineData(PeriodeJournee.Matin, Expressions.Français.Bonjour)]
        [InlineData(PeriodeJournee.AprèsMidi, Expressions.Français.BonAprèsMidi)]
        [InlineData(PeriodeJournee.Nuit, Expressions.Français.BonneNuit)]
        [InlineData(PeriodeJournee.Defaut, Expressions.Français.Bonjour)]
        public void DireBonjourTest(PeriodeJournee période, string salutationAttendue)
        {
            // ETANT DONNE la langue française
            // ET une période de la journée <période>
            var langue = new LangueFrancaise();

            // QUAND je dis bonjour
            var salutation = langue.DireBonjour(période);

            // ALORS on me répond <salutationAttendue>
            Assert.Equal(salutationAttendue, salutation);
        }

        [Theory]
        [InlineData(PeriodeJournee.Soir, Expressions.English.GoodEvening)]
        [InlineData(PeriodeJournee.Matin, Expressions.English.GoodMorning)]
        [InlineData(PeriodeJournee.AprèsMidi, Expressions.English.GoodAfternoon)]
        [InlineData(PeriodeJournee.Nuit, Expressions.English.GoodNight)]
        [InlineData(PeriodeJournee.Defaut, Expressions.English.Hello)]
        public void SayHelloTest(PeriodeJournee période, string salutationAttendue)
        {
            // ETANT DONNE la langue française
            // ET une période de la journée <période>
            var langue = new LangueAnglaise();

            // QUAND je dis bonjour
            var salutation = langue.DireBonjour(période);

            // ALORS on me répond <salutationAttendue>
            Assert.Equal(salutationAttendue, salutation);
        }

        [Theory]
        [InlineData(PeriodeJournee.Soir, Expressions.Français.BonneSoiree)]
        [InlineData(PeriodeJournee.Matin, Expressions.Français.BonneJournee)]
        [InlineData(PeriodeJournee.AprèsMidi, Expressions.Français.BonneApresMidi)]
        [InlineData(PeriodeJournee.Nuit, Expressions.Français.BonneNuit)]
        [InlineData(PeriodeJournee.Defaut, Expressions.Français.AuRevoir)]
        public void DireAureoirTest(PeriodeJournee période, string salutationAttendue)
        {
            // ETANT DONNE la langue française
            // ET une période de la journée <période>
            var langue = new LangueFrancaise();

            // QUAND je dis bonjour
            var salutation = langue.DireAuRevoir(période);

            // ALORS on me répond <salutationAttendue>
            Assert.Equal(salutationAttendue, salutation);
        }

        [Theory]
        [InlineData(PeriodeJournee.Soir, Expressions.English.HaveAGoodEvening)]
        [InlineData(PeriodeJournee.Matin, Expressions.English.HaveAGoodDay)]
        [InlineData(PeriodeJournee.AprèsMidi, Expressions.English.HaveAGoodAfternoon)]
        [InlineData(PeriodeJournee.Nuit, Expressions.English.HaveAGoodNight)]
        [InlineData(PeriodeJournee.Defaut, Expressions.English.GoodBye)]
        public void SayGoodbyeTest(PeriodeJournee période, string salutationAttendue)
        {
            // ETANT DONNE la langue française
            // ET une période de la journée <période>
            var langue = new LangueAnglaise();

            // QUAND je dis bonjour
            var salutation = langue.DireAuRevoir(période);

            // ALORS on me répond <salutationAttendue>
            Assert.Equal(salutationAttendue, salutation);
        }
    }

}
