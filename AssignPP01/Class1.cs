using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignPP01
{
    internal class Class1
    {
        public static void LineComparison()
        {
            int x1, x2, y1, y2;
            Console.WriteLine("enter x1 num= ");
            x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter y1 num= ");
            y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter x2 num= ");
            x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter y2 num= ");
            y2 = int.Parse(Console.ReadLine());

            int x3, y3, x4, y4;
            Console.WriteLine("enter x3 num= ");
            x3 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter y3 num= ");
            y3 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter x4 num= ");
            x4 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter y4 num= ");
            y4 = int.Parse(Console.ReadLine());

            var line1 = Math.Sqrt((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));
            var line2 = Math.Sqrt((Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2)));

            Console.WriteLine("line1 :" + line1);
            Console.WriteLine("line2 :" + line2);
            if (line1 == line2)
            {
                Console.WriteLine("Both are equal");
            }
            else
            {
                Console.WriteLine("Both are not Equal");
            }

        }

    }
}
