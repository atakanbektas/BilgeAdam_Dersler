using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wfa_Employee_CRUD.Classes
{
    internal class Employee
    {
        public string Name{ get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public bool isWorking { get; set; }
        public MedeniHali MedeniHal { get; set; }      
    }
    internal class Employees
    {
        public static List<Employee> list = new List<Employee>();
    }
}
