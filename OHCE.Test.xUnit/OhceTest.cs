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
            
            var ohce = new Ohce();

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
    }
}