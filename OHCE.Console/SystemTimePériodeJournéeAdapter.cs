using OHCESimonH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHCE.Console
{
    internal class SystemTimePériodeJournéeAdapter
    {
         private PeriodeJournee _périodeJournée;
        public PeriodeJournee GetPériode(int date)
        {

            if (date <= 12 && date > 6)
            {
                _périodeJournée = PeriodeJournee.Matin;
            }
            if (date > 12 && date <= 18)
            {
                _périodeJournée = PeriodeJournee.AprèsMidi;
            }
            if (date > 18 && date <= 22)
            {
                _périodeJournée = PeriodeJournee.Soir;
            }
            else
            { _périodeJournée = PeriodeJournee.Nuit; }
            return _périodeJournée;
        }
    }
}
