using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysTechCalculateSalary
{
    public static class STSysTechEmployeesData
    {
        private static List<STSysTechEmployee> allEmployees = new List<STSysTechEmployee>();
        public static List<STSysTechEmployee> AllEmployees
        {
            get { return allEmployees; }
        }
        
        public static List<STSysTechEmployee> GetChildren(int parent_id)
        {
            List<STSysTechEmployee> result = STSysTechEmployeesData.allEmployees.Where(x => (x.ParentId == parent_id)).Select(x => x).ToList();
            return result;
        }
        public static STSysTechEmployee GetEmployeeById(int id)
        {
            return allEmployees.Where(x => x.ID == id).FirstOrDefault();
        }

        public static void AddEmployees(List<STSysTechEmployee> emps)
        {
           allEmployees.AddRange(emps);
        }

    }
}
