using Xunit;
using OHCESimonH;
using System.Collections.Generic;
using OHCE.Test.xUnit.Utilities;
using OHCESimonH.langues;
using OHCE.Test.xUnit.Builders;

namespace OHCE.Test.xUnit
{
    public class OhceTest
    {
        [Fact(DisplayName =
        "QUAND on entre une chaîne de caractères " +
        "ALORS elle est renvoyée en miroir")]
        public void Miroir()
        {
            Ohce ohce = new Ohce();
            // QUAND on entre une chaîne de caractère
            var sortie = ohce.Miroir("toto");

            // ALORS elle est renvoyée en miroir
            Assert.Equal("otot", sortie);
        }
        private static readonly IEnumerable<ILangue> Langues = new ILangue[]
   {
        new LangueAnglaise(),
        new LangueFrancaise()
   };
        private static readonly IEnumerable<PeriodeJournee> Périodes = new PeriodeJournee[]
    {
        PeriodeJournee.Matin,
        PeriodeJournee.AprèsMidi,
        PeriodeJournee.Soir,
        PeriodeJournee.Nuit,
        PeriodeJournee.Defaut
    };
        public static IEnumerable<object[]> LanguesSeules => new CartesianData(Langues);
        public static IEnumerable<object[]> LanguesEtPériodes => new CartesianData(Langues, Périodes);

        [Theory(DisplayName = "ETANT DONNE un utilisateur parlant une langue" +
                          "QUAND on entre un palindrome " +  
                          "ALORS il est renvoyé " +
                          "ET le <bienDit> de cette langue est envoyé")]
        [MemberData(nameof(LanguesSeules))]
        public void PalindromeTest(ILangue langue)
        {
            // ETANT DONNE un utilisateur parlant <langue>
            Ohce ohce = new OhceBuilder()
            .AyantPourLangue(langue)
            .Build();

            // QUAND on entre un palindrome
            const string palindrome = "kayak";
            var sortie = ohce.Palindrome(palindrome);

            // ALORS il est renvoyé
            // ET "Bien dit"  est envoyé
            Assert.StartsWith(
                palindrome,
                sortie);
            Assert.EndsWith(langue.BienDit,
                sortie);
        }
        [Theory(DisplayName = "ETANT DONNE un utilisateur parlant une langue" +
                         "Et que la periode de la journéee est <période>" +
                         "QUAND on entre une chaine " +
                         "ALORS <bonjour> de cette langue à cette période est renvoyé " +
                         "ET la chaine est envoyée")]
        [MemberData(nameof(LanguesEtPériodes))]
        public void DireBonjourTest(ILangue langue, PeriodeJournee periodeJournee)
        {
            // ETANT DONNE un utilisateur parlant <langue>
            // Et que la periode de la journéee est <période>
            Ohce ohce = new OhceBuilder()
            .AyantPourLangue(langue)
            .AyantPourPériodeDeLaJournée(periodeJournee)
            .Build();

            // QUAND on entre une chaine
            const string chaine = "blabla";
            var sortie = ohce.DireBonjour(chaine);

            // ALORS <bonjour> de cette langue à cette période est renvoyé
            // ET la chaine est envoyé
            Assert.StartsWith(
                langue.DireBonjour(periodeJournee),
                sortie);
            Assert.EndsWith(chaine,
                sortie);
        }
        [Theory(DisplayName = "ETANT DONNE un utilisateur parlant une langue" +
                       "Et que la periode de la journéee est <période>" +
                       "QUAND on entre une chaine " +
                       "ALORS <auRevoir> dans cette langue à cette période est renvoyé en dernier ")]
        [MemberData(nameof(LanguesEtPériodes))]
        public void DireAuRevoirTest(ILangue langue, PeriodeJournee periodeJournee)
        {
            // ETANT DONNE un utilisateur parlant <langue>
            //Et que la periode de la journéee est <période>
            Ohce ohce = new OhceBuilder()
            .AyantPourLangue(langue)
            .AyantPourPériodeDeLaJournée(periodeJournee)
            .Build();

            // QUAND on entre une chaine
            const string chaine = "blabla";
            var sortie = ohce.DireAuRevoir(chaine);

            // ALORS <auRevoir> dans cette langue à cette période est renvoyé en dernier
            Assert.EndsWith(langue.DireAuRevoir(periodeJournee),
                sortie);
        }

    }
}