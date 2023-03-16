using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodsSub
{
    class ClassMtds
    {
        public void Div(int a)
        {
            int num1 = a/2;
            Console.WriteLine("{0}", num1);
        }

        public void getValues(out int x, out int y)
        {
            Console.WriteLine("Enter the first value: ");
            x = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter the second value: ");
            y = Convert.ToInt32(Console.ReadLine());
        }

        public void Overload(int a)
        {
            Console.WriteLine("Overload: " + a);
        }

        public void Overload(int a, int b)
        {
            Console.WriteLine("Overload: " + a + " and " + b);
        }
    }
}
