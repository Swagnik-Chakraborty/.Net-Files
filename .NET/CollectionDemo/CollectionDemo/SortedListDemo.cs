using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    internal class SortedListDemo
    {
        static void Main(string[] args)
        {
            SortedList sortedList = new SortedList();
            //Adding Elements to SortedList using Add
            sortedList.Add("USA", "United State of America");
            sortedList.Add("Ind", "India");
            sortedList.Add("SA", "South Africa");
            sortedList.Add("JAP", "Japan");
            sortedList.Add("NEP", "Nepal");









            Console.WriteLine("\nAccessing SortedList using For Each loop");
            //Accessing SortedList using For Each loop
            foreach (DictionaryEntry country in sortedList)
            {
                Console.WriteLine("Key: {0}, Value:{1}", country.Key, country.Value);
            }





            sortedList.Remove("NEP");



            Console.WriteLine("______________________");




            foreach (DictionaryEntry country in sortedList)
            {
                Console.WriteLine("Key: {0}, Value:{1}", country.Key, country.Value);
            }
        }
    }
}
