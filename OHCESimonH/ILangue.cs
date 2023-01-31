using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHCESimonH
{
    public interface ILangue
    {
        string BienDit { get; }
        string DireBonjour(PeriodeJournee période);
        string DireAuRevoir(PeriodeJournee période);
    }
}
