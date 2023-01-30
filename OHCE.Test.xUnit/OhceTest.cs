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
            
            var ohce = new Ohce();

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
    }
}