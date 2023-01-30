using Xunit;
using OHCESimonH;
using System.Collections.Generic;
using OHCE.Test.xUnit.Utilities;
using OHCESimonH.langues;

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
        public static IEnumerable<object[]> LanguesSeules => new CartesianData(Langues);

        [Theory(DisplayName = "ETANT DONNE un utilisateur parlant une langue" +
                          "QUAND on entre un palindrome " +
                          "ALORS il est renvoy� " +
                          "ET le <bienDit> de cette langue est envoy�")]
        [MemberData(nameof(LanguesSeules))]
        public void PalindromeTest(ILangue langue)
        {
            // ETANT DONNE un utilisateur parlant <langue>
            Ohce ohce = new Ohce(langue);

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
                         "QUAND on entre une chaine " +
                         "ALORS <bonjour> de cette langue est renvoy� " +
                         "ET la chaine est envoy�e")]
        [MemberData(nameof(LanguesSeules))]
        public void DireBonjourTest(ILangue langue)
        {   
            // ETANT DONNE un utilisateur parlant <langue>
            Ohce ohce = new Ohce(langue);

            // QUAND on entre une chaine
            const string chaine = "blabla";
            var sortie = ohce.DireBonjour(chaine);

            // ALORS <bonjour> de cette langue est renvoy�
            // ET la chaine est envoy�
            Assert.StartsWith(
                langue.Bonjour,
                sortie);
            Assert.EndsWith(chaine,
                sortie);
        }
        [Theory(DisplayName = "ETANT DONNE un utilisateur parlant une langue" + 
                       "QUAND on entre une chaine " +
                       "ALORS <auRevoir> dans cette langue est renvoy� en dernier ")]
        [MemberData(nameof(LanguesSeules))]
        public void DireAuRevoirTest(ILangue langue)
        {
            // ETANT DONNE un utilisateur parlant <langue>
            Ohce ohce = new Ohce(langue);

            // QUAND on entre une chaine
            const string chaine = "blabla";
            var sortie = ohce.DireAuRevoir(chaine);

            // ALORS <auRevoir> dans cette langue est renvoy� en dernier
            Assert.EndsWith(langue.AuRevoir,
                sortie);
        }

    }
}