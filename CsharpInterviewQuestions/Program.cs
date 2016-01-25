using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpInterviewQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee fte = new FullTimeEmployee()
            {
                ID = 101,
                FirstName = "Mark",
                LastName = "Malon",
                AnnualSalary = 60000
            };

            Console.WriteLine(fte.GetFullName());
            Console.WriteLine(fte.GetMonthlySalary());

            Console.WriteLine("---------------------");

            ContractEmployee cte = new ContractEmployee()
            {
                ID = 101,
                FirstName = "Sara",
                LastName = "Mclane",
                HourlyPay = 200,
                TotalHours = 40
            };

            Console.WriteLine(cte.GetFullName());
            Console.WriteLine(cte.GetMonthlySalary());
        }
    }
}
