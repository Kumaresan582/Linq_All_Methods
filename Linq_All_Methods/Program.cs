namespace Linq_All_Methods
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            AllMethods.Aggregate_Simple();
            AllMethods.Aggregate_Seed();
            AllMethods.Average();
            AllMethods._Count();
            AllMethods._Max();
            AllMethods._Min();
            AllMethods._Sum();

            AllMethods.simple_AsEnumerable();
            AllMethods.simple_Cast();
            AllMethods.Sample_OfType();
            AllMethods.Sample_ToDictionary();
            AllMethods.Sample_ToDictionary_Conditional();
            AllMethods.Sample_ToLookup();

            AllMethods.Sample_ElementAt();
            AllMethods.Sample_FirstOrDefault();
            AllMethods.Sample_LastOrDefault_Conditional();
            AllMethods.Sample_SingleOrDefault();
            AllMethods.Sample_DefaultIfEmpty();

            AllMethods.Sample_Range();
            AllMethods.Sample_GroupBy();

            AllMethods.Sample_Join();
            AllMethods.Sample_GroupJoin();

            AllMethods.Sample_OrderBy();
            AllMethods.Sample_OrderBy_Objects();
            AllMethods.Sample_OrderByDescending();
            AllMethods.Sample_ThenBy();
            AllMethods.Sample_ThenByDescending();

            AllMethods.Sample_Zip();
            AllMethods.Sample_SkipWhile();
            AllMethods.Sample_TakeWhile();

            AllMethods.Sample_select();
            AllMethods.Sample_SelectMany();
            AllMethods.Sample_All_Any();
            AllMethods.Sample_Contains();

            AllMethods.Sample_Where_Objects();
        }
    }
}
/*
using System.Collections.Generic;
namespace LINQDemo
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Department { get; set; }

        public static List<Employee> GetAllEmployees()
        {
            List<Employee> listStudents = new List<Employee>()
            {
                new Employee{ID= 101,Name = "Preety", Salary = 10000, Department = "IT"},
                new Employee{ID= 102,Name = "Priyanka", Salary = 15000, Department = "Sales"},
                new Employee{ID= 103,Name = "James", Salary = 50000, Department = "Sales"},
                new Employee{ID= 104,Name = "Hina", Salary = 20000, Department = "IT"},
                new Employee{ID= 105,Name = "Anurag", Salary = 30000, Department = "IT"},

            };

            return listStudents;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int Salary = Employee.GetAllEmployees().Aggregate<Employee, int>(0,
                            (TotalSalary, emp) => TotalSalary += emp.Salary);

            Console.WriteLine(Salary);
            Console.ReadKey();
        }
    }

}*/