using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class PolymorphismParent
    {
        public virtual void Display()
        {
            Console.WriteLine("This is Parent Display Method");
        }
    }
    public class ChildClass1:PolymorphismParent
    {
        public override void Display()
        {
            Console.WriteLine("This is ChildClass1 display Method");
        }
    }

    public class ChildClass2 : PolymorphismParent
    {
        public override void Display()
        {
            Console.WriteLine("This is ChildClass2 display Method");
        }
    }
}
