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
    }
}