using Oops_Concepts_Modules;
using System.Diagnostics.Metrics;

namespace ConsoleApp1
{
    internal class OopsMainProgram
    {
        static void Main(string[] args)
        {
            // Encapsulation example
            // if a field is internal it is available with in the assembly.
            Encapsulation encapsulation = new Encapsulation();
            encapsulation._id = 30;

            //Abstraction example
            NonAbstractClass nonAbstract = new NonAbstractClass();
            nonAbstract.Print();


            //Polymorphism example
            //Base class reference variable can hold child class object

            PolymorphismParent p = new ChildClass1();
            p.Display();

            PolymorphismParent p1 = new ChildClass2();
            p1.Display();


            //Inheritance Example

            ChildClass childClass = new ChildClass();
            childClass.BaseSumMethod();
            childClass.ChildClassMethod();

            // Implement Polymorphism using interface
            // Base class reference variable can hold child class object
            // and using base class reference we can access all the methods of child class 
            //Interface Example

            interfaceI2 interfacei2 = new Ultra();
            interfacei2.Print();
            interfacei2.Sum();
            interfacei2.Display();

            // Implement Polymorphism using interface
            // Base class reference variable can hold child class object
            // and using base class reference we can access all the methods of child class 
            //Interface Example

            IPolygon r1 = new Rectangle();
            r1.calculateArea();

            IPolygon s1 = new Square();
            s1.calculateArea();



            //Implement Polymorphism using AbstractClass
            AbstractClass abstractClass = new NonAbstractClass();
            abstractClass.Print();


        }
    }
}