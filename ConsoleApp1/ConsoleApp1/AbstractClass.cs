namespace ConsoleApp1
{
    // Abstract class contains both abstract and non abstract methods
    // We cannot instantiate an abstract class
    public abstract class AbstractClass
    {
        // abstract class contains fields
        int number = 0;

        // Can have non abstract methods
        void Display()
        {
            Console.WriteLine("This is display method");
        }

        //Abstract method
       public abstract void Print();
    }

    // A non abstract class this is inheriting the abstract class must implement
    // all the methods of that class
    public class NonAbstractClass : AbstractClass
    {
        public override void Print()
        {
            Console.WriteLine("This is Print Method");
        }
    }
}
