using Xunit;
using OHCESimonH;

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

        [Fact(DisplayName = "QUAND on entre un palindrome " +
                         "ALORS il est renvoy� " +
                         "ET le  est envoy�")]
        public void PalindromeTest()
        {

            Ohce ohce = new Ohce();

            // QUAND on entre un palindrome
            const string palindrome = "kayak";
            var sortie = ohce.Palindrome(palindrome);

            // ALORS il est renvoy�
            // ET "Bien dit"  est envoy�
            Assert.StartsWith(
                palindrome,
                sortie);
            Assert.EndsWith("Bien dit",
                sortie);
        }
        [Fact(DisplayName = "QUAND on entre une chaine " +
                         "ALORS Bonjour est renvoy�e " +
                         "ET la chaine est envoy�e")]
        public void DireBonjourTest()
        {
            Ohce ohce = new Ohce();

            // QUAND on entre une chaine
            const string chaine = "blabla";
            var sortie = ohce.DireBonjour(chaine);

            // ALORS Bonjour est renvoy�
            // ET la chaine est envoy�
            Assert.StartsWith(
                "Bonjour",
                sortie);
            Assert.EndsWith(chaine,
                sortie);
        }
        [Fact(DisplayName = "QUAND on entre une chaine " +
                                 "ALORS Au revoir est renvoy� en dernier ")]
        public void DireAuRevoirTest()
        {
            Ohce ohce = new Ohce();

            // QUAND on entre une chaine
            const string chaine = "blabla";
            var sortie = ohce.DireAuRevoir(chaine);

            // ALORS Au Revoir est renvoy� en dernier
            Assert.EndsWith("Au revoir",
                sortie);
        }

    }
}