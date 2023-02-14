using OHCE.Test.xUnit.TestDoubles;
using OHCESimonH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHCE.Test.xUnit.Builders
{
    internal class OhceBuilder
    {
        private PeriodeJournee _périodeJournée = PeriodeJournee.Defaut;
        private ILangue _langue = new LangueMock();

        public static Ohce Default => new OhceBuilder().Build();

        public Ohce Build() => new Ohce(_langue, _périodeJournée);

        public OhceBuilder AyantPourLangue(ILangue langue)
        {
            _langue = langue;
            return this;
        }

        public OhceBuilder AyantPourPériodeDeLaJournée(PeriodeJournee période)
        {
            _périodeJournée = période;
            return this;
        }
    }
}
