using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Company { get; set; }

        public string Department { get; set; }

        public int Salary { get; set; }
    }

    public class EmployeeManagement
    {
        public Dictionary<string, int> AverageAgeForEachCompany(List<Employee> employees)
        {
            Dictionary<string, int> sortedDict = new Dictionary<string, int>();

            var result = employees
                .GroupBy(e => e.Department)
                .Select(g => new { Department = g.Key, Avg = (int)g.Average(e => e.Age) })
                .OrderBy(e => e.Department);

            foreach (var item in result)
            {
                sortedDict.Add(item.Department, item.Avg);
            }

            return sortedDict;
        }

        public Dictionary<string, int> CountOfEmployeesForEachCompany(List<Employee> employees)
        {
            Dictionary<string, int> sortedDict = new Dictionary<string, int>();

            var result = employees
                .GroupBy(e => e.Department)
                .Select(g => new { Department = g.Key, Count = g.Count() })
                .ToDictionary(x => x.Department);

            return sortedDict;
        }

        public Dictionary<string, Employee> OldestAgeForEachCompany(List<Employee> employees)
        {

            Dictionary<string, Employee> sortedDict = new Dictionary<string, Employee>();

            var result = employees
              .GroupBy(e => e.Department)
              .Select(g => new { Department = g.Key, oldestAge =  g.MaxBy(e=>e.Age)});

            return sortedDict;
        }
    }
}
