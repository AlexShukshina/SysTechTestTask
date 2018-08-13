using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysTechCalculateSalary
{
    public class STEmployee : STSysTechEmployee
    {
        public override double GetRate(DateTime dateEnd)
        {
            double max_percent = 0.3;
            double stazh_premia = 0.03 * YearsOfWorking(dateEnd);
            if (stazh_premia > max_percent)
                stazh_premia = max_percent;
            double current_premia = stazh_premia * BaseRate;

            return BaseRate + current_premia;
        }
    }
}
