using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPractice
{
    internal class StringComparisonAndConcatenation
    {
        static void Main(string[] args)
        {
            string myString1 = "Geeks";

            // Initialize another string
            string myString2 = "Words";

            // Initialize another string
            string myString3 = "Geeks";

            // If value returned by this method is equal to 0
            // Then display both strings are equal 
            
            
            Console.WriteLine(myString1.CompareTo(myString3));

            if (myString1.CompareTo(myString3) == 0)
                Console.WriteLine($"{myString1} and {myString2} are same");
           
            Console.WriteLine(string.Compare(myString1, myString3));

            if (String.Equals(myString1, myString3))
                Console.WriteLine($"{myString1} and {myString2} are same.");

            string[] words = { "The", "World", "is", "Not", "Enough" };

            var unreadablePhrase = string.Concat(words);
            Console.WriteLine(unreadablePhrase);

            var readablePhrase = string.Join(" ", words);
            
            Console.WriteLine(readablePhrase);

            string str1 = "Jack";
            string str2 = "Sparrow";

            Console.WriteLine("Concatenation Result = " + String.Concat(str1, str2));

            var strJoining = string.Join(" ", str1,str2);
            Console.WriteLine(strJoining);
            Console.Read();


            //Get Hashcode

            string name1 = "Theodore Onyejiaku";
            string role1 = "Software Developer";

            string name2 = "Kelechukwu Onyejiaku";
            string role2 = "Software Developer";

         
            // get hash codes of the strings above
            int a = name1.GetHashCode();
            int b = name2.GetHashCode();
            int c = role1.GetHashCode();
            int d = role2.GetHashCode();
            
            System.Console.WriteLine(a);
            System.Console.WriteLine(b);
            System.Console.WriteLine(c);
            System.Console.WriteLine(d);


            //Clone string

            string s1 = "Iamatester";

            // Cannot implicitly convert 
            // type object to the string.
            // So explicit conversion 
            // using Clone() method
            string s2 = (String)s1.Clone();

            // Displaying both the string
            Console.WriteLine("String : {0}", s1);
            Console.WriteLine("Clone String : {0}", s2);

            //To String C#
            //It will not handle NULL values; it will throw a NULL reference exception error.
            string strHello = "Hello C#";
            int a1 = 123;
            string s12 = strHello.ToString();
            string s3 = a1.ToString();
            Console.WriteLine(s12);
            Console.WriteLine(s3);

            object input = null;
        //  string  myName = input.ToString();


            #region Stringbuilder

            StringBuilder sb = new StringBuilder();
            sb.Append("Hello ");
            sb.AppendLine("World!");
            sb.AppendLine("Hello C#");
            Console.WriteLine(sb);

            #endregion

        }
    }
}
