using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysTechCalculateSalary
{
    public class STManager : STSysTechEmployee
    {
        public override double GetRate(DateTime dateEnd)
        {
            double max_percent = 0.4;
            double stazh_premia = 0.05 * YearsOfWorking(dateEnd);
            double current_premia = (stazh_premia > max_percent ? max_percent:stazh_premia) * BaseRate;

            double result = this.BaseRate + current_premia;
            foreach (STSysTechEmployee emp in STSysTechEmployeesData.GetChildren(this.ID))
            {
                result += emp.GetRate(dateEnd) * 0.005;
            }

            return result;

        }

        
    }
}
