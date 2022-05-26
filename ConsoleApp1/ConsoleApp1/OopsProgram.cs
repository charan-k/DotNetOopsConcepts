namespace ConsoleApp1
{
    internal class OopsProgram
    {
        static void Main(string[] args)
        {
            // Encapsulation example
            // if class is internal it is available with in the same project.
            Encapsulation encapsulation = new Encapsulation();


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

        }
    }
}