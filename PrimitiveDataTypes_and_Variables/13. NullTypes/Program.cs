using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.NullTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int? a = null;
            Nullable<double> b = null;

            Console.WriteLine(a);
            Console.WriteLine(a + 23);

            a = 23;
            Console.WriteLine(a.GetValueOrDefault());
            
            Console.WriteLine(b);
            Console.WriteLine(b + 6);

            b = 6;
            Console.WriteLine(b.GetValueOrDefault());
        }
    }
}
