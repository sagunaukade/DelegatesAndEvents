using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    internal class AnonymousDelegate
    {
        // Delegate Definition  
        delegate void operation();
        public static void ImplementDelegate()
        {
            // Delegate instantiation  
            operation obj = delegate
            {
                Console.WriteLine("Anonymous method");
            };
            obj();
            Console.WriteLine();
        }
    }
}
