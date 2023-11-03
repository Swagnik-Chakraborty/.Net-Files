using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    public delegate void StringDelegate(string a, string b);
    internal class MultiCastDelegateDemo
    {
        static void Main(string[] args)
        {
            StringDelegate func = new StringDelegate(ChangeToUpperCase);
            func += new StringDelegate(ChangeToLowerCase);

            func.Invoke("sWaGnik", "ChakraBorty");

        }
        public static void ChangeToUpperCase(string a,string b)
        {
            Console.WriteLine(a.ToUpper() +" "+ b.ToUpper());
        }
        public static void ChangeToLowerCase(string a, string b)
        {
            Console.WriteLine(a.ToLower() + " " + b.ToLower());
        }
    }
}
