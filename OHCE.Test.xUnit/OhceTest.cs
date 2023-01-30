using Xunit;
using OHCESimonH;

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

        [Fact(DisplayName = "QUAND on entre un palindrome " +
                         "ALORS il est renvoyé " +
                         "ET le  est envoyé")]
        public void PalindromeTest()
        {

            Ohce ohce = new Ohce();

            // QUAND on entre un palindrome
            const string palindrome = "kayak";
            var sortie = ohce.Palindrome(palindrome);

            // ALORS il est renvoyé
            // ET "Bien dit"  est envoyé
            Assert.StartsWith(
                palindrome,
                sortie);
            Assert.EndsWith("Bien dit",
                sortie);
        }
        [Fact(DisplayName = "QUAND on entre une chaine " +
                         "ALORS Bonjour est renvoyée " +
                         "ET la chaine est envoyée")]
        public void DireBonjourTest()
        {
            Ohce ohce = new Ohce();

            // QUAND on entre une chaine
            const string chaine = "blabla";
            var sortie = ohce.DireBonjour(chaine);

            // ALORS Bonjour est renvoyé
            // ET la chaine est envoyé
            Assert.StartsWith(
                "Bonjour",
                sortie);
            Assert.EndsWith(chaine,
                sortie);
        }
        [Fact(DisplayName = "QUAND on entre une chaine " +
                                 "ALORS Au revoir est renvoyé en dernier ")]
        public void DireAuRevoirTest()
        {
            Ohce ohce = new Ohce();

            // QUAND on entre une chaine
            const string chaine = "blabla";
            var sortie = ohce.DireAuRevoir(chaine);

            // ALORS Au Revoir est renvoyé en dernier
            Assert.EndsWith("Au revoir",
                sortie);
        }

    }
}