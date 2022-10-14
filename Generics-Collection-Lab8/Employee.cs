//Daniel Svensson .Net22
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Collection_Lab8
{
    //class made after requirments in the lab, could've added more but this is a first draft
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public float Salary { get; set; }

        public Employee(int id,string name, string gender, float salary)
            {
            this.Id = id;
            this.Name = name;
            this.Gender = gender;
            this.Salary = salary;
            }
    }
}
