using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysTechCalculateSalary
{
    public class STSalesMan : STSysTechEmployee
    {
        public override double GetRate(DateTime dateEnd)
        {
            double max_percent = 0.35;
            double stazh_premia = 0.01 * YearsOfWorking(dateEnd);
            double current_premia = (stazh_premia > max_percent ? max_percent : stazh_premia) * BaseRate;

            double result = this.BaseRate + current_premia;
            foreach (STSysTechEmployee emp in STSysTechEmployeesData.GetChildren(this.ID))
            {
                result += 0.003 * getAllSubsSumRate(emp.ID, dateEnd);
            }

            return result;
        }

        private double getAllSubsSumRate(int id, DateTime dateEnd)
        {
            double result = STSysTechEmployeesData.GetEmployeeById(id).GetRate(dateEnd);
            foreach (STSysTechEmployee emp in STSysTechEmployeesData.GetChildren(id))
            {
                result += getAllSubsSumRate(emp.ID, dateEnd);
            }
            return result;

        }
    }
}
