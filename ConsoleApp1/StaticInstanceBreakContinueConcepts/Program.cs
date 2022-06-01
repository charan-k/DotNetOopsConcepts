using ConsoleApp1;

namespace StaticInstanceBreakContinueConcepts
{
    class Circle
    {
        static public float _PI;
        int _radius;

        //static constructors
        static Circle()
        {
            //static constructors to used to initialize static fields in a class;
            // static constructions doesn't have access modifiers
            // static constructors are called before instance constructors
            // static constructors are called only once.

            Console.WriteLine("This is Static Constructor");
            _PI = 3.14F;
        }
        //instance constructors
        public Circle(int radius)
        {
            this._radius = radius;
        }


        public float CalculateArea()
        {
            Console.WriteLine("This is Instance Constructor");
            return _PI * this._radius * this._radius;
        }

        public static void PrintMethod()
        {
            Console.WriteLine("This is Print Method");
        }
    }


    //Access modifiers
    public class Customer
    {
        private int _id;

        //Protected members are only accessible with in the class and also the class that inherits 
        // the base class,i.e the derived class.
        protected string? _name;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
    }

    //Protected internal members are accessible with in the assembly and also the class that inherits the base class 
    // whether the derived class is with in the assembly or outsde the assembly
    public class ProtectedInternalCustomer : Encapsulation
    {
        public void Print()
        {
            ProtectedInternalCustomer protectedInternal = new ProtectedInternalCustomer();
            protectedInternal._name = "hi";
        }

    }

    public class CorporateCustomer : Customer
    {
        public void Print()
        {
            //Protected members are only accessible with in the class and also the class that inherits 
            // the base class,i.e the derived class.
            CorporateCustomer cc = new CorporateCustomer();
            cc._name = "hi";

            //
            base._name = "accessing base class field";
        }
    }

    class EnumProgram
    {
        enum Days { Sun, Mon, tue, Wed, thu, Fri, Sat };

        public void UsingEnumMethod()
        {
            int WeekdayStart = (int)Days.Mon;
            int WeekdayEnd = (int)Days.Fri;

            Console.WriteLine("Monday: {0}", WeekdayStart);
            Console.WriteLine("Friday: {0}", WeekdayEnd);
            Console.ReadKey();
        }
    }

    class GFG
    {

        // adding two integer values.
        public int Add(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        // adding three integer values.
        public int Add(int a, int b, int c)
        {
            int sum = a + b + c;
            return sum;
        }
    }

