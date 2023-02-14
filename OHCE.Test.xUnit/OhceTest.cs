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
        "QUAND on entre une cha�ne de caract�res " +
        "ALORS elle est renvoy�e en miroir")]
        public void Miroir()
        {
            Ohce ohce = new Ohce();
            // QUAND on entre une cha�ne de caract�re
            var sortie = ohce.Miroir("toto");

            // ALORS elle est renvoy�e en miroir
            Assert.Equal("otot", sortie);
        }
        private static readonly IEnumerable<ILangue> Langues = new ILangue[]
   {
        new LangueAnglaise(),
        new LangueFrancaise()
   };
        private static readonly IEnumerable<PeriodeJournee> P�riodes = new PeriodeJournee[]
    {
        PeriodeJournee.Matin,
        PeriodeJournee.Apr�sMidi,
        PeriodeJournee.Soir,
        PeriodeJournee.Nuit,
        PeriodeJournee.Defaut
    };
        public static IEnumerable<object[]> LanguesSeules => new CartesianData(Langues);
        public static IEnumerable<object[]> LanguesEtP�riodes => new CartesianData(Langues, P�riodes);

        [Theory(DisplayName = "ETANT DONNE un utilisateur parlant une langue" +
                          "QUAND on entre un palindrome " +  
                          "ALORS il est renvoy� " +
                          "ET le <bienDit> de cette langue est envoy�")]
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

            // ALORS il est renvoy�
            // ET "Bien dit"  est envoy�
            Assert.StartsWith(
                palindrome,
                sortie);
            Assert.EndsWith(langue.BienDit,
                sortie);
        }
        [Theory(DisplayName = "ETANT DONNE un utilisateur parlant une langue" +
                         "Et que la periode de la journ�ee est <p�riode>" +
                         "QUAND on entre une chaine " +
                         "ALORS <bonjour> de cette langue � cette p�riode est renvoy� " +
                         "ET la chaine est envoy�e")]
        [MemberData(nameof(LanguesEtP�riodes))]
        public void DireBonjourTest(ILangue langue, PeriodeJournee periodeJournee)
        {
            // ETANT DONNE un utilisateur parlant <langue>
            // Et que la periode de la journ�ee est <p�riode>
            Ohce ohce = new OhceBuilder()
            .AyantPourLangue(langue)
            .AyantPourP�riodeDeLaJourn�e(periodeJournee)
            .Build();

            // QUAND on entre une chaine
            const string chaine = "blabla";
            var sortie = ohce.DireBonjour(chaine);

            // ALORS <bonjour> de cette langue � cette p�riode est renvoy�
            // ET la chaine est envoy�
            Assert.StartsWith(
                langue.DireBonjour(periodeJournee),
                sortie);
            Assert.EndsWith(chaine,
                sortie);
        }
        [Theory(DisplayName = "ETANT DONNE un utilisateur parlant une langue" +
                       "Et que la periode de la journ�ee est <p�riode>" +
                       "QUAND on entre une chaine " +
                       "ALORS <auRevoir> dans cette langue � cette p�riode est renvoy� en dernier ")]
        [MemberData(nameof(LanguesEtP�riodes))]
        public void DireAuRevoirTest(ILangue langue, PeriodeJournee periodeJournee)
        {
            // ETANT DONNE un utilisateur parlant <langue>
            //Et que la periode de la journ�ee est <p�riode>
            Ohce ohce = new OhceBuilder()
            .AyantPourLangue(langue)
            .AyantPourP�riodeDeLaJourn�e(periodeJournee)
            .Build();

            // QUAND on entre une chaine
            const string chaine = "blabla";
            var sortie = ohce.DireAuRevoir(chaine);

            // ALORS <auRevoir> dans cette langue � cette p�riode est renvoy� en dernier
            Assert.EndsWith(langue.DireAuRevoir(periodeJournee),
                sortie);
        }

    }
}