using OHCESimonH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHCE.Test.xUnit.TestDoubles
{
    internal record LangueMock : ILangue
    {
        public string BienDit { get; init; } = string.Empty;

        public string DireBonjour(PeriodeJournee période) => string.Empty;

        public string DireAuRevoir(PeriodeJournee période) => string.Empty;
    }
}
