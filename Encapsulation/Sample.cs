using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Sample
    {
        static void Main(string [] args)

        {
            Demo obj = new Demo();
            Console.WriteLine(obj.s[0]);
            obj.Mtd();

            obj.b = obj.i[0] < obj.i[1];
            Console.WriteLine(obj.b);
        }
    }
}
