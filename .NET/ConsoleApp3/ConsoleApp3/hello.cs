using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class hello
    {
        static void Main(string[]args)
        {
            SortedList s = new SortedList();
            s.Add("1", "swagnik");
            s.Add("2", "swastik");

            foreach(DictionaryEntry qw in s)
            {
                Console.WriteLine("key={0},value={1}",qw.Key,qw.Value);
            }
        }
    }
}
