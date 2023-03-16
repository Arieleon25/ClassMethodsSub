using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodsSub
{
    class Program
    {
        static void Main(string[] args)
        {

            //void method that outpus an integer

            ClassMtds classM = new ClassMtds();
            Console.WriteLine("Divide a number by 2: ");
            int input1 = Convert.ToInt32(Console.ReadLine());

            classM.Div(input1);

            //Method with Output Parameters

            int a, b;

            classM.getValues(out a, out b);

            Console.WriteLine("First value is: {0}", a);
            Console.WriteLine("second value is: {0}", b);

            //OverloadMethod

            classM.Overload(50);
            classM.Overload(50, 500);

            //Static class

            StaticClass.Details();

            Console.WriteLine("First name: {0}", StaticClass.F_name);
            Console.WriteLine("Last name: {0}", StaticClass.L_name);
            Console.WriteLine("Age: {0}", StaticClass.Age_no);

            Console.ReadLine();
        }
    }
}
