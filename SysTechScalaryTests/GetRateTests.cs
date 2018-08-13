using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SysTechCalculateSalary;
using System.Diagnostics;
using System.Collections.Generic;

namespace SysTechScalaryTests {

    [TestClass]
    public class GetRateTests 
    {
        private DateTime dateEnd = new DateTime(2018, 08, 01);
        private DateTime dateStartOld = new DateTime(1996, 03, 26);
        private DateTime dateStartNew = new DateTime(2016, 03, 26);

        [TestMethod]
        public void TestEmployee() 
        {
            STEmployee emp = new STEmployee();
            emp.BaseRate = 4500;
            emp.DateStart = dateStartNew;
            emp.ParentId = null;

            double expected = 4770;
            Assert.AreEqual(expected, emp.GetRate(dateEnd), 0.001);

        }

        [TestMethod]
        public void TestEmployee_Gt_30() {
            STEmployee emp = new STEmployee();
            emp.BaseRate = 4500;
            emp.DateStart = dateStartOld;
            emp.ParentId = null;

            double expected = 5850;
            Assert.AreEqual(expected, emp.GetRate(dateEnd), 0.001);

        }

        [TestMethod]
        public void TestManager_No_Subs() {
            STManager emp = new STManager();
            emp.BaseRate = 17200;
            emp.DateStart = dateStartOld;
            emp.ParentId = null;

            double expected = 24080;
            Assert.AreEqual(expected, emp.GetRate(dateEnd), 0.001);

        }

        [TestMethod]
        public void TestManager_2_Subs() {
            STSysTechEmployeesData.AllEmployees.Clear();
            STManager manager = new STManager() { ID = 1, ParentId = null };
            manager.BaseRate = 17200;
            manager.DateStart = dateStartOld;
            manager.ParentId = null;

            STSysTechEmployeesData.AllEmployees.AddRange(new List<STSysTechEmployee>()
                                           {
                                             new STEmployee() { BaseRate = 4500, DateStart = dateStartNew, ParentId = 1 },
                                             new STEmployee() { BaseRate = 4500, DateStart = dateStartNew, ParentId = 1 },
                                             manager
                                           }
            );

            double expected = 24127.7;

            Assert.AreEqual(expected, manager.GetRate(dateEnd), 0.001);

        }

        [TestMethod]
        public void TestSalesman_3_Subs() {

            STSysTechEmployeesData.AllEmployees.Clear();

            STSalesMan salesman = new STSalesMan() { ID = 1, ParentId = null };
            salesman.BaseRate = 17200;
            salesman.DateStart = dateStartOld;
            salesman.ParentId = null;

            STManager manager = new STManager() { ID = 2, ParentId = 1 };
            manager.BaseRate = 17200;
            manager.DateStart = dateStartOld;            

            STSysTechEmployeesData.AllEmployees.AddRange(new List<STSysTechEmployee>()
                                           {
                                             new STEmployee() { BaseRate = 4500, DateStart = dateStartNew, ParentId = 2 },
                                             new STEmployee() { BaseRate = 4500, DateStart = dateStartNew, ParentId = 2 },
                                             manager, salesman
                                           }
            );






            double expected = 21085.00;
            Assert.AreEqual(expected, salesman.GetRate(dateEnd), 0.01);

        }
    }
}
