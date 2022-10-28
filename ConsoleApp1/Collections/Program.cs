using System.Collections;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {

            #region List
            //It can have duplicate elements

            List<User> listOfUsers = new List<User>()
            {
        new User() { Name = "John Doe", Age = 42 },
        new User() { Name = "Jane Doe", Age = 34 },
        new User() { Name = "Joe Doe", Age = 8 },
            };

            foreach (User v in listOfUsers)
            {
                Console.WriteLine(v.Name + " is " + v.Age + " years old");
            }
            Console.ReadKey();


            var numbers = new List<int>() { 10, 20, 30, 40, 10 };

            numbers.Remove(10); // removes the first 10 from a list

            numbers.RemoveAt(2); //removes the 3rd element (index starts from 0)

            //numbers.RemoveAt(10); //throws ArgumentOutOfRangeException

            foreach (var el in numbers)
                Console.Write(el); //prints 20 30

            var numbers11 = new List<int>() { 10, 20, 30, 40 };

            numbers11.Insert(1, 11);// inserts 11 at 1st index: after 10.

            foreach (var num in numbers11)
                Console.Write(num);

            var names1 = new List<string>() { "Sonoo", "Ajay", "Vimal","Babul", "Sonoo", "Love" };

            names1.Sort();
            // Iterate through the list.  
            foreach (var name in names1)
            {
                Console.WriteLine(name);
            }
            #endregion

            #region HashSet

            //It does not store duplicate elements.
            //HashSet class if you have to store only unique elements.
            var hashset = new HashSet<string>();
            hashset.Add("Sonoo");
            hashset.Add("Ankit");
            hashset.Add("Peter");
            hashset.Add("Irfan");
            hashset.Add("Ankit");//will not be added  

            // Iterate HashSet elements using foreach loop  
            foreach (var name in hashset)
            {
                Console.WriteLine(name);
            }

            #endregion

            #region ArrayLIst 
            //ArrayList can contain multiple null and duplicate values

            Console.WriteLine("Array List example");
            var arlist1 = new ArrayList();
            arlist1.Add(1);
            arlist1.Add("Bill");
            arlist1.Add(" ");
            arlist1.Add(true);
            arlist1.Add(4.5);
            arlist1.Add("Bill");
            arlist1.Add(null);

            foreach (var item in arlist1)
                Console.Write(item + ", ");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Insert items in the arraylist");
            //   Example: Insert Element in ArrayList
            ArrayList arlist = new ArrayList()
                {
                    1,
                    "Bill",
                    300,
                    4.5f
                };

            arlist.Insert(0, "Second Item");

            foreach (var val in arlist)
                Console.WriteLine(val);

            Console.WriteLine(Environment.NewLine);


            ArrayList arList2 = new ArrayList()
                {
                    1,
                    null,
                    "Bill",
                    300,
                    " ",
                    4.5f,
                    300,
                };

            arList2.Remove(null); //Removes first occurance of null
            arList2.RemoveAt(4);

            foreach (var item in arList2)
                Console.Write(item + ", ");
            #endregion

            #region BitArray

            // Creating a BitArray
            BitArray myBitArr = new BitArray(5);

            myBitArr[0] = true;
            myBitArr[1] = true;
            myBitArr[2] = false;
            myBitArr[3] = true;
            myBitArr[4] = false;

            // To get the value of index at index 2
            Console.WriteLine(myBitArr.Get(2));

            // To get the value of index at index 3
            Console.WriteLine(myBitArr.Get(3));

            #endregion

            #region Stack

            //  Pop: This method returns the object at the beginning of the stack
            //  with modification means this method removes the topmost element of the stack.
            //  Peek: This method returns the object at the beginning of the stack without removing it.

            Console.WriteLine("Stack example");
            Stack my_stack = new Stack();

            // Adding elements in the Stack
            // Using Push method
            my_stack.Push("Geeks");
            my_stack.Push("geeksforgeeks");
            my_stack.Push("geeks23");
            my_stack.Push("GeeksforGeeks");

            // Accessing the elements
            // of my_stack Stack
            // Using foreach loop
            foreach (var elem in my_stack)
            {
                Console.WriteLine(elem);
            }


            Console.WriteLine("Total elements present in" +
                     " my_stack: {0}", my_stack.Count);

            // Obtain the topmost element
            // of my_stack Using Pop method
            Console.WriteLine("Topmost element of my_stack"
                              + " is: {0}", my_stack.Pop());

            Console.WriteLine("Total elements present in" +
                        " my_stack: {0}", my_stack.Count);

            // Obtain the topmost element
            // of my_stack Using Peek method
            Console.WriteLine("Topmost element of my_stack " +
                                  "is: {0}", my_stack.Peek());


            Console.WriteLine("Total elements present " +
                     "in my_stack: {0}", my_stack.Count);
            #endregion

            #region Queue
            Console.WriteLine("queuue");
            Queue my_queue = new Queue();

            // Adding elements in Queue
            // Using Enqueue() method
            my_queue.Enqueue("GFG");
            my_queue.Enqueue("Geeks");
            my_queue.Enqueue("GeeksforGeeks");
            my_queue.Enqueue("geeks");
            my_queue.Enqueue("Geeks123");

            Console.WriteLine("Total elements present in my_queue: {0}",
                                                        my_queue.Count);

            // Obtain the topmost element of my_queue by removing it
            // Using Dequeue method
            Console.WriteLine("Topmost element of my_queue"
                         + " is: {0}", my_queue.Dequeue());


            Console.WriteLine("Total elements present in my_queue: {0}",
                                                        my_queue.Count);

            // Obtain the topmost element of my_queue without removing it
            // Using Peek method
            Console.WriteLine("Topmost element of my_queue is: {0}",
                                                   my_queue.Peek());

            Console.WriteLine("Total elements present in my_queue: {0}",
                                                        my_queue.Count);


            #endregion

            #region Dictionary

            Console.WriteLine("Dictionaries");

            Dictionary<int, string> numberNames = new Dictionary<int, string>();
            numberNames.Add(2, "Four"); //adding a key/value using the Add() method
            numberNames.Add(1, "One");
            numberNames.Add(3, "Three");

            //The following throws run-time exception: key already added.
            numberNames.Add(3 ,"Three"); 

            foreach (KeyValuePair<int, string> kvp in numberNames)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

            var cities = new Dictionary<string, string>(){
                {"UK", "London, Manchester, Birmingham"},
                {"USA", "Chicago, New York, Washington"},
                {"India", "Mumbai, New Delhi, Pune"}
                };

            foreach (var kvp in cities)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

            #endregion

            #region Hashtable

            //In Hashtable, you can store key/value pairs of the same type or of the different type.
            //In Hashtable, there is no need to specify the type of the key and value.
            // Create a hashtable
            // Using Hashtable class
            Hashtable my_hashtable1 = new Hashtable();

            // Adding key/value pair
            // in the hashtable
            // Using Add() method
            my_hashtable1.Add("one", "Welcome");
            my_hashtable1.Add(1, "to");
            my_hashtable1.Add(2, "GeeksforGeeks");

            Console.WriteLine("Key and Value pairs from my_hashtable1:");

            foreach (DictionaryEntry ele1 in my_hashtable1)
            {
                Console.WriteLine("{0} and {1} ", ele1.Key, ele1.Value);
            }
            #endregion


            #region SortedList

            SortedList my_slist1 = new SortedList();

            // Adding key/value pairs in
            // SortedList using Add() method
            my_slist1.Add(1.02, "This");
            my_slist1.Add(1.07, "Is");
            my_slist1.Add(1.04, "SortedList");
            my_slist1.Add(1.01, "Tutorial");

            foreach (DictionaryEntry pair in my_slist1)
            {
                Console.WriteLine("{0} and {1}",
                          pair.Key, pair.Value);
            }
            Console.WriteLine();

            // Creating another SortedList
            // using Object Initializer Syntax
            // to initialize sortedlist
            SortedList my_slist2 = new SortedList() {
                                  { "5", 234 },
                                  { "4", 395 },
                                  { "3", 405 },
                                  { "2", 100 }};

            foreach (DictionaryEntry pair in my_slist2)
            {
                Console.WriteLine("{0} and {1}",
                          pair.Key, pair.Value);
            }

            #endregion

            #region Ienumerable

            List<string> List = new List<string>();
            List.Add("Sourav");
            List.Add("Ram");
            List.Add("shyam");
            List.Add("Sachin");
            IEnumerable names = from n in List where n.StartsWith("S") select n;
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();


            IEnumerable QuerySyntax = from obj in List
                                          where obj.Length==3
                                          select obj;

            foreach (string name1 in QuerySyntax)
            {
                Console.WriteLine(name1);
            }
            Console.ReadLine();
            #endregion

        }






    }

    class User
    {
        public string? Name { get; set; }

        public int Age { get; set; }
    }
}