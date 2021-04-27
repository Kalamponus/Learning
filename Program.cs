using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello there");
            Random r = new Random();
            Console.WriteLine(r.Next(1, 100));
            Console.WriteLine(r.Next(1, 100) + r.Next(1, 100));
            Console.ReadKey();
        }
    }
}
