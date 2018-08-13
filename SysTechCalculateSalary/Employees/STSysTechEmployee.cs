using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysTechCalculateSalary
{
    public abstract class STSysTechEmployee
    {
        #region Fields
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime DateStart { get; set; }

        /// <summary>
        /// 1-Employee, 2- Manager, 3- Salesman
        /// </summary>
        public int Group { get; set; }

        public double BaseRate { get; set; }

        public int? ParentId { get; set; }


        #endregion



        #region Methods

        public abstract double GetRate(DateTime dateEnd);

        public int YearsOfWorking(DateTime dateEnd)
        {
            if (dateEnd < DateStart)
                return 0;
            DateTime zeroDt = new DateTime(1, 1, 1);
            TimeSpan diff = dateEnd - DateStart;
            int years = (zeroDt + diff).Year - 1;
            return years;
        }
        #endregion

    }
}
