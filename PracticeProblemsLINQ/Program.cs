using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblemsLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem 1
            //List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            //List<string> results = LinqProblems.RunProblem1(words);
            //Console.WriteLine(results);
            //Console.ReadLine();
           

            //Problem 2
            //List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            //List<string> results1 = LinqProblems.RunProblem2(names);
            //Console.WriteLine(results1);
            //Console.ReadLine();

            //Problem 3 & Problem 4
            //List<Customer> customers = new List<Customer>()
            //{
            //    new Customer(1, "Mike", "Rodgers"),
            //    new Customer(2, "Nick", "Allen"),
            //    new Customer(3, "Jason", "Ryan"),
            //    new Customer(4, "Dan", "Laffey")
            //};
            //Customer results2 = LinqProblems.RunProblem3(customers);
            //Console.WriteLine(results2);
            //Console.ReadLine();

            //List<Customer> customers = new List<Customer>()
            //{
            //    new Customer(1, "Mike", "Rodgers"),
            //    new Customer(2, "Nick", "Allen"),
            //    new Customer(3, "Jason", "Ryan"),
            //    new Customer(4, "Dan", "Laffey")
            //};

            //Customer results3 = LinqProblems.RunProblem4(customers);
            //Console.WriteLine(results3);
            //Console.ReadLine();


            //Problem 5
            List<string> classGrades = new List<string>()
            {
                "80,100,92,89,65", 
                "93,81,78,84,69",
                "73,88,83,99,64",
                "98,100,66,74,55"
            };

            List<string> results4 = LinqProblems.RunProblem1(classGrades);
            Console.WriteLine(results4);
            Console.ReadLine();


            ////--------------------
            ////Bonus Problem 1
            //string letters = "terrill";

        }
    }
}
