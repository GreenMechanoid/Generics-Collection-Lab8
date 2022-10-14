//Daniel Svensson .Net22
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Collection_Lab8
{
    internal class PartsOfLab
    {
        public void RunPartOne(Employee emp1, Employee emp2, Employee emp3, Employee emp4, Employee emp5)
        {
            Stack employees = new Stack(); // creating the stack and pushing the initiated classes into it
            employees.Push(emp1);
            employees.Push(emp2);
            employees.Push(emp3);
            employees.Push(emp4);
            employees.Push(emp5);
            foreach (object obj in employees) // itterates the items in the stack and prints the property values
            {
                //using a simple get property value from "this property" in a WriteLine statement.
                GetPropertyValues(obj);

            }
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Retriving Via Pop method\n");
            int stackLength = employees.Count;
            for (int i = 0; i < stackLength; i++)
            {
                var temp = employees.Pop();//removeing the object from the stack and and passing it to GetPropertValues method

                Console.WriteLine("Number of Items left in the Stack " + employees.Count);
                GetPropertyValues(temp);
            }
            //re-adding the objects to the stack as per instruction
            employees.Push(emp1);
            employees.Push(emp2);
            employees.Push(emp3);
            employees.Push(emp4);
            employees.Push(emp5);
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Retriving Via Peek method\n");
            for (int i = 0; i < 2; i++)
            {
                var temp = employees.Peek();//checking the last item added to the stack and passing it to GetPropertValues method
                GetPropertyValues(temp);
                Console.WriteLine("Number of Items left in the Stack " + employees.Count);

            }
            Console.WriteLine(); // formatting the printout a lil bit for convinience
            if (employees.Contains(emp3)) // simple check if stack contains emp3
            {
                Console.WriteLine("Stack contains Employee 3");
            }
            else
            {
                Console.WriteLine("Employee 3 is not in the stack");
            }
        }

        public void RunPartTwo(Employee emp1, Employee emp2, Employee emp3, Employee emp4, Employee emp5)
        {
            List<Employee> employees = new List<Employee> {}; //Empty list to be populated below with .Add('object')
            employees.Add(emp1);
            employees.Add(emp2);
            employees.Add(emp3);
            employees.Add(emp4);
            employees.Add(emp5);
            if (employees.Contains(emp2))
            {
                Console.WriteLine("Employee2 object exists in the list");
            }
            else
            {
                Console.WriteLine("Employee2 object does not exist in the list");
            }
            Console.WriteLine();
            Console.WriteLine("Finding the first object with gender 'Male' in the list");
            // get's the first index of Gender = Male, then passes that into GetPropertyValues method
            // using p for parameter in the list, with some quick LINQ to query for the right value
            int index = employees.FindIndex(p => p.Gender == "Male"); 
            GetPropertyValues(employees[index]);

            Console.WriteLine();
            Console.WriteLine("Finding all objects with the gender 'Male'");
            // checking for Gender = Male in all the objects and if it is then passes it to the GetPropertyValues method
            foreach (object obj in employees.FindAll(p => p.Gender == "Male")) 
            {
                GetPropertyValues(obj);
            }
        }

        static void GetPropertyValues(object obj) 
            // seperated this out as it's used several times - it simply goes down the Objects tree to find the property values from the variables in the object
            // if user input this will cause error's due to wrong inputs, but as it's fixed values i'm not doing error checking
        {
            Console.WriteLine("{0} - {1} - {2} - {3} ", obj.GetType().GetProperty("Id").GetValue(obj)
              , obj.GetType().GetProperty("Name").GetValue(obj)
              , obj.GetType().GetProperty("Gender").GetValue(obj),
              obj.GetType().GetProperty("Salary").GetValue(obj));
             
        }
    }


}
