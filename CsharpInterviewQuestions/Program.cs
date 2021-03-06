﻿using System;
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
            //BaseEmployee be = new BaseEmployee()
            //{
            //    ID = 103,
            //    FirstName = "Plag",
            //    LastName = "Osim"
            //};

            //Console.WriteLine(be.GetFullName());
            //Console.WriteLine(be.GetMonthlySalary());

            /* to prevent making instance of base class */

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
