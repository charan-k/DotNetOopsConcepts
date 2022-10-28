using System.Xml.Schema;

namespace LinqConcepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Order by to sort
            string[] words = { "cherry", "apple","sun", "blueberry","start","stop" };
            var sortedWords = from w in words orderby w select w;
            Console.WriteLine("The sorted list of words:");
            foreach (var w in sortedWords)
            {
                Console.WriteLine(w);
            }

            #endregion

            #region contains 

            var words1 = new string[] { "falcon", "eagle", "sky", "tree", "water" };

            var res2 = words1.Where(word => word.Contains('a'));

            foreach (var word in res2)
            {
                Console.WriteLine(word);
            }
            #endregion

            #region First ,Last
            string[] words2 = { "falcon", "oak", "sky", "cloud", "tree", "tea", "water" };

            Console.WriteLine(words2.ElementAt(2));
            Console.WriteLine(words2.First());
            Console.WriteLine(words2.Last());

            Console.WriteLine(words2.First(word => word.Length == 3));
            Console.WriteLine(words2.Last(word => word.Length == 3));
            #endregion

            #region Length

            var strwords = new List<string> { "sky", "rock", "forest", "new",
        "falcon", "jewelry", "eagle", "blue", "gray" };

            var query = from word in strwords
                        where word.Length == 4
                        select word;

            foreach (var word in query)
            {
                Console.WriteLine(word);
            }

            #endregion

            #region StartsWith 
            Console.WriteLine("StartsWith s or f");

            var skywords = new List<string> { "sky", "rock", "forest", "new",
                "falcon", "jewelry", "small", "eagle", "blue", "gray" };
            
            var res = from word in skywords
                      where word.StartsWith('f') || word.StartsWith('s')
                      select word;


            var selectResult = from s in skywords
                               select s.Length>3;

            var resultx = skywords.FindAll(x => x.StartsWith('s')).Take(1);

            var resulty = skywords.Where(x => x.StartsWith("s"));

            var resultz = words.Where(x => x.StartsWith("s"));
            
            var resl = skywords.FindAll(x => x.Length == 3);

            var rsa   = skywords.FindAll(x => x.StartsWith('s'));

            foreach (var word1 in resl)
            {
                Console.WriteLine(word1);
            }

            foreach (var word in rsa)
            {
                Console.WriteLine(word);
            }

            foreach (var word in resultz)
            {
                Console.WriteLine(word);
            }
            #endregion

            #region C# LINQ join

            Console.WriteLine("Linq join");

            string[] basketA = { "coin", "book", "fork", "cord", "needle" };
            string[] basketB = { "watches", "coin", "pen", "book", "pencil" };

            var result = from item1 in basketA
                      join item2 in basketB
                      on item1 equals item2
                      select item1;

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            #endregion
        }
    }
}