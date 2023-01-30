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
    }
}