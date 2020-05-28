using System.Collections;
using System.Collections.Generic;

namespace LeetCode.Service
{
    public partial class Solution
    {
        public int GetImportance(IList<Employee> employees, int id) {
            var hashTable = new Hashtable(employees.Count);
            foreach(var employee in employees)
            {
                hashTable.Add(employee.id, employee);
            }
            return Helper(hashTable, id);
        }

        private int Helper(Hashtable hashTable, int id)
        {
            var current = (Employee)hashTable[id];
            var importance = current.importance;
            
            foreach(var subordinateID in current.subordinates)
                importance += Helper(hashTable, subordinateID);
            
            return importance;
        }
    }
}