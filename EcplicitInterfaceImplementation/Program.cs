using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcplicitInterfaceImplementation
{
    interface T1
    {
        void InterfaceMethod();
    }

    interface T2
    {
        void InterfaceMethod();
    }

    class Program : T1, T2
    {
        static void Main(string[] args)
        {
            Program P = new Program();
            //P.InterfaceMethod();
            ((T1)P).InterfaceMethod();
            ((T2)P).InterfaceMethod();
        }

        //public void InterfaceMethod()
        //{
        //    Console.WriteLine("T1 Interface Method");
        //}

        void T1.InterfaceMethod() // explicitly
        {
            Console.WriteLine("T1 Interface Method");
        }

        void T2.InterfaceMethod()
        {
            Console.WriteLine("T2 Interface Method");
        }
    }
}