        class Program
    {
        static void Main(string[] args)
        {
            // static and instace 

            #region Static Instance
            //Instance members
            Circle c1 = new Circle(5);
            float area1 = c1.CalculateArea();

            Circle c2 = new Circle(6);
            float area2 = c2.CalculateArea();


            //static fields are access by classaname
            Console.WriteLine((Circle._PI));

            Console.WriteLine((Circle._PI));
            #endregion

            #region Break and Continue


            int i;
            for (i = 0; i <= 10; i++)
            {
                if (i == 5)
                    continue;
                //     A Continue statement jumps out of the current loop
                //     condition and jumps back to the starting of the loop code.

                if (i == 8)
                    break;
                //     A Break statement breaks out of the loop
                //     at the current point or we can say that it terminates the loop condition.
                Console.WriteLine("value is {0}", i);
            }
            Console.ReadLine();

            //Output is 0,1,2,3,4,6,7
            #endregion

            #region Try Catch Finally

            StreamReader stream = null;
            try
            {
                stream = new StreamReader(@"C:\Sample\Data1.txt");
                Console.WriteLine(stream.ReadToEnd());
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Please check if the file {0} exists ", ex.FileName);
                //  throw new FileNotFoundException("File Path is not present");
            }
            catch (Exception ex)
            {
                //   throw new FileNotFoundException("File Path is not present");
            }
            finally
            {
                if (stream != null)
                    stream.Close();
                Console.WriteLine("Finally block");
            }


            #endregion

            #region Throw Exception

            try
            {
                int zero = 0;
                int val = 100 / zero;
                val = val + 1;
            }
            catch (DivideByZeroException ex)
            {
               // throw new DivideByZeroException("Plz dont try to divide by zero !!", ex);
            }
            #endregion

            #region CustomException

            int d, div, res;
            div = Int32.Parse(Console.ReadLine());
            d = Int32.Parse(Console.ReadLine());
            try
            {
                if (div == 0)
                {
                    throw new MyException();
                }
            }
            catch (MyException e)
            {
                e.MyDivideException();
            }

            res = d / div;
            Console.WriteLine("Result:{0}", res);

            #endregion

            #region AccessModifiers
            Customer customer = new Customer();

            //Not able to access _id as it is private ,private fields are accessible with in the class.
            //It is outside the customer class.
            //  customer._id = 20;

            //Protected members are only accessible with in the class and also the class that inherits 
            // the base class,i.e the derived class.

            //Public Id no restrictions accessible outside the class also
            customer.Id = 20;

            #endregion

            #region Enums

            EnumProgram enumProgram = new EnumProgram();
            enumProgram.UsingEnumMethod();

            #endregion

            #region Method Overloading


            // Creating Object
            GFG ob = new GFG();

            int sum1 = ob.Add(1, 2);
            Console.WriteLine("sum of the two "
                              + "integer value : " + sum1);

            int sum2 = ob.Add(1, 2, 3);
            Console.WriteLine("sum of the three "
                              + "integer value : " + sum2);
            #endregion


            #region Arrays

            double[] balance = new double[10];

            int[] marks = new int[5] { 99, 98, 92, 97, 95 };

            int[] marks1 = new int[] { 99, 98, 92, 97, 95 };

            // Arrays remove

          //  Remove all occurrences of an element from an array:
            int[] numbers = { 1, 3, 4, 5, 4, 2 };
            int numToRemove = 4;
            numbers = numbers.Where(val => val != numToRemove).ToArray();
            Console.WriteLine(String.Join(",", numbers));
            /*
            Output: 1,3,5,2
            */


            int[] array = { 1, 3, 4, 5, 4, 2 };
            int item = 4;

            array = array.Except(new int[] { item }).ToArray();
            Console.WriteLine(String.Join(",", array));

            /*
            Output: 1,3,5,2
            */


            // Resize array

            string[] myarray = {"C#", "C++", "Ruby",
                         "Java", "PHP", "Perl"};

            // Display original string before Resize
            Console.WriteLine("Original Array:");

            foreach (string k in myarray)
            {
                Console.WriteLine(k);
            }

            // Length of old array
            int len = myarray.Length;

            Console.WriteLine("Length of myarray: " + len);
            Console.WriteLine();

            // Resize the element of myarray 
            // and create a new array
            // Here new array is greater than
            // original array so, all the element 
            // from myarray is copied to new array
            // and remaining will be null
            Array.Resize(ref myarray, 10);

            Console.WriteLine("New array is greater than myarray:");

            foreach (string j in myarray)
            {
                Console.WriteLine(j);
            }

            // Length of new array
            int len1 = myarray.Length;
            Console.WriteLine("Length of New Array: " + len1);

            #endregion

            #region ArraySort

            // declaring and initializing the array
            int[] arr = new int[] { 1, 9, 6, 7, 5, 9 };

            // Sort array in ascending order.
            Array.Sort(arr);

            // reverse array
       //     Array.Reverse(arr);

            // print all element of array
            foreach (int value in arr)
            {
                Console.Write(value + " ");
            }

            int[] arr1 = new int[] { 1, 9, 6, 7, 5, 9 };

            // Sort the arr in decreasing order
            // and return a array
            arr1 = arr1.OrderByDescending(c => c).ToArray();

            // print all element of array
            foreach (int value in arr)
            {
                Console.Write(value + " ");
            }
            #endregion

            #region Searching Array

            string[] names = { "Steve", "Bill", "Bill Gates", "Ravi", "Mohan", "Salman", "Boski" };
            var stringToFind = "Bill";

            var result = Array.Find(names, element => element == stringToFind); // returns "Bill"


            string[] names1 = { "Steve", "Bill", "Bill Gates", "James", "Mohan", "Salman", "Boski" };

            var result1 = Array.Find(names1, element => element.StartsWith("B")); // returns Bill

            string[] names2 = { "Steve", "Bill", "bill", "James", "Mohan", "Salman", "Boski" };
            var stringToFind1 = "bill";

            string[] result2 = Array.FindAll(names2, element => element.ToLower() == stringToFind1); // return Bill, bill


            #endregion
        }

        class MyException : ApplicationException
        {
            public void MyExceptiona()
            {
                Console.WriteLine("An exception occured");
            }
            public void MyDivideException()
            {
                Console.WriteLine("Exception occured, divisor should not be zero");
            }
        }

    }
}
