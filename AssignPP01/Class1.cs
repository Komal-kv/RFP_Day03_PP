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

            var line1 = Math.Sqrt((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));
            Console.WriteLine("Length Of Line1 is : " + line1);

        }

    }

}
