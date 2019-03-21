using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8.b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter name:");
            var input = Console.ReadLine().ToLower();
            var result = GetName(input);
            Console.WriteLine($"{input} have phone number:{result}");
        }

        public static int GetName(string name)
        {

            Dictionary<string, int> phoneNumbers = new Dictionary<string, int>
            {
                { "vukashin", 70995605 },
                { "ana", 70123456 },
                { "viktor", 70654321 },
                { "weko", 75123654 },
                { "dejan", 70349420 }
            };
            if (phoneNumbers.ContainsKey(name))
            {
                return phoneNumbers[name];
            }
            throw new Exception($"there is no {name} name in our data base.");
        }
    }
}
