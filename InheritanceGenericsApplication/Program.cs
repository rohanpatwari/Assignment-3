using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceGenericsApplication
{

    public class GenericList<T>
    {
        dynamic a1;
        dynamic b1;

        public T Add(T a, T b)
        {

            this.a1 = a;
            this.b1 = b;

            T c = this.a1 + this.b1;
            return c;
        }
    }
    enum EmployeeType { FullTime, Contract };
    public class Employee
    {
        public string FirstName;
        public string LastName;
        public long SSN;
    }
    public class FullTimeEmployee : Employee
    {
        public DateTime HireDate;
        public int SalaryPerAnnum()
        {
            int Salary = Convert.ToInt32(Console.ReadLine());
            return Salary;
        }
    }
    public class ContractTypeEmployee : Employee
    {
        public DateTime ContractStartDate;
        public DateTime ContractEndDate;
        public int SalaryPerHour()
        {
            int Salary = Convert.ToInt32(Console.ReadLine());
            return Salary;
        }
    }
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Genric Lists: int, float");
            GenericList<int> i = new GenericList<int>();
            int inte = i.Add(10, 20);
            Console.WriteLine("Sum of two integers: {0}", inte);
            GenericList<float> fl = new GenericList<float>();
            float floa = fl.Add(10.2f, 20.3f);
            Console.WriteLine("Sum of two float numbers: {0}", floa);
            Employee e = new Employee();
            Console.WriteLine("Enter the First Name:");
            e.FirstName = Console.ReadLine();
            Console.WriteLine("Enter the Last Name:");
            e.LastName = Console.ReadLine();
            Console.WriteLine("Enter the SSN Number:");
            e.SSN = long.Parse(Console.ReadLine());
            Console.WriteLine("Select Employee Type: ");
            foreach (string str in Enum.GetNames(typeof(EmployeeType)))
                Console.WriteLine(str);
            EmployeeType ET = (EmployeeType)(Enum.Parse(typeof(EmployeeType), Console.ReadLine()));
            switch (ET)
            {
                case EmployeeType.FullTime:
                    FullTimeEmployee f = new FullTimeEmployee();
                    Console.WriteLine("Enter the HireDate:");
                    f.HireDate = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the Salary Per Annum:");
                    int Annumsalary = f.SalaryPerAnnum();
                    Console.WriteLine("Full Name: {0}", e.FirstName + " " + e.LastName);
                    Console.WriteLine("SSN: {0}", e.SSN);
                    Console.WriteLine("HireDate: {0}", f.HireDate);
                    Console.WriteLine("Salary Per Ann: {0}", Annumsalary);
                    break;

                case EmployeeType.Contract:

                    ContractTypeEmployee c = new ContractTypeEmployee();
                    Console.WriteLine("Enter the Contract Start Date:");
                    c.ContractStartDate = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the Contract End Date:");
                    c.ContractEndDate = DateTime.Parse(Console.ReadLine());
                    int HourlySalary = c.SalaryPerHour();
                    Console.WriteLine("Full Name: {0}", c.FirstName + " " + c.LastName);
                    Console.WriteLine("SSN: {0}", c.SSN);
                    Console.WriteLine("Contract Start Date: {0}", c.ContractStartDate);
                    Console.WriteLine("Contract End Date: {0}", c.ContractEndDate);
                    Console.WriteLine("Salary Per Hour: {0}", HourlySalary);
                    break;
                default:
                    Console.WriteLine("Please make the right selection");
                    break;
            }
            Console.ReadLine();

        }
    }
}
