//Daniel Svensson .Net22

using Generics_Collection_Lab8;
using Microsoft.VisualBasic;
using System.Collections;
using System.Reflection;

namespace Collection_Generics_Lab8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int selector = 0;
            //initializing the objects with variables
            Employee emp1 = new Employee(001, "Jacob", "Male", 45000);
            Employee emp2 = new Employee(002, "Julius", "Male", 46000);
            Employee emp3 = new Employee(003, "Andrew","Male",47000);
            Employee emp4 = new Employee(004, "Samantha", "Female", 48000);
            Employee emp5 = new Employee(005, "Gloria", "Female", 43000);

            PartsOfLab partsOfLab = new PartsOfLab(); // Entirety of the code for running the diffrent parts of the Lab
            // i decided to split it into a seperate file and methods for simpler checking of the diffrent parts.
            // and the fact that i dislike having a 300+ line Main when it's not necessary
            do
            {
                Console.Clear();
                Console.WriteLine("Please select what part you want to run");
                Console.WriteLine("1: Part one about stacks");
                Console.WriteLine("2: part Two about Lists");
                Console.WriteLine("3: Exit the program");

                do
                {
                    string input = Console.ReadLine(); // userinput for selecting "Part 1 or Part 2" of the lab
                    if (int.TryParse(input, out int result))
                    {
                        selector = result;
                    }
                    else
                    {
                        Console.WriteLine("that was a Wrong input, try again");
                    }


                } while (selector != 1 && selector != 2 && selector != 3);
                
                
                switch (selector)
                {
                    case 1:// entirety of the code for Part1 of the lab is in the file PartsOflab (stuff with Stack)
                        Console.Clear();
                        selector = 0;
                        partsOfLab.RunPartOne(emp1,emp2,emp3,emp4,emp5);
                        Console.WriteLine("Press Enter to Continue");
                        Console.ReadKey();
                        break;
                    case 2:// entirety of the code for Part1 of the lab is in the file PartsOflab (stuff with List)
                        Console.Clear();
                        selector = 0;
                        partsOfLab.RunPartTwo(emp1,emp2,emp3,emp4,emp5);
                        Console.WriteLine("Press Enter to Continue");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Have a Nice day!");
                        break;
                }


            } while (selector != 3);

        }

    }
}