using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class BaseClass
    {
        public void BaseSumMethod()
        {
            Console.WriteLine("This is Sum Method");
        }
    }

    public class ChildClass:BaseClass
    {
        public void ChildClassMethod()
        {
            Console.WriteLine("This is Child Class Method");
        }
    }
}
