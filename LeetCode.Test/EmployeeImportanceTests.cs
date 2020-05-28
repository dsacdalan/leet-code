using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Service;
using System.Collections.Generic;

namespace LeetCode.Test
{
    [TestClass]
    public class EmployeeImportanceTests
    {
        private readonly EmployeeImportance _service;

        public EmployeeImportanceTests()
        {
            _service = new EmployeeImportance();
        }

        [TestMethod]
        public void EmployeeImportance_1()
        {
            var employees = new List<Employee>();
            employees.Add(new Employee
            {
                id = 1,
                importance = 5,
                subordinates = new List<int> {2}
            });
            employees.Add(new Employee
            {
                id = 2,
                importance = 1,
                subordinates = new List<int>()
            });

            var result = _service.GetImportance(employees, 1);

            Assert.AreEqual(6, result);
        }
    }
}